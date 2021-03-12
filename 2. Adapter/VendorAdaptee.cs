using System.Collections.Generic;

namespace _2._Adapter
{
    internal class VendorAdaptee
    {
        public List<string> GetListOfProducts()
        {
            List<string> products = new List<string>();
            products.Add("Apple");
            products.Add("Orange");
            products.Add("Cereals");
            products.Add("Wine");
            return products;
        }
    }
}