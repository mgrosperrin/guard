using System;
using System.Linq.Expressions;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace MGR.Guard
{
    /// <summary>
    ///     Class to check whether a parameter, argument, invariant satisfy some usual conditions.
    /// </summary>
#if MGR_GUARD_PUBLIC
    public
#else
    internal
#endif
    static partial class Guard
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static ValueAndParameterName<T> ExtractValueAndParameterNameFromExpression<T>(Expression<Func<T>> selector)
        {
            var bodyExpression = selector.Body;
            return ExtractFromExpression<T>(bodyExpression, string.Empty, _ => _);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static ValueAndParameterName<T> ExtractFromExpression<T>(Expression expression,
            string finalParameterNamePart, Func<object, object> valueExtractor)
        {
            if (expression is ConstantExpression constantExpression)
            {
                return ExtractFromConstantExpression<T>(null, constantExpression, finalParameterNamePart,
                    valueExtractor);
            }

            if (expression is MemberExpression memberExpression)
            {
                return ExtractFromMemberExpression<T>(memberExpression, finalParameterNamePart, valueExtractor);
            }
            if (expression is BinaryExpression binaryExpression)
            {
                return ExtractFromBinaryExpresion<T>(binaryExpression, finalParameterNamePart, valueExtractor);
            }
            throw new NotImplementedException("Unable to parse the expression.");
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static ValueAndParameterName<T> ExtractFromBinaryExpresion<T>(BinaryExpression binaryExpression,
            string finalParameterNamePart, Func<object, object> valueExtractor)
        {
            if (binaryExpression.NodeType == ExpressionType.ArrayIndex)
            {
                var rightValueParameter =
                    ExtractFromExpression<object>(binaryExpression.Right, string.Empty,
                        _ => _);
                var leftValueParameter =
                    ExtractFromExpression<T>(binaryExpression.Left,
                        "[" + rightValueParameter.ParameterName + "]" + finalParameterNamePart, value =>
                        {
                            var valueType = value.GetType();
                            var method = valueType.GetRuntimeMethod("Get", new[] { rightValueParameter.Value.GetType() });
                            var tempValue = method.Invoke(value, new[] {rightValueParameter.Value});
                            return valueExtractor(tempValue);
                        });
                return leftValueParameter;
            }
            throw new NotImplementedException("Unable to parse BinaryExpression other than ArrayIndex.");
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static ValueAndParameterName<T> ExtractFromMemberExpression<T>(MemberExpression memberExpresion, string finalParameterNamePart, Func<object, object> valueExtractor)
        {
            object SubValueExtractor(object value)
            {
                var tempValue = ComputeValueExtractorForExpression(memberExpresion)(value);
                return valueExtractor(tempValue);
            }

            var subExpression = memberExpresion.Expression;
            switch (subExpression)
            {
                case ConstantExpression constantExpression:
                    return ExtractFromConstantExpression<T>(memberExpresion, constantExpression, finalParameterNamePart, SubValueExtractor);
                case MemberExpression _:
                case BinaryExpression _:
                    var tempNameAndParam = ExtractFromExpression<object>(subExpression, "." + memberExpresion.Member.Name + finalParameterNamePart, SubValueExtractor);
                    return new ValueAndParameterName<T>((T)tempNameAndParam.Value, tempNameAndParam.ParameterName);
            }

            throw new NotImplementedException("Unable to parse the MemberExpression.");
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static Func<object, object> ComputeValueExtractorForExpression(MemberExpression memberExpresion)
        {
            if (memberExpresion == null)
            {
                return _ => _;
            }
            if (memberExpresion.Member is PropertyInfo propertyInfo)
            {
                return value => propertyInfo.GetValue(value);
            }
            if (memberExpresion.Member is FieldInfo filedInfo)
            {
                return value => filedInfo.GetValue(value);
            }
            throw new NotImplementedException("Only Property and field access are currently implemented.");
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static ValueAndParameterName<T> ExtractFromConstantExpression<T>(MemberExpression memberExpresion, ConstantExpression constantExpression, string finalParameterNamePart, Func<object, object> valueExtractor)
        {
            object value = constantExpression.Value;
            string name = ComputeExpressionMemberName(memberExpresion, value);
            return new ValueAndParameterName<T>((T)valueExtractor(value), name + finalParameterNamePart);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static string ComputeExpressionMemberName(MemberExpression memberExpresion, object value)
        {
            if (memberExpresion == null)
            {
                return value == null ? "null" : value.ToString();
            }
            return memberExpresion.Member.Name;
        }

        private struct ValueAndParameterName<T>
        {
            public T Value { get; }
            public string ParameterName { get; }

            public ValueAndParameterName(T value, string parameterName)
            {
                Value = value;
                ParameterName = parameterName;
            }

            public void Deconstruct(out T value, out string parameterName)
            {
                value = Value;
                parameterName = ParameterName;
            }
        }
    }
}