using FluentAssertions;
using ObjectClassLibrary;
using Xunit.Sdk;

namespace ObjectClassLibraryTest
{
    public class BodyMassIndexTest
    {
        const string Name = "Jack Black";
        const double Weight = 180;
        const double Height = 65;
        const double BMIValue = 30.0;
        const string BMICategoryValue = "obese";

        private static BodyMassIndex GenerateBodyMassIndexInstance()
        {
            return new BodyMassIndex(Name, Weight, Height);
        }

        [Fact]
        public void BodyMassIndex_Bmi_ReturnsCorrectBMIValue()
        {
            //Arrange
            BodyMassIndex instance = GenerateBodyMassIndexInstance(); ;
            double actual;

            //Act
            actual = instance.Bmi();

            //Assert
            actual.Should().Be(BMIValue);
        }

        [Fact]
        public void BodyMassIndex_BmiCategory_ReturnsCorrectBMICategoryValue()
        {
            //Arrange
            BodyMassIndex instance = GenerateBodyMassIndexInstance();
            string actual;

            //Act
            actual = instance.BmiCategory();

            //Assert
            actual.Should().Be(BMICategoryValue);
        }

        [Theory]
        [InlineData("", Weight, Height)]
        [InlineData("  ", Weight, Height)]
        public void BodyMassIndex_BodyMassIndex_ReturnsArgumentNullExceptionForBlankName(string name, double weight, double height)
        {
            //Arrange
            BodyMassIndex instance;

            //Act
            Action act = () => instance = new BodyMassIndex(name, weight, height);

            //Assert
            act.Should().Throw<ArgumentNullException>().WithMessage("Name cannot be blank");
        }
    }
}