using Jaroszek.ProofOfConcept.DataAccess.Models;

namespace Jaroszek.ProofOfConcept.DataAccess.Interfaces
{
    public interface IDataAccessCommand
    {
        void AddNew(PersonDto person);
        void Update(PersonDto person);
        void DeleteById(int id);
    }
}