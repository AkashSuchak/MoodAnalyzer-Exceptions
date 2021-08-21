using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MoodAnalyzerMSTestWithCore
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void GivenSadMoodShouldReturnSad()
        {
            //Arrange
            string expected = "HAPPY";
            string message = "I am in Happy Mood";
            MoodAnalyzer moodAnalyzer = new MoodAnalyzer(message);

            //Act
            string mood = moodAnalyzer.AnalyzeMood();

            //Assert
            Assert.AreEqual(expected, mood);
        }
        /// <summary>
        /// TC 1.2 & 2.1 
        /// </summary>
        /// <param name="message"></param>
        [TestMethod]
        [DataRow(null)]
        public void GivenHAPPYMoodShouldReturnHappy(string message)
        {
            //Arrange
            string expected = "HAPPY";            
            MoodAnalyzer moodAnalyzer = new MoodAnalyzer(message);

            //Act
            string mood = moodAnalyzer.AnalyzeMood();

            //Assert
            Assert.AreEqual(expected, mood);
        }
    }
}
