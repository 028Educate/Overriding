using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace overriding
{
    public class Fish
    {
        //Method marked as virtual so sub classes can override i.e. provide its own implementation of the Eat method if they inherit from Fish
        public virtual void Eat()
        {
            Console.WriteLine("I am a Fish and I eat a variety of things depending on my species");
        }
    }
}
