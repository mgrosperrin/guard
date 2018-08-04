using System;
using Xunit;

namespace MGR.Guard
{
    public partial class GuardTests
    {
        public class IsGreaterThanOrEqualToZero
        {
            [Fact]
            public void Five_Integer_Is_Greather_Than_Or_Equals_To_Zero()
            {
                // Arrange
                int test = 5;

                // Act
                Guard.IsGreaterThanOrEqualToZero(test, "test");

                // Assert
                Assert.True(true);
            }

            [Fact]
            public void Minus_Five_Integer_Is_Not_Greather_Than_Or_Equals_To_Zero()
            {
                // Arrange
                int test = -5;

                // Act & Assert
                var actualException = Assert.Throws<ArgumentOutOfRangeException>(() => Guard.IsGreaterThanOrEqualToZero(test, "test"));
                Assert.Equal("test", actualException.ParamName);
            }

            [Fact]
            public void Zero_Integer_Is_Greather_Than_Or_Equals_To_Zero()
            {
                // Arrange
                int test = 0;

                // Act
                Guard.IsGreaterThanOrEqualToZero(test, "test");

                // Assert
                Assert.True(true);
            }

            [Fact]
            public void Five_Float_Is_Greather_Than_Or_Equals_To_Zero()
            {
                // Arrange
                float test = 5;

                // Act
                Guard.IsGreaterThanOrEqualToZero(test, "test");

                // Assert
                Assert.True(true);
            }

            [Fact]
            public void Minus_Five_Float_Is_Not_Greather_Than_Or_Equals_To_Zero()
            {
                // Arrange
                float test = -5;

                // Act & Assert
                var actualException = Assert.Throws<ArgumentOutOfRangeException>(() => Guard.IsGreaterThanOrEqualToZero(test, "test"));
                Assert.Equal("test", actualException.ParamName);
            }

            [Fact]
            public void Zero_Float_Is_Greather_Than_Or_Equals_To_Zero()
            {
                // Arrange
                float test = 0;

                // Act
                Guard.IsGreaterThanOrEqualToZero(test, "test");

                // Assert
                Assert.True(true);
            }

            [Fact]
            public void Five_Double_Is_Greather_Than_Or_Equals_To_Zero()
            {
                // Arrange
                double test = 5;

                // Act
                Guard.IsGreaterThanOrEqualToZero(test, "test");

                // Assert
                Assert.True(true);
            }

            [Fact]
            public void Minus_Five_Double_Is_Not_Greather_Than_Or_Equals_To_Zero()
            {
                // Arrange
                double test = -5;

                // Act & Assert
                var actualException = Assert.Throws<ArgumentOutOfRangeException>(() => Guard.IsGreaterThanOrEqualToZero(test, "test"));
                Assert.Equal("test", actualException.ParamName);
            }

            [Fact]
            public void Zero_Double_Is_Greather_Than_Or_Equals_To_Zero()
            {
                // Arrange
                double test = 0;

                // Act
                Guard.IsGreaterThanOrEqualToZero(test, "test");

                // Assert
                Assert.True(true);
            }

            [Fact]
            public void Five_Long_Is_Greather_Than_Or_Equals_To_Zero()
            {
                // Arrange
                long test = 5;

                // Act
                Guard.IsGreaterThanOrEqualToZero(test, "test");

                // Assert
                Assert.True(true);
            }

            [Fact]
            public void Minus_Five_Long_Is_Not_Greather_Than_Or_Equals_To_Zero()
            {
                // Arrange
                long test = -5;

                // Act & Assert
                var actualException = Assert.Throws<ArgumentOutOfRangeException>(() => Guard.IsGreaterThanOrEqualToZero(test, "test"));
                Assert.Equal("test", actualException.ParamName);
            }

            [Fact]
            public void Zero_Long_Is_Greather_Than_Or_Equals_To_Zero()
            {
                // Arrange
                long test = 0;

                // Act
                Guard.IsGreaterThanOrEqualToZero(test, "test");

                // Assert
                Assert.True(true);
            }
        }
    }
}