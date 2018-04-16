using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_11_OOP_
{
    class Month
    {
        public string[] month = { "January", "February", "March", "April", "May", "June", "July", "August", "September", "Oktober", "November", "December" };
        public string[] mouthSummerAndWinter = { "January", "February", "December", "June", "July", "August" };
        public static void Print(IEnumerable<string> obj)
        {
            foreach(string i in obj)
            {
                Console.WriteLine(i);
            }
        }
        public int Count(IEnumerable<string> obj)
        {
            int i = 0;
            foreach(string b in obj)
            {
                i++;
            }
            return i;
        }
    }
}
