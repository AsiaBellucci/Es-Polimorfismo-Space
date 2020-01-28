using Space.Astrazioni;
using System;
using System.Collections.Generic;
using System.Text;

namespace Space.Concretizzazioni
{
    public class NavettaStealth : SpaceStation
    {
        public override void RaggioLaser()
        {
            Console.WriteLine("Pew pew");
        }
    }
}
