using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoodAnalyser;

namespace MoodAnalyserTestCase
{
    [TestClass]
    public class UnitTest1
    {
        ///given Happy mood should return HAPPY
        [TestMethod]
       
        public void GivenSadMoodShouldReturnSad()
        {
            //Arrange
            string expected = "Happy";
            string message = " i m in Happy Mood";
            CheckMood moodAnlyse = new CheckMood(message);

            //Act
            string mood = moodAnlyse.AnalyseMood();

            //Assert
            Assert.AreEqual(expected, mood);
        }

    }
}
