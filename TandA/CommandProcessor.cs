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
            string arguments = TextUtil.ExtractArgument(line.Trim()).Trim().ToLower();

            //process the user input
            switch (command)
            {
                case "exit":
                    Program.quite = true;
                    return;
                case "help":
                    ShowHelp();
                    break;
                case "move":
                    Player.Move(arguments);
                    break;
                case "look":
                    Player.GetCurrentRoom();
                    break;
                case "pickup":
                    Player.PickUpItem(arguments);
                    break;
                case "drop":
                    Player.DropItem(arguments);
                    break;
                case "inventory":
                    Player.DisplayInventory();
                    break;
                case "whereami":
                    Player.GetCurrentRoom();
                    break;
                default:
                    TextBuffer.Add("I dont understand.");
                    break;
                
            }

           
            GameManager.ApplyRules();
            TextBuffer.Display();

        }

        public static void ShowHelp()
        {
            TextBuffer.Add("Available Commands:");
            TextBuffer.Add("-------------------");
            TextBuffer.Add("exit");
            TextBuffer.Add("help");
            TextBuffer.Add("move");
            TextBuffer.Add("look");
            TextBuffer.Add("pickup");
            TextBuffer.Add("inventory");
            TextBuffer.Add("whereami");
            
        }
    }
}
