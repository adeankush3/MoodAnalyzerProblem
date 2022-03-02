using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace MoodAnalyzerProblem
{
    public class MoodAnalyseFactory
    {
        public object CreateMoodAnalyserObject(string className, string constructorName)
        {
            string pattern = @"." + constructorName + "$";
            Match result = Regex.Match(className, pattern);

            if (result.Success)
            {
                try
                {
                    Assembly assembly = Assembly.GetExecutingAssembly();
                    Type moodAnalyserType = assembly.GetType(className);
                    var res = Activator.CreateInstance(moodAnalyserType);
                    return res;
                }
                catch (ArgumentNullException)
                {
                    throw new MoodAnalyserException(MoodAnalyserException.ExceptionType.CLASS_NAME_NOT_FOUND, "No such a class");
                }
            }
            else
            {
                try
                {
                    throw new MoodAnalyserException(MoodAnalyserException.ExceptionType.CONSTRUCTOR_NAME_NOT_FOUND, "No such a constructor");

                }
                catch (Exception e)
                {
                    return e.Message;
                }

            }
        }
    }
}
