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
        ///     Checks if the specified value is greater than or equal to the minLimit.
        /// </summary>
        /// <param name="expression">The value as an Expression.</param>
        /// <param name="minLimit">The min limit.</param>
        [PublicAPI]
        public static void IsGreaterThanOrEqualTo<T>([NotNull] Expression<Func<T>> expression, T minLimit)
        {
            IsNotNull(expression, nameof(expression));

            var (value, parameterName) = ExtractValueAndParameterNameFromExpression(expression);
            IsGreaterThanOrEqualTo(value, minLimit, parameterName);
        }
        /// <summary>
        ///     Checks if the specified value is greater than or equal to the minLimit.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="value">The value.</param>
        /// <param name="minLimit">The min limit.</param>
        /// <param name="parameterName">Name of the parameter.</param>
        [PublicAPI]
        public static void IsGreaterThanOrEqualTo<T>(T value, T minLimit, [NotNull] string parameterName)
        {
            var strValue = value as string;
            if (strValue != null)
            {
                IsGreaterThanOrEqualTo(strValue, minLimit as string, parameterName, StringComparer.CurrentCulture);
            }
            else
            {
                IsGreaterThanOrEqualTo(value, minLimit, parameterName, Comparer<T>.Default);
            }
        }

        /// <summary>
        ///     Checks if the specified value is greater than or equal to the minLimit.
        /// </summary>
        /// <param name="expression">The value as an Expression.</param>
        /// <param name="minLimit">The min limit.</param>
        /// <param name="comparer">The comparer.</param>
        [PublicAPI]
        public static void IsGreaterThanOrEqualTo<T>([NotNull] Expression<Func<T>> expression, T minLimit, [NotNull] IComparer<T> comparer)
        {
            IsNotNull(expression, nameof(expression));

            var (value, parameterName) = ExtractValueAndParameterNameFromExpression(expression);
            IsGreaterThanOrEqualTo(value, minLimit, parameterName, comparer);
        }
        /// <summary>
        ///     Checks if the specified value is greater than or equal to the minLimit.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="value">The value.</param>
        /// <param name="minLimit">The min limit.</param>
        /// <param name="parameterName">Name of the parameter.</param>
        /// <param name="comparer">The comparer.</param>
        [PublicAPI]
        public static void IsGreaterThanOrEqualTo<T>(T value, T minLimit, [NotNull] string parameterName, [NotNull] IComparer<T> comparer)
        {
            if (comparer == null)
            {
                throw new ArgumentNullException(nameof(comparer), Messages.ComparerNotNullMessage);
            }
            if (comparer.Compare(value, minLimit) < 0)
            {
                throw new ArgumentOutOfRangeException(parameterName, value,
                    Messages.IsGreaterThanOrEqualToFormat<T>()(minLimit));
            }
        }
    }
}