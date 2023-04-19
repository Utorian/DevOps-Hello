using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    public class RandomDice : iDice
    {
        private readonly Random random;

        public RandomDice()
        {
            random = new Random();
        }

        public int Roll()
        {
            return random.Next(1, 7);
        }
    }
}
