using System;
using Xunit;

namespace MGR.Guard
{
    public class GuardianTests
    {
        public class ExtractValueAndNameFromExpression
        {
            [Fact]
            public void Extract_From_Null_Constant_Expression()
            {
                // Arrange
                var guardian = Guardian.ChecksThat;

                // Act
                var actual = ((IGuardian)guardian).ExtractValueAndParameterNameFromExpression<object>(() => null);

                // Assert
                Assert.Equal("null", actual.ParameterName);
                Assert.Null(actual.Value);
            }
            [Fact]
            public void Extract_From_Constant_Expression()
            {
                // Arrange
                var guardian = Guardian.ChecksThat;

                // Act
                var actual = ((IGuardian)guardian).ExtractValueAndParameterNameFromExpression(() => 1);

                // Assert
                Assert.Equal("1", actual.ParameterName);
                Assert.Equal(1, actual.Value);
            }
            [Fact]
            public void Extract_From_Simple_Expression()
            {
                // Arrange
                object test = 1;
                var guardian = Guardian.ChecksThat;

                // Act
                var actual = ((IGuardian)guardian).ExtractValueAndParameterNameFromExpression(() => test);

                // Assert
                Assert.Equal("test", actual.ParameterName);
                Assert.Equal(1, actual.Value);
            }

            [Fact]
            public void Extract_From_Linked_Expression()
            {
                // Arrange
                SampleClass test = new SampleClass
                {
                    Param = "Hello"
                };
                var guardian = Guardian.ChecksThat;

                // Act
                var actual = ((IGuardian)guardian).ExtractValueAndParameterNameFromExpression(() => test.Param);

                // Assert
                Assert.Equal("test.Param", actual.ParameterName);
                Assert.Equal("Hello", actual.Value);
            }

            [Fact]
            public void Extract_From_Double_Linked_Expression()
            {
                // Arrange
                SampleClass test = new SampleClass
                {
                    Param = "Hello",
                    SubParam = new SampleClass
                    {
                        Param = "World"
                    }
                };
                var guardian = Guardian.ChecksThat;

                // Act
                var actual = ((IGuardian)guardian).ExtractValueAndParameterNameFromExpression(() => test.SubParam.Param);

                // Assert
                Assert.Equal("test.SubParam.Param", actual.ParameterName);
                Assert.Equal("World", actual.Value);
            }
            [Fact]
            public void Extract_From_Double_LinkedWith_Null_Part_Expression()
            {
                // Arrange
                SampleClass test = new SampleClass
                {
                    Param = "Hello"
                };
                var guardian = Guardian.ChecksThat;

                // Act & Assert
                Assert.Throws<NullReferenceException>(() => ((IGuardian)guardian).ExtractValueAndParameterNameFromExpression(() => test.SubParam.Param));
            }

            [Fact]
            public void Extract_From_Indexed_Expression()
            {
                // Arrange
                SampleClass test = new SampleClass
                {
                    Params = new[] { "Hello" }
                };
                var guardian = Guardian.ChecksThat;

                // Act
                var actual = ((IGuardian)guardian).ExtractValueAndParameterNameFromExpression(() => test.Params[0]);

                // Assert
                Assert.Equal("test.Params[0]", actual.ParameterName);
                Assert.Equal("Hello", actual.Value);
            }

            [Fact]
            public void Extract_From_Indexed_Then_Linked_Expression()
            {
                // Arrange
                SampleClass test = new SampleClass
                {
                    SubParams = new[]{
                                new SampleClass
                                        {
                                            Param = "Hello"
                                        }
                    }
                };
                var guardian = Guardian.ChecksThat;

                // Act
                var actual = ((IGuardian)guardian).ExtractValueAndParameterNameFromExpression(() => test.SubParams[0].Param);

                // Assert
                Assert.Equal("test.SubParams[0].Param", actual.ParameterName);
                Assert.Equal("Hello", actual.Value);
            }
        }

        class SampleClass
        {
            public string Param { get; set; }
            public string[] Params { get; set; }
            public SampleClass SubParam { get; set; }
            public SampleClass[] SubParams { get; set; }
        }
    }
}