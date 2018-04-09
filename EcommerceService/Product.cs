using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ServiceModel;
using System.Runtime.Serialization;

namespace EcommerceService
{
    [DataContract]
    public class Product
    {
        private string _name;
        private string _image;
        private string _desc;
        private double _price;
        private string _length;
        private string _size;
        private string _colour;

        [DataMember]
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        [DataMember]
        public string Image
        {
            get { return _image; }
            set { _image = value; }
        }

        [DataMember]
        public string Desc
        {
            get { return _desc; }
            set { _desc = value; }
        }

        [DataMember]
        public double Price
        {
            get { return _price; }
            set { _price = value; }
        }

        [DataMember]
        public string Length
        {
            get { return _length; }
            set { _length = value; }
        }

        [DataMember]
        public string Size
        {
            get { return _size; }
            set { _size = value; }
        }
        [DataMember]
        public string Colour
        {
            get { return _colour; }
            set { _colour = value; }
        }
    }
}