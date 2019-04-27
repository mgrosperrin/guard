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
        ///     Checks if the specified value is lower than or equal to zero.
        /// </summary>
        /// <param name="expression">The value as an Expression.</param>
        [PublicAPI]
        [Obsolete("Please use MGR.Guardian.ChecksThat.Guardian.ChecksThat.IsLowerThanOrEqualToZero instead.")]
        public static void IsLowerThanOrEqualToZero([NotNull] Expression<Func<int>> expression)
        {
            Guardian.ChecksThat.IsLowerThanOrEqualToZero(expression);
        }
        /// <summary>
        ///     Checks if the specified value is lower than or equal to zero.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <param name="parameterName">Name of the parameter.</param>
        [PublicAPI]
        [Obsolete("Please use MGR.Guardian.ChecksThat.Guardian.ChecksThat.IsLowerThanOrEqualToZero instead.")]
        public static void IsLowerThanOrEqualToZero(int value, [NotNull] string parameterName)
        {
            Guardian.ChecksThat.IsLowerThanOrEqualToZero(value, parameterName);
        }

        /// <summary>
        ///     Checks if the specified value is lower than or equal to zero.
        /// </summary>
        /// <param name="expression">The value as an Expression.</param>
        [PublicAPI]
        [Obsolete("Please use MGR.Guardian.ChecksThat.Guardian.ChecksThat.IsLowerThanOrEqualToZero instead.")]
        public static void IsLowerThanOrEqualToZero([NotNull] Expression<Func<long>> expression)
        {
            Guardian.ChecksThat.IsLowerThanOrEqualToZero(expression);
        }
        /// <summary>
        ///     Checks if the specified value is lower than or equal to zero.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <param name="parameterName">Name of the parameter.</param>
        [PublicAPI]
        [Obsolete("Please use MGR.Guardian.ChecksThat.Guardian.ChecksThat.IsLowerThanOrEqualToZero instead.")]
        public static void IsLowerThanOrEqualToZero(long value, [NotNull] string parameterName)
        {
            Guardian.ChecksThat.IsLowerThanOrEqualToZero(value, parameterName);
        }

        /// <summary>
        ///     Checks if the specified value is lower than or equal to zero.
        /// </summary>
        /// <param name="expression">The value as an Expression.</param>
        [PublicAPI]
        [Obsolete("Please use MGR.Guardian.ChecksThat.Guardian.ChecksThat.IsLowerThanOrEqualToZero instead.")]
        public static void IsLowerThanOrEqualToZero([NotNull] Expression<Func<double>> expression)
        {
            Guardian.ChecksThat.IsLowerThanOrEqualToZero(expression);
        }
        /// <summary>
        ///     Checks if the specified value is lower than or equals to zero.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <param name="parameterName">Name of the parameter.</param>
        [PublicAPI]
        [Obsolete("Please use MGR.Guardian.ChecksThat.Guardian.ChecksThat.IsLowerThanOrEqualToZero instead.")]
        public static void IsLowerThanOrEqualToZero(double value, [NotNull] string parameterName)
        {
            Guardian.ChecksThat.IsLowerThanOrEqualToZero(value, parameterName);
        }

        /// <summary>
        ///     Checks if the specified value is lower than or equal to zero.
        /// </summary>
        /// <param name="expression">The value as an Expression.</param>
        [PublicAPI]
        [Obsolete("Please use MGR.Guardian.ChecksThat.Guardian.ChecksThat.IsLowerThanOrEqualToZero instead.")]
        public static void IsLowerThanOrEqualToZero([NotNull] Expression<Func<float>> expression)
        {
            Guardian.ChecksThat.IsLowerThanOrEqualToZero(expression);
        }
        /// <summary>
        ///     Checks if the specified value is lower than or equal to zero.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <param name="parameterName">Name of the parameter.</param>
        [PublicAPI]
        [Obsolete("Please use MGR.Guardian.ChecksThat.Guardian.ChecksThat.IsLowerThanOrEqualToZero instead.")]
        public static void IsLowerThanOrEqualToZero(float value, [NotNull] string parameterName)
        {
            Guardian.ChecksThat.IsLowerThanOrEqualToZero(value, parameterName);
        }
    }
}