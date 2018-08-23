using System;
using Xunit;

namespace MGR.Guard
{
    public partial class GuardTests
    {
        public class IsLowerThanOrEqualTo
        {
            [Fact]
            public void String_Value_Is_Not_Lower_Than_Or_Equals_To_AAA()
            {
                // Arrange
                string test = "Value";
                string maxLimit = "AAA";

                // Act & Assert
                var actualException = Assert.Throws<ArgumentOutOfRangeException>(() => Guard.IsLowerThanOrEqualTo(test, "test", maxLimit));
                Assert.Equal("test", actualException.ParamName);
            }

            [Fact]
            public void String_Value_Is_Lower_Than_Or_Equals_To_ZZZ()
            {
                // Arrange
                string test = "Value";
                string maxLimit = "ZZZ";

                // Act
                Guard.IsLowerThanOrEqualTo(test, "test", maxLimit);
                // Assert
                Assert.True(true);
            }

            [Fact]
            public void String_Value_Is_Lower_Than_Or_Equals_To_Value()
            {
                // Arrange
                string test = "Value";
                string maxLimit = "Value";

                // Act
                Guard.IsLowerThanOrEqualTo(test, "test", maxLimit);
                // Assert
                Assert.True(true);
            }

            [Fact]
            public void Five_Integer_Is_Not_Lower_Than_Or_Equals_To_Zero()
            {
                // Arrange
                int test = 5;
                int maxLimit = 0;

                // Act & Assert
                var actualException = Assert.Throws<ArgumentOutOfRangeException>(() => Guard.IsLowerThanOrEqualTo(test, "test", maxLimit));
                Assert.Equal("test", actualException.ParamName);
            }

            [Fact]
            public void Five_Integer_Is_Lower_Than_Or_Equals_To_Ten()
            {
                // Arrange
                int test = 5;
                int maxLimit = 10;

                // Act
                Guard.IsLowerThanOrEqualTo(test, "test", maxLimit);
                // Assert
                Assert.True(true);
            }

            [Fact]
            public void Five_Integer_Is_Lower_Than_Or_Equals_To_Five()
            {
                // Arrange
                int test = 5;
                int maxLimit = 5;

                // Act
                Guard.IsLowerThanOrEqualTo(test, "test", maxLimit);
                // Assert
                Assert.True(true);
            }
        }
    }
}