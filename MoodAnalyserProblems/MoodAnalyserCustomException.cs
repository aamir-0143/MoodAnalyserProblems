using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyserProblems
{
    public class MoodAnalyserCustomException : Exception
    {
        ///<summary>
        ///Enum for Exception Type.
        /// </summary>
        public enum ExceptionType
        {
            NULL_MESSAGE, EMPTY_MESSAGE,
            NO_SUCH_FIELD, NO_SUCH_METHOD,
            NO_SUCH_CLASS, OBJECT_CREATION_ISSUE
        }

        ////Creating 'Type' variable of type ExceptionType
        private readonly ExceptionType type;

        ///<summary>
        ///Parameterized Constructor sets the Exception Type and message.
        /// </summary>
        /// <param name="Type"></param>
        /// <param name="message"></param>
        
        public MoodAnalyserCustomException(ExceptionType Type, string message) : base(message)
        {
            this.type = Type;
        }
    }
}
