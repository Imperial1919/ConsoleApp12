using System;

namespace ConsoleApp12
{
    class Program
    {


        public static void JadenCase(string phrase)
        {
          
                Console.WriteLine(System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(phrase));
            
        }
        static void Main(string[] args)
        {
            JadenCase("hi there. my name is bryce.");
        }
    }
}
