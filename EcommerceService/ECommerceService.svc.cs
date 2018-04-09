using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace EcommerceService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IECommerceService
    {
        public ColourList GetColourDetails(int colourID)
        {
            List<ColourList> colours = new List<ColourList>();
            if (colours.Count <= colourID)
                return null;
            return colours[colourID];
        }

        public LengthList GetLengthDetails(int lengthID)
        {
            List<LengthList> lengths = new List<LengthList>();
            if (lengths.Count <= lengthID)
                return null;
            return lengths[lengthID];
        }

        public ProductList GetProductDetails(int productID)
        {
            List<ProductList> products = new List<ProductList>();
            if (products.Count <= productID)
                return null;
            return products[productID];
        }

        public SizeList GetSizeDetails(int sizeID)
        {
            List<SizeList> sizes = new List<SizeList>();
            if (sizes.Count <= sizeID)
                return null;
            return sizes[sizeID];
        }
    }
}
