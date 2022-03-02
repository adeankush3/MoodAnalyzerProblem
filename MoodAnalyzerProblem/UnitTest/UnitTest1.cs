using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoodAnalyzerProblem;
using System;

namespace UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethodForSadMood()
        {
            string message = "I am in sad Mood";
            string expected = "sad";
            MoodAnalyser moodAnalyser = new MoodAnalyser(message);
            string actual = moodAnalyser.AnalyseMood();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMethodForAnyMood()
        {
            string message = "I am in Any Mood";
            string expected = "Happy";
            MoodAnalyser moodAnalyser = new MoodAnalyser(message);
            string actual = moodAnalyser.AnalyseMood();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]

        public void TestMethodForNullMood()

        {
                string message = "";
                string expected = "Happy";
                MoodAnalyser moodAnalyser = new MoodAnalyser(message);
                string actual = moodAnalyser.AnalyseMood();
                Assert.AreEqual(expected, actual);
            
        }

        [TestMethod]
        public void TestMethodForCustomizedEmptyException()
        {
            string message = "";
            string expected = "Mood should not be empty";
            MoodAnalyser moodAnalyser = new MoodAnalyser(message);
            string actual = moodAnalyser.AnalyseMood();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMethodForCustomizedNULLException()
        {
            string message = null;
            MoodAnalyser moodAnalyser = new MoodAnalyser(message);
            string actual = moodAnalyser.AnalyseMood();
            Assert.AreEqual("Mood should not be null", actual);
        }

        [TestMethod]
        public void ReflectionReturnMoodAnalyseObject()
        {

            object expected = new MoodAnalyser();
            object obj = new MoodAnalyseFactory().CreateMoodAnalyserObject("MoodAnalyzerProblem.MoodAnalyser", "MoodAnalyser");
            var objtype = obj.GetType();
            var expectedType = expected.GetType();
            Assert.AreEqual(expectedType, objtype);
        }

        [TestMethod]
        public void ImproperClassShouldThrowException()
        {
            object expected = new MoodAnalyser();
            try
            {
                var obj = new MoodAnalyseFactory().CreateMoodAnalyserObject("MoodAnalyzerProblem.Mood", "Mood");

            }
            catch (Exception e)
            {
                Assert.AreEqual("No such a class", e.Message);
            }
        }

        [TestMethod]
        public void ConstructorNotProperClassShouldThrowException()
        {
            object expected = new MoodAnalyser();
            try
            {
                var obj = new MoodAnalyseFactory().CreateMoodAnalyserObject("MoodAnalyzerProblem.MoodAnalyser", "MoodAnalyser");

            }
            catch (Exception e)
            {
                Assert.AreEqual("No such a Constructor", e.Message);
            }
        }

        [TestMethod]
        public void ReflectionReturnParameterizedConstructor()
        {
            string message = "I am in happy mood";
            MoodAnalyser expected = new MoodAnalyser(message);
            object actual = null;
            try
            {
                MoodAnalyseFactory factory = new MoodAnalyseFactory();
                actual = factory.CreateMoodAnalyserObject("MoodAnalyzerProblem.MoodAnalyser", "MoodAnalyser", message);

            }
            catch (MoodAnalyserException ex)
            {
                throw new System.Exception(ex.Message);
            }
            actual.Equals(expected);
        }

        [TestMethod]
        public void ReflectionReturnParameterizedClassInvalid()
        {
            string message = "I am in happy mood";
            MoodAnalyser expected = new MoodAnalyser(message);
            object actual = null;
            try
            {
                MoodAnalyseFactory factory = new MoodAnalyseFactory();
                actual = factory.CreateMoodAnalyserObject("MoodAnalyzerProblem.MoodAnaly", "MoodAnalyser", message);

            }
            catch (MoodAnalyserException actual1)
            {
                Assert.AreEqual(expected, actual1.Message);
            }
        }

    }
}