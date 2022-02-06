using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoodAnalyserExcep;
using System;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        [TestCategory("Happy Mood")]
        public void TestMethodHappy()
        {
            ///Arrange
            string message = "I am in HAPPY mood";
            string expected = "happy";
            MoodAnalyser moodanalyzer = new MoodAnalyser(message);

            ///Act
            string actual = moodanalyzer.AnalyseMood();

            ///Assert
            Assert.AreEqual(expected, actual);
        }


        [TestMethod]
        [TestCategory("Sad Mood")]
        public void GivenSadMessageReturnsSadMood()
        {
            ///Arrange
            string message = "I am in sad mood";
            string expected = "sad";
            MoodAnalyser moodanalyzer = new MoodAnalyser(message);

            ///Act
            string actual = moodanalyzer.AnalyseMood();

            ///Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        [TestCategory("Null Mood")]
        public void GivenNullMessageReturnsHappyMood()
        {
            ///Arrange
            string message = null;
            string expected = "happy";
            MoodAnalyser moodanalyzer = new MoodAnalyser(message);

            ///Act
            string actual = moodanalyzer.AnalyseMood();

            ///Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        [TestCategory("Custom Exception")]
        public void GivenNullMessageReturnsCustomException()
        {
            string message = null;
            string expected = "Message Should not be null";
            try
            {
                ///Arrange


                MoodAnalyser moodanalyzer = new MoodAnalyser(message);

                ///Act
                string actual = moodanalyzer.AnalyseMood();


            }
            catch (CustomMoodAnalyser ex)
            {
                ///Assert
                Assert.AreEqual(expected, ex.Message);
            }


        }
        [TestMethod]
        [TestCategory("Empty Exception")]
        public void GivenNullMessageReturnsEmptyException()
        {
            string message = " ";
            string expected = "Message Should not be empty";
            try
            {
                ///Arrange


                MoodAnalyser moodanalyzer = new MoodAnalyser(message);

                ///Act
                string actual = moodanalyzer.AnalyseMood();


            }
            catch (CustomMoodAnalyser ex)
            {
                ///Assert
                Console.WriteLine("Custom:" + ex);
                Assert.AreEqual(expected, ex.Message);
            }
        }
    }
}


    

