using ClassLibrary2.Models;

namespace ClassLibrary2.Resources
{
	public interface IPersonResource
	{
		List<PersonModel> GetPeople();
		PersonModel InsertPerson(string name);
	}
}