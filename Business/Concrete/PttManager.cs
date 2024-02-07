using Business.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class PttManager:ISupplierService
    {
        private IApplicantService _aplicantService;

        public PttManager(IApplicantService aplicantService)
        {
            _aplicantService = aplicantService;
        }

        public void GiveMask(Person person)
        {
            if (_aplicantService.CheckPerson(person))
            {
                Console.WriteLine(person.FirstName + " için maske verildi.");
            }
            else
            {
                Console.WriteLine("Maske verilemedi.");
            }
        }
    }
}
