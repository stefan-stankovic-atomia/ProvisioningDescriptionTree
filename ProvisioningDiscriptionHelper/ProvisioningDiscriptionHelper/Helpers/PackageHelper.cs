using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TreeContainer;
using ProvisioningDiscriptionHelper.Models;

namespace ProvisioningDiscriptionHelper.Helpers
{
    public class PackageHelper
    {
        protected static PackageHelper instance = null;
        private PackageHelper(){}

        public static PackageHelper Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new PackageHelper();
                }

                return instance;
            }
        }

        public List<MyListBoxItem> getServicesList(ProvisioningDescription provisioningDescription, string packageName)
        {
            var package = provisioningDescription.packageDescription.packageList.Where(p => p.name == packageName).FirstOrDefault();
            var packageServicesName = package.serviceList.Select(s => s.name).ToList();

            List<MyListBoxItem> listOfServices = new List<MyListBoxItem>();

            foreach(var serviceName in packageServicesName)
            {
                listOfServices.Add(ServiceHelper.Instance.GetServiceByName(provisioningDescription, serviceName));
            }

            return listOfServices;
        }
    }
}
