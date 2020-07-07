using System;
using IronNinja.Interfaces;

namespace IronNinja.Models
{
    public class SpiceHound : Ninja
    {
        public SpiceHound(string name): base(name){}
        public override bool IsFull
        {
            get
            {
                if(calorieIntake >=1200)
                {
                    return true;
                }
                return false;
            }
        }

        public override void Consume(IConsumable item)
        {
            if(!IsFull)
            {
                calorieIntake += item.Calories;
                if(item.IsSpicy)
                {
                    calorieIntake -= 5;
                    Console.WriteLine($"{Name} says: Hot Hot Hot!!!");
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