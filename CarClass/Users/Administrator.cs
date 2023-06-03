using SalesKingAuto.Roles;

namespace SalesKingAuto.Users; 

public class Administrator : User {
    /// <inheritdoc />
    public Administrator(string username, long id, string emailAddress, string address, string city, string state,
        string zipCode, string password, string firstName, string lastName, string phoneNumber) : base(username, id,
        emailAddress, address, city, state, zipCode, password, firstName, lastName, phoneNumber,
        new AdministratorRole()) { }

    public void UpdateUserRole(string password, string targetUsername, IUserRole role) {
        // Todo: Implement User Database
    }
}