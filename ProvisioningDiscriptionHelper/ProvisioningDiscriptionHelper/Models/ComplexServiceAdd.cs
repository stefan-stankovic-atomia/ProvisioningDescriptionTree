using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ProvisioningDiscriptionHelper.Models
{
    public class ComplexServiceAdd
    {
        [XmlAttribute("partName")]
        public string partName { get; set; }
        [XmlAttribute("condition")]
        public string condition { get; set; }
        [XmlAttribute("instanceName")]
        public string instanceName { get; set; }
        [XmlElement("initPropertyList")]
        public ComplexServiceInitPropertyList initPropertyList { get; set; }
        [XmlElement("add")]
        public ComplexServiceAdd[] add { get; set; }
        [XmlArray("initOperationsList", IsNullable = false), XmlArrayItem(typeof(ComplexServiceInitOperation), ElementName = "initOperation")]
        public ComplexServiceInitOperation[] initOperationsList { get; set; }
    }
}
