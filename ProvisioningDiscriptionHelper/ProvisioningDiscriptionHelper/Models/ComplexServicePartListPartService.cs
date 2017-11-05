using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ProvisioningDiscriptionHelper.Models
{
    public class ComplexServicePartListPartService
    {
        [XmlAttribute("name")]
        public string name { get; set; }
        [XmlAttribute("max")]
        public string max { get; set; }
        [XmlAttribute("min")]
        public string min { get; set; }
        [XmlAttribute("forcePropertiesUpdate")]
        public string forcePropertiesUpdate { get; set; }     
        [XmlElement("propertyTransformation")]
        public ComplexServicePartListPropertyTransformation[] propertyTransformation { get; set; }
        [XmlElement("partList")]
        public ComplexServicePartList partList { get; set; }
        [XmlElement("resourcePredefinition")]
        public ResourcePredefinition[] resourcePredefinition { get; set; }
    }

    public class ResourcePredefinition
    {
        [XmlElement("expression")]
        public string[] expression { get; set; }
    }
}
