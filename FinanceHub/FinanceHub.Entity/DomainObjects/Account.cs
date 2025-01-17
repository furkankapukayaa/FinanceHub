using FinanceHub.Entity.Enums;

namespace FinanceHub.Entity.DomainObjects
{
    public class Account : BaseDomainObject
    {
        public int No { get; set; }
        public User Owner { get; set; }
        public string Name { get; set; }
        public int Balance { get; set; }
        public CurrencyType Currency { get; set; }
        public AccountType Type { get; set; }
    }
}