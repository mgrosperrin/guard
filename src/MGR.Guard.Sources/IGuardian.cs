using System;
using System.Linq.Expressions;

namespace MGR.Guard
{
    /// <summary>
    /// Interface to hide the method to extract the value and parameter name from an expression.
    /// </summary>
    public interface IGuardian
    {
        /// <summary>
        /// Extract the value and the parameter name from an expression.
        /// </summary>
        /// <typeparam name="T">The type of value returned by the expression.</typeparam>
        /// <param name="selector">The expression that represent the selection of the value.</param>
        /// <returns>An object containing the value and the parameter name represented by the expression.</returns>
        ValueAndParameterName<T> ExtractValueAndParameterNameFromExpression<T>(Expression<Func<T>> selector);
    }
}
