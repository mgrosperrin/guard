using System;
using System.Collections.Generic;
using System.IO;
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
        ///     Checks if the specified value is equal to the reference value.
        /// </summary>
        /// <param name="expression">The value as an expression.</param>
        /// <param name="referenceValue">The reference value.</param>
        [PublicAPI]
        [Obsolete("Please use MGR.Guardian.ChecksThat.Guardian.ChecksThat.IsEqualTo instead.")]
        public static void IsEqualTo<T>([NotNull] Expression<Func<T>> expression, T referenceValue)
        {
            Guardian.ChecksThat.IsEqualTo(expression, referenceValue);
        }

        /// <summary>
        ///     Checks if the specified value is equal to the reference value.
        /// </summary>
        /// <typeparam name="T">The type of the value</typeparam>
        /// <param name="value">The value.</param>
        /// <param name="parameterName">Name of the parameter.</param>
        /// <param name="referenceValue">The reference value.</param>
        [PublicAPI]
        [Obsolete("Please use MGR.Guardian.ChecksThat.Guardian.ChecksThat.IsEqualTo instead.")]
        public static void IsEqualTo<T>(T value, [NotNull] string parameterName, T referenceValue)
        {
            Guardian.ChecksThat.IsEqualTo(value, parameterName, referenceValue);
        }

        /// <summary>
        ///     Checks if the specified <see cref="FileSystemInfo " /> <paramref name="expression" /> exists.
        /// </summary>
        /// <param name="expression">The value as an expression.</param>
        /// <param name="referenceValue">The reference value.</param>
        /// <param name="comparer">The comparer.</param>
        [PublicAPI]
        [Obsolete("Please use MGR.Guardian.ChecksThat.Guardian.ChecksThat.IsEqualTo instead.")]
        public static void IsEqualTo<T>([NotNull] Expression<Func<T>> expression, T referenceValue, [NotNull] IComparer<T> comparer)
        {
            Guardian.ChecksThat.IsEqualTo(expression, referenceValue, comparer);
        }

        /// <summary>
        ///     Checks if the specified value is equal to the reference value.
        /// </summary>
        /// <typeparam name="T">The type of the value</typeparam>
        /// <param name="value">The value.</param>
        /// <param name="parameterName">Name of the parameter.</param>
        /// <param name="referenceValue">The reference value.</param>
        /// <param name="comparer">The comparer.</param>
        [PublicAPI]
        [Obsolete("Please use MGR.Guardian.ChecksThat.Guardian.ChecksThat.IsEqualTo instead.")]
        public static void IsEqualTo<T>(T value, [NotNull] string parameterName, T referenceValue,
            [NotNull] IComparer<T> comparer)
        {
            Guardian.ChecksThat.IsEqualTo(value, parameterName, referenceValue, comparer);
        }
    }
}