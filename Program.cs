using System;

namespace Csharp_Prog
{
   class Program
   {

      static void MyMethod()
      {
         int count = 0;
         Console.WriteLine("I just got executed!");
         Console.WriteLine("Enter a line");
         string input = Console.ReadLine();

         while (input != null)
         {
            count++;
            Console.WriteLine("Enter a word");
            input = Console.ReadLine();

         }

         Console.WriteLine(count);
      }



      static void Main(string[] args)
      {
         MyMethod();

      }
   }
}
