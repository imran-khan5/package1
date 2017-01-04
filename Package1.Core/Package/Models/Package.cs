using System;

namespace Package1.Core.Package.Models
{

    public class Package
    {
        public Bundle[] BundleList { get; set; }
    }

    public class Costswithoutlinerental
    {
        public float MonthlyCost { get; set; }
        public string MonthlyCostDisplay { get; set; }
    }

}
