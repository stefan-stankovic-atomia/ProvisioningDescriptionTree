using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ProvisioningDiscriptionHelper.Models
{
    [Serializable()]
    public class ServicesDescription
    {
        [XmlArray("simpleServiceList"), XmlArrayItem(typeof(SimpleService), ElementName = "simpleService")]
        public SimpleService[] simpleServiceList { get; set; }
        [XmlArray("complexServiceList"), XmlArrayItem(typeof(ComplexService), ElementName = "complexService")]
        public ComplexService[] complexServiceList { get; set; }
    }
}
