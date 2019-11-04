using Jaroszek.ProofOfConcept.DataAccess.Models;
using System.Collections.Generic;

namespace Jaroszek.ProofOfConcept.DataAccess.Interfaces
{

    public interface IDataAccessQuery
    {
        List<Person> GetAll();
        Person GetByName(string name);

    }
}
