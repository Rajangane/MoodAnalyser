using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyser
{
    public class CheckMood
    {
        private string message;
        public CheckMood(string message)
        {
            this.message = message;
        }
        /// <summary>
        /// Parameterized Constructor
        /// </summary>
        /// <returns></returns>
        public string AnalyseMood()
        {
            if (this.message.Contains("Happy"))
            {
                return "Happy";

            }
            else
            {
                return "Sad";
            }
        }
    }
}
