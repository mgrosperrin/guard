using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using JetBrains.Annotations;

namespace MGR.Guard
{
#if MGR_GUARD_PUBLIC
    public
#else
    internal
#endif
        static partial class Guard
    {
        /// <summary>
        ///     Checks if the specified value is strictly between between the minLimit and the maxLimit.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="expression">The value as an Expression.</param>
        /// <param name="minLimit">The min limit.</param>
        /// <param name="maxLimit">The max limit.</param>
        [PublicAPI]
        public static void IsStrictlyBetween<T>(Expression<Func<T>> expression, T minLimit, T maxLimit)
        {
            IsNotNull(expression, nameof(expression));

            var (value, parameterName) = ExtractValueAndParameterNameFromExpression(expression);
            IsStrictlyBetween(value, parameterName, minLimit, maxLimit);
        }
        /// <summary>
        ///     Checks if the specified value is strictly between the minLimit and the maxLimit.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="value">The value.</param>
        /// <param name="parameterName">Name of the parameter.</param>
        /// <param name="minLimit">The min limit.</param>
        /// <param name="maxLimit">The max limit.</param>
        [PublicAPI]
        public static void IsStrictlyBetween<T>(T value, string parameterName, T minLimit, T maxLimit)
        {
            var stringValue = value as string;
            if (stringValue != null)
            {
                IsStrictlyBetween(stringValue, parameterName, minLimit as string, maxLimit as string, StringComparer.CurrentCulture);
            }
            else
            {
                IsStrictlyBetween(value, parameterName, minLimit, maxLimit, Comparer<T>.Default);
            }
        }
        /// <summary>
        ///     Checks if the specified value is strictly between the minLimit and the maxLimit.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="expression">The value as an Expression.</param>
        /// <param name="minLimit">The min limit.</param>
        /// <param name="maxLimit">The max limit.</param>
        /// <param name="comparer">The comparer.</param>
        [PublicAPI]
        public static void IsStrictlyBetween<T>(Expression<Func<T>> expression, T minLimit, T maxLimit, IComparer<T> comparer)
        {
            IsNotNull(expression, nameof(expression));

            var (value, parameterName) = ExtractValueAndParameterNameFromExpression(expression);
            IsLowerThan(value, parameterName, maxLimit, comparer);
        }

        /// <summary>
        ///     Checks if the specified value is strictly between the minLimit and the maxLimit.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="value">The value.</param>
        /// <param name="parameterName">Name of the parameter.</param>
        /// <param name="minLimit">The min limit.</param>
        /// <param name="maxLimit">The max limit.</param>
        /// <param name="comparer">The comparer.</param>
        [PublicAPI]
        public static void IsStrictlyBetween<T>(T value, string parameterName, T minLimit, T maxLimit, IComparer<T> comparer)
        {
            if (comparer == null)
            {
                throw new ArgumentNullException(nameof(comparer), Messages.ComparerNotNullMessage);
            }
            if (comparer.Compare(value, minLimit) <= 0|| comparer.Compare(value, maxLimit) >= 0)
            {
                throw new ArgumentOutOfRangeException(parameterName, value, Messages.IsStrictlyBetweenFormat<T>()(minLimit, maxLimit));
            }
        }
    }
}
