using FactoryMethod.ConcreteProduct;
using FactoryMethod.Creator;
using FactoryMethod.Product;

namespace FactoryMethod.ConcreteCreator
{
    public class BlackFactory : CardFactory
    {        
        private int _creditLimit;
        private int _billedAnnually;

        public BlackFactory(int creditLimit, int billedAnnually)
        {
            _creditLimit = creditLimit;
            _billedAnnually = billedAnnually;
        }

        public override CreditCard GetCreditCard()
        {
            return new BlackCard(_creditLimit, _billedAnnually);
        }
    }
}
