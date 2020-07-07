using System;
using IronNinja.Interfaces;

namespace IronNinja.Models
{
    public class SweetTooth : Ninja
    {
        public SweetTooth(string name) : base(name){}
        public override bool IsFull
        {
            get
            {
                if(calorieIntake >= 1500)
                {
                    return true;
                }
                return false;
            }
        }
        public override void Consume(IConsumable item)
        {
            if (!IsFull)
            {
                calorieIntake += item.Calories;
                if(item.IsSweet)
                {
                    calorieIntake +=10;
                    Console.WriteLine($"{Name} says: OH that's so sweet!");
                }
                ConsumptionHistory.Add(item);
                Console.WriteLine(item.GetInfo());
            }
            else
            {
                Console.WriteLine($"{Name} says: My tum tum hurts too much");
            }
        }

    }
}