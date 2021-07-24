using My_favorite_things.Favs;
using System;

namespace My_favorite_things
{
    class Program
    {
        static void Main(string[] args)
        {
            var yellowBass = new Bass
            {
                Make = "Ernie Ball",
                Model = "Musicman Stingray"
            };

            Console.WriteLine("These are a few of my favorite things.");
            yellowBass.Play();

            var blackBass = new Bass
            {
                Make = "Fender",
                Model = "Jazz"
            };

            blackBass.Sound();

            var decentBourbon = new Bourbon
            {
                Brand = "Woodford",
                Origin = "Lexington"
            };

            decentBourbon.Pair();

            var goodBourbon = new Bourbon
            {
                Brand = "Angel's Envy",
                Origin = "Louisville"
            };
            goodBourbon.Smooth();
        }
    }
}
