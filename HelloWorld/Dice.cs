using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    public class Dice : iDice
    {
        private iDice dice;

        public Dice(iDice dice)
        {
            this.dice = dice;
        }

        public int Roll()
        {
            return dice.Roll();
        }
    }
}
