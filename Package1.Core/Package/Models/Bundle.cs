namespace Package1.Core.Package.Models
{
    public class Bundle
    {
        public string BundleType { get; set; }
        public int BundleId { get; set; }
        public int ProviderId { get; set; }
        public string ProviderName { get; set; }

        public Costswithoutlinerental CostsWithoutLineRental { get; set; }
    }
}
