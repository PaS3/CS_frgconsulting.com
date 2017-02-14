using System;
using System.Text;

namespace hello
{
  abstract class world
   {
      public abstract string word();
   }
   class hello:  world
   {
      private string first;
      public hello(string a="hello world of Dynamic Polymorphism and Inheritance")
      {
         first = a;
      }
      public override string word ()
      {
         Console.WriteLine("The word is :");
         return (first);
      }
   }

   class outputworld
   {
      static void Main(string[] args)
      {
         hello h = new hello();
         string nh = h.word();
         byte[] hexy = Encoding.Default.GetBytes(nh);
         var hexyinStrings = BitConverter.ToString(hexy);
         hexyinStrings = hexyinStrings.Replace("-", "");

         Console.WriteLine(nh);
         Console.WriteLine("Hex of string: \n" + hexyinStrings);
         Console.ReadKey();
      }
    }
  }
