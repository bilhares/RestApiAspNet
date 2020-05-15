using CalculadoraRest.Model;
using CalculadoraRest.Model.Context;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CalculadoraRest.Services.Implementations
{
    public class PersonServiceImpl : IPersonService
    {

        private MySqlContext _context;

        public PersonServiceImpl(MySqlContext context)
        {
            _context = context;
        }

        public Person Create(Person person)
        {
            try
            {
                _context.Add(person);
                _context.SaveChanges();

            }
            catch (Exception e)
            {
                throw e;
            }
            return person;
        }

        public void Delete(int id)
        {
            Person person = _context.Person.Find(id);
            _context.Remove(person);
            _context.SaveChanges();
        }

        public List<Person> FindAll()
        {
            return _context.Person.ToList();
        }

        public Person FindById(int id)
        {
            return _context.Person.SingleOrDefault(p => p.Id == id);
        }

        public Person Update(Person person)
        {
            bool exist = _context.Person.Any(p => p.Id == person.Id);
            try
            {
                if (!exist) return new Person();

                _context.Update(person);
                _context.SaveChanges();

            }catch(Exception e)
            {
                throw e;
            }
            return person;
        }
    }
}
