using System;
using System.Collections.Generic;
using System.Linq;

namespace Jaroszek.ProofOfConcept.CRUD
{
    public sealed class PersonsSingleton
    {

        private static PersonsSingleton instance = null;

        public static PersonsSingleton Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new PersonsSingleton();
                }

                return instance;
            }
        }

        private List<Person> Persons = new List<Person>();


        public void InitialDb()
        {
            Person person = new Person();

            person.Id = 1;
            person.Name = "Paweł";
            person.Surname = "Nowak";
            person.Street = "Rejtana";
            person.Number = "19";
            person.PostalCode = "35-103";
            person.City = "Rzeszów";
            person.AddDate = DateTime.Now;
            person.Description = "Dawno nic nie zamawiał ";

            Persons.Add(person);

            person = null;
            person = new Person();

            person.Id = 2;
            person.Name = "Marek";
            person.Surname = "Kowalski";
            person.Street = "Reja";
            person.Number = "1";
            person.PostalCode = "35-101";
            person.City = "Warszawa";
            person.AddDate = DateTime.Now;
            person.Description = "zamawia małe ilości ale często ";

            Persons.Add(person);
        }

        public void Insert(string Name, string Description)
        {
            Person person = new Person();
            Persons.Add(person);
        }

        public void Insert(Person person)
        {
            Persons.Add(person);
        }

        public void Update(Person person)
        {
            var result = Persons.Single(p => p.Name == person.Name);
            if (result != null)
            {
                result.Name = person.Name;
                result.Surname = person.Surname;
                result.Street = person.Street;
                result.Number = person.Number;
                result.PostalCode = person.PostalCode;
                result.City = person.City;
                result.AddDate = person.AddDate;
                result.Description = person.Description;
            }

        }

        public void Remove(int id)
        {
            var remove = Persons.FirstOrDefault((p => p.Id == id));
            if (remove != null)
                Persons.Remove(remove);
        }

    }
}
