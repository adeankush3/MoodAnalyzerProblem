using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyzerProblem
{
    public class MoodAnalyserException : Exception
    {
        public enum ExceptionType
        {
            NULL_EXCEPTION, EMPTY_EXCEPTION
        }
        public ExceptionType exceptionType;
        public MoodAnalyserException(ExceptionType type, string message) : base(message)
        {
            exceptionType = type;
        }

    }
}
