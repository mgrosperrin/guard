using System;
using System.Collections.Generic;
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
        ///     Determines if the specified value is greater than or equal to the minLimit.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="value">The value.</param>
        /// <param name="minLimit">The min limit.</param>
        /// <param name="parameterName">Name of the parameter.</param>
        [PublicAPI]
        public static void IsGreaterThanOrEqualTo<T>(T value, T minLimit, [InvokerParameterName] string parameterName)
        {
            var strValue = value as string;
            if (strValue != null)
            {
                IsGreaterThanOrEqualTo(strValue, minLimit as string, parameterName, StringComparer.CurrentCulture);
            }
            else
            {
                IsGreaterThanOrEqualTo(value, minLimit, parameterName, Comparer<T>.Default);
            }
        }

        /// <summary>
        ///     Determines if the specified value is greater than or equal to the minLimit.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="value">The value.</param>
        /// <param name="minLimit">The min limit.</param>
        /// <param name="parameterName">Name of the parameter.</param>
        /// <param name="comparer">The comparer.</param>
        [PublicAPI]
        public static void IsGreaterThanOrEqualTo<T>(T value, T minLimit, [InvokerParameterName] string parameterName, IComparer<T> comparer)
        {
            IsNotNull(comparer, nameof(comparer));

            if (comparer.Compare(value, minLimit) < 0)
            {
                throw new ArgumentOutOfRangeException(parameterName, value,
                    Messages.IsGreaterThanOrEqualToFormat<T>()(minLimit));
            }
        }
    }
}