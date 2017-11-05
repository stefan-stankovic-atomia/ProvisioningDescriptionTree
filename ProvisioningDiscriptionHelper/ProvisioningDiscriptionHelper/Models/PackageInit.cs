using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ProvisioningDiscriptionHelper.Models
{
    [Serializable()]
    public class PackageInit
    {
        [XmlArray("arguments", IsNullable = false), XmlArrayItem(typeof(PackageInitArgument), ElementName = "argument")] 
        public PackageInitArgument[] arguments { get; set; }
        [XmlElement("serviceToAdd")]
        public PackageInitServiceToAdd[] serviceToAdd { get; set; }
    }
}
