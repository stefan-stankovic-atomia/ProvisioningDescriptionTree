using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ProvisioningDiscriptionHelper.Models
{
    public class ComplexServiceActionHooks
    {
        [XmlElement("onSwitchService")]
        public ComplexServiceOnSwitchService[] onSwitchService { get; set; }
        [XmlElement("onBeforeAddService")]
        public OnBeforeChangePackage[] onBeforeAddService { get; set; }
    }
}
