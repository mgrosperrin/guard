using System;
using System.Linq.Expressions;
using System.Reflection;
using JetBrains.Annotations;

namespace MGR.Guard
{
#if MGR_GUARD_PUBLIC
    public
#else
    internal
#endif
        static partial class GuardianExtensions
    {
        /// <summary>
        ///     Checks if the specified value is defined in the enum type.
        /// </summary>
        /// <typeparam name="TEnum">The type of the enum to Guardian.ChecksThat.</typeparam>
        /// <param name="source">The <see cref="Guardian"/> to extends.</param>
        /// <param name="expression">The enum as an Expression.</param>
        [PublicAPI]
#pragma warning disable CS3024 // Constraint type is not CLS-compliant
        public static void IsDefined<TEnum>([NotNull] this Guardian source, [NotNull] Expression<Func<TEnum>> expression)
#pragma warning restore CS3024 // Constraint type is not CLS-compliant
            where TEnum : struct, IConvertible
        {
            source.IsNotNull(expression, nameof(expression));

            var (value, parameterName) = ((IGuardian)source).ExtractValueAndParameterNameFromExpression(expression);
            IsDefined(source, value, parameterName);
        }
        /// <summary>
        ///     Checks if the specified value is defined in the enum type.
        /// </summary>
        /// <typeparam name="TEnum">The type of the enum to Guardian.ChecksThat.</typeparam>
        /// <param name="source">The <see cref="Guardian"/> to extends.</param>
        /// <param name="value">The value to check.</param>
        /// <param name="parameterName">The name of the parameter.</param>
        [PublicAPI]
#pragma warning disable CS3024 // Constraint type is not CLS-compliant
        public static void IsDefined<TEnum>([NotNull] this Guardian source, TEnum value, [NotNull] string parameterName)
#pragma warning restore CS3024 // Constraint type is not CLS-compliant
            where TEnum : struct, IConvertible
        {

            var enumType = typeof(TEnum);
            if (!enumType.GetTypeInfo().IsEnum)
            {
                throw new ArgumentException(Messages.IsDefinedType);
            }
            if (!Enum.IsDefined(enumType, value))
            {
                throw new ArgumentOutOfRangeException(Messages.IsDefinedFormat<TEnum>()(value, enumType), parameterName);
            }
        }
    }
}