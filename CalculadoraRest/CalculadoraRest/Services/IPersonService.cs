using CalculadoraRest.Model;
using System.Collections.Generic;

namespace CalculadoraRest.Services
{
    public interface IPersonService
    {
        Person Create(Person person);
        Person FindById(int id);
        List<Person> FindAll();
        Person Update(Person person);
        void Delete(int id);
    }
}
