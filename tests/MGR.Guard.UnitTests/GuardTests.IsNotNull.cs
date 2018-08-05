using System;
using Xunit;

namespace MGR.Guard
{
    public partial class GuardTests
    {
        public class IsNotNull
        {
            [Fact]
            public void A_Null_Object_Is_Null()
            {
                // Arrange
                object test = null;

                // Act & Assert
                // ReSharper disable once AssignNullToNotNullAttribute
                ArgumentNullException actual = Assert.Throws<ArgumentNullException>(() => Guard.IsNotNull(test, "test"));
                Assert.Equal("test", actual.ParamName);
            }

            [Fact]
            public void A_New_Object_Is_Not_Null()
            {
                // Arrange
                object test = new object();

                // Act
                Guard.IsNotNull(test, "test");

                // Assert
                Assert.True(true);
            }
        }
    }
}