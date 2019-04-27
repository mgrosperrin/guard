using System;
using Xunit;

namespace MGR.Guard
{
    public partial class GuardianExtensionsTests
    {
        public class IsGreaterThanOrEqualTo
        {
            [Fact]
            public void String_Value_Is_Not_Greater_Than_Or_Equals_To_ZZZ()
            {
                // Arrange
                string test = "Value";
                string minLimit = "ZZZ";

                // Act & Assert
                var actualException = Assert.Throws<ArgumentOutOfRangeException>(() => Guardian.ChecksThat.IsGreaterThanOrEqualTo(test, "test", minLimit));
                Assert.Equal("test", actualException.ParamName);
            }

            [Fact]
            public void String_Value_Is_Greater_Than_Or_Equals_To_AAA()
            {
                // Arrange
                string test = "Value";
                string minLimit = "AAA";

                // Act
                Guardian.ChecksThat.IsGreaterThanOrEqualTo(test, minLimit, "test");
                // Assert
                Assert.True(true);
            }

            [Fact]
            public void String_Value_Is_Greater_Than_Or_Equals_To_Value()
            {
                // Arrange
                string test = "Value";
                string minLimit = "Value";

                // Act
                Guardian.ChecksThat.IsGreaterThanOrEqualTo(test, minLimit, "test");
                // Assert
                Assert.True(true);
            }

            [Fact]
            public void Five_Integer_Is_Not_Greater_Than_Or_Equals_To_Ten()
            {
                // Arrange
                int test = 5;
                int minLimit = 10;

                // Act & Assert
                var actualException = Assert.Throws<ArgumentOutOfRangeException>(() => Guardian.ChecksThat.IsGreaterThanOrEqualTo(test, "test", minLimit));
                Assert.Equal("test", actualException.ParamName);
            }

            [Fact]
            public void Five_Integer_Is_Greater_Than_Or_Equals_To_Zero()
            {
                // Arrange
                int test = 5;
                int minLimit = 0;

                // Act
                Guardian.ChecksThat.IsGreaterThanOrEqualTo(test, "test", minLimit);
                // Assert
                Assert.True(true);
            }

            [Fact]
            public void Five_Integer_Is_Greater_Than_Or_Equals_To_Five()
            {
                // Arrange
                int test = 5;
                int minLimit = 5;

                // Act
                Guardian.ChecksThat.IsGreaterThanOrEqualTo(test, "test", minLimit);
                // Assert
                Assert.True(true);
            }
        }
    }
}