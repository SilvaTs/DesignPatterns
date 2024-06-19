namespace FactoryMethod.Product
{
    public abstract class CreditCard
    {
        public abstract string TypeCredit { get; }
        public abstract int CreditLimit { get; set; }
        public abstract int BilledAnnually { get; set; }
    }
}
