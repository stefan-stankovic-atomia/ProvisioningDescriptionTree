using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ProvisioningDiscriptionHelper.Models
{
    [Serializable()]
    public class PackageDisableScript
    {
        [XmlAttribute("name")]
        public string name { get; set; }
        [XmlArray("serviceList", IsNullable = false), XmlArrayItem(typeof(PackageDisableService), ElementName = "service")]
        public PackageDisableService[] serviceList { get; set; }
    }
}
