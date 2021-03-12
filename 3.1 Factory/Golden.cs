namespace _3._1_Factory
{
    public class Golden : CreditCard
    {
        public string GetCardType()
        {
            return "Golden Card";
        }

        public int GetCreditLimit()
        {
            return 20000;
        }

        public int GetAnnualCharge()
        {
            return 500;
        }
    }
}