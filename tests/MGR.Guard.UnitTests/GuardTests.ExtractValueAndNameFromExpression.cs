using System;
using Xunit;

namespace MGR.Guard
{
    public partial class GuardTests
    {
        public class ExtractValueAndNameFromExpression
        {
            [Fact]
            public void Extract_From_Null_Constant_Expression()
            {
                // Arrange

                // Act
                var actual = Guard.ExtractValueAndNameFromExpression<object>(() => null);

                // Assert
                Assert.Equal("null", actual.ParameterName);
                Assert.Null(actual.Value);
            }
            [Fact]
            public void Extract_From_Constant_Expression()
            {
                // Arrange

                // Act
                var actual = Guard.ExtractValueAndNameFromExpression(() => 1);

                // Assert
                Assert.Equal("1", actual.ParameterName);
                Assert.Equal(1, actual.Value);
            }
            [Fact]
            public void Extract_From_Simple_Expression()
            {
                // Arrange
                object test = 1;

                // Act
                var actual = Guard.ExtractValueAndNameFromExpression(() => test);

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

                // Act
                var actual = Guard.ExtractValueAndNameFromExpression(() => test.Param);

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

                // Act
                var actual = Guard.ExtractValueAndNameFromExpression(() => test.SubParam.Param);

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

                // Act & Assert
                Assert.Throws<NullReferenceException>(() => Guard.ExtractValueAndNameFromExpression(() => test.SubParam.Param));
            }

            [Fact]
            public void Extract_From_Indexed_Expression()
            {
                // Arrange
                SampleClass test = new SampleClass
                {
                    Params = new[] { "Hello" }
                };

                // Act
                var actual = Guard.ExtractValueAndNameFromExpression(() => test.Params[0]);

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

                // Act
                var actual = Guard.ExtractValueAndNameFromExpression(() => test.SubParams[0].Param);

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