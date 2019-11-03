using Jaroszek.ProofOfConcept.CRUD.Models;

namespace Jaroszek.ProofOfConcept.CRUD.Services
{
    using Jaroszek.ProofOfConcept.CRUD.Interfaces;
    using System;

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

            PersonsSingleton.Instance.Insert(person);

        }

        public void Insert(string Name, string Description)
        {
            Person person = new Person();

            person.Id = 1;
            person.Name = Name;
            person.Surname = "Nowak";
            person.Street = "Rejtana";
            person.Number = "19";
            person.PostalCode = "35-103";
            person.City = "Rzeszów";
            person.AddDate = DateTime.Now;
            person.Description = Description;

            PersonsSingleton.Instance.Insert(person);

        }

        public void Update(string name, string description)
        {


            Person person = new Person();
            person.Name = name;
            person.Surname = "Kowalski";
            person.Street = "Warszawska";
            person.Number = "15";
            person.PostalCode = "21-020";
            person.City = "Lublin";
            person.AddDate = DateTime.Now;
            person.Description = description;

            PersonsSingleton.Instance.Update(person);

        }

        public void Update(PersonDto personDto)
        {

            Person person = new Person();
            person.Name = personDto.Name;
            person.Surname = "Kowalski";
            person.Street = "Warszawska";
            person.Number = "15";
            person.PostalCode = "21-020";
            person.City = "Lublin";
            person.AddDate = DateTime.Now;
            person.Description = personDto.Description;

            PersonsSingleton.Instance.Update(person);

        }

        public void Remove(int id)
        {
            PersonsSingleton.Instance.Remove(id);
        }

    }
}