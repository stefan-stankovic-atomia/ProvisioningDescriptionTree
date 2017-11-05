using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using TreeContainer;
using System.IO;
using System.Windows.Markup;
using ProvisioningDiscriptionHelper.Models;
using ProvisioningDiscriptionHelper.Helpers;
using ProvisioningDiscriptionHelper.Constants;
using TreeContainer.ProvisioningDescriptionsContainters;

namespace VisLogTree
{
	/// <summary>
	/// Interaction logic for Window1.xaml
	/// </summary>
	public partial class Window1 : Window
	{
        ProvisioningDescription provisioningDescription;
        public List<Package> packageList = new List<Package>();
        public List<ServiceForList> serviceList = new List<ServiceForList>();
        public List<string> wrongServices = new List<string>();

		public Window1()
		{
			InitializeComponent();            
		}

		private void tcMain_Click(object sender, RoutedEventArgs e)
		{
			Button btn = e.OriginalSource as Button;
			if (btn != null)
			{
				TreeNode tn = (TreeNode)(btn.Parent);
				tn.Collapsed = !tn.Collapsed;
			}
		}

		private void DrawComponentTree(Object o, TreeNode tnControl)
		{
            MyListBoxItem item = (MyListBoxItem) o;
			TreeNode tnSubtreeRoot;
			Button btn = new Button();
			btn.Content = item.name;
			
			if (tnControl == null)
			{
                wrongServices.Clear();
                tcMain.Clear();
				tnSubtreeRoot = tcMain.AddRoot(btn);
			}
			else
			{
				tnSubtreeRoot = tcMain.AddNode(btn, tnControl);
			}

			if (item != null)
			{
                var childList = new List<MyListBoxItem>();

                if (string.IsNullOrEmpty(item.description))
                {
                    try
                    {
                        var serviceList = PackageHelper.Instance.getServicesList(provisioningDescription, item.name);
                        if (serviceList != null && serviceList.Count != 0)
                        {
                            childList.AddRange(serviceList);
                        }
                    }
                    catch (Exception e) 
                    {
                        MessageBox.Show(e.Message);
                    }
                }
                else if (item.description == ServiceName.servisNotInList)
                {
                    wrongServices.Add(item.name);
                }
                else
                {
                    try
                    {
                        var childItems = ServiceHelper.Instance.GetChildElements(provisioningDescription, item);
                        if (childItems != null && childItems.Count > 0)
                            childList.AddRange(childItems);
                    }
                    catch (Exception e)
                    {
                        MessageBox.Show(e.Message);
                    }
                }

                foreach (var node in childList)
                {
                    DrawComponentTree(node, tnSubtreeRoot);
                }

			}
		}

		private void DrawComponentTree()
		{
			tcMain.Clear();
			//DrawComponentTree(spnlDialog, null);
		}

        private void FillList()
        {
            List<MyListBoxItem> items = new List<MyListBoxItem>();
            //packageListBox.Items.Clear();
            if ((bool)checkedPackageList.IsChecked)
            {
                packageList.ForEach(p => items.Add(new MyListBoxItem(p.name, "")));
                packageListBox.ItemsSource = items;
            }
            else
            {
                serviceList.ForEach(p => items.Add(new MyListBoxItem(p.name, p.isComplexService ? ServiceName.complexService : ServiceName.simpleService)));
                packageListBox.ItemsSource = items;
            }
        }


        private void newPackageIsSelected(object sender, SelectionChangedEventArgs e)
        {
            if (e.AddedItems.Count > 0)
            {
                DrawComponentTree((MyListBoxItem)e.AddedItems[0], null);
                if (wrongServices.Count > 0)
                {
                    string services = "";
                    wrongServices.ForEach(s => services = services + s + "\n");
                    MessageBox.Show("Services is not defined: \n" + services);
                }
            }
        }

        private void button_OpenProvisioningDescription(object sender, RoutedEventArgs e)
        {
            System.Windows.Forms.OpenFileDialog openProvisioningDescriptionFileDialog = new System.Windows.Forms.OpenFileDialog();
            //openProvisioningDescriptionFileDialog.InitialDirectory = "c:\\";
            openProvisioningDescriptionFileDialog.Filter = "All files (*.*)|*.*|xml files (*.xml)|*.xml";
            openProvisioningDescriptionFileDialog.FilterIndex = 2;
            openProvisioningDescriptionFileDialog.RestoreDirectory = true;

            if (openProvisioningDescriptionFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                try
                {
                    provisioningDescription = XmlHelper.Instance.Deserialize<ProvisioningDescription>(openProvisioningDescriptionFileDialog.FileName);
                    packageList = provisioningDescription.packageDescription.packageList.OrderBy(o => o.name).ToList();
                    serviceList = ServiceHelper.Instance.GetServiceList(provisioningDescription);
                    FillList();                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                }
            }
        }

        private void radioPackageIsChecked(object sender, RoutedEventArgs e)
        {
            FillList();
        }

        private void radioServiceIsChecked(object sender, RoutedEventArgs e)
        {
            FillList();
        }
	}
}
