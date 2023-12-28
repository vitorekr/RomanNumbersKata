namespace RomanNumbers
{
    public class RomanNumeralTests
    {
        [Fact]
        public void Convert_Arabic_to_Roman()
        {
            var roman = new RomanNumeralGenerator();
            Assert.Equal("I", roman.Convert(1));
            Assert.Equal("II", roman.Convert(2));
            Assert.Equal("III", roman.Convert(3));
            Assert.Equal("V", roman.Convert(5));
            Assert.Equal("VI", roman.Convert(6));
            Assert.Equal("VII", roman.Convert(7));
            Assert.Equal("VIII", roman.Convert(8));
            Assert.Equal("X", roman.Convert(10));
            Assert.Equal("XI", roman.Convert(11));
            Assert.Equal("XIII", roman.Convert(13));
            Assert.Equal("XV", roman.Convert(15));
            Assert.Equal("XVII", roman.Convert(17));
            Assert.Equal("XX", roman.Convert(20));
            Assert.Equal("LXXX", roman.Convert(80));
            Assert.Equal("MMXIX", roman.Convert(2019));
            Assert.Equal("XXIX", roman.Convert(29));
            Assert.Equal("CCXCIV", roman.Convert(294));

            Assert.Equal("IV", roman.Convert(4));
            Assert.Equal("IX", roman.Convert(9));
        }
    }
}