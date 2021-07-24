using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_favorite_things.Favs
{
    class Bourbon
    {
        public string Brand { get; set; }
        public string Origin { get; set; }


        public void Pair()
        {
            Console.WriteLine($"{Brand} out of {Origin} pairs well with dark chocolate.");
        }

        public void Smooth()
        {
            Console.WriteLine($"I like how smooth {Brand} is. The distillery tour in {Origin} is worth the trip.");
        }
    }
}
