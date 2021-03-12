namespace _3._1_Factory
{
    public class GoldenFactory : CreditCardFactory
    {
        protected override CreditCard MakeProduct()
        {
            CreditCard product = new Golden();
            return product;
        }
    }
}