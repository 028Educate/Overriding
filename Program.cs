using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace overriding
{
    class Program
    {
        static void Main(string[] args)
        {
            Fish fish = new Fish();
            Shark cShark = new Shark();

            //Base virtual Fish Eat method invoked
            fish.Eat();

            //Shark's Overridden Eat method invoked
            cShark.Eat();
        }
    }
}
