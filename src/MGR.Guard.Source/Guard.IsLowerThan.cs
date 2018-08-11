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
        ///     Checks if the specified value is lower than the maxLimit.
        /// </summary>
        /// <param name="expression">The value as an Expression.</param>
        /// <param name="maxLimit">The max limit.</param>
        [PublicAPI]
        public static void IsLowerThan<T>([NotNull] Expression<Func<T>> expression, T maxLimit)
        {
            IsNotNull(expression, nameof(expression));

            var (value, parameterName) = ExtractValueAndParameterNameFromExpression(expression);
            IsLowerThan(value, parameterName, maxLimit);
        }

        /// <summary>
        ///     Checks if the specified value is lower than the maxLimit.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="value">The value.</param>
        /// <param name="parameterName">Name of the parameter.</param>
        /// <param name="maxLimit">The max limit.</param>
        [PublicAPI]
        public static void IsLowerThan<T>(T value, [NotNull] string parameterName, T maxLimit)
        {
            var stringValue = value as string;
            if (stringValue != null)
            {
                IsLowerThan(stringValue, parameterName, maxLimit as string, StringComparer.CurrentCulture);
            }
            else
            {
                IsLowerThan(value, parameterName, maxLimit, Comparer<T>.Default);
            }
        }

        /// <summary>
        ///     Checks if the specified value is lower than the maxLimit.
        /// </summary>
        /// <param name="expression">The value as an Expression.</param>
        /// <param name="maxLimit">The max limit.</param>
        /// <param name="comparer">The comparer.</param>
        [PublicAPI]
        public static void IsLowerThan<T>([NotNull] Expression<Func<T>> expression, T maxLimit, [NotNull] IComparer<T> comparer)
        {
            IsNotNull(expression, nameof(expression));

            var (value, parameterName) = ExtractValueAndParameterNameFromExpression(expression);
            IsLowerThan(value, parameterName, maxLimit, comparer);
        }

        /// <summary>
        ///     Checks if the specified value is lower than the maxLimit.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="value">The value.</param>
        /// <param name="parameterName">Name of the parameter.</param>
        /// <param name="maxLimit">The max limit.</param>
        /// <param name="comparer">The comparer.</param>
        [PublicAPI]
        public static void IsLowerThan<T>(T value, [NotNull] string parameterName, T maxLimit,
            [NotNull] IComparer<T> comparer)
        {
            if (comparer == null)
            {
                throw new ArgumentNullException(nameof(comparer), Messages.ComparerNotNullMessage);
            }
            if (comparer.Compare(value, maxLimit) >= 0)
            {
                throw new ArgumentOutOfRangeException(parameterName, value,
                    Messages.IsLowerThanFormat<T>()(maxLimit));
            }
        }
    }
}