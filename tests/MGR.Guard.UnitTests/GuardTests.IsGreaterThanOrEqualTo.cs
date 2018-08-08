﻿using System;
using Xunit;

namespace MGR.Guard
{
    public partial class GuardTests
    {
        public class IsGreaterThanOrEqualTo
        {
            [Fact]
            public void String_Value_Is_Not_Greather_Than_Or_Equals_To_ZZZ()
            {
                // Arrange
                string test = "Value";
                string minLimit = "ZZZ";

                // Act & Assert
                var actualException = Assert.Throws<ArgumentOutOfRangeException>(() => Guard.IsGreaterThanOrEqualTo(test, "test", minLimit));
                Assert.Equal("test", actualException.ParamName);
            }

            [Fact]
            public void String_Value_Is_Greather_Than_Or_Equals_To_AAA()
            {
                // Arrange
                string test = "Value";
                string minLimit = "AAA";

                // Act
                Guard.IsGreaterThanOrEqualTo(test, minLimit, "test");
                // Assert
                Assert.True(true);
            }

            [Fact]
            public void String_Value_Is_Greather_Than_Or_Equals_To_Value()
            {
                // Arrange
                string test = "Value";
                string minLimit = "Value";

                // Act
                Guard.IsGreaterThanOrEqualTo(test, minLimit, "test");
                // Assert
                Assert.True(true);
            }

            [Fact]
            public void Five_Integer_Is_Not_Greather_Than_Or_Equals_To_Ten()
            {
                // Arrange
                int test = 5;
                int minLimit = 10;

                // Act & Assert
                var actualException = Assert.Throws<ArgumentOutOfRangeException>(() => Guard.IsGreaterThanOrEqualTo(test, "test", minLimit));
                Assert.Equal("test", actualException.ParamName);
            }

            [Fact]
            public void Five_Integer_Is_Greather_Than_Or_Equals_To_Zero()
            {
                // Arrange
                int test = 5;
                int minLimit = 0;

                // Act
                Guard.IsGreaterThanOrEqualTo(test, "test", minLimit);
                // Assert
                Assert.True(true);
            }

            [Fact]
            public void Five_Integer_Is_Greather_Than_Or_Equals_To_Five()
            {
                // Arrange
                int test = 5;
                int minLimit = 5;

                // Act
                Guard.IsGreaterThanOrEqualTo(test, "test", minLimit);
                // Assert
                Assert.True(true);
            }
        }
    }
}