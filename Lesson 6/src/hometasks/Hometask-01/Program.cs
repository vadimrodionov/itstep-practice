using System;
using artem_buzinov.Hometask_01.Actors;

namespace artem_buzinov.Hometask_01
{
    class Program
    {
        public void ComeMessage()
        {
            Console.WriteLine("Клиент прибыл");
        }
        static void Main(string[] args)
        {
            Customer customer = new Customer("Jack");
            
        }
    }
}
