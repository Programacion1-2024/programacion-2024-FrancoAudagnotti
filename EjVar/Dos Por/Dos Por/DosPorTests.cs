namespace Dos_Por
{
    public class DosPorTests
    {
        [Fact]
        public void No_name_given()
        {
            Assert.Equal("Una para vos, una para mi.", TwoFer.Speak());
        }
        [Fact]
        public void A_name_given()
        {
            Assert.Equal("Una para Alicia, una para mi.", TwoFer.Speak("Alicia"));
        }
        [Fact]
        public void Another_name_given()
        {
            Assert.Equal("Una para Roberto, una para mi.", TwoFer.Speak("Roberto"));
        }
    }
}