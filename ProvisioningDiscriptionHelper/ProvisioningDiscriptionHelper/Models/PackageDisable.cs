using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ProvisioningDiscriptionHelper.Models
{
    [Serializable()]
    public class PackageDisable
    {
        [XmlArray("scriptList"), XmlArrayItem(typeof(PackageDisableScript), ElementName = "script")] 
        public PackageDisableScript[] scriptList { get; set; }
    }
}
