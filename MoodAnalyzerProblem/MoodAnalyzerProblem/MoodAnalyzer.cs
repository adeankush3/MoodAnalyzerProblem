using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyzerProblem
{
    public class MoodAnalyser
    {
        string Message;

        public MoodAnalyser(string Message)
        {
            this.Message = Message;
        }
        public string AnalyseMood()
        {
            try
            {
                if (this.Message == null)
                {
                    throw new MoodAnalyserException(MoodAnalyserException.ExceptionType.NULL_EXCEPTION, "Mood should not be null");

                }
                if (this.Message.Equals(string.Empty))
                {
                    throw new MoodAnalyserException(MoodAnalyserException.ExceptionType.EMPTY_EXCEPTION, "Mood should not be empty");
                }


                if (Message.ToLower().Contains("sad"))
                {
                    return "sad";
                }
                else
                {
                    return "Happy";

                }
            }
            catch (MoodAnalyserException e)
            {
                return e.Message;
            }
            catch (NullReferenceException e)
            {
                return e.Message;
            }

        }
    }
}