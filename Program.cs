using System;
using IronNinja.Interfaces;
using IronNinja.Models;


namespace IronNinja
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("!!!IRON NINJA!!!");

            Buffet word = new Buffet();
            SweetTooth drew = new SweetTooth("Drew");
            SpiceHound david = new SpiceHound("David");

            while(!drew.IsFull  || !david.IsFull)
            {
                drew.Consume(word.Serve());
                david.Consume(word.Serve());
            }
            Console.WriteLine($"Drew scarffed down {drew.ConsumptionHistory.Count} items.\nDavid scarffed down {david.ConsumptionHistory.Count} items");

            if (drew.ConsumptionHistory.Count > david.ConsumptionHistory.Count)
            {
                Console.WriteLine("DREW WINS");
            }
            else if (david.ConsumptionHistory.Count > drew.ConsumptionHistory.Count)
            {
                Console.WriteLine("DAVID WINS");
            }
            else
            {
                Console.WriteLine("Andrew WINS");
            }
        }
    }
}
