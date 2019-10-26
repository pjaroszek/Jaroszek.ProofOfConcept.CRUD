using System.Collections.Generic;
using Jaroszek.ProofOfConcept.CRUD.Services;

namespace Jaroszek.ProofOfConcept.CRUD
{
    class Program
    {
        public static List<Person> Persons = new List<Person>();
        static void Main(string[] args)
        {
            CrudOperations crud = new CrudOperations();
            crud.Insert();

            Person person = new Person();

            person.Id = 1;
            person.Name = "Pawel";
            person.Surname = "Nowak";
            person.Street = "Rejtana";
            person.Number = "22";
            person.PostalCode = "35-103";
            person.City = "Rzeszow";
            person.Description = "Opis ";


            crud.Update(person);


            crud.Remove(2);



        }
    }
}
