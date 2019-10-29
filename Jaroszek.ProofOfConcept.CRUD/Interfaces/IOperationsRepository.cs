namespace Jaroszek.ProofOfConcept.CRUD.Interfaces
{
    public interface IOperationsRepository
    {
        void Insert(PersonDto personDto);
        void Update(PersonDto personDto);
        void Update(string name, string description);
        void Remove(int id);
    }
}