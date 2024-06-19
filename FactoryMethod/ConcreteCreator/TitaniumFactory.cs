using FactoryMethod.ConcreteProduct;
using FactoryMethod.Creator;
using FactoryMethod.Product;

namespace FactoryMethod.ConcreteCreator
{
    public class TitaniumFactory : CardFactory
    {
        private int _creditLimit;
        private int _billedAnnually;

        public TitaniumFactory(int creditLimit, int billedAnnually)
        {
            _creditLimit = creditLimit;
            _billedAnnually = billedAnnually;
        }

        public override CreditCard GetCreditCard()
        {
            return new TitaniumCard(_creditLimit, _billedAnnually);
        }
    }
}
