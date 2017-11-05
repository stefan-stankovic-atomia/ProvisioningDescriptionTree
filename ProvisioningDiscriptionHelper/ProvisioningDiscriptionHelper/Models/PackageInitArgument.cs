using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ProvisioningDiscriptionHelper.Models
{
    [Serializable()]
    public class PackageInitArgument
    {
        [XmlAttribute("serviceName")]
        public string serviceName { get; set; }
        [XmlAttribute("propertyName")]
        public string propertyName { get; set; }
        [XmlAttribute("propertyValue")]
        public string propertyValue { get; set; }
    }
}
