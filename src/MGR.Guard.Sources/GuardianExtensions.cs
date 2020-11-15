using System;
using System.Globalization;

namespace MGR.Guard
{
    /// <summary>
    /// Extensions methods for the <see cref="Guardian"/> class.
    /// </summary>
#if MGR_GUARD_PUBLIC
    public
#else
    internal
#endif
    static partial class GuardianExtensions
    {
        private static class Messages
        {
            internal const string IsNotNullMessage = "The argument cannot be null.";
            internal static readonly Func<object, string> IsEqualToFormat = referenceValue => string.Format(CultureInfo.CurrentCulture, "The argument must be equal to {0}.", referenceValue);
            internal const string ComparerNotNullMessage = "The comparer cannot be null. ";
            internal const string IsEqualToZeroMessage = "The argument must be equal to 0.";
            internal static readonly Func<string, string> ExistsNotFoundFormat = parameterName => string.Format(CultureInfo.CurrentCulture, "The file passed as parameter '{0}' doesn't exists.",
                parameterName);
            internal static Func<T, string> IsGreaterThanFormat<T>() => minLimit => string.Format(CultureInfo.CurrentCulture, "The argument must be strictly greater than {0}.", minLimit);
            internal static Func<T, T, string> IsStrictlyBetweenFormat<T>() => (minLimit, maxLimit) => string.Format(CultureInfo.CurrentCulture, "The argument must be strictly between {0} and {1}.", minLimit, maxLimit);
            internal static Func<T, T, string> IsBetweenFormat<T>() => (minLimit, maxLimit) => string.Format(CultureInfo.CurrentCulture, "The argument must be between {0} and {1}.", minLimit, maxLimit);
            internal static Func<T, string> IsGreaterThanOrEqualToFormat<T>() => minLimit => string.Format(CultureInfo.CurrentCulture, "The argument must be greater than or equal to {0}.", minLimit);
            internal const string IsGreaterThanZeroMessage = "The argument must be strictly greater than 0.";
            internal const string IsGreaterThanOrEqualToZeroMessage = "The argument must be greater than or equal to 0.";
            internal const string IsNotEmptyGuidMessage = "The argument cannot be an empty Guid.";
            internal const string IsNotNullOrEmptyMessage = "The argument cannot be null or empty.";
            internal static Func<T, string> IsLowerThanFormat<T>() => maxLimit => string.Format(CultureInfo.CurrentCulture, "The argument must be strictly lower than {0}.", maxLimit);
            internal static Func<T, string> IsLowerThanOrEqualToFormat<T>() => maxLimit => string.Format(CultureInfo.CurrentCulture, "The argument must be lower than or equal to {0}.", maxLimit);
            internal const string IsLowerThanZeroMessage = "The argument must be strictly lower than 0.";
            internal const string IsLowerThanOrEqualToZeroMessage = "The argument must be lower than or equal to 0.";
            internal const string IsDefinedType = "TEnum must be an enumerated type.";
            internal static Func<TEnum, Type, string> IsDefinedFormat<TEnum>() => (value, enumType) => string.Format(CultureInfo.CurrentCulture, "The value '{0}' is not defined in the enum type '{1}'.", value, enumType);
            internal const string IsNotEmptyMessage = "The collection cannot be empty.";
        }
    }
}