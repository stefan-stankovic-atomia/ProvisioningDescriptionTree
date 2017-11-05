using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ProvisioningDiscriptionHelper.Models
{
    [Serializable()]
    public class PackageDisableProperty
    {
        [XmlAttribute("name")]
        public string name { get; set; }
        [XmlAttribute("newValue")]
        public string newValue { get; set; }
    }
}
