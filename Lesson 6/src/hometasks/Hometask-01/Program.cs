using System;
using artem_buzinov.Hometask_01.Actors;

namespace artem_buzinov.Hometask_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer("Jack");

            customer.Status();
        }
    }
}
