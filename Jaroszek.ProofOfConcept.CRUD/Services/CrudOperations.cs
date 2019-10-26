using System.Linq;

namespace Jaroszek.ProofOfConcept.CRUD.Services
{
    public class CrudOperations
    {
        public void Insert()
        {
            Person person = new Person();

            person.Id = 1;
            person.Name = "Paweł";
            person.Surname = "Nowak";
            person.Street = "Rejtana";
            person.Number = "19";
            person.PostalCode = "35-103";
            person.City = "Rzeszów";
            person.Description = "Opis ";

            Program.Persons.Add(person);

            person.Id = 2;
            person.Name = "Michał";
            person.Surname = "Nowak";
            person.Street = "Reja";
            person.Number = "1";
            person.PostalCode = "35-101";
            person.City = "Warszawa";
            person.Description = "Opis ";

            Program.Persons.Add(person);

        }


        public void Update(Person person)
        {
            var result = Program.Persons.FirstOrDefault(p => p.Id == person.Id);
            if (result != null)
            {
                result.Name = person.Name;
                result.Surname = person.Surname;
                result.Street = person.Street;
                result.Number = person.Number;
                result.PostalCode = person.PostalCode;
                result.City = person.City;
                result.Description = person.Description;
            }
        }

        public void Remove(int id)
        {
            var itemToRemove = Program.Persons.FirstOrDefault(p => p.Id == id);
            if (itemToRemove != null)
            {
                Program.Persons.Remove(itemToRemove);
            }

        }


    }
}