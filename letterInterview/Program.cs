using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace letterInterview
{
    class Program
    {
        static void Main()
        {
            string lines;
            using (System.IO.StreamReader reader = new System.IO.StreamReader(@"C:\Users\owner\Documents\Visual Studio 2013\Projects\letterInterview\letterInterview\InterviewFile.csv"))
            {
                lines = reader.ReadToEnd();
            }
            char[] delimiterChar = { ',' };
            String[] words = lines.Split(delimiterChar);
            foreach (string s in words)
            {
                System.Console.WriteLine(s);
            }
            System.Console.WriteLine("Press any key to exit.");
            System.Console.ReadKey();
        }
    }
}
