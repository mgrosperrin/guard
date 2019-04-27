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
        /// <typeparam name="T">The type of the value to Guardian.ChecksThat.</typeparam>
        /// <param name="expression">The value as an Expression.</param>
        /// <param name="minLimit">The min limit.</param>
        /// <param name="maxLimit">The max limit.</param>
        [PublicAPI]
        [Obsolete("Please use MGR.Guardian.ChecksThat.Guardian.ChecksThat.IsStrictlyBetween instead.")]
        public static void IsStrictlyBetween<T>(Expression<Func<T>> expression, T minLimit, T maxLimit)
        {
            Guardian.ChecksThat.IsStrictlyBetween(expression, minLimit, maxLimit);
        }
        /// <summary>
        ///     Checks if the specified value is strictly between the minLimit and the maxLimit.
        /// </summary>
        /// <typeparam name="T">The type of the value to Guardian.ChecksThat.</typeparam>
        /// <param name="value">The value.</param>
        /// <param name="parameterName">Name of the parameter.</param>
        /// <param name="minLimit">The min limit.</param>
        /// <param name="maxLimit">The max limit.</param>
        [PublicAPI]
        [Obsolete("Please use MGR.Guardian.ChecksThat.Guardian.ChecksThat.IsStrictlyBetween instead.")]
        public static void IsStrictlyBetween<T>(T value, string parameterName, T minLimit, T maxLimit)
        {
            Guardian.ChecksThat.IsStrictlyBetween(value, parameterName, minLimit, maxLimit);
        }
        /// <summary>
        ///     Checks if the specified value is strictly between the minLimit and the maxLimit.
        /// </summary>
        /// <typeparam name="T">The type of the value to Guardian.ChecksThat.</typeparam>
        /// <param name="expression">The value as an Expression.</param>
        /// <param name="minLimit">The min limit.</param>
        /// <param name="maxLimit">The max limit.</param>
        /// <param name="comparer">The comparer.</param>
        [PublicAPI]
        [Obsolete("Please use MGR.Guardian.ChecksThat.Guardian.ChecksThat.IsStrictlyBetween instead.")]
        public static void IsStrictlyBetween<T>(Expression<Func<T>> expression, T minLimit, T maxLimit, IComparer<T> comparer)
        {
            Guardian.ChecksThat.IsStrictlyBetween(expression, minLimit, maxLimit, comparer);
        }

        /// <summary>
        ///     Checks if the specified value is strictly between the minLimit and the maxLimit.
        /// </summary>
        /// <typeparam name="T">The type of the value to Guardian.ChecksThat.</typeparam>
        /// <param name="value">The value.</param>
        /// <param name="parameterName">Name of the parameter.</param>
        /// <param name="minLimit">The min limit.</param>
        /// <param name="maxLimit">The max limit.</param>
        /// <param name="comparer">The comparer.</param>
        [PublicAPI]
        [Obsolete("Please use MGR.Guardian.ChecksThat.Guardian.ChecksThat.IsStrictlyBetween instead.")]
        public static void IsStrictlyBetween<T>(T value, string parameterName, T minLimit, T maxLimit, IComparer<T> comparer)
        {
            Guardian.ChecksThat.IsStrictlyBetween(value, parameterName, minLimit, maxLimit, comparer);
        }
    }
}
