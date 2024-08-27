namespace BlazorInWinForms.Services;

internal class PersonService : IPersonService
{
    private readonly IList<Person> _persons = new List<Person>
    {
        new Person(1, "John", "Doe", "Business Analyst"),
        new Person(3, "Sabrina", "Miller", "Product Manager"),
        new Person(16, "Claudio", "Bernasconi", "Software Engineer")
    };

    public Person GetPerson(int personId)
    {
        return _persons.Single(p => p.PersonId == personId);
    }
}
