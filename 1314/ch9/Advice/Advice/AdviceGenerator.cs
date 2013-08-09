using System;
using System.Collections.Generic;
using System.Text;

namespace Advice
{
    class AdviceGenerator
    {
        string[] answers = new string[]{
            "Dial 999 and ask for the Coastguard",
            "Learn to swim, young man",
            "Clunk-click, every trip",
            "Always remember the Green Cross Code",
            "Think once, think twice, think bike",
            "Switch off some power - now",
            "Be smart..be safe"
            };

        public string GetRandomAnswer(string question)
        {
            Random rnd = new Random();
            
            return answers[rnd.Next(0, answers.Length)];
        }
    }
}
