namespace Jaroszek.ProofOfConcept.DataAccess.Models
{
    using System;

    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Street { get; set; }
        public string Number { get; set; }
        public string PostalCode { get; set; }
        public string City { get; set; }
        public DateTime AddDate { get; set; }
        public string Description { get; set; }
    }
}