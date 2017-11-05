using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ProvisioningDiscriptionHelper.Models
{
    [Serializable()]
    public class PackageInitProperty
    {
        [XmlAttribute("servicePropertyName")]
        public string servicePropertyName { get; set; }
        [XmlAttribute("valueSource")]
        public string valueSource { get; set; }
    }
}
