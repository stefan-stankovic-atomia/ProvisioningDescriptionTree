using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ProvisioningDiscriptionHelper.Models
{
    [Serializable()]
    public class ServiceProperty
    {
        [XmlAttribute("name")]
        public string name { get; set; }
        [XmlAttribute("description")]
        public string description { get; set; }
        [XmlAttribute("defaultValue")]
        public string defaultValue { get; set; }
        [XmlAttribute("expiresAfter")]
        public string expiresAfter { get; set; }
        [XmlAttribute("required")]
        public string required { get; set; }
        [XmlAttribute("key")]
        public string key { get; set; }
        [XmlAttribute("friendlyName")]
        public string friendlyName { get; set; }
        [XmlAttribute("storeType")]
        public string storeType { get; set; }
        [XmlAttribute("log")]
        public string log { get; set; }
        [XmlAttribute("allowDefaultOverride")]
        public string allowDefaultOverride { get; set; }
    }
}
