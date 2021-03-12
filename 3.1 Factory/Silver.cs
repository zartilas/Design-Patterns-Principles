namespace _3._1_Factory
{
    public class Silver : CreditCard
    {
        public string GetCardType()
        {
            return "Silver Card";
        }

        public int GetCreditLimit()
        {
            return 100000;
        }

        public int GetAnnualCharge()
        {
            return 1000;
        }
    }
}