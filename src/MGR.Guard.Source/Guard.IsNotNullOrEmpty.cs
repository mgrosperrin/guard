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
        ///     Determines if the specified value is null
        /// </summary>
        /// <param name="value">The value.</param>
        /// <param name="parameterName">Name of the parameter.</param>
        /// <exception cref="ArgumentException">Thrown when the value is <code>null</code></exception>
        [ContractAnnotation("value:null => halt")]
        public static void IsNotNull([CanBeNull] object value, [InvokerParameterName] string parameterName)
        {
            if (value == null)
            {
                throw new ArgumentNullException(parameterName, Messages.IsNotNullMessage);
            }
        }

        /// <summary>
        ///     Determines if the specified <see cref="string" /> value is null or empty
        /// </summary>
        /// <param name="value">The value.</param>
        /// <param name="parameterName">Name of the parameter.</param>
        /// <exception cref="ArgumentException">
        ///     Thrown when the value is <code>null</code> or equal to <see cref="string.Empty" />
        /// </exception>
        [ContractAnnotation("value:null => halt")]
        public static void IsNotNullOrEmpty([CanBeNull] string value, [InvokerParameterName] string parameterName)
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentNullException(parameterName, Messages.IsNotNullOrEmptyMessage);
            }
        }

        /// <summary>
        ///     Determines if the specified <see cref="Guid" /> value is empty
        /// </summary>
        /// <param name="value">The value.</param>
        /// <param name="parameterName">Name of the parameter.</param>
        /// <exception cref="ArgumentException">Thrown when the value is equal to <see cref="Guid.Empty" /></exception>
        public static void IsNotEmptyGuid(Guid value, [InvokerParameterName] string parameterName)
        {
            if (value == Guid.Empty)
            {
                throw new ArgumentException(Messages.IsNotEmptyGuidMessage, parameterName);
            }
        }
    }
}