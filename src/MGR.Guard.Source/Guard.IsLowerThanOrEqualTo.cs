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
        ///     Determines if the specified value is lower than or equal to the maxLimit.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="value">The value.</param>
        /// <param name="maxLimit">The min limit.</param>
        /// <param name="parameterName">Name of the parameter.</param>
        [PublicAPI]
        public static void IsLowerThanOrEqualTo<T>(T value, T maxLimit, [InvokerParameterName] string parameterName)
        {
            var stringValue = value as string;
            if (stringValue != null)
            {
                IsLowerThanOrEqualTo(stringValue, maxLimit as string, parameterName, StringComparer.CurrentCulture);
            }
            else
            {
                IsLowerThanOrEqualTo(value, maxLimit, parameterName, Comparer<T>.Default);
            }
        }

        /// <summary>
        ///     Determines if the specified value is lower than or equal to the maxLimit.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="value">The value.</param>
        /// <param name="maxLimit">The min limit.</param>
        /// <param name="parameterName">Name of the parameter.</param>
        /// <param name="comparer">The comparer.</param>
        [PublicAPI]
        public static void IsLowerThanOrEqualTo<T>(T value, T maxLimit, [InvokerParameterName] string parameterName, IComparer<T> comparer)
        {
            IsNotNull(comparer, nameof(comparer));

            if (comparer.Compare(value, maxLimit) > 0)
            {
                throw new ArgumentOutOfRangeException(parameterName, value,
                    Messages.IsLowerThanOrEqualToFormat<T>()(maxLimit));
            }
        }
    }
}