namespace FinanceHub.Entity.DomainObjects
{
    public class Spending : BaseDomainObject
    {
        public Category Category { get; set; }
        public int Amount { get; set; }
        public Account Account { get; set; }
        public int OldBalance { get; set; }
        public int AvaibleBalance { get; set; }
        public DateTime SpendingDate { get; set; }
        public string Business { get; set; }
    }
}