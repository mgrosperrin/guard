using System;
using Xunit;

namespace MGR.Guard
{
    public partial class GuardTests
    {
        public class IsNotEmptyGuid
        {
            [Fact]
            public void Empty_Guid_Is_Empty()
            {
                // Arrange
                Guid test = Guid.Empty;

                // Act & Assert
                ArgumentException actual = Assert.Throws<ArgumentException>(() => Guard.IsNotEmptyGuid(test, "test"));
                Assert.Equal("test", actual.ParamName);
            }

            [Fact]
            public void New_Guid_Is_Not_Empty()
            {
                // Arrange
                Guid test = Guid.NewGuid();

                // Act
                Guard.IsNotEmptyGuid(test, "test");

                // Assert
            }
        }
    }
}