using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ProvisioningDiscriptionHelper.Models
{
    [Serializable()]
    public class SimpleService
    {
        [XmlAttribute("name")]
        public string name { get; set; }
        [XmlAttribute("description")]
        public string description { get; set; }
        [XmlAttribute("providingModule")]
        public string providingModule { get; set; }
        [XmlAttribute("noSave")]
        public string noSave { get; set; }
        [XmlAttribute("max")]
        public string max { get; set; }
        [XmlAttribute("min")]
        public string min { get; set; }
        [XmlAttribute("friendlyName")]
        public string friendlyName { get; set; }
        [XmlArray("propertyList", IsNullable = false), XmlArrayItem(typeof(ServiceProperty), ElementName = "property")]
        public ServiceProperty[] propertyList { get; set; }
        [XmlArray("operationList", IsNullable = false), XmlArrayItem(typeof(SimpleServiceOperation), ElementName = "operation")]
        public SimpleServiceOperation[] operationList { get; set; }
        [XmlArray("childServiceList", IsNullable = false), XmlArrayItem(typeof(SimpleService), ElementName = "simpleService")]
        public SimpleService[] childServiceList { get; set; }
    }
}
