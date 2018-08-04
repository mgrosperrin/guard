using System;
using System.Reflection;
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
        ///     Checks if the specified value is defined in the enum type.
        /// </summary>
        /// <typeparam name="TEnum">The type of the enum.</typeparam>
        /// <param name="value">The value to check.</param>
        /// <param name="parameterName">The name of the parameter.</param>
        [PublicAPI]
#pragma warning disable CS3024 // Constraint type is not CLS-compliant
        public static void IsDefined<TEnum>(TEnum value, [InvokerParameterName] string parameterName)
#pragma warning restore CS3024 // Constraint type is not CLS-compliant
            where TEnum : struct, IConvertible
        {
            var enumType = typeof(TEnum);
            if (!enumType.GetTypeInfo().IsEnum)
            {
                throw new ArgumentException(Messages.IsDefinedType);
            }
            if (!Enum.IsDefined(enumType, value))
            {
                throw new ArgumentOutOfRangeException(Messages.IsDefinedFormat<TEnum>()(value, enumType), parameterName);
            }
        }
    }
}