using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace overriding
{
    //Inherit from fish
    public class Shark : Fish
    {
        //Due to inheritance, the virtual Eat method in the Fish class is overridden to provide a Shark 
        //specific implementation of the Eat method i.e. different output message
        public override void Eat()
        {
            Console.WriteLine("I am a Shark and I eat Seals, Tuna, Boats and more!");
        }
    }
}
