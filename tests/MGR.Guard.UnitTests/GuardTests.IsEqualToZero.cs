using System;
using Xunit;

namespace MGR.Guard
{
    public partial class GuardTests
    {
        public class IsEqualToZero
        {
            [Fact]
            public void Minus_Five_Int_Is_Not_Equals_To_Zero()
            {
                // Arrange
                int test = -5;

                // Act & Assert
                var actualException = Assert.Throws<ArgumentException>(() => Guard.IsEqualToZero(test, "test"));
                Assert.Equal("test", actualException.ParamName);
            }

            [Fact]
            public void Zero_Int_Is_Equals_To_Zero()
            {
                // Arrange
                int test = 0;

                // Act
                Guard.IsEqualToZero(test, "test");

                // Assert
                Assert.True(true);
            }

            [Fact]
            public void Minus_Five_Float_Is_Not_Equals_To_Zero()
            {
                // Arrange
                float test = -5;

                // Act & Assert
                var actualException = Assert.Throws<ArgumentException>(() => Guard.IsEqualToZero(test, "test"));
                Assert.Equal("test", actualException.ParamName);
            }

            [Fact]
            public void Zero_Float_Is_Equals_To_Zero()
            {
                // Arrange
                float test = 0;

                // Act
                Guard.IsEqualToZero(test, "test");

                // Assert
                Assert.True(true);
            }

            [Fact]
            public void Minus_Five_Double_Is_Not_Equals_To_Zero()
            {
                // Arrange
                double test = -5;

                // Act & Assert
                var actualException = Assert.Throws<ArgumentException>(() => Guard.IsEqualToZero(test, "test"));
                Assert.Equal("test", actualException.ParamName);
            }

            [Fact]
            public void Zero_Double_Is_Equals_To_Zero()
            {
                // Arrange
                double test = 0;

                // Act
                Guard.IsEqualToZero(test, "test");

                // Assert
                Assert.True(true);
            }

            [Fact]
            public void Minus_Five_Long_Is_Not_Equals_To_Zero()
            {
                // Arrange
                long test = -5;

                // Act & Assert
                var actualException = Assert.Throws<ArgumentException>(() => Guard.IsEqualToZero(test, "test"));
                Assert.Equal("test", actualException.ParamName);
            }

            [Fact]
            public void Zero_Long_Is_Equals_To_Zero()
            {
                // Arrange
                long test = 0;

                // Act
                Guard.IsEqualToZero(test, "test");

                // Assert
                Assert.True(true);
            }
        }
    }
}