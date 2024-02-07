using Business.Concrete;
using Entities.Concrete;
using System.Globalization;

internal class Program
{
    private static void Main(string[] args)
    {
        Person person1 = new Person { FirstName = "Orhan", LastName = "Doğan", DateOfBirth = 1990, NationalIdentity = 12345678910 };

        PersonManager personManager = new PersonManager();
        PttManager pttManager = new PttManager(personManager);
        pttManager.GiveMask(person1);
    }
}