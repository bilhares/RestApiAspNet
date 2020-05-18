using CalculadoraRest.Model;
using CalculadoraRest.Model.Context;
using CalculadoraRest.Repository;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CalculadoraRest.Business.Implementations
{
    public class PersonBusinessImpl : IPersonBusiness
    {

        private IPersonRepository _repository;

        public PersonBusinessImpl(IPersonRepository repository)
        {
            _repository = repository;
        }

        public Person Create(Person person)
        {
            return _repository.Create(person);
        }

        public void Delete(int id)
        {
            _repository.Delete(id);
        }

        public List<Person> FindAll()
        {
            return _repository.FindAll();
        }

        public Person FindById(int id)
        {
            return _repository.FindById(id);
        }

        public Person Update(Person person)
        {
            return _repository.Update(person);
        }
    }
}
