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
        ///     Checks if the specified value is greater than the minLimit.
        /// </summary>
        /// <param name="expression">The value as an Expression.</param>
        /// <param name="minLimit">The min limit.</param>
        [PublicAPI]
        [Obsolete("Please use MGR.Guardian.ChecksThat.Guardian.ChecksThat.IsGreaterThan instead.")]
        public static void IsGreaterThan<T>([NotNull] Expression<Func<T>> expression, T minLimit)
        {
            Guardian.ChecksThat.IsGreaterThan(expression, minLimit);
        }

        /// <summary>
        ///     Checks if the specified value is greater than the minLimit.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="value">The value.</param>
        /// <param name="parameterName">Name of the parameter.</param>
        /// <param name="minLimit">The min limit.</param>
        [PublicAPI]
        [Obsolete("Please use MGR.Guardian.ChecksThat.Guardian.ChecksThat.IsGreaterThan instead.")]
        public static void IsGreaterThan<T>(T value, [NotNull] string parameterName, T minLimit)
        {
            Guardian.ChecksThat.IsGreaterThan(value, parameterName, minLimit);
        }

        /// <summary>
        ///     Checks if the specified value is greater than the minLimit.
        /// </summary>
        /// <param name="expression">The value as an Expression.</param>
        /// <param name="minLimit">The min limit.</param>
        /// <param name="comparer">The comparer.</param>
        [PublicAPI]
        [Obsolete("Please use MGR.Guardian.ChecksThat.Guardian.ChecksThat.IsGreaterThan instead.")]
        public static void IsGreaterThan<T>([NotNull] Expression<Func<T>> expression, T minLimit, [NotNull] IComparer<T> comparer)
        {
            Guardian.ChecksThat.IsGreaterThan(expression, minLimit, comparer);
        }

        /// <summary>
        ///     Checks if the specified value is greater than the minLimit.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="value">The value.</param>
        /// <param name="parameterName">Name of the parameter.</param>
        /// <param name="minLimit">The min limit.</param>
        /// <param name="comparer">The comparer.</param>
        [PublicAPI]
        [Obsolete("Please use MGR.Guardian.ChecksThat.Guardian.ChecksThat.IsGreaterThan instead.")]
        public static void IsGreaterThan<T>(T value, [NotNull] string parameterName, T minLimit,
            [NotNull] IComparer<T> comparer)
        {
            Guardian.ChecksThat.IsGreaterThan(value, parameterName, minLimit, comparer);
        }
    }
}