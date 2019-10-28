using Jaroszek.ProofOfConcept.CRUD.Interfaces;
using Jaroszek.ProofOfConcept.CRUD.Services;
using System;

namespace Jaroszek.ProofOfConcept.CRUD
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                PersonsSingleton.Instance.InitialDb();

                var personClassToCheckValue = PersonsSingleton.Instance;

                PersonDto personDto = new PersonDto();
                personDto.Name = "Michal";
                personDto.Description = "zazwyczaj zamawia rano";

                IOperationsRepository crud = new OperationsRepository();
                crud.Insert(personDto);


                PersonDto personDtoUpdate = new PersonDto();
                personDtoUpdate.Name = "Michala";
                personDtoUpdate.Description = "zmienił preferencje, zamawia w południe";

                crud.Update(personDtoUpdate);

                crud.Remove(2);

            }
            catch (InvalidOperationException operationException)
            {
                Console.Write(operationException.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            Console.ReadKey();
        }

    }
}
