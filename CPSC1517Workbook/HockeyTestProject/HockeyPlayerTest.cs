using FluentAssertions;
using Hockey.Data;

namespace Hockey.Test
{
    public class HockeyPlayerTest
    {
        public HockeyPlayer GenerateTestPlayer()
        {
            return new HockeyPlayer();

            //int[] nums = { 1, 2, 3 };

            //string x = "" + nums;

            //it's common to have a ToString method to have all these weird data types be strings.
        }

        [Fact]
        public void HockeyPlayer_FirstName_ReturnsGoodFirstName()
        {
            // Arrange
            HockeyPlayer player = GenerateTestPlayer();
            const string NAME = "test";
            player.FirstName = NAME;

            // Act
            string actual = player.FirstName;

            // Assert
            actual.Should().Be(NAME);
        }

        [Fact]
        public void HockeyPlayer_FirstName_ThrowsExceptionForEmptyArg()
        {
            HockeyPlayer player = GenerateTestPlayer();
            const string EMPTY_NAME = "";

            Action act = () => player.FirstName = EMPTY_NAME;

            act.Should().Throw<ArgumentException>().WithMessage("First name cannot be null or empty.");
        }
    }
}