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
        static partial class Guard
    {
        /// <summary>
        ///     Checks if the specified value is lower than zero.
        /// </summary>
        /// <param name="expression">The value as an Expression.</param>
        [PublicAPI]
        public static void IsLowerThanZero([NotNull] Expression<Func<int>> expression)
        {
            IsNotNull(expression, nameof(expression));

            var (value, parameterName) = ExtractValueAndParameterNameFromExpression(expression);
            IsLowerThanZero(value, parameterName);
        }
        /// <summary>
        ///     Checks if the specified value is lower than zero.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <param name="parameterName">Name of the parameter.</param>
        [PublicAPI]
        public static void IsLowerThanZero(int value, [NotNull] string parameterName)
        {
            if (value >= 0)
            {
                throw new ArgumentOutOfRangeException(parameterName, value, Messages.IsLowerThanZeroMessage);
            }
        }

        /// <summary>
        ///     Checks if the specified value is lower than zero.
        /// </summary>
        /// <param name="expression">The value as an Expression.</param>
        [PublicAPI]
        public static void IsLowerThanZero([NotNull] Expression<Func<long>> expression)
        {
            IsNotNull(expression, nameof(expression));

            var (value, parameterName) = ExtractValueAndParameterNameFromExpression(expression);
            IsLowerThanZero(value, parameterName);
        }
        /// <summary>
        ///     Checks if the specified value is lower than zero.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <param name="parameterName">Name of the parameter.</param>
        [PublicAPI]
        public static void IsLowerThanZero(long value, [NotNull] string parameterName)
        {
            if (value >= 0)
            {
                throw new ArgumentOutOfRangeException(parameterName, value, Messages.IsLowerThanZeroMessage);
            }
        }

        /// <summary>
        ///     Checks if the specified value is lower than zero.
        /// </summary>
        /// <param name="expression">The value as an Expression.</param>
        [PublicAPI]
        public static void IsLowerThanZero([NotNull] Expression<Func<double>> expression)
        {
            IsNotNull(expression, nameof(expression));

            var (value, parameterName) = ExtractValueAndParameterNameFromExpression(expression);
            IsLowerThanZero(value, parameterName);
        }
        /// <summary>
        ///     Checks if the specified value is lower than zero.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <param name="parameterName">Name of the parameter.</param>
        public static void IsLowerThanZero(double value, [NotNull] string parameterName)
        {
            if (value >= 0)
            {
                throw new ArgumentOutOfRangeException(parameterName, value, Messages.IsLowerThanZeroMessage);
            }
        }

        /// <summary>
        ///     Checks if the specified value is lower than zero.
        /// </summary>
        /// <param name="expression">The value as an Expression.</param>
        [PublicAPI]
        public static void IsLowerThanZero([NotNull] Expression<Func<float>> expression)
        {
            IsNotNull(expression, nameof(expression));

            var (value, parameterName) = ExtractValueAndParameterNameFromExpression(expression);
            IsLowerThanZero(value, parameterName);
        }
        /// <summary>
        ///     Checks if the specified value is lower than zero.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <param name="parameterName">Name of the parameter.</param>
        [PublicAPI]
        public static void IsLowerThanZero(float value, [NotNull] string parameterName)
        {
            if (value >= 0)
            {
                throw new ArgumentOutOfRangeException(parameterName, value, Messages.IsLowerThanZeroMessage);
            }
        }
    }
}