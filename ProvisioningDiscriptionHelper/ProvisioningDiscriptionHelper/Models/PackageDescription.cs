using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ProvisioningDiscriptionHelper.Models
{
    [Serializable()]
    public class PackageDescription
    {
        [XmlArray("packageList"), XmlArrayItem(typeof(Package), ElementName = "package")] 
        public Package[] packageList { get; set; }
        [XmlArray("packageExtensionList"), XmlArrayItem(typeof(PackageExtension), ElementName = "packageExtension")] 
        public PackageExtension[] packageExtensionList { get; set; }
    }
}
