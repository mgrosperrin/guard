﻿using System;
using Xunit;

namespace MGR.Guard
{
    public partial class GuardTests
    {
        public class IsLowerThan
        {
            [Fact]
            public void String_Value_Is_Not_Lower_Than_AAA()
            {
                // Arrange
                string test = "Value";
                string maxLimit = "AAA";

                // Act & Assert
                var actualException = Assert.Throws<ArgumentOutOfRangeException>(() => Guard.IsLowerThan(test, maxLimit, "test"));
                Assert.Equal("test", actualException.ParamName);
            }

            [Fact]
            public void String_Value_Is_Lower_Than_ZZZ()
            {
                // Arrange
                string test = "Value";
                string maxLimit = "ZZZ";

                // Act
                Guard.IsLowerThan(test, maxLimit, "test");
                // Assert
                Assert.True(true);
            }

            [Fact]
            public void String_Value_Is_Not_Strictly_Lower_Than_Value()
            {
                // Arrange
                string test = "Value";
                string maxLimit = "Value";

                // Act & Assert
                var actualException = Assert.Throws<ArgumentOutOfRangeException>(() => Guard.IsLowerThan(test, maxLimit, "test"));
                Assert.Equal("test", actualException.ParamName);
            }

            [Fact]
            public void Five_Integer_Is_Not_Lower_Than_Zero()
            {
                // Arrange
                int test = 5;
                int maxLimit = 0;

                // Act & Assert
                var actualException = Assert.Throws<ArgumentOutOfRangeException>(() => Guard.IsLowerThan(test, maxLimit, "test"));
                Assert.Equal("test", actualException.ParamName);
            }

            [Fact]
            public void Five_Integer_Is_Lower_Than_Ten()
            {
                // Arrange
                int test = 5;
                int maxLimit = 10;

                // Act
                Guard.IsLowerThan(test, maxLimit, "test");
                // Assert
                Assert.True(true);
            }

            [Fact]
            public void Five_Integer_Is_Not_Strictly_Lower_Than_Five()
            {
                // Arrange
                int test = 5;
                int maxLimit = 5;

                // Act & Assert
                var actualException = Assert.Throws<ArgumentOutOfRangeException>(() => Guard.IsLowerThan(test, maxLimit, "test"));
                Assert.Equal("test", actualException.ParamName);
            }
        }
    }
}