namespace FinanceHub.Entity.DomainObjects
{
    public class User : BaseDomainObject
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Phone { get; set; }
    }
}