﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace EcommerceService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IECommerceService
    {
        [OperationContract]
        SizeList GetSizeDetails(int sizeID);

        [OperationContract]
        LengthList GetLengthDetails(int lengthID);

        [OperationContract]
        ColourList GetColourDetails(int colourID);

        [OperationContract]
        ProductList GetProductDetails(int productID);
    }
}
