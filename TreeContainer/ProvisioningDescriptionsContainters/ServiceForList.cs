using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TreeContainer.ProvisioningDescriptionsContainters
{
    public class ServiceForList
    {
        public string name { get; set; }
        public bool isComplexService { get; set; }
        public ServiceForList(string name, bool isComplexService)
        {
            this.name = name;
            this.isComplexService = isComplexService;
        }
        
    }
}
