using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EcommerceService
{
    public class SizeList 
    {
        List<Size> sizes = new List<Size>();

        public SizeList ()
        {
            Size s = new Size();
            s.SizeName = "S-M";
            s.SizeDesc = "Less than 7 inches";
            sizes.Add(s);

            s.SizeName = "M-L";
            s.SizeDesc = "7 inches or more";
            sizes.Add(s);
        }
    }
}