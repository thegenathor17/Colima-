using System.Reflection.Metadata;
using System.Collections.Generic;
using Keywords;
namespace Interpreter
{
    public class Reader
    {
        int number = 1;
        protected void Constructor()
        {
            this.number = number+1;
        }
        //CS is breaking my head D:
        public static void Spliter(string input)
        {
            string[] commands = input.Split(" ");
            for (int i = 0; i <= 9; i++)
            {
                foreach (var token in commands)
                {
                    if(Compare.keyWords[i]==token)
                    {
                            
                    }
                }
            }
            ReadLines(commands);
        }
        public static void ReadLines(string[] commands)
        {
            Dictionary<int, string> writesDictionary = new Dictionary<int, string>();
            for (int i = 0; i <= commands.Length; i++)
            {
                if (commands[i] == "Write")
                {
                    writesDictionary[i] = "Write";
                }
            }
        }
    }
}