using System;
using System.IO;

namespace ExceptionTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            //var text = File.ReadAllText("HelloWorld.txt");
            int catyGrade = -23;
            //string text;
            //string path = "HelloWorld.txt";

            //try
            //{
            //    text = File.ReadAllText(path);
            //    Console.WriteLine(text);
            //}
            //catch ( FileNotFoundException e)
            //{
            //    Console.WriteLine("Sorry I can't find: " + path);
            //    Console.WriteLine(e.Message);
            //}
            //catch(ArgumentException ae)
            //{
            //    //Console.WriteLine("Sorry you gave an empty named file");
            //    Console.WriteLine(ae.Message);
            //}
            //finally
            //{
            //    Console.WriteLine("We made it here.");
            //}

            try
            {
                Console.WriteLine(Grade(catyGrade));
            }
            catch ( ArgumentOutOfRangeException e )
            {
                //Console.WriteLine("Caty's grade " + catyGrade + " is weird!");
                Console.WriteLine(e.Message);
            }
            finally
            {
                //FINALLY IS ALWAYS READ REGARDLESS IF AN EXCEPTION IS THROWN OR NOT (if it catches or not)
                Console.WriteLine("Bananas");
            }

        }

        public static string Grade(int mark)
        {
            if(mark < 0 || mark > 100)
            {
                throw new ArgumentOutOfRangeException("Mark can't be : " + mark);
            }

            return mark >= 65 ? (mark >= 85 ? "Distinction" : "Pass") : "Fail";
        }
    }
}
