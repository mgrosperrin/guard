using System;

namespace MGR.Guard
{
    /// <summary>
    ///     Class to check whether a parameter, argument, invariant satisfy some usual conditions.
    /// </summary>
    [Obsolete("Please use extensions methods to MGR.Guardian.ChecksThat.Guardian.ChecksThat property instead.")]
#if MGR_GUARD_PUBLIC
    public
#else
    internal
#endif
    partial class Guard
    {
    }
}