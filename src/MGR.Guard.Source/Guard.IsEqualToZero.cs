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
        ///     Checks if the specified value is equal to zero.
        /// </summary>
        /// <param name="expression">The value as an Expression.</param>
        [PublicAPI]
        public static void IsEqualToZero([NotNull] Expression<Func<int>> expression)
        {
            IsNotNull(expression, nameof(expression));

            var (value, parameterName) = ExtractValueAndParameterNameFromExpression(expression);
            IsEqualToZero(value, parameterName);
        }
        /// <summary>
        ///     Checks if the specified value is equal to zero.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <param name="parameterName">Name of the parameter.</param>
        [PublicAPI]
        public static void IsEqualToZero(int value, [NotNull] string parameterName)
        {
            if (value != 0)
            {
                throw new ArgumentException(Messages.IsEqualToZeroMessage, parameterName);
            }
        }

        /// <summary>
        ///     Checks if the specified value is equal to zero.
        /// </summary>
        /// <param name="expression">The value as an Expression.</param>
        [PublicAPI]
        public static void IsEqualToZero([NotNull] Expression<Func<long>> expression)
        {
            IsNotNull(expression, nameof(expression));

            var (value, parameterName) = ExtractValueAndParameterNameFromExpression(expression);
            IsEqualToZero(value, parameterName);
        }
        /// <summary>
        ///     Checks if the specified value is equal to zero.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <param name="parameterName">Name of the parameter.</param>
        [PublicAPI]
        public static void IsEqualToZero(long value, [NotNull] string parameterName)
        {
            if (value != 0)
            {
                throw new ArgumentException(Messages.IsEqualToZeroMessage, parameterName);
            }
        }

        /// <summary>
        ///     Checks if the specified value is equal to zero.
        /// </summary>
        /// <param name="expression">The value as an Expression.</param>
        [PublicAPI]
        public static void IsEqualToZero([NotNull] Expression<Func<double>> expression)
        {
            IsNotNull(expression, nameof(expression));

            var (value, parameterName) = ExtractValueAndParameterNameFromExpression(expression);
            IsEqualToZero(value, parameterName);
        }
        /// <summary>
        ///     Checks if the specified value is equal to zero.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <param name="parameterName">Name of the parameter.</param>
        public static void IsEqualToZero(double value, [NotNull] string parameterName)
        {
            if (Math.Abs(value - 0) > double.Epsilon)
            {
                throw new ArgumentException(Messages.IsEqualToZeroMessage, parameterName);
            }
        }

        /// <summary>
        ///     Checks if the specified value is equal to zero.
        /// </summary>
        /// <param name="expression">The value as an Expression.</param>
        [PublicAPI]
        public static void IsEqualToZero([NotNull] Expression<Func<float>> expression)
        {
            IsNotNull(expression, nameof(expression));

            var (value, parameterName) = ExtractValueAndParameterNameFromExpression(expression);
            IsEqualToZero(value, parameterName);
        }
        /// <summary>
        ///     Checks if the specified value is equal to zero.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <param name="parameterName">Name of the parameter.</param>
        [PublicAPI]
        public static void IsEqualToZero(float value, [NotNull] string parameterName)
        {
            if (Math.Abs(value - 0) > float.Epsilon)
            {
                throw new ArgumentException(Messages.IsEqualToZeroMessage, parameterName);
            }
        }
    }
}