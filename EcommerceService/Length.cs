using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ServiceModel;
using System.Runtime.Serialization;

namespace EcommerceService
{
    [DataContract]
    public class Length
    {
        string _name;
        string _desc;

        [DataMember]
        public string LengthName
        {
            get { return _name; }
            set { _name = value; }
        }

        [DataMember]
        public string LengthDesc
        {
            get { return _desc; }
            set { _desc = value; }
        }
    }
}