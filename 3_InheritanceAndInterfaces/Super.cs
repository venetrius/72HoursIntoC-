using System;

namespace RunningIntoInheritance {
    

   class Super {
       String name = "name";
      static void Main(string[] args) {
          Super sup = new Super();
         Console.WriteLine("Hello World");
         Console.WriteLine("Name : " + sup.name);
         Console.ReadLine();
      }
   }
}