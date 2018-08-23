MGR.Guard API
===

All methods are static and throw exception when the condition is not met.

The methods all have two forms:
1. One that takes the parameter to check, potentialy some complementary values, and the name of the parameter,
2. One that takes an [expression to specify the value and the name of the parameter](guard-expression.md), and potentially some complementary values.

## Exists
Checks if a ```System.IO.FileSystemInfo``` exists.

#### Exception thrown
```System.IO.FileNotFoundException``` if the file or directory doesn't exists.

## IsBetween
Checks if a value is between a min and a max limit.

#### Exception thrown
```System.ArgumentOutOfRangeException``` if the value is not between the specified min and max limits.

## IsDefined
Checks if a value is a defined *enum* value.

#### Exception thrown
```System.ArgumentException``` if the specified type is not an *enum*.

```System.ArgumentOutOfRangeException``` if the value is not a defined value of the specified *enum*.

## IsEqualTo
Checks if a value is equal to another reference.

#### Exception thrown
```System.ArgumentNullException``` if the specified comparer is null.

```System.ArgumentException``` if the specified value is not equal to the reference.

## IsEqualToZero
Checks if a value is equal to zero.

#### Exception thrown
```System.IO.ArgumentException``` if the specified value is not equal to zero.

## IsGreaterThan
Checks if a value is greater than a minimal limit.

#### Exception thrown
```System.ArgumentNullException``` if the specified comparer is null.

```System.ArgumentOutOfRangeException``` if the specified value is lower than the minimal limit.

## IsGreaterThanOrEqualTo
Checks if a value is greater than or equal to a minimal limit.

#### Exception thrown
```System.ArgumentNullException``` if the specified comparer is null.

```System.ArgumentOutOfRangeException``` if the specified value is lower than or equal to the minimal limit.

## IsGreaterThanOrEqualToZero
Checks if a value is greater than or equal to zero.

#### Exception thrown
```System.ArgumentOutOfRangeException``` if the specified value is lower than or equal to zero.

## IsGreaterThanZero
Checks if a value is greater than zero.

#### Exception thrown
```System.ArgumentOutOfRangeException``` if the specified value is lower than zero.

## IsLowerThan
Checks if a value is lower than a maximal limit.

#### Exception thrown
```System.ArgumentNullException``` if the specified comparer is null.

```System.ArgumentOutOfRangeException``` if the specified value is greater than a maximal limit.

## IsLowerThanOrEqualTo
Checks if a value is lower than or equal to a minimal limit.

#### Exception thrown
```System.ArgumentNullException``` if the specified comparer is null.

```System.ArgumentOutOfRangeException``` if the specified value is greater than or equal to the minimal limit.

## IsLowerThanOrEqualToZero
Checks if a value is lower than or equal to zero.

#### Exception thrown
```System.ArgumentOutOfRangeException``` if the specified value is greater than or equal to zero.

## IsLowerThanZero
Checks if a value is lower than zero.

#### Exception thrown
```System.ArgumentOutOfRangeException``` if the specified value is greater than zero.

## IsNotEmptyGuid
Checks if a ```System.Guid``` is not empty.

#### Exception thrown
```System.ArgumentNullException``` if the specified ```System.Guid``` is empty.

## IsNotNull
Checks if a value is not ```null```.

#### Exception thrown
```System.ArgumentNullException``` if the specified value is ```null```.

## IsNotNullOrEmpty
Checks if a ```string``` is not ```null``` or empty.

#### Exception thrown
```System.ArgumentNullException``` if the specified value is ```null``` or empty.

## IsStrictlyBetween
Checks if a value is strictly between a min and a max limit.

#### Exception thrown
```System.ArgumentOutOfRangeException``` if the value is not strictly between the specified min and max limits.

