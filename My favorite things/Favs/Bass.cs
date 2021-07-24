using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_favorite_things.Favs
{
    class Bass
    {
        public string Make { get; set; }
        public string Model { get; set; }

        public void Play()
        {
            Console.WriteLine($"My {Make} {Model} plays smoothly.");
        }

        public void Sound()
        {
            Console.WriteLine($"I like the sound of my {Make} {Model}.");
        }

    }
}
