using System;
using System.Collections;
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
        ///     Checks that the specified <see cref="IEnumerable " /> <paramref name="expression" /> is empty.
        /// </summary>
        /// <param name="source">The <see cref="Guardian"/> to extends.</param>
        /// <param name="expression">The collection as an Expression.</param>
        [PublicAPI]
        public static void IsNotEmpty([NotNull] this Guardian source, [NotNull] Expression<Func<IEnumerable>> expression)
        {
            source.IsNotNull(expression, nameof(expression));

            var (collection, parameterName) = ((IGuardian)source).ExtractValueAndParameterNameFromExpression(expression);
            IsNotEmpty(source, collection, parameterName);
        }
        /// <summary>
        ///     Checks if the specified <see cref="FileSystemInfo " /> <paramref name="collection" /> exists.
        /// </summary>
        /// <param name="source">The <see cref="Guardian"/> to extends.</param>
        /// <param name="collection">The file.</param>
        /// <param name="parameterName">The name of the file parameter.</param>
        [PublicAPI]
        public static void IsNotEmpty([NotNull] this Guardian source, [NotNull] IEnumerable collection, string parameterName)
        {
            source.IsNotNull(collection, nameof(collection));

            var enumerator = collection.GetEnumerator();
            var hasItems = enumerator.MoveNext();
            if (!hasItems)
            {
                throw new ArgumentException(Messages.IsNotEmptyMessage, parameterName);
            }
        }
    }
}