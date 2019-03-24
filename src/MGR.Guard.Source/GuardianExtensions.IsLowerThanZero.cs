using System;
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
        ///     Checks if the specified value is lower than zero.
        /// </summary>
        /// <param name="source">The <see cref="Guardian"/> to extends.</param>
        /// <param name="expression">The value as an Expression.</param>
        [PublicAPI]
        public static void IsLowerThanZero([NotNull] this Guardian source, [NotNull] Expression<Func<int>> expression)
        {
            source.IsNotNull(expression, nameof(expression));

            var (value, parameterName) = ((IGuardian)source).ExtractValueAndParameterNameFromExpression(expression);
            IsLowerThanZero(source, value, parameterName);
        }
        /// <summary>
        ///     Checks if the specified value is lower than zero.
        /// </summary>
        /// <param name="source">The <see cref="Guardian"/> to extends.</param>
        /// <param name="value">The value.</param>
        /// <param name="parameterName">Name of the parameter.</param>
        [PublicAPI]
        public static void IsLowerThanZero([NotNull] this Guardian source, int value, [NotNull] string parameterName)
        {
            if (value >= 0)
            {
                throw new ArgumentOutOfRangeException(parameterName, value, Messages.IsLowerThanZeroMessage);
            }
        }

        /// <summary>
        ///     Checks if the specified value is lower than zero.
        /// </summary>
        /// <param name="source">The <see cref="Guardian"/> to extends.</param>
        /// <param name="expression">The value as an Expression.</param>
        [PublicAPI]
        public static void IsLowerThanZero([NotNull] this Guardian source, [NotNull] Expression<Func<long>> expression)
        {
            source.IsNotNull(expression, nameof(expression));

            var (value, parameterName) = ((IGuardian)source).ExtractValueAndParameterNameFromExpression(expression);
            IsLowerThanZero(source, value, parameterName);
        }
        /// <summary>
        ///     Checks if the specified value is lower than zero.
        /// </summary>
        /// <param name="source">The <see cref="Guardian"/> to extends.</param>
        /// <param name="value">The value.</param>
        /// <param name="parameterName">Name of the parameter.</param>
        [PublicAPI]
        public static void IsLowerThanZero([NotNull] this Guardian source, long value, [NotNull] string parameterName)
        {
            if (value >= 0)
            {
                throw new ArgumentOutOfRangeException(parameterName, value, Messages.IsLowerThanZeroMessage);
            }
        }

        /// <summary>
        ///     Checks if the specified value is lower than zero.
        /// </summary>
        /// <param name="source">The <see cref="Guardian"/> to extends.</param>
        /// <param name="expression">The value as an Expression.</param>
        [PublicAPI]
        public static void IsLowerThanZero([NotNull] this Guardian source, [NotNull] Expression<Func<double>> expression)
        {
            source.IsNotNull(expression, nameof(expression));

            var (value, parameterName) = ((IGuardian)source).ExtractValueAndParameterNameFromExpression(expression);
            IsLowerThanZero(source, value, parameterName);
        }
        /// <summary>
        ///     Checks if the specified value is lower than zero.
        /// </summary>
        /// <param name="source">The <see cref="Guardian"/> to extends.</param>
        /// <param name="value">The value.</param>
        /// <param name="parameterName">Name of the parameter.</param>
        public static void IsLowerThanZero([NotNull] this Guardian source, double value, [NotNull] string parameterName)
        {
            if (value >= 0)
            {
                throw new ArgumentOutOfRangeException(parameterName, value, Messages.IsLowerThanZeroMessage);
            }
        }

        /// <summary>
        ///     Checks if the specified value is lower than zero.
        /// </summary>
        /// <param name="source">The <see cref="Guardian"/> to extends.</param>
        /// <param name="expression">The value as an Expression.</param>
        [PublicAPI]
        public static void IsLowerThanZero([NotNull] this Guardian source, [NotNull] Expression<Func<float>> expression)
        {
            source.IsNotNull(expression, nameof(expression));

            var (value, parameterName) = ((IGuardian)source).ExtractValueAndParameterNameFromExpression(expression);
            IsLowerThanZero(source, value, parameterName);
        }
        /// <summary>
        ///     Checks if the specified value is lower than zero.
        /// </summary>
        /// <param name="source">The <see cref="Guardian"/> to extends.</param>
        /// <param name="value">The value.</param>
        /// <param name="parameterName">Name of the parameter.</param>
        [PublicAPI]
        public static void IsLowerThanZero([NotNull] this Guardian source, float value, [NotNull] string parameterName)
        {
            if (value >= 0)
            {
                throw new ArgumentOutOfRangeException(parameterName, value, Messages.IsLowerThanZeroMessage);
            }
        }
    }
}