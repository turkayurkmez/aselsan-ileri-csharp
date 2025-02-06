using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovSubstution
{

   
    public class Geometry
    {
        public IAlanHesaplanabilir AlaniHesaplanabilirGeometrikSekilGetir(int birim1, int birim2=1)
        {
            //bir biçimde .....
            if (birim2 != 1)
            {
                return new Dortgen { En = birim1, Boy = birim2 };
            }
            return new Kare() { KenarUzunluk = birim1};
        }
    }

    public interface IAlanHesaplanabilir
    {
        int AlanHesapla();
    }
    public class Dortgen : IAlanHesaplanabilir
    {
        public virtual int En { get; set; }
        public virtual int Boy { get; set; }

        public int AlanHesapla()
        {
            return En * Boy;
        }

    }


    /*
     * Liskov diyor ki:
     *   Eğer bir sınıf başkadından miras alıyorsa; bu ikisinden türeyen nesneler koşulsuz ve şartsız yer değiştirebilmelidir. 
     *   
     *   Değiştiremiyorsa Miras ilişkisi yanlış kurulmuş ya da olmamalı demektir
      */
    public class Kare :IAlanHesaplanabilir //: Dortgen
    {
        //public override int Boy
        //{
        //    get => base.Boy; set
        //    {
        //        base.Boy = value;
        //        base.En = value;
        //    }
        //}

        //public override int En
        //{
        //    get => base.En; set
        //    {
        //        base.En = value;
        //        base.Boy = value;
        //    }
        //}

        public int KenarUzunluk { get; set; }

        public int AlanHesapla()
        {
            return KenarUzunluk * KenarUzunluk;
        }
    }


}
