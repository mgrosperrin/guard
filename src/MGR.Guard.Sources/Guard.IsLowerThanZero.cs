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
        [Obsolete("Please use MGR.Guardian.ChecksThat.Guardian.ChecksThat.IsLowerThanZero instead.")]
        public static void IsLowerThanZero([NotNull] Expression<Func<int>> expression)
        {
            Guardian.ChecksThat.IsLowerThanZero(expression);
        }
        /// <summary>
        ///     Checks if the specified value is lower than zero.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <param name="parameterName">Name of the parameter.</param>
        [PublicAPI]
        [Obsolete("Please use MGR.Guardian.ChecksThat.Guardian.ChecksThat.IsLowerThanZero instead.")]
        public static void IsLowerThanZero(int value, [NotNull] string parameterName)
        {
            Guardian.ChecksThat.IsLowerThanZero(value, parameterName);
        }

        /// <summary>
        ///     Checks if the specified value is lower than zero.
        /// </summary>
        /// <param name="expression">The value as an Expression.</param>
        [PublicAPI]
        [Obsolete("Please use MGR.Guardian.ChecksThat.Guardian.ChecksThat.IsLowerThanZero instead.")]
        public static void IsLowerThanZero([NotNull] Expression<Func<long>> expression)
        {
            Guardian.ChecksThat.IsLowerThanZero(expression);
        }
        /// <summary>
        ///     Checks if the specified value is lower than zero.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <param name="parameterName">Name of the parameter.</param>
        [PublicAPI]
        [Obsolete("Please use MGR.Guardian.ChecksThat.Guardian.ChecksThat.IsLowerThanZero instead.")]
        public static void IsLowerThanZero(long value, [NotNull] string parameterName)
        {
            Guardian.ChecksThat.IsLowerThanZero(value, parameterName);
        }

        /// <summary>
        ///     Checks if the specified value is lower than zero.
        /// </summary>
        /// <param name="expression">The value as an Expression.</param>
        [PublicAPI]
        [Obsolete("Please use MGR.Guardian.ChecksThat.Guardian.ChecksThat.IsLowerThanZero instead.")]
        public static void IsLowerThanZero([NotNull] Expression<Func<double>> expression)
        {
            Guardian.ChecksThat.IsLowerThanZero(expression);
        }
        /// <summary>
        ///     Checks if the specified value is lower than zero.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <param name="parameterName">Name of the parameter.</param>
        [Obsolete("Please use MGR.Guardian.ChecksThat.Guardian.ChecksThat.IsLowerThanZero instead.")]
        public static void IsLowerThanZero(double value, [NotNull] string parameterName)
        {
            Guardian.ChecksThat.IsLowerThanZero(value, parameterName);
        }

        /// <summary>
        ///     Checks if the specified value is lower than zero.
        /// </summary>
        /// <param name="expression">The value as an Expression.</param>
        [PublicAPI]
        [Obsolete("Please use MGR.Guardian.ChecksThat.Guardian.ChecksThat.IsLowerThanZero instead.")]
        public static void IsLowerThanZero([NotNull] Expression<Func<float>> expression)
        {
            Guardian.ChecksThat.IsLowerThanZero(expression);
        }
        /// <summary>
        ///     Checks if the specified value is lower than zero.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <param name="parameterName">Name of the parameter.</param>
        [PublicAPI]
        [Obsolete("Please use MGR.Guardian.ChecksThat.Guardian.ChecksThat.IsLowerThanZero instead.")]
        public static void IsLowerThanZero(float value, [NotNull] string parameterName)
        {
            Guardian.ChecksThat.IsLowerThanZero(value, parameterName);
        }
    }
}