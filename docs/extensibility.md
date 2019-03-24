MGR.Guard extensibility
===

All checks are built as extension method of the `MGR.Guard.Guardian` class.

To be constistent with built-in methods, I recommand to have the following signature: `void YourMathod(this Guardian source, TypeOfValue value, string parameterName, <optional additional values>)`.

You can also provide an overload with an expression and use the explicitly implemented (by the `Guardian` instance) `IGuardian.ExtractValueAndParameterNameFromExpression`. This method will extract the value and the parameter name from the expression.

As an example, the method to check for non nullability is implemented as:
```c#
public static void IsNotNull<T>(this Guardian source, Expression<Func<T>> expression)
{
    var (value, parameterName) = ((IGuardian)source).ExtractValueAndParameterNameFromExpression(expression);
    
    IsNotNull(source, value, parameterName);
}
public static void IsNotNull(this Guardian source, object value, string parameterName)
{
    if (value == null)
    {
        throw new ArgumentNullException(parameterName, essages.IsNotNullMessage);
    }
}
```