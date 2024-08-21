using ClassLibrary2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary2.Resources
{
	public class PersonResource : IPersonResource
	{
		private List<PersonModel> people = new();

		public PersonResource()
		{
			people.Add(new PersonModel { Id = 1, Name = "Yuliia" });
			people.Add(new PersonModel { Id = 2, Name = "vvvv" });
		}

		public List<PersonModel> GetPeople()
		{
			return people;
		}

		public PersonModel InsertPerson(string name)
		{
			PersonModel person = new() { Name = name };
			person.Id = people.Max(x=>x.Id) + 1;
			people.Add(person);
			return person;
		}
	}
}
