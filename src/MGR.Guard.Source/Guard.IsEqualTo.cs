using System;
using System.Collections.Generic;
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
        ///     Determines if the specified value is equal to the reference value.
        /// </summary>
        /// <typeparam name="T">The type of the value</typeparam>
        /// <param name="value">The value.</param>
        /// <param name="referenceValue">The reference value.</param>
        /// <param name="parameterName">Name of the parameter.</param>
        [PublicAPI]
        public static void IsEqualTo<T>(T value, T referenceValue, [NotNull] string parameterName)
        {
            var strValue = value as string;
            if (strValue != null)
            {
                IsEqualTo(strValue, referenceValue as string, parameterName, StringComparer.CurrentCulture);
            }
            else
            {
                IsEqualTo(value, referenceValue, parameterName, Comparer<T>.Default);
            }
        }

        /// <summary>
        ///     Determines if the specified value is equal to the reference value.
        /// </summary>
        /// <typeparam name="T">The type of the value</typeparam>
        /// <param name="value">The value.</param>
        /// <param name="referenceValue">The reference value.</param>
        /// <param name="parameterName">Name of the parameter.</param>
        /// <param name="comparer">The comparer.</param>
        [PublicAPI]
        public static void IsEqualTo<T>(T value, T referenceValue, [NotNull] string parameterName, [NotNull] IComparer<T> comparer)
        {
            if (comparer == null)
            {
                throw new ArgumentNullException(nameof(comparer), Messages.ComparerNotNullMessage);
            }
            if (comparer.Compare(value, referenceValue) != 0)
            {
                throw new ArgumentException(Messages.IsEqualToFormat(referenceValue), parameterName);
            }
        }
    }
}