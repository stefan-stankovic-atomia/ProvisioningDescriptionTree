using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ProvisioningDiscriptionHelper.Models
{
    public class ComplexServicePartList
    {
        [XmlElement("partService")]
        public ComplexServicePartListPartService[] partService { get; set; }
        [XmlElement("partServiceInstance")]
        public ComplexServicePartServiceInstance[] partServiceInstance { get; set; }
        
    }
}
