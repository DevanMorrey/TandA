using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace TandA
{
    static class CommandProcessor
    {

        public static void ProcessCommand(string line)
        {
            string command = TextUtil.ExtractCommand(line.Trim()).Trim().ToLower();
            string argument = TextUtil.ExtractArgument(line.Trim()).Trim().ToLower();

            switch (command)
            {
                case "exit":
                    Program.quite = true;
                    return;
                case "help":
                    ShowHelp();
                    break;
                
            }

        }

        public static void ShowHelp()
        {

        }
    }
}
