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
            NULL_EXCEPTION, EMPTY_EXCEPTION, CLASS_NAME_NOT_FOUND, CONSTRUCTOR_NAME_NOT_FOUND,
            METHOD_NOT_FOUND
        }
        public ExceptionType exceptionType;
        public MoodAnalyserException(ExceptionType type, string message) : base(message)
        {
            exceptionType = type;
        }

    }
}