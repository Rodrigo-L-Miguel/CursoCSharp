using System.Globalization;

namespace ExFixacaoHeranca.Entities
{
    class ImportedProduct : Product
    {
        public double CustomnsFee { get; set; }

        public ImportedProduct() { }

        public ImportedProduct(string name, double price, double customnsFee): 
            base(name,price)
        {
            CustomnsFee = customnsFee;
        }

        public override string PriceTag()
        {
            return base.PriceTag() + " (Customs fee: $ " + TotalPrice().ToString("F2",CultureInfo.InvariantCulture) + ")";

        }

        public double TotalPrice()
        {
            return Price + CustomnsFee;
        }
    }
}
