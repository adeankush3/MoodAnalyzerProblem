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

                throw new MoodAnalyserException(MoodAnalyserException.ExceptionType.CONSTRUCTOR_NAME_NOT_FOUND, "No such a constructor");

            }
        }
        public string CreateMoodAnalyserObject(string className, string constructor, string message)
        {
            try
            {
                Type type = typeof(MoodAnalyser);
                if (type.Name.Equals(className) || type.FullName.Equals(className))
                {
                    if (type.Name.Equals(constructor))
                    {
                        ConstructorInfo constructorInfo = type.GetConstructor(new[] { typeof(string) });
                        var obj = constructorInfo.Invoke(new object[] { message });
                        return Convert.ToString(obj);
                    }
                    else
                    {
                        throw new MoodAnalyserException(MoodAnalyserException.ExceptionType.CONSTRUCTOR_NAME_NOT_FOUND, "Constructor is not found");

                    }

                }
            }
            catch (Exception)
            {
                throw new MoodAnalyserException(MoodAnalyserException.ExceptionType.CLASS_NAME_NOT_FOUND, "Class not found");

            }
            return default;
        }

        public string InvokeAnalyserMethod(string message, string methodName)
        {
            try
            {
                Type type = typeof(MoodAnalyser);

                MethodInfo methodInfo = type.GetMethod(methodName);
                MoodAnalyseFactory factory = new MoodAnalyseFactory();
                object moodAnalyserObject = factory.CreateMoodAnalyserObject("MoodAnalyzerProblem.MoodAnalyser", "MoodAnalyser", message);
                object info = methodInfo.Invoke(moodAnalyserObject, null);
                return info.ToString();
            }
            catch (NullReferenceException)
            {
                throw new MoodAnalyserException(MoodAnalyserException.ExceptionType.METHOD_NOT_FOUND, "Method not found");
            }

        }
    }
}
