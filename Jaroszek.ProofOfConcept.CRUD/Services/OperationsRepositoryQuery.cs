namespace Jaroszek.ProofOfConcept.CRUD.Services
{
    using Jaroszek.ProofOfConcept.CRUD.Interfaces;
    using Jaroszek.ProofOfConcept.CRUD.Models;
    using System.Collections.Generic;

    public class OperationsRepositoryQuery : IOperationsRepositoryQuery
    {
        public List<Person> GetAll()
        {
            return PersonsSingleton.Instance.GetAll();
        }

        public Person FindByName(string name)
        {
            return PersonsSingleton.Instance.FindByName(name);
        }
    }
}
