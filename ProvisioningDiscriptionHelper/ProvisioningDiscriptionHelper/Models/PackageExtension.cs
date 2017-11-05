using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ProvisioningDiscriptionHelper.Models
{
    [Serializable()]
    public class PackageExtension
    {
        [XmlAttribute("name")]
        public string name { get; set; }
        [XmlElement("serviceLimitationList")]
        public PackageServiceLimitationList serviceLimitationList { get; set; }
        [XmlArray("extendsList"), XmlArrayItem(typeof(PackageExtends), ElementName = "extends")] 
        public PackageExtends[] extendsList { get; set; }
    }
    [Serializable()]
    public class PackageExtends
    {
        [XmlAttribute("name")]
        public string name { get; set; }
    }
}
