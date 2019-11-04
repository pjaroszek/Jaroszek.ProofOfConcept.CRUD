using Jaroszek.ProofOfConcept.DataAccess.Models;

using System;
using System.Collections.Generic;
using System.Linq;
using Jaroszek.ProofOfConcept.DataAccess.Interfaces;

namespace Jaroszek.ProofOfConcept.SqlServer.Services
{
    public class OperationRepositorySql : IDataAccessQuery
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