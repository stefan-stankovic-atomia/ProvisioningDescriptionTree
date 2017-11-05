using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ProvisioningDiscriptionHelper.Models
{
    [Serializable()]
    public class ComplexService
    {
        [XmlAttribute("name")]
        public string name { get; set; }
        [XmlAttribute("friendlyName")]
        public string friendlyName { get; set; }
        [XmlAttribute("description")]
        public string description { get; set; }
        [XmlArray("complexServicePropertyList", IsNullable = false), XmlArrayItem(typeof(ServiceProperty), ElementName = "complexServiceProperty")]
        public ServiceProperty[] propertyList { get; set; }
        [XmlElement("partList")]
        public ComplexServicePartList partList { get; set; }
        [XmlArray("init", IsNullable = false), XmlArrayItem(typeof(ComplexServiceAdd), ElementName = "add")]
        public ComplexServiceAdd[] init { get; set; }
        [XmlElement("actionHooks")]
        public ComplexServiceActionHooks actionHooks { get; set; }
    }
}
