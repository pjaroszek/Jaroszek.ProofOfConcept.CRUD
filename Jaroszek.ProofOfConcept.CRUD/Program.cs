using Jaroszek.ProofOfConcept.CRUD.Interfaces;
using Jaroszek.ProofOfConcept.CRUD.Services;

namespace Jaroszek.ProofOfConcept.CRUD
{
    class Program
    {
        static void Main(string[] args)
        {
            PersonsSingleton.Instance.InitialDb();

            var personClassToCheckValue = PersonsSingleton.Instance;

            PersonDto personDto = new PersonDto();
            personDto.Name = "Michal";
            personDto.Description = "zazwyczaj zamawia rano";

            IOperationsRepository crud = new OperationsRepository();
            crud.Insert(personDto);


            PersonDto personDtoUpdate = new PersonDto();
            personDtoUpdate.Name = "Michal";
            personDtoUpdate.Description = "zmienił preferencje, zamawia w południe";

            crud.Update(personDtoUpdate);

            crud.Remove(2);

        }


    }
}
