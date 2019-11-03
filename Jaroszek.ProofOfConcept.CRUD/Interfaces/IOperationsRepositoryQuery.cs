using Jaroszek.ProofOfConcept.CRUD.Models;
using System.Collections.Generic;

namespace Jaroszek.ProofOfConcept.CRUD.Interfaces
{
    public interface IOperationsRepositoryQuery
    {
        List<Person> GetAll();
        Person FindByName(string name);

    }
}