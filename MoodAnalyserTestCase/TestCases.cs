using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoodAnalyserProblems;  

namespace MoodAnalyserTestCase
{
    [TestClass]
    public class TestCases
    {
        /// <summary>
        /// TC 1.1: Given?I am in Sad Mood? message Should Return SAD.
        /// </summary>
        [TestMethod]
        public void GivenSadMoodShouldReturnSAD()
        {
            //Arrange
            string expected = "SAD";
            string message = "I am in Sad Mood";
            MoodAnalyser moodAnalyse = new MoodAnalyser();

            //Act
            string mood = moodAnalyse.AnalyseMood(message);

            //Assert
            Assert.AreEqual(expected, mood);
        }
    }
}