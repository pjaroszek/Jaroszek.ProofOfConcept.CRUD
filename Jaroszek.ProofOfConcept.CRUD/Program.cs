using Jaroszek.ProofOfConcept.CRUD.Interfaces;
using Jaroszek.ProofOfConcept.CRUD.Services;
using System;
using System.Collections.Generic;

namespace Jaroszek.ProofOfConcept.CRUD
{
    class Program
    {
        public static List<Person> Persons = new List<Person>();

        static void Main(string[] args)
        {

            InitialDb();

            PersonDto personDto = new PersonDto();
            personDto.Name = "Michal";
            personDto.Description = "zazwyczaj zamawia rano";

            IOperationsRepository crud = new OperationsRepository();
            crud.Insert(personDto);


            PersonDto personDtoUpdate = new PersonDto();
            personDtoUpdate.Name = "Michal";
            personDtoUpdate.Description = "zmienił preferencje, zamawia w południe";

            crud.Update(personDtoUpdate);

            //     crud.Remove(2);

        }

        private static void InitialDb()
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

            Program.Persons.Add(person);

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

            Program.Persons.Add(person);
        }
    }
}
