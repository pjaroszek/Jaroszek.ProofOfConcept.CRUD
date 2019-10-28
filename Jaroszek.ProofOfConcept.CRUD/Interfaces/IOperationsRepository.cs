namespace Jaroszek.ProofOfConcept.CRUD.Interfaces
{
    public interface IOperationsRepository
    {
        void Insert(PersonDto personDto);
        void Update(PersonDto personDto);
        void Remove(int id);
    }
}