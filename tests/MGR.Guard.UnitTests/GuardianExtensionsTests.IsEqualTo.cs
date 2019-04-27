using System;
using Xunit;

namespace MGR.Guard
{
    public partial class GuardianExtensionsTests
    {
        public class IsEqualTo
        {
            [Fact]
            public void Same_String_Values_Are_Equals()
            {
                // Arrange
                string test = "Value";
                string referenceValue = "Value";

                // Act
                Guardian.ChecksThat.IsEqualTo(test, "test", referenceValue);

                // Assert
                Assert.True(true);
            }

            [Fact]
            public void Different_String_Values_Are_Not_Equals()
            {
                // Arrange
                string test = "Value";
                string referenceValue = "NotValue";

                // Act & Assert
                var actualException = Assert.Throws<ArgumentException>(() => Guardian.ChecksThat.IsEqualTo(test, "test", referenceValue));
                Assert.Equal("test", actualException.ParamName);
            }

            [Fact]
            public void Different_Strings_Are_Not_Equals_With_Comparer()
            {
                // Arrange
                string test = "Value";
                string referenceValue = "NotValue";

                // Act & Assert
                var actualException = Assert.Throws<ArgumentException>(() => Guardian.ChecksThat.IsEqualTo(test, "test", referenceValue, StringComparer.Ordinal));
                Assert.Equal("test", actualException.ParamName);
            }

            [Fact]
            public void Same_Integer_Are_Equals()
            {
                // Arrange
                int test = 5;
                int referenceValue = 5;

                // Act
                Guardian.ChecksThat.IsEqualTo(test, "test", referenceValue);

                // Assert
                Assert.True(true);
            }

            [Fact]
            public void Different_Integer_Are_Not_Equals()
            {
                // Arrange
                int test = 5;
                int referenceValue = 0;

                // Act & Assert
                var actualException = Assert.Throws<ArgumentException>(() => Guardian.ChecksThat.IsEqualTo(test, "test", referenceValue));
                Assert.Equal("test", actualException.ParamName);
            }
        }
    }
}