using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ProvisioningDiscriptionHelper.Models
{
    [Serializable()]
    public class Package
    {
        [XmlAttribute("name")]
        public string name { get; set; }
        [XmlArray("serviceList"), XmlArrayItem(typeof(PackageService), ElementName = "service")] 
        public PackageService[] serviceList { get; set; }
        [XmlElement("serviceLimitationList")]
        public PackageServiceLimitationList serviceLimitationList { get; set; }
        [XmlArray("propertySettings", IsNullable = false), XmlArrayItem(typeof(PackagePropertySet), ElementName = "set")] 
        public PackagePropertySet[] propertySettings { get; set; }
        [XmlElement("init")]
        public PackageInit init { get; set; }
        [XmlElement("disable")]
        public PackageDisable disable { get; set; }
        [XmlArray("actionHooks", IsNullable = false), XmlArrayItem(typeof(OnBeforeChangePackage), ElementName = "onBeforeChangePackage")]
        public OnBeforeChangePackage[] actionHooks { get; set; }
    }
}
