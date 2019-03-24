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
        [Obsolete("Please use MGR.Guardian.ChecksThat.Guardian.ChecksThat.IsNotNull instead.")]
        public static void IsNotNull<T>(Expression<Func<T>> expression)
        {
            Guardian.ChecksThat.IsNotNull(expression);
        }
        /// <summary>
        ///     Checks if the specified value is null
        /// </summary>
        /// <param name="value">The value.</param>
        /// <param name="parameterName">Name of the parameter.</param>
        /// <exception cref="ArgumentException">Thrown when the value is <code>null</code></exception>
        [ContractAnnotation("value:null => halt")]
        [Obsolete("Please use MGR.Guardian.ChecksThat.Guardian.ChecksThat.IsNotNull instead.")]
        public static void IsNotNull([NotNull] object value, [NotNull] string parameterName)
        {
            Guardian.ChecksThat.IsNotNull(value, parameterName);
        }

        /// <summary>
        ///     Checks if the specified <see cref="string" /> value is null or empty.
        /// </summary>
        /// <param name="expression">The value as an Expression.</param>
        [PublicAPI]
        [Obsolete("Please use MGR.Guardian.ChecksThat.Guardian.ChecksThat.IsNotNullOrEmpty instead.")]
        public static void IsNotNullOrEmpty([NotNull] Expression<Func<string>> expression)
        {
            Guardian.ChecksThat.IsNotNullOrEmpty(expression);
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
        [Obsolete("Please use MGR.Guardian.ChecksThat.Guardian.ChecksThat.IsNotNullOrEmpty instead.")]
        public static void IsNotNullOrEmpty([NotNull] string value, [NotNull] string parameterName)
        {
            Guardian.ChecksThat.IsNotNullOrEmpty(value, parameterName);
        }

        /// <summary>
        ///     Checks if the specified <see cref="Guid" /> value is empty
        /// </summary>
        /// <param name="expression">The value as an Expression.</param>
        [PublicAPI]
        [Obsolete("Please use MGR.Guardian.ChecksThat.Guardian.ChecksThat.IsNotEmptyGuid instead.")]
        public static void IsNotEmptyGuid([NotNull] Expression<Func<Guid>> expression)
        {
            Guardian.ChecksThat.IsNotEmptyGuid(expression);
        }
        /// <summary>
        ///     Checks if the specified <see cref="Guid" /> value is empty
        /// </summary>
        /// <param name="value">The value.</param>
        /// <param name="parameterName">Name of the parameter.</param>
        /// <exception cref="ArgumentException">Thrown when the value is equal to <see cref="Guid.Empty" /></exception>
        [Obsolete("Please use MGR.Guardian.ChecksThat.Guardian.ChecksThat.IsNotEmptyGuid instead.")]
        public static void IsNotEmptyGuid(Guid value, [NotNull] string parameterName)
        {
            Guardian.ChecksThat.IsNotEmptyGuid(value, parameterName);
        }
    }
}