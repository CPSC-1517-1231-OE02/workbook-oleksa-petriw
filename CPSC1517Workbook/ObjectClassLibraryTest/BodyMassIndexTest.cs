using FluentAssertions;
using ObjectClassLibrary;

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
            BodyMassIndex instance = GenerateBodyMassIndexInstance();
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
        public void BodyMassIndex_Constructor_ThrowsForBlankName(string name, double weight, double height)
        {
            //Arrange
            BodyMassIndex instance;

            //Act
            Action act = () => instance = new BodyMassIndex(name, weight, height);

            //Assert
            act.Should().Throw<ArgumentNullException>().WithMessage("Name cannot be blank");
        }

        [Theory]
        [InlineData(Name, 0, Height)]
        [InlineData(Name, -100, Height)]
        public void BodyMassIndex_Constructor_ThrowsForNonPositiveWeight(string name, double weight, double height)
        {
            //Arrange
            BodyMassIndex instance;

            //Act
            Action act = () => instance = new BodyMassIndex(name, weight, height);

            //Assert
            act.Should().Throw<ArgumentOutOfRangeException>().WithMessage("Weight must be a positive non-zero number");
        }

        [Theory]
        [InlineData(Name, Weight, 0)]
        [InlineData(Name, Weight, -100)]
        public void BodyMassIndex_Constructor_ThrowsForNonPositiveHeight(string name, double weight, double height)
        {
            //Arrange
            BodyMassIndex instance;

            //Act
            Action act = () => instance = new BodyMassIndex(name, weight, height);

            //Assert
            act.Should().Throw<ArgumentOutOfRangeException>().WithMessage("Height must be a positive non-zero number");
        }

        [Theory]
        [InlineData("Underweight Person1", 90, 60, 17.6, "underweight")]
        [InlineData("Underweight Person2", 120, 75, 15.0, "underweight")]
        public void BodyMassIndex_BmiCategory_ReturnsUnderweightCategory(string name, double weight, double height, double expectedBMI, string expectedCategory)
        {
            //Arrange
            BodyMassIndex instance;
            string actualCategory;
            double actualBmi;

            //Act
            instance = new BodyMassIndex(name, weight, height);
            actualCategory = instance.BmiCategory();
            actualBmi = instance.Bmi();

            //Assert
            actualCategory.Should().Be(expectedCategory);
            actualBmi.Should().Be(expectedBMI);
        }

        [Theory]
        [InlineData("Normal weight Person1", 111, 65, 18.5, "normal")]
        [InlineData("Normal weight Person2", 149, 65, 24.8, "normal")]
        public void BodyMassIndex_BmiCategory_ReturnsNormalCategory(string name, double weight, double height, double expectedBMI, string expectedCategory)
        {
            //Arrange
            BodyMassIndex instance;
            string actualCategory;
            double actualBmi;

            //Act
            instance = new BodyMassIndex(name, weight, height);
            actualCategory = instance.BmiCategory();
            actualBmi = instance.Bmi();

            //Assert
            actualCategory.Should().Be(expectedCategory);
            actualBmi.Should().Be(expectedBMI);
        }

        [Theory]
        [InlineData("Overweight Person1", 150, 65, 25.0, "overweight")]
        [InlineData("Overweight Person2", 179, 65, 29.8, "overweight")]
        public void BodyMassIndex_BmiCategory_ReturnsOverweightCategory(string name, double weight, double height, double expectedBMI, string expectedCategory)
        {
            //Arrange
            BodyMassIndex instance;
            string actualCategory;
            double actualBmi;

            //Act
            instance = new BodyMassIndex(name, weight, height);
            actualCategory = instance.BmiCategory();
            actualBmi = instance.Bmi();

            //Assert
            actualCategory.Should().Be(expectedCategory);
            actualBmi.Should().Be(expectedBMI);
        }

        [Theory]
        [InlineData("Obese Person1", 180, 65, 30.0, "obese")]
        [InlineData("Obese Person2", 210, 65, 34.9, "obese")]
        public void BodyMassIndex_BmiCategory_ReturnsObeseCategory(string name, double weight, double height, double expectedBMI, string expectedCategory)
        {
            //Arrange
            BodyMassIndex instance;
            string actualCategory;
            double actualBmi;

            //Act
            instance = new BodyMassIndex(name, weight, height);
            actualCategory = instance.BmiCategory();
            actualBmi = instance.Bmi();

            //Assert
            actualCategory.Should().Be(expectedCategory);
            actualBmi.Should().Be(expectedBMI);
        }
    }
}