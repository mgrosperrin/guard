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
        ///     Checks if the specified value is null
        /// </summary>
        /// <param name="expression">The value as an expression.</param>
        /// <exception cref="ArgumentException">Thrown when the value is <code>null</code></exception>
        public static void IsNotNull<T>(Expression<Func<T>> expression)
        {
            IsNotNull(expression, nameof(expression));

            var (value, parameterName) = ExtractValueAndParameterNameFromExpression(expression);
            IsNotNull(value, parameterName);
        }
        /// <summary>
        ///     Checks if the specified value is null
        /// </summary>
        /// <param name="value">The value.</param>
        /// <param name="parameterName">Name of the parameter.</param>
        /// <exception cref="ArgumentException">Thrown when the value is <code>null</code></exception>
        [ContractAnnotation("value:null => halt")]
        public static void IsNotNull([NotNull] object value, [NotNull] string parameterName)
        {
            if (value == null)
            {
                throw new ArgumentNullException(parameterName, Messages.IsNotNullMessage);
            }
        }

        /// <summary>
        ///     Checks if the specified <see cref="string" /> value is null or empty.
        /// </summary>
        /// <param name="expression">The value as an Expression.</param>
        [PublicAPI]
        public static void IsNotNullOrEmpty([NotNull] Expression<Func<string>> expression)
        {
            IsNotNull(expression, nameof(expression));

            var (value, parameterName) = ExtractValueAndParameterNameFromExpression(expression);
            IsNotNullOrEmpty(value, parameterName);
        }
        /// <summary>
        ///     Checks if the specified <see cref="string" /> value is null or empty.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <param name="parameterName">Name of the parameter.</param>
        /// <exception cref="ArgumentException">
        ///     Thrown when the value is <code>null</code> or equal to <see cref="string.Empty" />
        /// </exception>
        [ContractAnnotation("value:null => halt")]
        public static void IsNotNullOrEmpty([NotNull] string value, [NotNull] string parameterName)
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentNullException(parameterName, Messages.IsNotNullOrEmptyMessage);
            }
        }

        /// <summary>
        ///     Checks if the specified <see cref="Guid" /> value is empty
        /// </summary>
        /// <param name="expression">The value as an Expression.</param>
        [PublicAPI]
        public static void IsNotEmptyGuid([NotNull] Expression<Func<Guid>> expression)
        {
            IsNotNull(expression, nameof(expression));

            var (value, parameterName) = ExtractValueAndParameterNameFromExpression(expression);
            IsNotEmptyGuid(value, parameterName);
        }
        /// <summary>
        ///     Checks if the specified <see cref="Guid" /> value is empty
        /// </summary>
        /// <param name="value">The value.</param>
        /// <param name="parameterName">Name of the parameter.</param>
        /// <exception cref="ArgumentException">Thrown when the value is equal to <see cref="Guid.Empty" /></exception>
        public static void IsNotEmptyGuid(Guid value, [NotNull] string parameterName)
        {
            if (value == Guid.Empty)
            {
                throw new ArgumentNullException(parameterName, Messages.IsNotEmptyGuidMessage);
            }
        }
    }
}