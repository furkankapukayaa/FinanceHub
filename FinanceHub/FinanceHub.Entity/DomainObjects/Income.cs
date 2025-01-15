namespace FinanceHub.Entity.DomainObjects
{
    public class Income : BaseDomainObject
    {
        public Account Account { get; set; }
        public int Amount { get; set; }
        public int OldBalance { get; set; }
        public int AvaibleBalance { get; set; }
        public DateTime IncomeDate { get; set; }
    }
}