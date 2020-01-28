using Space.Concretizzazioni;
using System;

namespace Space
{
    class Program
    {
        static void Main(string[] args)
        {
            NavettaStealth navS = new NavettaStealth();
            EnnesimaNavetta ennNav = new EnnesimaNavetta();
            navS.RaggioLaser();
            ennNav.RaggioLaser();  


        }
    }
}
