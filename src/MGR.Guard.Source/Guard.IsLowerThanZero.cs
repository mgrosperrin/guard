using System;
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
        ///     Determines if the specified value is lower than zero.
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
        ///     Determines if the specified value is lower than zero.
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
        ///     Determines if the specified value is lower than zero.
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
        ///     Determines if the specified value is lower than zero.
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