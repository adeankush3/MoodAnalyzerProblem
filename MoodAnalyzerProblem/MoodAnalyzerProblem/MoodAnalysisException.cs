using System;
using System.Runtime.Serialization;

namespace MoodAnalyzerProblem
{
    [Serializable]
    internal class MoodAnalysisException : Exception
    {
        private object eMPTY_MOOD;
        private string v;

        public MoodAnalysisException()
        {
        }

        public MoodAnalysisException(string message) : base(message)
        {
        }

        public MoodAnalysisException(object eMPTY_MOOD, string v)
        {
            this.eMPTY_MOOD = eMPTY_MOOD;
            this.v = v;
        }

        public MoodAnalysisException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected MoodAnalysisException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }

        public static object ExceptionType { get; internal set; }
    }
}