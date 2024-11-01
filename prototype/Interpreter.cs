using System.Reflection.Metadata;
using System.Collections.Generic;
using Console;
namespace Interpreter
{
    public class Reader
    {
        public List<string> keyWords = new List<string>{"Write", "+", "-", "/", "*", "Add", "Sub", "Mul", "Div"};
        int number = 1;
        protected void Constructor()
        {
            this.number = number+1;
        }
        //CS is breaking my head D:
        public void Spliter(string input)
        {
            string[] commands = input.Split(" ");
            Dictionary<int, string> detectedKeywords = new Dictionary<int, string>();
            for (int i = 0; i <= commands.Length; i++)
            {
                for (int j = 0; j<= commands.Length; j++)
                {
                    if(keyWords[i]==commands[j])
                    {
                        detectedKeywords[i] = commands[j];
                    }
                }
            }
            ReadLines(detectedKeywords, commands);
        }
        public static void ReadLines(Dictionary<int, string> detectedKeywords, string[] commands)
        {
            for (int i = 0; i <= commands.Length; i++)
            {
                for (int j = 0; j<= commands.Length; j++)
                {
                    if(detectedKeywords[i]=="Write")
                    {
                        string newLine = "/nl";
                        string[] writeString = new string[]{};
                        foreach (string word in writeString)
                        {
                            if (word != newLine)
                            {
                                Console.Write(word + " ");
                            }
                            else if (word == newLine)
                            {
                                Console.WriteLine(".");
                            }
                        }
                    }
                }
            }
        }
    }
}