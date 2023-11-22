using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Save_kyran_pt1_professional_edition
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StreamReader saveKyranFile = new StreamReader("U:/SaveKyran2.txt");
            string saveKyranFullSentence = saveKyranFile.ReadToEnd();
            saveKyranFile.Close();

            //Console.WriteLine(saveKyranFullSentence);
           

            char[] separators = new char[] { ' ', '.', ',', '!', '(', ')', '"'};
            //string[] separatingStrings = { ""};

            string[] saveKyranSentenceWords = saveKyranFullSentence.Split(separators, StringSplitOptions.RemoveEmptyEntries);
            //saveKyranSentenceWords = saveKyranFullSentence.Split(separators, StringSplitOptions.RemoveEmptyEntries);

            Dictionary<string, int> wordsDictionary = new Dictionary<string, int>();

            for (int i = 0; i < saveKyranSentenceWords.Length; i++)
            {
                Console.WriteLine(saveKyranSentenceWords[i]);
                if (wordsDictionary.ContainsKey(saveKyranSentenceWords[i]))
                    wordsDictionary[saveKyranSentenceWords[i]] += 1;
                else
                    wordsDictionary.Add(saveKyranSentenceWords[i], 1);
            }

            //for (int i = 0; i < wordsDictionary.Count - 1; i++)
            //{
            //    Console.WriteLine();
            //}

            //foreach (int word in wordsDictionary)
            //{

            //}

            List<int> values = new List<int>();

            foreach (KeyValuePair<string, int> word in wordsDictionary)
            {
                //Console.WriteLine(word.Key + " " + word.Value);
                values.Add(word.Value);
            }

            values.Sort();
            values.Reverse();
            Console.WriteLine("");
            foreach (int number in values)
            {
                Console.Write(number);
            }

            Console.ReadLine();

        }
    }
}
