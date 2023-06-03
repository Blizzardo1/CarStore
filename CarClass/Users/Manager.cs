using SalesKingAuto.Roles;

namespace SalesKingAuto.Users; 

public class Manager : User {
    /// <inheritdoc />
    public Manager(string username, long id, string emailAddress, string address, string city, string state,
        string zipCode, string password, string firstName, string lastName, string phoneNumber) : base(username, id,
        emailAddress, address, city, state, zipCode, password, firstName, lastName, phoneNumber,
        new ManagerRole()) { }
}