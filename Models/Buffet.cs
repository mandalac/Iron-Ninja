using System;
using System.Collections.Generic;
using IronNinja.Interfaces;

namespace IronNinja.Models
{
    public class Buffet
    {
        public List<IConsumable> Menu;
        public Buffet()
        {
            Menu = new List<IConsumable>()
            {
                new Food("Cheese", 400, true, false),
                new Food("Crab", 200, true, false),
                new Food("Steak", 500, false, false),
                new Food("Octopus", 300, true, false),
                new Food("Senzu Beans", 2000, false, true),
                new Food("Gumbo", 700, true, false),
                new Food("Cheese Fountain", 1000, false, false),
                new Drink("Cake Shake", 1100, false),
                new Drink("Cranberry Juice", 300, false),
                new Drink("Bloody Mary", 300, true),
                new Drink("Water", 0, false),
                new Drink("Matcha", 360,false)
            };
        }

        public IConsumable Serve()
        {
            Random rand = new Random();
            IConsumable item = Menu[rand.Next(Menu.Count)];
            return item;
        }
    }
}