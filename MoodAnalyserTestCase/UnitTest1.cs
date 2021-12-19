using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoodAnalyser;

namespace MoodAnalyserTestCase
{
    [TestClass]
    public class UnitTest1
    {
        ///given sad mood should return SAD
        [TestMethod]
       
        public void GivenSadMoodShouldReturnSad()
        {
            //Arrange
            string expected = "Sad";
            string message = " i m in Sad Mood";
            CheckMood moodAnlyse = new CheckMood(message);

            //Act
            string mood = moodAnlyse.AnalyseMood();

            //Assert
            Assert.AreEqual(expected, mood);
        }

    }
}
