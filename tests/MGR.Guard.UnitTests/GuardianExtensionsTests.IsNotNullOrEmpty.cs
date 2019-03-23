using System;
using Xunit;

namespace MGR.Guard
{
    public partial class GuardianExtensionsTests
    {
        public class IsNotNullOrEmpty
        {
            [Fact]
            public void A_Null_String_Is_Null_Or_Empty()
            {
                // Arrange
                string test = null;

                // Act & Assert
                // ReSharper disable once AssignNullToNotNullAttribute
                ArgumentNullException actual = Assert.Throws<ArgumentNullException>(() => Guardian.ChecksThat.IsNotNullOrEmpty(test, "test"));
                Assert.Equal("test", actual.ParamName);
            }
            [Fact]
            public void A_Empty_String_Is_Null_Or_Empty()
            {
                // Arrange
                string test = string.Empty;

                // Act & Assert
                ArgumentNullException actual = Assert.Throws<ArgumentNullException>(() => Guardian.ChecksThat.IsNotNullOrEmpty(test, "test"));
                Assert.Equal("test", actual.ParamName);
            }
            [Fact]
            public void A_Not_Null_String_Is_Not_Null_Or_Empty()
            {
                // Arrange
                string test = "This string is not null or empty";

                // Act
                Guardian.ChecksThat.IsNotNullOrEmpty(test, "test");

                // Assert
                Assert.True(true);
            }
        }
    }
}