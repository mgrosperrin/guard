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
        public static void Exists([NotNull] Expression<Func<FileSystemInfo>> expression)
        {
            IsNotNull(expression, nameof(expression));

            var (fileSystemInfo, parameterName) = ExtractValueAndParameterNameFromExpression(expression);
            Exists(fileSystemInfo, parameterName);
        }
        /// <summary>
        ///     Checks if the specified <see cref="FileSystemInfo " /> <paramref name="file" /> exists.
        /// </summary>
        /// <param name="file">The file.</param>
        /// <param name="parameterName">The name of the file parameter.</param>
        [PublicAPI]
        public static void Exists([NotNull] FileSystemInfo file, string parameterName)
        {

            IsNotNull(file, nameof(file));

            file.Refresh();
            if (!file.Exists)
            {
                throw new FileNotFoundException(Messages.ExistsNotFoundFormat(parameterName), file.FullName);
            }
        }
    }
}