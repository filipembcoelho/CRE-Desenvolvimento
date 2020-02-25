namespace RumosCRE.Domain.Models
{
    public abstract class Person
    {
        public string FirstName { get; set; }
        public string MiddleNames { get; set; }
        public string LastName { get; set; }
        public string TaxNumber { get; set; }
    }
}
