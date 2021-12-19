using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoodAnalyser;
using static MoodAnalyser.ConstructorMoodcs;
using static MoodAnalyser.MoodAnalyserCustomException;
using static MoodAnalyser.MoodAnalyserFactory;

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
        [TestMethod]
        public void Giving_NullMood_Expecting_CustomException_Results()
        {
            //Arrange
            ConstructorMoodcs obj = new ConstructorMoodcs(null);
            string expected = "Mood should not be NULL";

            try
            {
                //Act
                string actualMsg = obj.AnalyseMood();
            }

            catch (MoodAnalyserCustomException ex)
            {
                //Assert
                Assert.AreEqual(expected, ex.Message);
            }


        }
        [TestMethod]
        public void GivenMoodAnalyserClassName_ShouldReturnMoodAnalyseObject()
        {
            //Arrange
            string message = null;
            MoodAnalyserFactory expected = new MoodAnalyserFactory(message);

            //Act

            object obj = CreateMoodAnalyser("MoodAnalyser.ConstructorMoodcs", "ConstructorMoodcs");
            //expected.Equals(obj);

            //Assert
            Assert.AreNotEqual(expected, obj);
        }



    }
}
