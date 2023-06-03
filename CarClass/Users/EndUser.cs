using SalesKingAuto.Roles;

namespace SalesKingAuto.Users; 

public class EndUser : User {
    private readonly List< Order > _orders;

    private Order? _currentOrder;

    /// <inheritdoc />
    public EndUser(string username, long id, string emailAddress, string address, string city, string state,
        string zipCode, string password, string firstName, string lastName, string phoneNumber) : base(username, id,
        emailAddress, address, city, state, zipCode, password, firstName, lastName, phoneNumber,
        new EndUserRole()) {
        _orders = new List< Order >();
        _currentOrder = null;
    }

    private void LoadOrders() {
        // Todo: Connect Database
    }

    public void AddCarToCart(Car car) {
        if (_currentOrder == null) {
            _currentOrder = new Order();
            _orders.Add(_currentOrder);
        }

        _currentOrder.Add(car);
    }

    public void RemoveCarFromCart(Car car) {
        _currentOrder?.Remove(car);
    }

    public decimal Checkout() {
        // Create a transaction
        // Add cars to transaction
        // Save transaction
        // Clear cart
        if (_currentOrder is null) return 0m;

        decimal total = _currentOrder.Total;
        int index = _orders.IndexOf(_currentOrder);
        _orders[ index ].CompleteOrder();

        _currentOrder = null;
        return total;
    }
}