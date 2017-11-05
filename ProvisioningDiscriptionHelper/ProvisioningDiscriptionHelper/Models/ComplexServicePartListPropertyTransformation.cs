using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ProvisioningDiscriptionHelper.Models
{
    public class ComplexServicePartListPropertyTransformation
    {
        [XmlArray("simpleTransformer", IsNullable = false), XmlArrayItem(typeof(ComplexServiceTransformationServiceProperty), ElementName = "serviceProperty")]
        public ComplexServiceTransformationServiceProperty[] serviceProperty { get; set; }
    }
}
