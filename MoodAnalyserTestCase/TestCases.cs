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

        ///<summary>
        ///TC 3.1: Given Null Mood Should Throw MoodAnalysisException.
        /// </summary>
        [TestMethod]
        public void Given_NULL_Mood_Should_Throw_MoodAnalysisException()
        {
            try
            {
                string message = null;
                MoodAnalyser moodAnalyse = new MoodAnalyser(message);
                string mood = moodAnalyse.AnalyseMood();
            }
            catch (MoodAnalyserCustomException e)
            {
                Assert.AreEqual("Mood should not be null", e.Message);
            }
        }

        ///<summary>
        ///TC 3.2: Given Empty Mood Should Throw MoodAnalysisException Indicating Empty Mood.
        /// </summary>
        [TestMethod]
        public void Given_EMPTY_Mood_Should_Throw_MoodAnalysisException_Indicating_EMPTY_Mood()
        {
            try
            {
                string message = "";
                MoodAnalyser moodAnalyse = new MoodAnalyser(message);
                string mood = moodAnalyse.AnalyseMood();
            }
            catch (MoodAnalyserCustomException e)
            {
                Assert.AreEqual("Mood should not be Empty", e.Message);
            }


        }
    }
}