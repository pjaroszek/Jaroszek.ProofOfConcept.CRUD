using Jaroszek.ProofOfConcept.DataAccess.Interfaces;
using Jaroszek.ProofOfConcept.DataAccess.Models;
using System.Collections.Generic;

namespace Jaroszek.ProofOfConcept.MySql.Services
{
    public class OperationsRepositoryMySql : IDataAccessCommand, IDataAccessQuery
    {
        public void AddNew(PersonDto person)
        {
            throw new System.NotImplementedException();
        }

        public void Update(PersonDto person)
        {
            throw new System.NotImplementedException();
        }

        public void DeleteById(int id)
        {
            throw new System.NotImplementedException();
        }

        public List<Person> GetAll()
        {
            throw new System.NotImplementedException();
        }

        public Person GetByName(string name)
        {
            throw new System.NotImplementedException();
        }
    }
}