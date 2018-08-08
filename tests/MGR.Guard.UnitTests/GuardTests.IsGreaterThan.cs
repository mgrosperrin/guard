using System;
using Xunit;

namespace MGR.Guard
{
    public partial class GuardTests
    {
        public class IsGreaterThan
        {
            [Fact]
            public void String_Value_Is_Not_Greather_Than_ZZZ()
            {
                // Arrange
                string test = "Value";
                string minLimit = "ZZZ";

                // Act & Assert
                var actualException = Assert.Throws<ArgumentOutOfRangeException>(() => Guard.IsGreaterThan(test, "test", minLimit));
                Assert.Equal("test", actualException.ParamName);
            }

            [Fact]
            public void String_Value_Is_Greather_Than_AAA()
            {
                // Arrange
                string test = "Value";
                string minLimit = "AAA";

                // Act
                Guard.IsGreaterThan(test, "test", minLimit);
                // Assert
                Assert.True(true);
            }

            [Fact]
            public void String_Value_Is_Not_Strictly_Greather_Than_Value()
            {
                // Arrange
                string test = "Value";
                string minLimit = "Value";

                // Act & Assert
                var actualException = Assert.Throws<ArgumentOutOfRangeException>(() => Guard.IsGreaterThan(test, "test", minLimit));
                Assert.Equal("test", actualException.ParamName);
            }

            [Fact]
            public void Five_Integer_Is_Not_Greather_Than_Ten()
            {
                // Arrange
                int test = 5;
                int minLimit = 10;

                // Act & Assert
                var actualException = Assert.Throws<ArgumentOutOfRangeException>(() => Guard.IsGreaterThan(test, "test", minLimit));
                Assert.Equal("test", actualException.ParamName);
            }

            [Fact]
            public void Five_Integer_Is_Greather_Than_Zero()
            {
                // Arrange
                int test = 5;
                int minLimit = 0;

                // Act
                Guard.IsGreaterThan(test, "test", minLimit);
                // Assert
                Assert.True(true);
            }

            [Fact]
            public void Five_Integer_Is_Not_Strictly_Greather_Than_Five()
            {
                // Arrange
                int test = 5;
                int minLimit = 5;

                // Act & Assert
                var actualException = Assert.Throws<ArgumentOutOfRangeException>(() => Guard.IsGreaterThan(test, "test", minLimit));
                Assert.Equal("test", actualException.ParamName);
            }
        }
    }
}