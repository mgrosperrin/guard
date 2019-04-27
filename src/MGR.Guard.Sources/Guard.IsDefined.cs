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
        ///     Checks if the specified value is defined in the enum type.
        /// </summary>
        /// <typeparam name="TEnum">The type of the enum.</typeparam>
        /// <param name="expression">The enum as an Expression.</param>
        [PublicAPI]
        [Obsolete("Please use MGR.Guardian.ChecksThat.Guardian.ChecksThat.IsDefined instead.")]
#pragma warning disable CS3024 // Constraint type is not CLS-compliant
        public static void IsDefined<TEnum>([NotNull] Expression<Func<TEnum>> expression)
#pragma warning restore CS3024 // Constraint type is not CLS-compliant
            where TEnum : struct, IConvertible
        {
            Guardian.ChecksThat.IsDefined(expression);
        }
        /// <summary>
        ///     Checks if the specified value is defined in the enum type.
        /// </summary>
        /// <typeparam name="TEnum">The type of the enum.</typeparam>
        /// <param name="value">The value to check.</param>
        /// <param name="parameterName">The name of the parameter.</param>
        [PublicAPI]
        [Obsolete("Please use MGR.Guardian.ChecksThat.Guardian.ChecksThat.IsDefined instead.")]
#pragma warning disable CS3024 // Constraint type is not CLS-compliant
        public static void IsDefined<TEnum>(TEnum value, [NotNull] string parameterName)
#pragma warning restore CS3024 // Constraint type is not CLS-compliant
            where TEnum : struct, IConvertible
        {
            Guardian.ChecksThat.IsDefined(value, parameterName);
        }
    }
}