using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProject.Probelms
{
    internal class ReverseSentense
    {
        public string SentenseReverse(string sentence)
        {
            string reversedSentence = "";

            Console.WriteLine(sentence.Length);

            string[] splitSentence = sentence.Split(' ');

            for(int i = splitSentence.Length - 1; i >= 0; i--)
            {
                reversedSentence += splitSentence[i] + " ";
            }

            return reversedSentence;



        }
    }
}
