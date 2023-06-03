using System.Security;
using SalesKingAuto.Roles;

namespace SalesKingAuto.Users; 

public abstract class User {
    private string _password;
    private readonly IUserRole _role;
    private string _token;

    protected User(string username, long id, string emailAddress, string address, string city, string state,
        string zipCode, string password, string firstName, string lastName, string phoneNumber, IUserRole role) {
        Username = username;
        UserId = id;
        EmailAddress = emailAddress;
        Address = address;
        City = city;
        State = state;
        ZipCode = zipCode;
        _password = password;
        FirstName = firstName;
        LastName = lastName;
        PhoneNumber = phoneNumber;
        _role = role;
    }

    public string Username { get; private set; }

    public long UserId { get; }

    public string EmailAddress { get; private set; }

    public string Address { get; private set; }

    public string City { get; private set; }

    public string State { get; private set; }

    public string ZipCode { get; private set; }

    public string FirstName { get; private set; }

    public string LastName { get; private set; }

    public string PhoneNumber { get; private set; }

    public string Role => _role.Role;

    private void ValidateToken() {
        // This is an improper way to check for a token session. This is just for an assignment. 
        if (_token.IsEmpty()) throw new SecurityException("User is not currently logged in");
    }

    public bool Login(string password) {
        if (!_token.IsEmpty()) return true;

        if (password != _password) throw new SecurityException("Invalid password");
        // Generate Session Token
        _token = Nonce.Generate();
        return true;
    }

    public void Logout() {
        ValidateToken();
        _token = string.Empty;
    }

    protected void UpdateUsername(string username, string password) {
        if (password != _password) throw new SecurityException("Invalid password");
        ValidateToken();
        Username = username;
    }

    protected void UpdateEmailAddress(string emailAddress, string password) {
        if (password != _password) throw new SecurityException("Invalid password");
        ValidateToken();
        EmailAddress = emailAddress;
    }

    protected void UpdateAddress(string address, string password) {
        if (password != _password) throw new SecurityException("Invalid password");
        ValidateToken();
        Address = address;
    }

    protected void UpdateCity(string city, string password) {
        if (password != _password) throw new SecurityException("Invalid password");
        ValidateToken();
        City = city;
    }

    protected void UpdateState(string state, string password) {
        if (password != _password) throw new SecurityException("Invalid password");
        ValidateToken();
        State = state;
    }

    protected void UpdateZipCode(string zipCode, string password) {
        if (password != _password) throw new SecurityException("Invalid password");
        ValidateToken();
        ZipCode = zipCode;
    }

    protected void UpdatePassword(string password, string newPassword) {
        if (password != _password) throw new SecurityException("Invalid password");
        ValidateToken();
        _password = newPassword;
    }

    protected void UpdateFirstName(string firstName, string password) {
        if (password != _password) throw new SecurityException("Invalid password");
        ValidateToken();
        FirstName = firstName;
    }

    protected void UpdateLastName(string lastName, string password) {
        if (password != _password) throw new SecurityException("Invalid password");
        ValidateToken();
        LastName = lastName;
    }

    protected void UpdatePhoneNumber(string phoneNumber, string password) {
        if (password != _password) throw new SecurityException("Invalid password");
        ValidateToken();
        PhoneNumber = phoneNumber;
    }
}