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
        static partial class GuardianExtensions
    {
        /// <summary>
        ///     Checks if the specified <see cref="FileSystemInfo " /> <paramref name="expression" /> exists.
        /// </summary>
        /// <param name="source">The <see cref="Guardian"/> to extends.</param>
        /// <param name="expression">The file as an Expression.</param>
        [PublicAPI]
        public static void Exists([NotNull] this Guardian source, [NotNull] Expression<Func<FileSystemInfo>> expression)
        {
            source.IsNotNull(expression, nameof(expression));

            var (fileSystemInfo, parameterName) = ((IGuardian)source).ExtractValueAndParameterNameFromExpression(expression);
            Exists(source, fileSystemInfo, parameterName);
        }
        /// <summary>
        ///     Checks if the specified <see cref="FileSystemInfo " /> <paramref name="file" /> exists.
        /// </summary>
        /// <param name="source">The <see cref="Guardian"/> to extends.</param>
        /// <param name="file">The file.</param>
        /// <param name="parameterName">The name of the file parameter.</param>
        [PublicAPI]
        public static void Exists([NotNull] this Guardian source, [NotNull] FileSystemInfo file, string parameterName)
        {
            source.IsNotNull(file, nameof(file));

            file.Refresh();
            if (!file.Exists)
            {
                throw new FileNotFoundException(Messages.ExistsNotFoundFormat(parameterName), file.FullName);
            }
        }
    }
}