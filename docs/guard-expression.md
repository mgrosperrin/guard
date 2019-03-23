MGR.Guard expression-based API
===

The expression-based API takes an expression to specify the value
and the name of the parameter.

The expression can be any combinaison of:

- a ConstantExpression (ie `() => 1`),
- a MemberExpression (ie `() => value`, `() => value.Property`),
- a BinaryExpression that represents an array index access (ie `() => value[0]`)

If any part of an expression is null (except the complete expression), a `System.NullReferenceException` will be thrown be the expression parser.
