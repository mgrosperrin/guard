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
        ///     Determines if the specified value is greater than zero.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <param name="parameterName">Name of the parameter.</param>
        [PublicAPI]
        public static void IsGreaterThanZero(int value, [InvokerParameterName] string parameterName)
        {
            if (value <= 0)
            {
                throw new ArgumentOutOfRangeException(parameterName, value, Messages.IsGreaterThanZeroMessage);
            }
        }

        /// <summary>
        ///     Determines if the specified value is greater than zero.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <param name="parameterName">Name of the parameter.</param>
        [PublicAPI]
        public static void IsGreaterThanZero(long value, [InvokerParameterName] string parameterName)
        {
            if (value <= 0)
            {
                throw new ArgumentOutOfRangeException(parameterName, value, Messages.IsGreaterThanZeroMessage);
            }
        }

        /// <summary>
        ///     Determines if the specified value is greater than zero.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <param name="parameterName">Name of the parameter.</param>
        [PublicAPI]
        public static void IsGreaterThanZero(double value, [InvokerParameterName] string parameterName)
        {
            if (value <= 0)
            {
                throw new ArgumentOutOfRangeException(parameterName, value, Messages.IsGreaterThanZeroMessage);
            }
        }

        /// <summary>
        ///     Determines if the specified value is greater than zero.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <param name="parameterName">Name of the parameter.</param>
        [PublicAPI]
        public static void IsGreaterThanZero(float value, [InvokerParameterName] string parameterName)
        {
            if (value <= 0)
            {
                throw new ArgumentOutOfRangeException(parameterName, value, Messages.IsGreaterThanZeroMessage);
            }
        }
    }
}