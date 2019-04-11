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
        static partial class GuardianExtensions
    {
        /// <summary>
        ///     Checks if the specified value is null
        /// </summary>
        /// <typeparam name="T">The type of the value to Guardian.ChecksThat.</typeparam>
        /// <param name="source">The <see cref="Guardian"/> to extends.</param>
        /// <param name="expression">The value as an expression.</param>
        /// <exception cref="ArgumentException">Thrown when the value is <code>null</code></exception>
        public static void IsNotNull<T>([NotNull] this Guardian source, Expression<Func<T>> expression)
        {
            source.IsNotNull(expression, nameof(expression));

            var (value, parameterName) = ((IGuardian)source).ExtractValueAndParameterNameFromExpression(expression);
            IsNotNull(source, value, parameterName);
        }
        /// <summary>
        ///     Checks if the specified value is null
        /// </summary>
        /// <param name="source">The <see cref="Guardian"/> to extends.</param>
        /// <param name="value">The value.</param>
        /// <param name="parameterName">Name of the parameter.</param>
        /// <exception cref="ArgumentException">Thrown when the value is <code>null</code></exception>
        [ContractAnnotation("value:null => halt")]
        public static void IsNotNull([NotNull] this Guardian source, [NotNull] object value, [NotNull] string parameterName)
        {
            if (value == null)
            {
                throw new ArgumentNullException(parameterName, Messages.IsNotNullMessage);
            }
        }

        /// <summary>
        ///     Checks if the specified <see cref="string" /> value is null or empty.
        /// </summary>
        /// <param name="source">The <see cref="Guardian"/> to extends.</param>
        /// <param name="expression">The value as an Expression.</param>
        [PublicAPI]
        public static void IsNotNullOrEmpty([NotNull] this Guardian source, [NotNull] Expression<Func<string>> expression)
        {
            source.IsNotNull(expression, nameof(expression));

            var (value, parameterName) = ((IGuardian)source).ExtractValueAndParameterNameFromExpression(expression);
            IsNotNullOrEmpty(source, value, parameterName);
        }
        /// <summary>
        ///     Checks if the specified <see cref="string" /> value is null or empty.
        /// </summary>
        /// <param name="source">The <see cref="Guardian"/> to extends.</param>
        /// <param name="value">The value.</param>
        /// <param name="parameterName">Name of the parameter.</param>
        /// <exception cref="ArgumentException">
        ///     Thrown when the value is <code>null</code> or equal to <see cref="string.Empty" />
        /// </exception>
        [ContractAnnotation("value:null => halt")]
        public static void IsNotNullOrEmpty([NotNull] this Guardian source, [NotNull] string value, [NotNull] string parameterName)
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentNullException(parameterName, Messages.IsNotNullOrEmptyMessage);
            }
        }

        /// <summary>
        ///     Checks if the specified <see cref="Guid" /> value is empty
        /// </summary>
        /// <param name="source">The <see cref="Guardian"/> to extends.</param>
        /// <param name="expression">The value as an Expression.</param>
        [PublicAPI]
        public static void IsNotEmptyGuid([NotNull] this Guardian source, [NotNull] Expression<Func<Guid>> expression)
        {
            source.IsNotNull(expression, nameof(expression));

            var (value, parameterName) = ((IGuardian)source).ExtractValueAndParameterNameFromExpression(expression);
            IsNotEmptyGuid(source, value, parameterName);
        }
        /// <summary>
        ///     Checks if the specified <see cref="Guid" /> value is empty
        /// </summary>
        /// <param name="source">The <see cref="Guardian"/> to extends.</param>
        /// <param name="value">The value.</param>
        /// <param name="parameterName">Name of the parameter.</param>
        /// <exception cref="ArgumentException">Thrown when the value is equal to <see cref="Guid.Empty" /></exception>
        public static void IsNotEmptyGuid([NotNull] this Guardian source, Guid value, [NotNull] string parameterName)
        {
            if (value == Guid.Empty)
            {
                throw new ArgumentNullException(parameterName, Messages.IsNotEmptyGuidMessage);
            }
        }
    }
}