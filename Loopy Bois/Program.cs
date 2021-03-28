using System;

namespace Loopy_Bois
{
    class Program
    {
        static void Main(string[] args)
        {
            string myString = "ooooooo";
            int count = 0;
            
            foreach(char myChar in myString)
            {
                if (myChar == 'o')
                {
                    count++;
                }
            }

            Console.WriteLine("There were " + count + " o characters in the string");
           
        }
    }
}
