using System;

namespace HowAreYouTodayApplication {
   class HowAreYouToday {
      static void Main(string[] args) {
         Console.WriteLine("Hello World");
         Console.WriteLine("How are you today?");
         String val = Console.ReadLine();
         Console.WriteLine(val);
         Console.WriteLine("Can you give me an integer?");
         String toInt = Console.ReadLine();
         try{
            int a = Convert.ToInt32(toInt);
            Console.WriteLine("Your input: {0}",a);
         }catch(Exception){
             Console.WriteLine("Ahhh. I said a integer");
         }
         Console.WriteLine("Do you want to leave?");
         Console.ReadLine();
      }
   }
}