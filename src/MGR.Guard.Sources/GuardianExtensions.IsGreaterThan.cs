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
        static partial class GuardianExtensions
    {
        /// <summary>
        ///     Checks if the specified value is greater than the minLimit.
        /// </summary>
        /// <typeparam name="T">The type of the value to Guardian.ChecksThat.</typeparam>
        /// <param name="source">The <see cref="Guardian"/> to extends.</param>
        /// <param name="expression">The value as an Expression.</param>
        /// <param name="minLimit">The min limit.</param>
        [PublicAPI]
        public static void IsGreaterThan<T>([NotNull] this Guardian source, [NotNull] Expression<Func<T>> expression, T minLimit)
        {
            source.IsNotNull(expression, nameof(expression));

            var (value, parameterName) = ((IGuardian)source).ExtractValueAndParameterNameFromExpression(expression);
            IsGreaterThan(source, value, parameterName, minLimit);
        }

        /// <summary>
        ///     Checks if the specified value is greater than the minLimit.
        /// </summary>
        /// <typeparam name="T">The type of the value to Guardian.ChecksThat.</typeparam>
        /// <param name="source">The <see cref="Guardian"/> to extends.</param>
        /// <param name="value">The value.</param>
        /// <param name="parameterName">Name of the parameter.</param>
        /// <param name="minLimit">The min limit.</param>
        [PublicAPI]
        public static void IsGreaterThan<T>([NotNull] this Guardian source, T value, [NotNull] string parameterName, T minLimit)
        {
            var strValue = value as string;
            if (strValue != null)
            {
                IsGreaterThan(source, strValue, parameterName, minLimit as string, StringComparer.CurrentCulture);
            }
            else
            {
                IsGreaterThan(source, value, parameterName, minLimit, Comparer<T>.Default);
            }
        }

        /// <summary>
        ///     Checks if the specified value is greater than the minLimit.
        /// </summary>
        /// <typeparam name="T">The type of the value to Guardian.ChecksThat.</typeparam>
        /// <param name="source">The <see cref="Guardian"/> to extends.</param>
        /// <param name="expression">The value as an Expression.</param>
        /// <param name="minLimit">The min limit.</param>
        /// <param name="comparer">The comparer.</param>
        [PublicAPI]
        public static void IsGreaterThan<T>([NotNull] this Guardian source, [NotNull] Expression<Func<T>> expression, T minLimit, [NotNull] IComparer<T> comparer)
        {
            source.IsNotNull(expression, nameof(expression));

            var (value, parameterName) = ((IGuardian)source).ExtractValueAndParameterNameFromExpression(expression);
            IsGreaterThan(source, value, parameterName, minLimit, comparer);
        }

        /// <summary>
        ///     Checks if the specified value is greater than the minLimit.
        /// </summary>
        /// <typeparam name="T">The type of the value to Guardian.ChecksThat.</typeparam>
        /// <param name="source">The <see cref="Guardian"/> to extends.</param>
        /// <param name="value">The value.</param>
        /// <param name="parameterName">Name of the parameter.</param>
        /// <param name="minLimit">The min limit.</param>
        /// <param name="comparer">The comparer.</param>
        [PublicAPI]
        public static void IsGreaterThan<T>([NotNull] this Guardian source, T value, [NotNull] string parameterName, T minLimit,
            [NotNull] IComparer<T> comparer)
        {
            if (comparer == null)
            {
                throw new ArgumentNullException(nameof(comparer), Messages.ComparerNotNullMessage);
            }
            if (comparer.Compare(value, minLimit) <= 0)
            {
                throw new ArgumentOutOfRangeException(parameterName, value, Messages.IsGreaterThanFormat<T>()(minLimit));
            }
        }
    }
}