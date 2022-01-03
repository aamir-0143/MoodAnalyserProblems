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
            if (this.message.Contains("Sad"))
            {
                return "SAD";
            }
            else
            {
                return "HAPPY";
            }
        }
    }
}
