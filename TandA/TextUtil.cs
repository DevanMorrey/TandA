using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace TandA
{
    static class TextUtil
    {

        public static string ExtractCommand(string line)
        {
            //Find command of use input
            int index = line.IndexOf(' ');

            if (index == -1)
            {
                return line;
            }
            else
            {
                return line.Substring(0, index);
            }
            
        }

        public static string ExtractArgument(string line)
        {
            // Find argument of user input
            int index = line.IndexOf(' ');

            if (index == -1)
            {
                return "";
            }
            else
            {
                return line.Substring(index + 1, line.Length - index -1);
            }
        }

        public static string WordWrap(string text, int bufferWidth)
        {
            //TODO: Word wrap
            return text;
        }

        public static string SubTitleFormat(string message)
        {
            string underline = "";
            string output = "";

            underline.PadLeft(message.Length, '-');
            output = message + ": \n" + underline + "\n";

            return output;
        }
    }
}
