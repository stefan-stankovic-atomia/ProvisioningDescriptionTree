using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ProvisioningDiscriptionHelper.Models
{
    public class ComplexServiceInitPropertyList
    {
        [XmlElement("initProperty")]
        public ComplexServiceInitProperty[] initProperty { get; set; }
        [XmlElement("propertyTransformation")]
        public ComplexServicePartListPropertyTransformation[] propertyTransformation { get; set; }
    }

    public class ComplexServiceInitProperty
    {
        [XmlAttribute("name")]
        public string name { get; set; }
        [XmlAttribute("value")]
        public string value { get; set; }
    }
}
