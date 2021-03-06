﻿using System;
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
        static partial class GuardianExtensions
    {
        /// <summary>
        ///     Checks if the specified value is between between the minLimit and the maxLimit.
        /// </summary>
        /// <typeparam name="T">The type of the value to Guardian.ChecksThat.</typeparam>
        /// <param name="source">The <see cref="Guardian"/> to extends.</param>
        /// <param name="expression">The value as an Expression.</param>
        /// <param name="minLimit">The min limit.</param>
        /// <param name="maxLimit">The max limit.</param>
        [PublicAPI]
        public static void IsBetween<T>([NotNull] this Guardian source, Expression<Func<T>> expression, T minLimit, T maxLimit)
        {
            source.IsNotNull(expression, nameof(expression));

            var (value, parameterName) = ((IGuardian)source).ExtractValueAndParameterNameFromExpression(expression);
            IsBetween(source, value, parameterName, minLimit, maxLimit);
        }
        /// <summary>
        ///     Checks if the specified value is between the minLimit and the maxLimit.
        /// </summary>
        /// <typeparam name="T">The type of the value to Guardian.ChecksThat.</typeparam>
        /// <param name="source">The <see cref="Guardian"/> to extends.</param>
        /// <param name="value">The value.</param>
        /// <param name="parameterName">Name of the parameter.</param>
        /// <param name="minLimit">The min limit.</param>
        /// <param name="maxLimit">The max limit.</param>
        [PublicAPI]
        public static void IsBetween<T>([NotNull] this Guardian source, T value, string parameterName, T minLimit, T maxLimit)
        {
            var stringValue = value as string;
            if (stringValue != null)
            {
                IsBetween(source, stringValue, parameterName, minLimit as string, maxLimit as string, StringComparer.CurrentCulture);
            }
            else
            {
                IsBetween(source, value, parameterName, minLimit, maxLimit, Comparer<T>.Default);
            }
        }
        /// <summary>
        ///     Checks if the specified value is between the minLimit and the maxLimit.
        /// </summary>
        /// <typeparam name="T">The type of the value to Guardian.ChecksThat.</typeparam>
        /// <param name="source">The <see cref="Guardian"/> to extends.</param>
        /// <param name="expression">The value as an Expression.</param>
        /// <param name="minLimit">The min limit.</param>
        /// <param name="maxLimit">The max limit.</param>
        /// <param name="comparer">The comparer.</param>
        [PublicAPI]
        public static void IsBetween<T>([NotNull] this Guardian source, Expression<Func<T>> expression, T minLimit, T maxLimit, IComparer<T> comparer)
        {
            source.IsNotNull(expression, nameof(expression));

            var (value, parameterName) = ((IGuardian)source).ExtractValueAndParameterNameFromExpression(expression);
            IsLowerThan(source, value, parameterName, maxLimit, comparer);
        }

        /// <summary>
        ///     Checks if the specified value is between the minLimit and the maxLimit.
        /// </summary>
        /// <typeparam name="T">The type of the value to Guardian.ChecksThat.</typeparam>
        /// <param name="source">The <see cref="Guardian"/> to extends.</param>
        /// <param name="value">The value.</param>
        /// <param name="parameterName">Name of the parameter.</param>
        /// <param name="minLimit">The min limit.</param>
        /// <param name="maxLimit">The max limit.</param>
        /// <param name="comparer">The comparer.</param>
        [PublicAPI]
        public static void IsBetween<T>([NotNull] this Guardian source, T value, string parameterName, T minLimit, T maxLimit, IComparer<T> comparer)
        {
            if (comparer == null)
            {
                throw new ArgumentNullException(nameof(comparer), Messages.ComparerNotNullMessage);
            }
            if (comparer.Compare(value, minLimit) < 0 || comparer.Compare(value, maxLimit) > 0)
            {
                throw new ArgumentOutOfRangeException(parameterName, value, Messages.IsBetweenFormat<T>()(minLimit, maxLimit));
            }
        }
    }
}
