using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ProvisioningDiscriptionHelper.Models
{
    [Serializable()]
    public class PackageDisableService
    {
        [XmlAttribute("path")]
        public string path { get; set; }
        [XmlAttribute("action")]
        public string action { get; set; }
        [XmlArray("propertyList", IsNullable = false), XmlArrayItem(typeof(PackageDisableProperty), ElementName = "property")]
        public PackageDisableProperty[] propertyList { get; set; }
    }
}
