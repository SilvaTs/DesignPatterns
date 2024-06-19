using FactoryMethod.ConcreteProduct;
using FactoryMethod.Creator;
using FactoryMethod.Product;

namespace FactoryMethod.ConcreteCreator
{
    public class PlatinumFactory : CardFactory
    {
        private int _creditLimit;
        private int _billedAnnually;

        public PlatinumFactory(int creditLimit, int billedAnnually)
        {
            _creditLimit = creditLimit;
            _billedAnnually = billedAnnually;
        }

        public override CreditCard GetCreditCard()
        {
            return new PlatinumCard(_creditLimit, _billedAnnually);
        }
    }
}
