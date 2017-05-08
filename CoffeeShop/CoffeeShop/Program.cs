using System;

namespace CoffeeShop
{
#if WINDOWS || XBOX
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        static void Main(string[] args)
        {
            using (CoffeeShop game = new CoffeeShop())
            {
                game.Run();
            }
        }
    }
#endif
}

