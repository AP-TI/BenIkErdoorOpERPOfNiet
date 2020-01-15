using System;
using System.Collections.Generic;
using System.Text;

namespace BenIkErdoorOpERPOfNiet
{
    class DobbelSteenMetVierKanten
    {
        Random random;
        public DobbelSteenMetVierKanten()
        {
            random = new Random();
        }

        public int Gooi()
        {
            return random.Next(1, 5);
        }
    }
}
