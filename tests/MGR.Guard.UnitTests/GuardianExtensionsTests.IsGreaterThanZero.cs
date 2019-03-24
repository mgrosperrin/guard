using System;
using Xunit;

namespace MGR.Guard
{
    public partial class GuardianExtensionsTests
    {
        public class IsGreaterThanZero
        {
            [Fact]
            public void Five_Integer_Is_Greater_Than_Zero()
            {
                // Arrange
                int test = 5;

                // Act
                Guardian.ChecksThat.IsGreaterThanZero(test, "test");

                // Assert
                Assert.True(true);
            }

            [Fact]
            public void Minus_Five_Integer_Is_Not_Greater_Than_Zero()
            {
                // Arrange
                int test = -5;

                // Act & Assert
                var actualException = Assert.Throws<ArgumentOutOfRangeException>(() => Guardian.ChecksThat.IsGreaterThanZero(test, "test"));
                Assert.Equal("test", actualException.ParamName);
            }

            [Fact]
            public void Zero_Integer_Is_Not_Strictly_Greater_Than_Zero()
            {
                // Arrange
                int test = 0;

                // Act & Assert
                var actualException = Assert.Throws<ArgumentOutOfRangeException>(() => Guardian.ChecksThat.IsGreaterThanZero(test, "test"));
                Assert.Equal("test", actualException.ParamName);
            }

            [Fact]
            public void Five_Float_Is_Greater_Than_Zero()
            {
                // Arrange
                float test = 5;

                // Act
                Guardian.ChecksThat.IsGreaterThanZero(test, "test");

                // Assert
                Assert.True(true);
            }

            [Fact]
            public void Minus_Five_Float_Is_Not_Greater_Than_Zero()
            {
                // Arrange
                float test = -5;

                // Act & Assert
                var actualException = Assert.Throws<ArgumentOutOfRangeException>(() => Guardian.ChecksThat.IsGreaterThanZero(test, "test"));
                Assert.Equal("test", actualException.ParamName);
            }

            [Fact]
            public void Zero_Float_Is_Not_Strictly_Greater_Than_Zero()
            {
                // Arrange
                float test = 0;

                // Act & Assert
                var actualException = Assert.Throws<ArgumentOutOfRangeException>(() => Guardian.ChecksThat.IsGreaterThanZero(test, "test"));
                Assert.Equal("test", actualException.ParamName);
            }

            [Fact]
            public void Five_Double_Is_Greater_Than_Zero()
            {
                // Arrange
                double test = 5;

                // Act
                Guardian.ChecksThat.IsGreaterThanZero(test, "test");

                // Assert
                Assert.True(true);
            }

            [Fact]
            public void Minus_Five_Double_Is_Not_Greater_Than_Zero()
            {
                // Arrange
                double test = -5;

                // Act & Assert
                var actualException = Assert.Throws<ArgumentOutOfRangeException>(() => Guardian.ChecksThat.IsGreaterThanZero(test, "test"));
                Assert.Equal("test", actualException.ParamName);
            }

            [Fact]
            public void Zero_Double_Is_Not_Strictly_Greater_Than_Zero()
            {
                // Arrange
                double test = 0;

                // Act & Assert
                var actualException = Assert.Throws<ArgumentOutOfRangeException>(() => Guardian.ChecksThat.IsGreaterThanZero(test, "test"));
                Assert.Equal("test", actualException.ParamName);
            }

            [Fact]
            public void Five_Long_Is_Greater_Than_Zero()
            {
                // Arrange
                long test = 5;

                // Act
                Guardian.ChecksThat.IsGreaterThanZero(test, "test");

                // Assert
                Assert.True(true);
            }

            [Fact]
            public void Minus_Five_Long_Is_Not_Greater_Than_Zero()
            {
                // Arrange
                long test = -5;

                // Act & Assert
                var actualException = Assert.Throws<ArgumentOutOfRangeException>(() => Guardian.ChecksThat.IsGreaterThanZero(test, "test"));
                Assert.Equal("test", actualException.ParamName);
            }

            [Fact]
            public void Zero_Long_Is_Not_Strictly_Greater_Than_Zero()
            {
                // Arrange
                long test = 0;

                // Act & Assert
                var actualException = Assert.Throws<ArgumentOutOfRangeException>(() => Guardian.ChecksThat.IsGreaterThanZero(test, "test"));
                Assert.Equal("test", actualException.ParamName);
            }
        }
    }
}