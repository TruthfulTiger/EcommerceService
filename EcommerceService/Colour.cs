using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ServiceModel;
using System.Runtime.Serialization;

namespace EcommerceService
{
    [DataContract]
    public class Colour
    {
        string _colour;
        string _type;
        string _image;

        [DataMember]
        public string ColourName
        {
            get { return _colour; }
            set { _colour = value; }
        }

        [DataMember]
        public string Type
        {
            get { return _type; }
            set { _type = value; }
        }

        [DataMember]
        public string ColourImage
        {
            get { return _image; }
            set { _image = value; }
        }
    }
}