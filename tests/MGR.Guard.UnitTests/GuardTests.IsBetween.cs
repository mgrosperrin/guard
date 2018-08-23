using System;
using Xunit;

namespace MGR.Guard
{
    public partial class GuardTests
    {
        public class IsBetween
        {
            [Fact]
            public void String_Value_Is_Lower_Than_The_Range()
            {
                // Arrange
                var test = "Value";
                var minLimit = "VVV";
                var maxLimit = "WWW";

                // Act & Assert
                var actualException = Assert.Throws<ArgumentOutOfRangeException>(() => Guard.IsBetween(test, "test", minLimit, maxLimit));
                Assert.Equal("test", actualException.ParamName);
            }

            [Fact]
            public void String_Value_Is_Greater_Than_The_Range()
            {
                // Arrange
                var test = "Value";
                var minLimit = "AAA";
                var maxLimit = "BBB";

                // Act & Assert
                var actualException = Assert.Throws<ArgumentOutOfRangeException>(() => Guard.IsBetween(test, "test", minLimit, maxLimit));
                Assert.Equal("test", actualException.ParamName);
            }

            [Fact]
            public void String_Value_Is_Equal_To_The_MinLimit()
            {
                // Arrange
                var test = "Value";
                var minLimit = "Value";
                var maxLimit = "VVV";

                // Act & Assert
                Guard.IsBetween(test, "test", minLimit, maxLimit);
            }

            [Fact]
            public void String_Value_Is_Equal_To_The_MaxLimit()
            {
                // Arrange
                var test = "Value";
                var minLimit = "AAA";
                var maxLimit = "Value";

                // Act & Assert
                Guard.IsBetween(test, "test", minLimit, maxLimit);
            }

            [Fact]
            public void String_Value_Is_In_The_Range()
            {
                // Arrange
                var test = "Value";
                var minLimit = "AAA";
                var maxLimit = "ZZZ";

                // Act & Assert
                Guard.IsBetween(test, "test", minLimit, maxLimit);
            }
            [Fact]
            public void Integer_Value_Is_Lower_Than_The_Range()
            {
                // Arrange
                var test = 5;
                var minLimit = 10;
                var maxLimit = 15;

                // Act & Assert
                var actualException = Assert.Throws<ArgumentOutOfRangeException>(() => Guard.IsBetween(test, "test", minLimit, maxLimit));
                Assert.Equal("test", actualException.ParamName);
            }

            [Fact]
            public void Integer_Value_Is_Greater_Than_The_Range()
            {
                // Arrange
                var test = 5;
                var minLimit = 2;
                var maxLimit = 4;

                // Act & Assert
                var actualException = Assert.Throws<ArgumentOutOfRangeException>(() => Guard.IsBetween(test, "test", minLimit, maxLimit));
                Assert.Equal("test", actualException.ParamName);
            }

            [Fact]
            public void Integer_Value_Is_Equal_To_The_MinLimit()
            {
                // Arrange
                var test = 5;
                var minLimit = 5;
                var maxLimit = 15;

                // Act & Assert
                Guard.IsBetween(test, "test", minLimit, maxLimit);
            }

            [Fact]
            public void Integer_Value_Is_Equal_To_The_MaxLimit()
            {
                // Arrange
                var test = 5;
                var minLimit = 2;
                var maxLimit = 5;

                // Act & Assert
                Guard.IsBetween(test, "test", minLimit, maxLimit);
            }

            [Fact]
            public void Integer_Value_Is_In_The_Range()
            {
                // Arrange
                var test = 5;
                var minLimit = 2;
                var maxLimit = 15;

                // Act & Assert
                Guard.IsBetween(test, "test", minLimit, maxLimit);
            }
        }
    }
}