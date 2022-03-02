using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyzerProblem
{
    class MoodException : Exception
    {
        public enum ExceptionType
        {
            NULL_MOOD,
            EMPTY_MOOD
        }

        public ExceptionType exceptionType;

        public MoodException(ExceptionType type, string msg) : base(msg)
        {
            this.exceptionType = type;
        }
    }
}
