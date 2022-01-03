using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyserProblems
{
    public class MoodAnalyser
    {
        private string message;
        public MoodAnalyser(string message)
        {
            this.message = message;
        }
        /// <summary>
        /// Parameterised Constructor.
        /// </summary>
        /// <param name="message"></param>
        public string AnalyseMood()
        {
            //try
            //{
            //    if (this.message.Contains("Sad"))
            //    {
            //        return "SAD";
            //    }
            //    else
            //    {
            //        return "HAPPY";
            //    }
            //}
            //catch
            //{
            //    return "HAPPY";
            //}

            try
            {
                if (this.message.Equals(string.Empty))
                {
                    throw new MoodAnalyserCustomException(MoodAnalyserCustomException.ExceptionType.EMPTY_MESSAGE, "Mood should not be Empty");
                }

                if (this.message.Contains("Sad"))
                {
                    return "SAD";
                }
                else
                {
                    return "HAPPY";
                }
            }
            catch (NullReferenceException)
            {
                throw new MoodAnalyserCustomException(MoodAnalyserCustomException.ExceptionType.NULL_MESSAGE, "Mood should not be null");
            }
            
        }
    }
}
