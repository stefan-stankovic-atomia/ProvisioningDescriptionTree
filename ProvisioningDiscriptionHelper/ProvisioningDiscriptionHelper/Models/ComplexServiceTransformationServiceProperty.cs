using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ProvisioningDiscriptionHelper.Models
{
    public class ComplexServiceTransformationServiceProperty
    {
        [XmlAttribute("name")]
        public string name { get; set; }
        [XmlElement("expression")]
        public string expression { get; set; }
    }
}
