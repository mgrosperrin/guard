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
        ///     Determines if the specified value is equal to zero.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <param name="parameterName">Name of the parameter.</param>
        [PublicAPI]
        public static void IsEqualToZero(int value, [InvokerParameterName] string parameterName)
        {
            if (value != 0)
            {
                throw new ArgumentException(Messages.IsEqualToZeroMessage, parameterName);
            }
        }

        /// <summary>
        ///     Determines if the specified value is equal to zero.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <param name="parameterName">Name of the parameter.</param>
        [PublicAPI]
        public static void IsEqualToZero(long value, [InvokerParameterName] string parameterName)
        {
            if (value != 0)
            {
                throw new ArgumentException(Messages.IsEqualToZeroMessage, parameterName);
            }
        }

        /// <summary>
        ///     Determines if the specified value is equal to zero.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <param name="parameterName">Name of the parameter.</param>
        public static void IsEqualToZero(double value, [InvokerParameterName] string parameterName)
        {
            if (Math.Abs(value - 0) > double.Epsilon)
            {
                throw new ArgumentException(Messages.IsEqualToZeroMessage, parameterName);
            }
        }

        /// <summary>
        ///     Determines if the specified value is equal to zero.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <param name="parameterName">Name of the parameter.</param>
        [PublicAPI]
        public static void IsEqualToZero(float value, [InvokerParameterName] string parameterName)
        {
            if (Math.Abs(value - 0) > float.Epsilon)
            {
                throw new ArgumentException(Messages.IsEqualToZeroMessage, parameterName);
            }
        }
    }
}