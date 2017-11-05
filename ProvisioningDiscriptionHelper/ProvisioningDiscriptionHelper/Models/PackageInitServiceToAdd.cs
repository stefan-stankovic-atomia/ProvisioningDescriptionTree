using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ProvisioningDiscriptionHelper.Models
{
    [Serializable()]
    public class PackageInitServiceToAdd
    {
        [XmlAttribute("serviceName")]
        public string serviceName { get; set; }
        [XmlArray("propertyInitList", IsNullable = false), XmlArrayItem(typeof(PackageInitProperty), ElementName = "property")]
        public PackageInitProperty[] propertyInitList { get; set; }
    }
}
