using System;

namespace Csharp_Prog
{
   class Program
   {
      static void Main(string[] args)
      {
         int count;
         for (count = 1; count <= 10; ++count)
         {
            if (count == 5)
            {
               break;
            }

            Console.Write($"{count}  ");
         }
         Console.WriteLine($"\n Broke out of loop at count = {count}");
      }
   }
}
