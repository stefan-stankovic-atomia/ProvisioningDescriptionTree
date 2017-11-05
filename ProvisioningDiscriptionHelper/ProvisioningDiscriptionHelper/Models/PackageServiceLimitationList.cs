using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ProvisioningDiscriptionHelper.Models
{
    [Serializable()]
    public class PackageServiceLimitationList
    {
        [XmlArray("globalLimitation"), XmlArrayItem(typeof(PackageLimitationGroup), ElementName = "group")] 
        public PackageLimitationGroup[] globalLimitation { get; set; }
    }
}
