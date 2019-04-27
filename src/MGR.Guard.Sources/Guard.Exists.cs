using System;
using System.IO;
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
        ///     Checks if the specified <see cref="FileSystemInfo " /> <paramref name="expression" /> exists.
        /// </summary>
        /// <param name="expression">The file as an Expression.</param>
        [PublicAPI]
        [Obsolete("Please use MGR.Guardian.ChecksThat.Guardian.ChecksThat.Exists instead.")]
        public static void Exists([NotNull] Expression<Func<FileSystemInfo>> expression)
        {
            Guardian.ChecksThat.Exists(expression);
        }
        /// <summary>
        ///     Checks if the specified <see cref="FileSystemInfo " /> <paramref name="file" /> exists.
        /// </summary>
        /// <param name="file">The file.</param>
        /// <param name="parameterName">The name of the file parameter.</param>
        [PublicAPI]
        [Obsolete("Please use MGR.Guardian.ChecksThat.Guardian.ChecksThat.Exists instead.")]
        public static void Exists([NotNull] FileSystemInfo file, string parameterName)
        {
            Guardian.ChecksThat.Exists(file, parameterName);
        }
    }
}