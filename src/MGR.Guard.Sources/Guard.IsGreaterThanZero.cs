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
        ///     Checks if the specified value is greater than zero.
        /// </summary>
        /// <param name="expression">The value as an Expression.</param>
        [PublicAPI]
        [Obsolete("Please use MGR.Guardian.ChecksThat.Guardian.ChecksThat.IsGreaterThanZero instead.")]
        public static void IsGreaterThanZero([NotNull] Expression<Func<int>> expression)
        {
            Guardian.ChecksThat.IsGreaterThanZero(expression);
        }
        /// <summary>
        ///     Checks if the specified value is greater than zero.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <param name="parameterName">Name of the parameter.</param>
        [PublicAPI]
        [Obsolete("Please use MGR.Guardian.ChecksThat.Guardian.ChecksThat.IsGreaterThanZero instead.")]
        public static void IsGreaterThanZero(int value, [NotNull] string parameterName)
        {
            Guardian.ChecksThat.IsGreaterThanZero(value, parameterName);
        }


        /// <summary>
        ///     Checks if the specified value is greater than zero.
        /// </summary>
        /// <param name="expression">The value as an Expression.</param>
        [PublicAPI]
        [Obsolete("Please use MGR.Guardian.ChecksThat.Guardian.ChecksThat.IsGreaterThanZero instead.")]
        public static void IsGreaterThanZero([NotNull] Expression<Func<long>> expression)
        {
            Guardian.ChecksThat.IsGreaterThanZero(expression);
        }
        /// <summary>
        ///     Checks if the specified value is greater than zero.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <param name="parameterName">Name of the parameter.</param>
        [PublicAPI]
        [Obsolete("Please use MGR.Guardian.ChecksThat.Guardian.ChecksThat.IsGreaterThanZero instead.")]
        public static void IsGreaterThanZero(long value, [NotNull] string parameterName)
        {
            Guardian.ChecksThat.IsGreaterThanZero(value, parameterName);
        }


        /// <summary>
        ///     Checks if the specified value is greater than zero.
        /// </summary>
        /// <param name="expression">The value as an Expression.</param>
        [PublicAPI]
        [Obsolete("Please use MGR.Guardian.ChecksThat.Guardian.ChecksThat.IsGreaterThanZero instead.")]
        public static void IsGreaterThanZero([NotNull] Expression<Func<double>> expression)
        {
            Guardian.ChecksThat.IsGreaterThanZero(expression);
        }
        /// <summary>
        ///     Checks if the specified value is greater than zero.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <param name="parameterName">Name of the parameter.</param>
        [PublicAPI]
        [Obsolete("Please use MGR.Guardian.ChecksThat.Guardian.ChecksThat.IsGreaterThanZero instead.")]
        public static void IsGreaterThanZero(double value, [NotNull] string parameterName)
        {
            Guardian.ChecksThat.IsGreaterThanZero(value, parameterName);
        }


        /// <summary>
        ///     Checks if the specified value is greater than zero.
        /// </summary>
        /// <param name="expression">The value as an Expression.</param>
        [PublicAPI]
        [Obsolete("Please use MGR.Guardian.ChecksThat.Guardian.ChecksThat.IsGreaterThanZero instead.")]
        public static void IsGreaterThanZero([NotNull] Expression<Func<float>> expression)
        {
            Guardian.ChecksThat.IsGreaterThanZero(expression);
        }
        /// <summary>
        ///     Checks if the specified value is greater than zero.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <param name="parameterName">Name of the parameter.</param>
        [PublicAPI]
        [Obsolete("Please use MGR.Guardian.ChecksThat.Guardian.ChecksThat.IsGreaterThanZero instead.")]
        public static void IsGreaterThanZero(float value, [NotNull] string parameterName)
        {
            Guardian.ChecksThat.IsGreaterThanZero(value, parameterName);
        }
    }
}