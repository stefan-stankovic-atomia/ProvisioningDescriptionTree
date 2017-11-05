using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ProvisioningDiscriptionHelper.Helpers
{
    public class XmlHelper
    {
        private static XmlHelper instance = null;
        private XmlHelper() { }

        public static XmlHelper Instance 
        {
            get
            {
                if (instance == null)
                {
                    instance = new XmlHelper();
                }

                return instance;
            }
        }

        public T Deserialize<T>(string input) where T : class
        {
            System.Xml.Serialization.XmlSerializer ser = new System.Xml.Serialization.XmlSerializer(typeof(T));

            using (FileStream fileStream = new FileStream(input, FileMode.Open))
            {
                return (T)ser.Deserialize(fileStream);
            }
        }

        public string Serialize<T>(T ObjectToSerialize)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(ObjectToSerialize.GetType());

            using (StringWriter textWriter = new StringWriter())
            {
                xmlSerializer.Serialize(textWriter, ObjectToSerialize);
                return textWriter.ToString();
            }
        }
    }
}
