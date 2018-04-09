using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EcommerceService
{
    public class LengthList 
    {
        List<Length> lengths = new List<Length>();

        public LengthList()
        {
            Length l = new Length();
            l.LengthName = "Short";
            l.LengthDesc = "Wrist length";
            l.Price = 10;
            lengths.Add(l);

            l.LengthName = "Medium";
            l.LengthDesc = "Forearm length";
            l.Price = 12.50;
            lengths.Add(l);

            l.LengthName = "Long";
            l.LengthDesc = "Elbow length";
            l.Price = 15;
            lengths.Add(l);
        }

    }
}