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
        [Obsolete("Please use MGR.Guardian.ChecksThat.Guardian.ChecksThat.IsEqualToZero instead.")]
        public static void IsEqualToZero([NotNull] Expression<Func<int>> expression)
        {
            Guardian.ChecksThat.IsEqualToZero(expression);
        }
        /// <summary>
        ///     Checks if the specified value is equal to zero.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <param name="parameterName">Name of the parameter.</param>
        [PublicAPI]
        [Obsolete("Please use MGR.Guardian.ChecksThat.Guardian.ChecksThat.IsEqualToZero instead.")]
        public static void IsEqualToZero(int value, [NotNull] string parameterName)
        {
            Guardian.ChecksThat.IsEqualToZero(value, parameterName);
        }

        /// <summary>
        ///     Checks if the specified value is equal to zero.
        /// </summary>
        /// <param name="expression">The value as an Expression.</param>
        [PublicAPI]
        [Obsolete("Please use MGR.Guardian.ChecksThat.Guardian.ChecksThat.IsEqualToZero instead.")]
        public static void IsEqualToZero([NotNull] Expression<Func<long>> expression)
        {
            Guardian.ChecksThat.IsEqualToZero(expression);
        }
        /// <summary>
        ///     Checks if the specified value is equal to zero.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <param name="parameterName">Name of the parameter.</param>
        [PublicAPI]
        [Obsolete("Please use MGR.Guardian.ChecksThat.Guardian.ChecksThat.IsEqualToZero instead.")]
        public static void IsEqualToZero(long value, [NotNull] string parameterName)
        {
            Guardian.ChecksThat.IsEqualToZero(value, parameterName);
        }

        /// <summary>
        ///     Checks if the specified value is equal to zero.
        /// </summary>
        /// <param name="expression">The value as an Expression.</param>
        [PublicAPI]
        [Obsolete("Please use MGR.Guardian.ChecksThat.Guardian.ChecksThat.IsEqualToZero instead.")]
        public static void IsEqualToZero([NotNull] Expression<Func<double>> expression)
        {
            Guardian.ChecksThat.IsEqualToZero(expression);
        }
        /// <summary>
        ///     Checks if the specified value is equal to zero.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <param name="parameterName">Name of the parameter.</param>
        [PublicAPI]
        [Obsolete("Please use MGR.Guardian.ChecksThat.Guardian.ChecksThat.IsEqualToZero instead.")]
        public static void IsEqualToZero(double value, [NotNull] string parameterName)
        {
            Guardian.ChecksThat.IsEqualToZero(value, parameterName);
        }

        /// <summary>
        ///     Checks if the specified value is equal to zero.
        /// </summary>
        /// <param name="expression">The value as an Expression.</param>
        [PublicAPI]
        [Obsolete("Please use MGR.Guardian.ChecksThat.Guardian.ChecksThat.IsEqualToZero instead.")]
        public static void IsEqualToZero([NotNull] Expression<Func<float>> expression)
        {
            Guardian.ChecksThat.IsEqualToZero(expression);
        }
        /// <summary>
        ///     Checks if the specified value is equal to zero.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <param name="parameterName">Name of the parameter.</param>
        [PublicAPI]
        [Obsolete("Please use MGR.Guardian.ChecksThat.Guardian.ChecksThat.IsEqualToZero instead.")]
        public static void IsEqualToZero(float value, [NotNull] string parameterName)
        {
            Guardian.ChecksThat.IsEqualToZero(value, parameterName);
        }
    }
}