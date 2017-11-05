using ProvisioningDiscriptionHelper.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisLogTree
{
    class PackageCollection : ObservableCollection<Package>
    {
        public void Add(Package package)
        {
            this.Add(package);
        }
    }
}
