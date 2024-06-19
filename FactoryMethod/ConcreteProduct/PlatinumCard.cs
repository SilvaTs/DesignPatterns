using FactoryMethod.Product;

namespace FactoryMethod.ConcreteProduct
{
    public class PlatinumCard : CreditCard
    {
        private readonly string _typeCredit;
        private int _creditLimit;
        private int _billedAnnually;

        public PlatinumCard(int creditLimit, int billedAnnually)
        {
            _typeCredit = "Platinum";
            _creditLimit = creditLimit;
            _billedAnnually = billedAnnually;
        }

        public override string TypeCredit
        {
            get { return _typeCredit; }
        }
        public override int CreditLimit
        {
            get { return _creditLimit; }
            set { _creditLimit = value; }
        }
        public override int BilledAnnually
        {
            get { return _billedAnnually; }
            set { _billedAnnually = value; }
        }
    }
}
