using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkingWithStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            //string mystring = "My \"so-called\" life.";
            //string mystring = @"What if I need to\ncontrol a line";
            //string myString = string.Format("{0:C}", 123.45);
            //string myString = string.Format("{0:N}", 12354343643);
            //string myString = string.Format("Percentage: {0:P}", .125);
            //string myString = string.Format("phone Number: {0:#-(###) ###-####}", 12122037922);

            //string myString = string.Format(" That summer we took threes across the board ");

            //myString = myString.Substring(6,14);
            //myString = myString.ToUpper();
            //myString = myString.Replace(" ", "--");
            //myString = myString.Remove(6, 14);
            //string myString = string.Format("Length before: {0} -- Length after: {1}", myString.Length, myString.Trim().Length);

            StringBuilder myString = new StringBuilder();

            for (int i = 0; i < 100; i++)
            {
                myString.Append("--");
                myString.Append(i);
            }

            Console.WriteLine(myString);
            Console.ReadLine();
        }
    }
}
