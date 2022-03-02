using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoodAnalyzerProblem;
using System;

namespace UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethodSadMood()
        {
            string message = "I Am In Sad Mood";
            string expected = "Sad";
            MoodAnalyser moodAnalyser = new MoodAnalyser(message);
            string actual = moodAnalyser.AnalyseMood();
            Assert.AreEqual(expected,actual);
        }

        [TestMethod]
        public void TestMethodAnyMood()
        {
            string message = "I Am In Any Mood";
            string expected = "Happy";
            MoodAnalyser moodAnalyser = new MoodAnalyser(message);
            string actual = moodAnalyser.AnalyseMood();
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethrNullMood()

        {
            string message = "";
            string expected = "Happy";
            MoodAnalyser moodAnalyser = new MoodAnalyser(message);
            string actual = moodAnalyser.AnalyseMood();
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethodCustomizedEmptyException()
        {
            string message = "";
            string expected = "Mood should not be empty";
            MoodAnalyser moodAnalyser = new MoodAnalyser(message);
            string actual = moodAnalyser.AnalyseMood();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMethodCustomizedNULLException()
        {
            string message = null;
            MoodAnalyser moodAnalyser = new MoodAnalyser(message);
            string actual = moodAnalyser.AnalyseMood();
            Assert.AreEqual("Mood should not be null", actual);
        }
    }
}