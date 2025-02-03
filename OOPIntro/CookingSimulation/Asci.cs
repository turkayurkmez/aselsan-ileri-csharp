using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CookingSimulation
{
    public class Asci
    {
        public string Ad { get; set; }

        public void Pisir(Yemek yemek)
        {
            /*
             * Bezelye,
             * Pizza,
             * Hamburger,
             * Çorba
             * Baklava
             */

            yemek.Pisir();
            yemek.SunumYap();


        }
    }
}
