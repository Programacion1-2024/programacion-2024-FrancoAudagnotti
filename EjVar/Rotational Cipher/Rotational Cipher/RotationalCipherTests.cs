namespace Rotational_Cipher
{
    public class RotationalCipherTests
    {
        [Fact]
        public void Rotate_a_by_0_same_output_as_input()
        {
            Assert.Equal("a", Ejercicio.Rotate("a", 0));
        }
        [Fact]
        public void Rotate_a_by_1()
        {
            Assert.Equal("b", Ejercicio.Rotate("a", 1));
        }
        [Fact]
        public void Rotate_a_by_26_same_output_as_input()
        {
            Assert.Equal("a", Ejercicio.Rotate("a", 26));
        }
        [Fact]
        public void Rotate_m_by_13()
        {
            Assert.Equal("z", Ejercicio.Rotate("m", 13));
        }
        [Fact]
        public void Rotate_n_by_13_with_wrap_around_alphabet()
        {
            Assert.Equal("a", Ejercicio.Rotate("n", 13));
        }
        [Fact]
        public void Rotate_capital_letters()
        {
            Assert.Equal("TRL", Ejercicio.Rotate("OMG", 5));
        }
        [Fact]
        public void Rotate_spaces()
        {
            Assert.Equal("T R L", Ejercicio.Rotate("O M G", 5));
        }
        [Fact]
        public void Rotate_numbers()
        {
            Assert.Equal("Xiwxmrk 1 2 3 xiwxmrk", Ejercicio.Rotate("Testing 1 2 3 testing", 4));
        }
        [Fact]
        public void Rotate_punctuation()
        {
            Assert.Equal("Gzo'n zvo, Bmviyhv!", Ejercicio.Rotate("Let's eat, Grandma!", 21));
        }
        [Fact]
        public void Rotate_all_letters()
        {
            Assert.Equal("Gur dhvpx oebja sbk whzcf bire gur ynml qbt.", Ejercicio.Rotate("The quick brown fox jumps over the lazy dog.", 13));
        }
    }
}