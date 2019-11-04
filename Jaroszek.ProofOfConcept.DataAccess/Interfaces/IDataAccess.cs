namespace Jaroszek.ProofOfConcept.DataAccess.Interfaces
{
    using Jaroszek.ProofOfConcept.DataAccess.Models;
    using System.Collections.Generic;
    interface IDataAccess
    {
        List<Person> GetAll();
        Person GetByName(string name);
        void AddNew(PersonDto person);
        void Update(PersonDto person);
        void DeleteById(int id);
    }
}
