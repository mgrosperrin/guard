using System;
using Xunit;

namespace MGR.Guard
{
    public partial class GuardianExtensionsTests
    {
        public class IsNotEmptyGuid
        {
            [Fact]
            public void Empty_Guid_Is_Empty()
            {
                // Arrange
                Guid test = Guid.Empty;

                // Act & Assert
                ArgumentNullException actual = Assert.Throws<ArgumentNullException>(() => Guardian.ChecksThat.IsNotEmptyGuid(test, "test"));
                Assert.Equal("test", actual.ParamName);
            }

            [Fact]
            public void New_Guid_Is_Not_Empty()
            {
                // Arrange
                Guid test = Guid.NewGuid();

                // Act
                Guardian.ChecksThat.IsNotEmptyGuid(test, "test");

                // Assert
            }
        }
    }
}