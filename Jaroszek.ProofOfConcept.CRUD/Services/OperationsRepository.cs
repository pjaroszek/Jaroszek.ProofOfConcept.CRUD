namespace Jaroszek.ProofOfConcept.CRUD.Services
{
    using Jaroszek.ProofOfConcept.CRUD.Interfaces;
    using System;
    using System.Linq;

    public class OperationsRepository : IOperationsRepository
    {
        public void Insert(PersonDto personDto)
        {
            Person person = new Person();

            person.Id = 1;
            person.Name = personDto.Name;
            person.Surname = "Nowak";
            person.Street = "Rejtana";
            person.Number = "19";
            person.PostalCode = "35-103";
            person.City = "Rzeszów";
            person.AddDate = DateTime.Now;
            person.Description = personDto.Description;

            Program.Persons.Add(person);
        }

        public void Update(PersonDto personDto)
        {
            var result = Program.Persons.FirstOrDefault(p => p.Name == personDto.Name);
            if (result != null)
            {
                result.Name = personDto.Name;
                result.Surname = "Kowalski";
                result.Street = "Warszawska";
                result.Number = "15";
                result.PostalCode = "21-020";
                result.City = "Lublin";
                result.AddDate = DateTime.Now;
                result.Description = personDto.Description;
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