using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoodAnalyzerProblem;
using System;

namespace UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        

        [TestMethod]
        public void TestMethod1()
        {
            string message = "I am in Sad Mood";
            MoodAnalyzer moodAnalyzer = new MoodAnalyzer(message);
            Assert.AreEqual("Sad", moodAnalyzer.AnalyzeMood());
        }
        
        [TestMethod]
        public void TestMethod2()
        {
            string message1 = "I am in Any Mood";
            MoodAnalyzer moodAnalyzer1 = new MoodAnalyzer(message1);
            Assert.AreEqual("Happy", moodAnalyzer1.AnalyzeMood());
        }
        
        [TestMethod]
        public void TestMethod3()
        {
            try
            {
                string message = null;
                MoodAnalyzer mood = new MoodAnalyzer(message);
                Assert.AreEqual("Happy", mood.AnalyzeMood());
            }
            catch(Exception ex)
            {
                //Console.WriteLine(ex);
                Assert.AreEqual("Input should not be Empty.",ex.Message);
            }
        }
    }
}