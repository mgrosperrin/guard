using System;
using System.Linq.Expressions;

namespace MGR.Guard
{
    internal static partial class Guard
    {
        internal static (T Value,  string ParameterName) ExtractValueAndNameFromExpression<T>(Expression<Func<T>> selector)
        {
            var (value, parameterName) = ExtractValueAndParameterNameFromExpression(selector);
            return (value, parameterName);
        }
    }
}
