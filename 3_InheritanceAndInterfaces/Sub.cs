using System;

namespace RunningIntoInheritance {
    class Super {
       public String name = "name";
      /*static void Main(string[] args) {
          Super sup = new Super();
         Console.WriteLine("Hello World");
         Console.WriteLine("Name : " + sup.name);
         Console.ReadLine();*/
      }


   class Sub:Super {
      static void Main(string[] args) {
          Super sup = new Super();
          Sub sub = new Sub();
         Console.WriteLine("Hello World");
         Console.WriteLine("Super Name :" + sup.name);
         Console.WriteLine("This name :" + sub.name);
         Console.ReadLine();
      }
   }
}