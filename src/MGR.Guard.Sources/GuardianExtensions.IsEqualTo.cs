﻿using System;
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
        static partial class GuardianExtensions
    {
        /// <summary>
        ///     Checks if the specified value is equal to the reference value.
        /// </summary>
        /// <typeparam name="T">The type of the value to Guardian.ChecksThat.</typeparam>
        /// <param name="source">The <see cref="Guardian"/> to extends.</param>
        /// <param name="expression">The value as an expression.</param>
        /// <param name="referenceValue">The reference value.</param>
        [PublicAPI]
        public static void IsEqualTo<T>([NotNull] this Guardian source, [NotNull] Expression<Func<T>> expression, T referenceValue)
        {
            source.IsNotNull(expression, nameof(expression));

            var (value, parameterName) = ((IGuardian)source).ExtractValueAndParameterNameFromExpression(expression);
            IsEqualTo(source, value, parameterName, referenceValue);
        }

        /// <summary>
        ///     Checks if the specified value is equal to the reference value.
        /// </summary>
        /// <typeparam name="T">The type of the value to Guardian.ChecksThat.</typeparam>
        /// <param name="source">The <see cref="Guardian"/> to extends.</param>
        /// <param name="value">The value.</param>
        /// <param name="parameterName">Name of the parameter.</param>
        /// <param name="referenceValue">The reference value.</param>
        [PublicAPI]
        public static void IsEqualTo<T>([NotNull] this Guardian source, T value, [NotNull] string parameterName, T referenceValue)
        {
            var strValue = value as string;
            if (strValue != null)
            {
                IsEqualTo(source, strValue, parameterName, referenceValue as string, StringComparer.CurrentCulture);
            }
            else
            {
                IsEqualTo(source, value, parameterName, referenceValue, Comparer<T>.Default);
            }
        }

        /// <summary>
        ///     Checks if the specified <see cref="FileSystemInfo " /> <paramref name="expression" /> exists.
        /// </summary>
        /// <typeparam name="T">The type of the value to Guardian.ChecksThat.</typeparam>
        /// <param name="source">The <see cref="Guardian"/> to extends.</param>
        /// <param name="expression">The value as an expression.</param>
        /// <param name="referenceValue">The reference value.</param>
        /// <param name="comparer">The comparer.</param>
        [PublicAPI]
        public static void IsEqualTo<T>([NotNull] this Guardian source, [NotNull] Expression<Func<T>> expression, T referenceValue, [NotNull] IComparer<T> comparer)
        {
            source.IsNotNull(expression, nameof(expression));

            var (value, parameterName) = ((IGuardian)source).ExtractValueAndParameterNameFromExpression(expression);
            IsEqualTo(source, value, parameterName, referenceValue, comparer);
        }

        /// <summary>
        ///     Checks if the specified value is equal to the reference value.
        /// </summary>
        /// <typeparam name="T">The type of the value to Guardian.ChecksThat.</typeparam>
        /// <param name="source">The <see cref="Guardian"/> to extends.</param>
        /// <param name="value">The value.</param>
        /// <param name="parameterName">Name of the parameter.</param>
        /// <param name="referenceValue">The reference value.</param>
        /// <param name="comparer">The comparer.</param>
        [PublicAPI]
        public static void IsEqualTo<T>([NotNull] this Guardian source, T value, [NotNull] string parameterName, T referenceValue,
            [NotNull] IComparer<T> comparer)
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