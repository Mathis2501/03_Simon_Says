using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Simon_Says
{
    class Simon
    {
        public static string Echo(string EchoThis)
        {
            return EchoThis.ToLower();
        }

        public static string Shout(string EchoThisUpper)
        {
            return EchoThisUpper.ToUpper();
        }

        public static string Repeat(string Repeat)
        {
            return Repeat + " " + Repeat;
        }
        public static string Repeat(string RetString, int RetInt)
        {
            string OrigString = RetString;
            for (int i = 1; i < RetInt; i++)
            {
                RetString = RetString + " " + OrigString;
            }
            return RetString;
        }

        public static string StartOfWord(string OrigString, int OrigInt)
        {
            return OrigString.Substring(0, OrigInt);
        }

        public static string FirstWord(string OrigString)
        {
            return OrigString.Substring(0, OrigString.IndexOf(" "));
        }

        public static string Titleize(string OrigString)
        {
            throw new NotImplementedException();
        }
    }
}
