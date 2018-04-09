using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ServiceModel;
using System.Runtime.Serialization;

namespace EcommerceService
{
    [DataContract]
    public class Size
    {
        string _name;
        string _desc;

        [DataMember]
        public string SizeName
        {
            get { return _name; }
            set { _name = value; }
        }

        [DataMember]
        public string SizeDesc
        {
            get { return _desc; }
            set { _desc = value; }
        }
    }
}