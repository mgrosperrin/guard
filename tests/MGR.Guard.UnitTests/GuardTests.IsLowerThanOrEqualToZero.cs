using System;
using Xunit;

namespace MGR.Guard
{
    public partial class GuardTests
    {
        public class IsLowerThanOrEqualToZero
        {
            [Fact]
            public void Minus_Five_Integer_Is_Lower_Than_Or_Equals_To_Zero()
            {
                // Arrange
                int test = -5;

                // Act
                Guard.IsLowerThanOrEqualToZero(test, "test");

                // Assert
                Assert.True(true);
            }

            [Fact]
            public void Five_Integer_Is_Not_Lower_Than_Or_Equals_To_Zero()
            {
                // Arrange
                int test = 5;

                // Act & Assert
                var actualException = Assert.Throws<ArgumentOutOfRangeException>(() => Guard.IsLowerThanOrEqualToZero(test, "test"));
                Assert.Equal("test", actualException.ParamName);
            }

            [Fact]
            public void Zero_Integer_Is_Lower_Than_Or_Equals_To_Zero()
            {
                // Arrange
                int test = 0;

                // Act
                Guard.IsLowerThanOrEqualToZero(test, "test");

                // Assert
                Assert.True(true);
            }

            [Fact]
            public void Minus_Five_Float_Is_Lower_Than_Or_Equals_To_Zero()
            {
                // Arrange
                float test = -5;

                // Act
                Guard.IsLowerThanOrEqualToZero(test, "test");

                // Assert
                Assert.True(true);
            }

            [Fact]
            public void Five_Float_Is_Not_Lower_Than_Or_Equals_To_Zero()
            {
                // Arrange
                float test = 5;

                // Act & Assert
                var actualException = Assert.Throws<ArgumentOutOfRangeException>(() => Guard.IsLowerThanOrEqualToZero(test, "test"));
                Assert.Equal("test", actualException.ParamName);
            }

            [Fact]
            public void Zero_Float_Is_Lower_Than_Or_Equals_To_Zero()
            {
                // Arrange
                float test = 0;

                // Act
                Guard.IsLowerThanOrEqualToZero(test, "test");

                // Assert
                Assert.True(true);
            }

            [Fact]
            public void Minus_Five_Double_Is_Lower_Than_Or_Equals_To_Zero()
            {
                // Arrange
                double test = -5;

                // Act
                Guard.IsLowerThanOrEqualToZero(test, "test");

                // Assert
                Assert.True(true);
            }

            [Fact]
            public void Five_Double_Is_Not_Lower_Than_Or_Equals_To_Zero()
            {
                // Arrange
                double test = 5;

                // Act & Assert
                var actualException = Assert.Throws<ArgumentOutOfRangeException>(() => Guard.IsLowerThanOrEqualToZero(test, "test"));
                Assert.Equal("test", actualException.ParamName);
            }

            [Fact]
            public void Zero_Double_Is_Lower_Than_Or_Equals_To_Zero()
            {
                // Arrange
                double test = 0;

                // Act
                Guard.IsLowerThanOrEqualToZero(test, "test");

                // Assert
                Assert.True(true);
            }
        }
    }
}
