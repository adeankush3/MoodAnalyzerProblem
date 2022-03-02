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
        public MoodAnalyzer()
        {
        }
        public MoodAnalyzer(string msg)
        {
            this.msg = msg;
        }
        public string AnalyzeMood()
        {
            try
            {
                if (this.msg.Equals(string.Empty))
                {
                    throw new MoodException(MoodException.ExceptionType.EMPTY_MOOD, "Input should not be Empty.");
                }

                if (msg.Equals("I am in Sad Mood"))
                {
                    return "Sad";
                }
                if (msg.Equals("I am in Any Mood"))
                {
                    return "Happy";
                }
                if (msg == null)
                {
                    return "Happy";
                }
            }
            catch (NullReferenceException)
            {
                throw new MoodException(MoodException.ExceptionType.NULL_MOOD, "Input should not be Empty.");
            }
            return null;
        }
    }
}