using System;
using System.Collections.Generic;
using System.Text;

namespace Space.Astrazioni
{
    public abstract class SpaceStation
    {
        public virtual void RaggioLaser()
        {
            Console.WriteLine("Bang bang");
        }
    }
}
