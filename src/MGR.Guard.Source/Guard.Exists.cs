using System.IO;
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
        ///     Checks if the specified <see cref="FileInfo " /> <paramref name="file" /> exists.
        /// </summary>
        /// <param name="file">The file.</param>
        [PublicAPI]
        public static void Exists(FileSystemInfo file)
        {
            IsNotNull(file, nameof(file));

            file.Refresh();
            if (!file.Exists)
            {
                throw new FileNotFoundException(Messages.ExistsNotFoundFormat(file.FullName));
            }
        }
    }
}