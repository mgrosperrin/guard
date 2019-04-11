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
        /// <param name="maxLimit">The max limit.</param>
        [PublicAPI]
        [Obsolete("Please use MGR.Guardian.ChecksThat.Guardian.ChecksThat.IsLowerThanOrEqualTo instead.")]
        public static void IsLowerThanOrEqualTo<T>([NotNull] Expression<Func<T>> expression, T maxLimit)
        {
            Guardian.ChecksThat.IsLowerThanOrEqualTo(expression, maxLimit);
        }

        /// <summary>
        ///     Checks if the specified value is lower than or equal to the maxLimit.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="value">The value.</param>
        /// <param name="parameterName">Name of the parameter.</param>
        /// <param name="maxLimit">The max limit.</param>
        [PublicAPI]
        [Obsolete("Please use MGR.Guardian.ChecksThat.Guardian.ChecksThat.IsLowerThanOrEqualTo instead.")]
        public static void IsLowerThanOrEqualTo<T>(T value, [NotNull] string parameterName, T maxLimit)
        {
            Guardian.ChecksThat.IsLowerThanOrEqualTo(value, parameterName, maxLimit);
        }

        /// <summary>
        ///     Checks if the specified value is lower than or equal to the maxLimit.
        /// </summary>
        /// <param name="expression">The value as an Expression.</param>
        /// <param name="maxLimit">The max limit.</param>
        /// <param name="comparer">The comparer.</param>
        [PublicAPI]
        [Obsolete("Please use MGR.Guardian.ChecksThat.Guardian.ChecksThat.IsLowerThanOrEqualTo instead.")]
        public static void IsLowerThanOrEqualTo<T>([NotNull] Expression<Func<T>> expression, T maxLimit, [NotNull] IComparer<T> comparer)
        {
            Guardian.ChecksThat.IsLowerThanOrEqualTo(expression, maxLimit, comparer);
        }

        /// <summary>
        ///     Checks if the specified value is lower than or equal to the maxLimit.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="value">The value.</param>
        /// <param name="parameterName">Name of the parameter.</param>
        /// <param name="maxLimit">The max limit.</param>
        /// <param name="comparer">The comparer.</param>
        [PublicAPI]
        [Obsolete("Please use MGR.Guardian.ChecksThat.Guardian.ChecksThat.IsLowerThanOrEqualTo instead.")]
        public static void IsLowerThanOrEqualTo<T>(T value, [NotNull] string parameterName, T maxLimit,
            [NotNull] IComparer<T> comparer)
        {
            Guardian.ChecksThat.IsLowerThanOrEqualTo(value, parameterName, maxLimit, comparer);
        }
    }
}