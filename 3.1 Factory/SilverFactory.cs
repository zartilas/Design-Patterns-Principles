namespace _3._1_Factory
{
    public class SilverFactory : CreditCardFactory
    {
        protected override CreditCard MakeProduct()
        {
            CreditCard product = new Silver();
            return product;
        }
    }
}