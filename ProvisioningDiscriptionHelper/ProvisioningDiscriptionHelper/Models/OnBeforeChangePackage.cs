﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ProvisioningDiscriptionHelper.Models
{
    [Serializable()]
    public class OnBeforeChangePackage
    {
        [XmlAttribute("argument")]
        public string argument { get; set; }
        [XmlAttribute("type")]
        public string type { get; set; }
    }
}