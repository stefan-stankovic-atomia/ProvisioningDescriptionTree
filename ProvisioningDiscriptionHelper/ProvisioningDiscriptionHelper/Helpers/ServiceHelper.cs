using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TreeContainer.ProvisioningDescriptionsContainters;
using ProvisioningDiscriptionHelper.Models;
using System.Linq;
using TreeContainer;

namespace ProvisioningDiscriptionHelper.Helpers
{
    public class ServiceHelper
    {
        protected static ServiceHelper instance = null;
        private ServiceHelper(){}
        public static ServiceHelper Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ServiceHelper();
                }
                return instance;
            }
        }

        public List<ServiceForList> GetServiceList(ProvisioningDescription provisioningDescription)
        {
            var serviceList = new List<ServiceForList>();
            serviceList.AddRange(provisioningDescription.servicesDescription.simpleServiceList.Select(s => new ServiceForList(s.name, false)).OrderBy(o => o.name));
            serviceList.AddRange(provisioningDescription.servicesDescription.complexServiceList.Select(s => new ServiceForList(s.name, true)).OrderBy(o => o.name));
            return serviceList;
        }

        public bool isSimpleService(ProvisioningDescription provisioningDescription, string serviceName)
        {
            return provisioningDescription.servicesDescription.simpleServiceList.Any(s => s.name == serviceName);
        }

        public MyListBoxItem GetServiceByName(ProvisioningDescription provisioningDescription, string name)
        {

            if (provisioningDescription.servicesDescription.complexServiceList.Any(s => s.name == name))
            {
                var service = provisioningDescription.servicesDescription.complexServiceList.Where(s => s.name == name).FirstOrDefault();
                return new MyListBoxItem(service.name, Constants.ServiceName.complexService);
            }

            if (provisioningDescription.servicesDescription.simpleServiceList.Any(s => s.name == name))
            {
                var service = provisioningDescription.servicesDescription.simpleServiceList.Where(s => s.name == name).FirstOrDefault();
                return new MyListBoxItem(service.name, Constants.ServiceName.simpleService);
            }

            return null;
        }

        public List<MyListBoxItem> GetChildElements(ProvisioningDescription provisioningDescription, MyListBoxItem item)
        {
            if (item.description == Constants.ServiceName.simpleService)
                return null;

            List<MyListBoxItem> arrayOfChild = new List<MyListBoxItem>();

            var complexService = provisioningDescription.servicesDescription.complexServiceList.Where(s => s.name == item.name).FirstOrDefault();

            var partServicesArray = complexService.partList.partService;

            if (partServicesArray != null)
            {
                var partServices = partServicesArray.ToList();

                foreach (var p in partServices)
                {
                    var service = GetServiceByName(provisioningDescription, p.name);
                    if (service != null)
                    {
                        arrayOfChild.Add(service);
                    }
                    else
                    {
                        arrayOfChild.Add(new MyListBoxItem(p.name, Constants.ServiceName.servisNotInList));
                    }
                }
            }

            return arrayOfChild;
        }
    }
}
