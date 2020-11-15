using System;
using System.Collections;
using System.Linq;
using Xunit;

namespace MGR.Guard
{
    public partial class GuardianExtensionsTests
    {
        public class IsNotEmpty
        {
            [Fact]
            public void Collection_Should_Not_Be_Null()
            {
                // Arrange
                IEnumerable collection = null;

                // Act & Assert
                var actualException = Assert.Throws<ArgumentOutOfRangeException>(() => Guardian.ChecksThat.IsNotEmpty(collection, nameof(collection)));
                Assert.Equal("collection", actualException.ParamName);
            }

            [Fact]
            public void Collection_Should_Not_Be_Empty()
            {
                // Arrange
                IEnumerable collection = Enumerable.Empty<object>();

                // Act & Assert
                var actualException = Assert.Throws<ArgumentOutOfRangeException>(() => Guardian.ChecksThat.IsNotEmpty(collection, nameof(collection)));
                Assert.Equal("collection", actualException.ParamName);
            }

            [Fact]
            public void Non_Empty_Collection()
            {
                // Arrange
                IEnumerable collection = new []{new object()};

                // Act & Assert
                Guardian.ChecksThat.IsNotEmpty(collection, nameof(collection));
            }
        }
    }
}