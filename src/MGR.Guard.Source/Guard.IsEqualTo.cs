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
        public static void IsEqualTo<T>([NotNull] Expression<Func<T>> expression, T referenceValue)
        {
            IsNotNull(expression, nameof(expression));

            var (value, parameterName) = ExtractValueAndParameterNameFromExpression(expression);
            IsEqualTo(value, referenceValue, parameterName);
        }
        /// <summary>
        ///     Checks if the specified value is equal to the reference value.
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
        ///     Checks if the specified <see cref="FileSystemInfo " /> <paramref name="expression" /> exists.
        /// </summary>
        /// <param name="expression">The value as an expression.</param>
        /// <param name="referenceValue">The reference value.</param>
        /// <param name="comparer">The comparer.</param>
        [PublicAPI]
        public static void IsEqualTo<T>([NotNull] Expression<Func<T>> expression, T referenceValue, [NotNull] IComparer<T> comparer)
        {
            IsNotNull(expression, nameof(expression));

            var (value, parameterName) = ExtractValueAndParameterNameFromExpression(expression);
            IsEqualTo(value, referenceValue, parameterName, comparer);
        }
        /// <summary>
        ///     Checks if the specified value is equal to the reference value.
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