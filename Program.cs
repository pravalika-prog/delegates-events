using System;

namespace Delegates_and_events
{
   // public delegate void RestaurantsperfomanceHandler(int hours, WorkTpe worktype);
    class Program 
    {
       public delegate void RestaurantsperfomanceHandler(int hours, WorkTpe worktype);
            static void Main(String[] args)
        {
            // Console.WriteLine("Hello World!");
            RestaurantsperfomanceHandler de1 = new RestaurantsperfomanceHandler(Restaurantsperformed1);
            RestaurantsperfomanceHandler de2 = new RestaurantsperfomanceHandler(Restaurantsperformed2);
            de1 +=de2;
            de1(5, WorkTpe.customerorders);
            //de2(6, WorkTpe.respondorders);
        }
        static void Restaurantsperformed1(int hoursdaily, WorkTpe worktype)
        {
            Console.WriteLine("Restaurantsperformed1 called"+hoursdaily.ToString());
        }
        static void Restaurantsperformed2(int maxhors, WorkTpe worktype)
        {
            Console.WriteLine("Restaurantsperformed2 called"+maxhors.ToString());
        }
        public enum WorkTpe
        {
            customerorders,
            respondorders,

        }

    }
}