using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex5
{
    internal class Hotel
    {
        private List<Person> _people;

        public List<Person> People
        {
            get { return _people; }
            set { _people = value; }
        }
        public Hotel()
        {
            People = new List<Person>();
        }
        public void AddPerson(Person person)
        {
            People.Add(person);
        }
        public void RemovePerson(Person person)
        {
            People.Remove(person);
        }
        public float RentAmount(string citizenID)
        {
            Person person = People.Find(p => p.CitizenId.ToLower().Equals(citizenID.ToLower()));
            if (person == null) { return 0; }
            return person.Room.Price * person.NumberOfDay;
        }
    }
}
