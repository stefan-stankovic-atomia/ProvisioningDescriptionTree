using ProvisioningDiscriptionHelper.Helpers;
using ProvisioningDiscriptionHelper.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;

namespace ProvisioningDiscriptionHelper
{
    public partial class Form1 : Form
    {
        ProvisioningDescription provisioningDescription;
        public Form1()
        {
            InitializeComponent();
        }

        private void OpenProvisioningDescription_Click(object sender, EventArgs e)
        {
            OpenFileDialog openProvisioningDescriptionFileDialog = new OpenFileDialog();

            //openProvisioningDescriptionFileDialog.InitialDirectory = "c:\\";
            openProvisioningDescriptionFileDialog.Filter = "All files (*.*)|*.*|xml files (*.xml)|*.xml";
            openProvisioningDescriptionFileDialog.FilterIndex = 2;
            openProvisioningDescriptionFileDialog.RestoreDirectory = true;

            if (openProvisioningDescriptionFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    provisioningDescription = XmlHelper.Instance.Deserialize<ProvisioningDescription>(openProvisioningDescriptionFileDialog.FileName);
                

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                }
            }
        }

        private void SaveProvisioningDescription_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveProvisioningDescriptionFileDialog = new SaveFileDialog();
            saveProvisioningDescriptionFileDialog.Filter = "All files (*.*)|*.*|xml files (*.xml)|*.xml";
            saveProvisioningDescriptionFileDialog.Title = "Save an XML File";
            saveProvisioningDescriptionFileDialog.ShowDialog();
            if (saveProvisioningDescriptionFileDialog.FileName != "")
            {
                using(FileStream fs = (FileStream)saveProvisioningDescriptionFileDialog.OpenFile())
                {

                    string dataasstring = XmlHelper.Instance.Serialize<ProvisioningDescription>(provisioningDescription);
                    byte[] info = new UTF8Encoding(true).GetBytes(dataasstring);
                    fs.Write(info, 0, info.Length);

                    byte[] data = new byte[] { 0x0 };
                    fs.Write(data, 0, data.Length);

                    fs.Close();
                } 
                
            }  
        }
    }
}
