using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosed
{
    //public enum CardType
    //{
    //    Standard,
    //    Silver,
    //    Gold        
    //}

    public abstract class CardType
    {
        public abstract decimal GetDiscountedPrice(decimal price);
      
    }

    public class StandardCard : CardType
    {
        public override decimal GetDiscountedPrice(decimal price)
        {
            return price * .95m;
        }
    }

    public class SilverCard : CardType
    {
        public override decimal GetDiscountedPrice(decimal price)
        {
            return price * .9m;
        }
    }

    public class GoldCard : CardType
    {
        public override decimal GetDiscountedPrice(decimal price)
        {
            return price * .85m;
        }
    }

    public class PremiumCard : CardType
    {
        public override decimal GetDiscountedPrice(decimal price)
        {
            throw new ArgumentException();
        }
    }

    public class Customer
    {
        public string Name { get; set; }
        public CardType CardType { get; set; }

    }
    internal class OrderManager
    {
        public Customer Customer { get; set; }
        public decimal GetTotalPrice(decimal price)
        {

           return Customer.CardType.GetDiscountedPrice(price);
            //switch (Customer.CardType)
            //{
            //    case CardType.Standard:
            //        return price * .95m;
            //    case CardType.Silver:
            //        return price * 9m;
            //    case CardType.Gold:
            //        return price * .85m;
                    
            //    default:
            //        return price;
                    
            //}
        }
    }
}
