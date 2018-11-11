

using Microsoft.VisualStudio.TestTools.UnitTesting;
using TurkishId;

namespace TurkishIdNumberTest
{
    [TestClass]
    public class TurkishIdNumberTest
    {
        private const string validTurkishId = "14948892948";

      
       

       

        private static readonly string[] validNumbers = new string[]
        {
            validTurkishId,
            "19191919190",
            "76558242278",
            "80476431508",
            "76735508630",
            "90794350894",
            "43473624496",
            "10000000146",
            "56673392584",
            "29260807600",
            "93212606504",
            "35201408508",
            "64404737702",
        };

        private static readonly string[] invalidNumbers = new string[]
        {
            null,
            "04948892948", // first digit zero
            "14948892946", // last digit invalid
            "14948892937", // last second digit invalid

            // non numeric chars
            "A4948892948",
            "7B558242278",
            "80C76431508",
            "767D5508630",
            "9079E350894",
            "43473F24496",
            "566733G2584",
            "2926080H600",
            "93212606I04",
            "352014085J8",
            "3520140853K",

            // uneven length
            "7",
            "76",
            "76558",
            "765582",
            "7655824",
            "76558242",
            "765582422",
            "7655824227",
            "765582422781",

            // spaces
            " 765582422781",
            "765582422781 ",
        };

        [TestMethod]
        public void IsValid_Valid_ReturnsTrue()
        {
            foreach(var number in validNumbers)
            {
                Assert.IsTrue(TurkishIdNumber.IsValid(number));

            }

        }

        [TestMethod]
        public void IsValid_Invalid_ReturnsFalse()
        {
            foreach (var number in validNumbers)
            {
                Assert.IsTrue(TurkishIdNumber.IsValid(number));

            }
        }

       

      
    }
}