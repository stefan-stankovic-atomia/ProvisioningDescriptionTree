using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ProvisioningDiscriptionHelper.Models
{
    [Serializable()]
    public class PackageLimitationGroup
    {
        [XmlAttribute("maxCount")]
        public string maxCount { get; set; }
        [XmlAttribute("name")]
        public string name { get; set; }
        [XmlElement("service")]
        public PackageService service { get; set; }
    }
}
