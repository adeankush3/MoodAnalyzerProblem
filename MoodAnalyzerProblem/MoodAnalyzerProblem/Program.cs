using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyzerProblem
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Mood Analyzer Problem");

            string message = "I am in Sad Mood";
            MoodAnalyzer moodAnalyzer = new MoodAnalyzer(message);
            moodAnalyzer.AnalyzeMood();

            string message1 = "I am in Any Mood";
            MoodAnalyzer moodAnalyzer1 = new MoodAnalyzer(message1);
            moodAnalyzer1.AnalyzeMood();
        }
    }
}