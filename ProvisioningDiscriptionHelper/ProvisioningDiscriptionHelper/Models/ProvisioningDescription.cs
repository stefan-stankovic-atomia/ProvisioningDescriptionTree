using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ProvisioningDiscriptionHelper.Models
{
    [Serializable()]
    [XmlRoot(ElementName = "provisioningDescription", DataType = "string", IsNullable = false)]
    public class ProvisioningDescription
    {
        [XmlElement("servicesDescription")]
        public ServicesDescription servicesDescription { get; set; }
        [XmlElement("packageDescription")]
        public PackageDescription packageDescription { get; set; }
    }
}
