using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EcommerceService
{
    public class ColourList
    {
        List<Colour> colours = new List<Colour>();

        public ColourList()
        {
            Colour c = new Colour();
            c.Type = "King Cole Riot";
            c.ColourName = "Ace";
            c.ColourImage = "";
            colours.Add(c);

            c.Type = "Pride";
            c.ColourName = "Rainbow";
            c.ColourImage = "";
            colours.Add(c);

            c.Type = "Mandala";
            c.ColourName = "Centaur";
            c.ColourImage = "";
            colours.Add(c);
        }
    }
}