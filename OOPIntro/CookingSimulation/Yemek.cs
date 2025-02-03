using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CookingSimulation
{
    public class Yemek
    {
        //Her yemeğin ...................... vardır.
        public string Ad { get; set; }
        public List<string> Malzemeler { get; set; }

        public int PismeSuresi { get; set; }

        public void Pisir()
        {
            Console.WriteLine($"{Ad} isimli yemek, {PismeSuresi} dakikada pişti");
        }

        public virtual void SunumYap()
        {
            Console.WriteLine($"{Ad} isimli yemek, yanında pilav ile  hazır");
        }
    }

    public class FastFood : Yemek
    {

    }

    public class Hamburger : FastFood
    {
        public Hamburger()
        {
            Ad = "Hamburger";
            Malzemeler = new List<string> { "Ekmek", "Kıyma", "Marul", "Domates", "Turşu" };
            PismeSuresi = 10;
        }

        
    }

    public class Tatli : Yemek
    {
    }

    public class Baklava : Tatli
    {
        public Baklava()
        {
            Ad = "Baklava";
            Malzemeler = new List<string> { "Yufka", "Fıstıklı", "Şeker", "Tereyağı" };
            PismeSuresi = 60;
        }

        public override void SunumYap()
        {
            Console.WriteLine($"{Ad} isimli yemek, yanında dondurma ile  hazır");
        }
    }
}
