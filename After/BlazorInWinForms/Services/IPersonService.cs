namespace BlazorInWinForms.Services;

internal interface IPersonService
{
    Person GetPerson(int personId);
}

public record Person(int PersonId, string FirstName, string LastName, string Role);
