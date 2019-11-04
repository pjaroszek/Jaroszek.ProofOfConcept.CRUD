using Jaroszek.ProofOfConcept.DataAccess.Models;
using System.Collections.Generic;

namespace Jaroszek.ProofOfConcept.DataAccess.Interfaces
{

    public interface IDataAccess
    {
        List<Person> GetAll();
        Person GetByName(string name);
        void AddNew(PersonDto person);
        void Update(PersonDto person);
        void DeleteById(int id);
    }
}
