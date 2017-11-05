using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ProvisioningDiscriptionHelper.Models
{
    public class ComplexServiceOnSwitchService
    {
        [XmlAttribute("type")]
        public string type { get; set; }
        [XmlAttribute("argument")]
        public string argument { get; set; }
    }
}
