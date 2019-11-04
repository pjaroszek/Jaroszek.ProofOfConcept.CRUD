using Jaroszek.ProofOfConcept.DataAccess.Interfaces;
using Jaroszek.ProofOfConcept.DataAccess.Models;
using Jaroszek.ProofOfConcept.SqlServer.Services;
using System;

namespace Jaroszek.ProofOfConcept.CRUD
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {


                DataAccess.Models.PersonDto person = new PersonDto();
                person.Name = "Kornel";
                person.Description = "Marlenka";

                IDataAccessCommand dataSqlCommand = new OperationRepositorySqlCommand();
                dataSqlCommand.AddNew(person);





                IDataAccessQuery dataAccessQuery = new OperationRepositorySql();
                var result = dataAccessQuery.GetAll();


                //                PersonsSingleton.Instance.InitialDb();
                //
                //                var personClassToCheckValue = PersonsSingleton.Instance;
                //
                //               
                //                IOperationsRepositoryCommand crudCommand = new OperationsRepositoryCommand();
                //
                //                crudCommand.Insert("Kornel", "Marlenka");
                //
                //                crudCommand.Update("Kornel", "Zamawia w piątek a chce dostawę w sobotę..");
                //
                //                crudCommand.Remove(2);
                //
                //                IOperationsRepositoryQuery crudQuery = new OperationsRepositoryQuery();
                //                var result = crudQuery.GetAll();
                //                var resultName = crudQuery.FindByName("Kornel");

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
