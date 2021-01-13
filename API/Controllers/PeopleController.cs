using API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace API.Controllers
{
    public class PeopleController : ApiController
    {
        private List<Person> _people = new List<Person>
        {
             new Person
             {
                 ID = 0,
                 FirstName = "John",
                 LastName = "Smith"
             },
             new Person
             {
                 ID = 1,
                 FirstName = "Dmitriy",
                 LastName = "Amerados"
             },
             new Person
             {
                 ID = 2,
                 FirstName = "William",
                 LastName = "Shakespear"
             },
             new Person
             {
                 ID = 3,
                 FirstName = "John",
                 LastName = "Williamed"
             },
             new Person
             {
                 ID = 4,
                 FirstName = "Will",
                 LastName = "Smith"
             },
        };

        [Route("api/people/firstnames")]
        [HttpGet]
        public List<string> FirstNames()
        {
            return _people.Select(p => p.FirstName).ToList();
        }

        [Route("api/people/firstnames/{id}")]
        [HttpGet]
        public string FirstNames(int id)
        {
            return _people.Where(p => p.ID == id).FirstOrDefault().FirstName;
        }

        // GET: api/People
        public IEnumerable<Person> Get()
        {
            return _people;
        }

        // GET: api/People/5
        public Person Get(int id)
        {
            return _people.Where(p => p.ID == id).FirstOrDefault();
        }

        // POST: api/People
        public void Post(Person person)
        {
            _people.Add(person);
        }

        // DELETE: api/People/5
        public void Delete(int id)
        {
            _people.RemoveAt(id);
        }
    }
}
