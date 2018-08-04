﻿using System;
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
        ///     Determines if the specified value is greater than or equal to zero.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <param name="parameterName">Name of the parameter.</param>
        [PublicAPI]
        public static void IsGreaterThanOrEqualToZero(int value, [InvokerParameterName] string parameterName)
        {
            if (value < 0)
            {
                throw new ArgumentOutOfRangeException(parameterName, value, Messages.IsGreaterThanOrEqualToZeroMessage);
            }
        }

        /// <summary>
        ///     Determines if the specified value is greater than or equal to zero.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <param name="parameterName">Name of the parameter.</param>
        [PublicAPI]
        public static void IsGreaterThanOrEqualToZero(long value, [InvokerParameterName] string parameterName)
        {
            if (value < 0)
            {
                throw new ArgumentOutOfRangeException(parameterName, value, Messages.IsGreaterThanOrEqualToZeroMessage);
            }
        }

        /// <summary>
        ///     Determines if the specified value is greater than or equal to zero.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <param name="parameterName">Name of the parameter.</param>
        [PublicAPI]
        public static void IsGreaterThanOrEqualToZero(double value, [InvokerParameterName] string parameterName)
        {
            if (value < 0)
            {
                throw new ArgumentOutOfRangeException(parameterName, value, Messages.IsGreaterThanOrEqualToZeroMessage);
            }
        }

        /// <summary>
        ///     Determines if the specified value is greater than or equal to zero.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <param name="parameterName">Name of the parameter.</param>
        [PublicAPI]
        public static void IsGreaterThanOrEqualToZero(float value, [InvokerParameterName] string parameterName)
        {
            if (value < 0)
            {
                throw new ArgumentOutOfRangeException(parameterName, value, Messages.IsGreaterThanOrEqualToZeroMessage);
            }
        }
    }
}