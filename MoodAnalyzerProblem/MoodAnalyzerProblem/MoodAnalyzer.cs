using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyzerProblem
{
    public class MoodAnalyzer
    {
        string msg;
        public MoodAnalyzer(string msg)
        {
            this.msg = msg;
        }
        public string AnalyzeMood()
        {
            if (msg.Equals("I am in Sad Mood"))
            {
                return "Sad";
            }
            if (msg.Equals("I am in Any Mood"))
            {
                return "Happy";
            }
            return null;
        }
    }
}