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
        ///     Checks if the specified value is lower than or equal to the maxLimit.
        /// </summary>
        /// <param name="expression">The value as an Expression.</param>
        /// <param name="maxLimit">The min limit.</param>
        [PublicAPI]
        public static void IsLowerThanOrEqualTo<T>([NotNull] Expression<Func<T>> expression, T maxLimit)
        {
            IsNotNull(expression, nameof(expression));

            var (value, parameterName) = ExtractValueAndParameterNameFromExpression(expression);
            IsLowerThanOrEqualTo(value, parameterName, maxLimit);
        }

        /// <summary>
        ///     Checks if the specified value is lower than or equal to the maxLimit.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="value">The value.</param>
        /// <param name="parameterName">Name of the parameter.</param>
        /// <param name="maxLimit">The min limit.</param>
        [PublicAPI]
        public static void IsLowerThanOrEqualTo<T>(T value, [NotNull] string parameterName, T maxLimit)
        {
            var stringValue = value as string;
            if (stringValue != null)
            {
                IsLowerThanOrEqualTo(stringValue, parameterName, maxLimit as string, StringComparer.CurrentCulture);
            }
            else
            {
                IsLowerThanOrEqualTo(value, parameterName, maxLimit, Comparer<T>.Default);
            }
        }

        /// <summary>
        ///     Checks if the specified value is lower than or equal to the maxLimit.
        /// </summary>
        /// <param name="expression">The value as an Expression.</param>
        /// <param name="maxLimit">The min limit.</param>
        /// <param name="comparer">The comparer.</param>
        [PublicAPI]
        public static void IsLowerThanOrEqualTo<T>([NotNull] Expression<Func<T>> expression, T maxLimit, [NotNull] IComparer<T> comparer)
        {
            IsNotNull(expression, nameof(expression));

            var (value, parameterName) = ExtractValueAndParameterNameFromExpression(expression);
            IsLowerThanOrEqualTo(value, parameterName, maxLimit, comparer);
        }

        /// <summary>
        ///     Checks if the specified value is lower than or equal to the maxLimit.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="value">The value.</param>
        /// <param name="parameterName">Name of the parameter.</param>
        /// <param name="maxLimit">The min limit.</param>
        /// <param name="comparer">The comparer.</param>
        [PublicAPI]
        public static void IsLowerThanOrEqualTo<T>(T value, [NotNull] string parameterName, T maxLimit,
            [NotNull] IComparer<T> comparer)
        {
            if (comparer == null)
            {
                throw new ArgumentNullException(nameof(comparer), Messages.ComparerNotNullMessage);
            }
            if (comparer.Compare(value, maxLimit) > 0)
            {
                throw new ArgumentOutOfRangeException(parameterName, value,
                    Messages.IsLowerThanOrEqualToFormat<T>()(maxLimit));
            }
        }
    }
}