using System;
using JetBrains.Annotations;

namespace MGR.Guard
{
#if PUBLIC
    public
#else
    internal
#endif
        static partial class Guard
    {
        /// <summary>
        ///     Determines if the specified value is lower than or equal to zero.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <param name="parameterName">Name of the parameter.</param>
        [PublicAPI]
        public static void IsLowerThanOrEqualToZero(int value, [InvokerParameterName] string parameterName)
        {
            if (value > 0)
            {
                throw new ArgumentOutOfRangeException(parameterName, value, Messages.IsLowerThanOrEqualToZeroMessage);
            }
        }

        /// <summary>
        ///     Determines if the specified value is lower than or equal to zero.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <param name="parameterName">Name of the parameter.</param>
        [PublicAPI]
        public static void IsLowerThanOrEqualToZero(long value, [InvokerParameterName] string parameterName)
        {
            if (value > 0)
            {
                throw new ArgumentOutOfRangeException(parameterName, value, Messages.IsLowerThanOrEqualToZeroMessage);
            }
        }

        /// <summary>
        ///     Determines if the specified value is lower than or equals to zero.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <param name="parameterName">Name of the parameter.</param>
        [PublicAPI]
        public static void IsLowerThanOrEqualToZero(double value, [InvokerParameterName] string parameterName)
        {
            if (value > 0)
            {
                throw new ArgumentOutOfRangeException(parameterName, value, Messages.IsLowerThanOrEqualToZeroMessage);
            }
        }

        /// <summary>
        ///     Determines if the specified value is lower than or equal to zero.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <param name="parameterName">Name of the parameter.</param>
        [PublicAPI]
        public static void IsLowerThanOrEqualToZero(float value, [InvokerParameterName] string parameterName)
        {
            if (value > 0)
            {
                throw new ArgumentOutOfRangeException(parameterName, value, Messages.IsLowerThanOrEqualToZeroMessage);
            }
        }
    }
}