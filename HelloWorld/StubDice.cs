using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    public class StubDice : iDice
    {
        public int Roll()
        {
            return 3;
        }
    }
}
