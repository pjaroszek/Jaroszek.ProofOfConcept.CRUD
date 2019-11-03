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

               
                IOperationsRepositoryCommand crudCommand = new OperationsRepositoryCommand();

                crudCommand.Insert("Kornel", "Marlenka");

                crudCommand.Update("Kornel", "Zamawia w piątek a chce dostawę w sobotę..");

                crudCommand.Remove(2);

                IOperationsRepositoryQuery crudQuery = new OperationsRepositoryQuery();
                var result = crudQuery.GetAll();
                var resultName = crudQuery.FindByName("Kornel");
                
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
