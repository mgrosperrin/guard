MGR.Guard.Sources
===

The purpose of the `MGR.Guard.Sources` package is to provide the `MGR.Guard`
library as source code to be used in a library without adding a
dependency to it.

All classes (`MGR.Guard.Guardian`, `MGR.Guard.GuardianExtensions` and the now obsolete `MGR.Guard.Guard`) are marked as `internal` to not be exposed by your library.

These classes can be marked as `public` by setting the constant `MGR_GUARD_PUBLIC`.
