using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ProvisioningDiscriptionHelper.Models
{
    public class ComplexServicePartServiceInstance
    {
        [XmlAttribute("name")]
        public string name { get; set; }
        [XmlAttribute("instanceName")]
        public string instanceName { get; set; }
        [XmlAttribute("condition")]
        public string condition { get; set; }
        [XmlElement("propertyTransformation")]
        public ComplexServicePartListPropertyTransformation[] propertyTransformation { get; set; }
        [XmlElement("partList")]
        public ComplexServicePartList partList { get; set; }
    }
}
