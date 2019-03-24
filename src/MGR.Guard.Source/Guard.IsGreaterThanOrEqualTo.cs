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
        [Obsolete("Please use MGR.Guardian.ChecksThat.Guardian.ChecksThat.IsGreaterThanOrEqualTo instead.")]
        public static void IsGreaterThanOrEqualTo<T>([NotNull] Expression<Func<T>> expression, T minLimit)
        {
            Guardian.ChecksThat.IsGreaterThanOrEqualTo(expression, minLimit);
        }

        /// <summary>
        ///     Checks if the specified value is greater than or equal to the minLimit.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="value">The value.</param>
        /// <param name="parameterName">Name of the parameter.</param>
        /// <param name="minLimit">The min limit.</param>
        [PublicAPI]
        [Obsolete("Please use MGR.Guardian.ChecksThat.Guardian.ChecksThat.IsGreaterThanOrEqualTo instead.")]
        public static void IsGreaterThanOrEqualTo<T>(T value, [NotNull] string parameterName, T minLimit)
        {
            Guardian.ChecksThat.IsGreaterThanOrEqualTo(value, parameterName, minLimit);
        }

        /// <summary>
        ///     Checks if the specified value is greater than or equal to the minLimit.
        /// </summary>
        /// <param name="expression">The value as an Expression.</param>
        /// <param name="minLimit">The min limit.</param>
        /// <param name="comparer">The comparer.</param>
        [PublicAPI]
        [Obsolete("Please use MGR.Guardian.ChecksThat.Guardian.ChecksThat.IsGreaterThanOrEqualTo instead.")]
        public static void IsGreaterThanOrEqualTo<T>([NotNull] Expression<Func<T>> expression, T minLimit, [NotNull] IComparer<T> comparer)
        {
            Guardian.ChecksThat.IsGreaterThanOrEqualTo(expression, minLimit, comparer);
        }

        /// <summary>
        ///     Checks if the specified value is greater than or equal to the minLimit.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="value">The value.</param>
        /// <param name="parameterName">Name of the parameter.</param>
        /// <param name="minLimit">The min limit.</param>
        /// <param name="comparer">The comparer.</param>
        [PublicAPI]
        [Obsolete("Please use MGR.Guardian.ChecksThat.Guardian.ChecksThat.IsGreaterThanOrEqualTo instead.")]
        public static void IsGreaterThanOrEqualTo<T>(T value, [NotNull] string parameterName, T minLimit,
            [NotNull] IComparer<T> comparer)
        {
            Guardian.ChecksThat.IsGreaterThanOrEqualTo(value, parameterName, minLimit, comparer);
        }
    }
}