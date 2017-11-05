using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ProvisioningDiscriptionHelper.Models
{
    public class ComplexServiceInitOperation
    {
        [XmlAttribute("name")]
        public string name { get; set; }
        [XmlAttribute("opArgument")]
        public string opArgument { get; set; }
    }
}
