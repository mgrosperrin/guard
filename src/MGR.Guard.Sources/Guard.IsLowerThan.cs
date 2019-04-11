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
        [Obsolete("Please use MGR.Guardian.ChecksThat.Guardian.ChecksThat.IsLowerThan instead.")]
        public static void IsLowerThan<T>([NotNull] Expression<Func<T>> expression, T maxLimit)
        {
            Guardian.ChecksThat.IsLowerThan(expression, maxLimit);
        }

        /// <summary>
        ///     Checks if the specified value is lower than the maxLimit.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="value">The value.</param>
        /// <param name="parameterName">Name of the parameter.</param>
        /// <param name="maxLimit">The max limit.</param>
        [PublicAPI]
        [Obsolete("Please use MGR.Guardian.ChecksThat.Guardian.ChecksThat.IsLowerThan instead.")]
        public static void IsLowerThan<T>(T value, [NotNull] string parameterName, T maxLimit)
        {
            Guardian.ChecksThat.IsLowerThan(value, parameterName, maxLimit);
        }

        /// <summary>
        ///     Checks if the specified value is lower than the maxLimit.
        /// </summary>
        /// <param name="expression">The value as an Expression.</param>
        /// <param name="maxLimit">The max limit.</param>
        /// <param name="comparer">The comparer.</param>
        [PublicAPI]
        [Obsolete("Please use MGR.Guardian.ChecksThat.Guardian.ChecksThat.IsLowerThan instead.")]
        public static void IsLowerThan<T>([NotNull] Expression<Func<T>> expression, T maxLimit, [NotNull] IComparer<T> comparer)
        {
            Guardian.ChecksThat.IsLowerThan(expression, maxLimit, comparer);
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
        [Obsolete("Please use MGR.Guardian.ChecksThat.Guardian.ChecksThat.IsLowerThan instead.")]
        public static void IsLowerThan<T>(T value, [NotNull] string parameterName, T maxLimit,
            [NotNull] IComparer<T> comparer)
        {
            Guardian.ChecksThat.IsLowerThan(value, parameterName, maxLimit, comparer);
        }
    }
}