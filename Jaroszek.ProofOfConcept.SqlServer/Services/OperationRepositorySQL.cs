using Jaroszek.ProofOfConcept.DataAccess.Models;
using Jaroszek.ProofOfConcept.SqlServer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Jaroszek.ProofOfConcept.SqlServer.Services
{
    public class OperationRepositorySql : IPersonRepositoryQuery
    {
        private List<Person> _persons = new List<Person>();

        public List<Person> GetAll()
        {
            return _persons;
        }

        public Person GetByName(string name)
        {
            return _persons.Where(p => p.Name == name).SingleOrDefault();
        }

      
    }
}