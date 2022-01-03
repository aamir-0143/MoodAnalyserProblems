using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoodAnalyserProblems;  

namespace MoodAnalyserTestCase
{
    [TestClass]
    public class TestCases
    {
        /// <summary>
        /// Repeat TC 1.1: Given?I am in Sad Mood? message in Constructor Should Return SAD.
        /// </summary>
        [TestMethod]
        public void GivenSadMoodShouldReturnSAD()
        {
            //Arrange
            string expected = "SAD";
            string message = "I am in Sad Mood";
            MoodAnalyser moodAnalyse = new MoodAnalyser(message);

            //Act
            string mood = moodAnalyse.AnalyseMood();

            //Assert
            Assert.AreEqual(expected, mood);
        }

        /// <summary>
        /// TC 1.2: Given? Haapy Mood? message in Constructor Should Return HAPPY.
        /// </summary>
        [TestMethod]
        public void GivenHappyMoodShouldReturnHAPPY() 
        {
            //Arrange
            string expected = "HAPPY";
            string message = "I am in Happy Mood";
            MoodAnalyser moodAnalyse = new MoodAnalyser(message);

            //Act
            string mood = moodAnalyse.AnalyseMood();

            //Assert
            Assert.AreEqual(expected, mood);
        }

        /// <summary>
        /// TC 2.1: Given null Mood Should Return HAPPY?
        /// </summary>
        [TestMethod]
        [DataRow("I am in HAPPY Mood")]
        [DataRow(null)]
        public void GivenNullMoodShouldReturnHAPPY(string message)
        {
            //Arrange
            string expected = "HAPPY";
            MoodAnalyser moodAnalyse = new MoodAnalyser(message);

            //Act
            string mood = moodAnalyse.AnalyseMood();

            //Assert
            Assert.AreEqual(expected, mood);
        }


    }
}