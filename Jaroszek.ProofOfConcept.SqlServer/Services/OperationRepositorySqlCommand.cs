using Jaroszek.ProofOfConcept.DataAccess.Interfaces;
using Jaroszek.ProofOfConcept.DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Jaroszek.ProofOfConcept.SqlServer.Services
{
    public class OperationRepositorySqlCommand : IDataAccessCommand
    {
        private List<Person> _persons = new List<Person>();

        public void AddNew(PersonDto personDto)
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

            _persons.Add(person);

        }

        public void Update(PersonDto person)
        {
            Person p = _persons.Where(x => x.Name == person.Name).SingleOrDefault();
            p.Description = person.Description;

        }

        public void DeleteById(int id)
        {
            _persons.Remove(_persons.Where(p => p.Id == id).SingleOrDefault());
        }
    }
}