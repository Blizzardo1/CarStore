namespace SalesKingAuto; 

public class Order : ListTransaction< Car >, ICloneable {
    private static ulong _nextId = 1;
    private DateTime _orderCompletedDate;

    public Order() {
        Cart = new List< Car >();
        GenerateOrderId();
    }

    /// <summary>
    /// The unique identifier for the order
    /// </summary>
    public ulong OrderID { get; private set; }

    /// <summary>
    /// The initial date the order was placed
    /// </summary>
    public DateTime OrderDate { get; private set; }

    /// <summary>
    /// The Cart containing cars.
    /// </summary>
    public List< Car > Cart { get; private set; }

    /// <summary>
    /// Whether or not the Order is finalized.
    /// Finalized orders are immutable.
    /// </summary>
    public bool Finalized { get; private set; }

    /// <summary>
    /// The expected delivery date
    /// </summary>
    public DateTime DeliveryDate { get; private set; }

    /// <summary>
    /// The completion date of the order
    /// </summary>
    public DateTime OrderCompletedDate => _orderCompletedDate;
    
    /// <summary>
    /// Whether or not it's been delivered
    /// </summary>
    public bool Delivered { get; private set; }

    /// <summary>
    /// The subtotal of the order
    /// </summary>
    public decimal Subtotal
    {
        get
        {
            decimal res = 0m;
            Cart.ForEach(c => res += c.Price);
            return res;
        }
    }

    /// <summary>
    /// The percentage of tax applied to the order
    /// </summary>
    public decimal Tax { get; set; }

    /// <summary>
    /// Subtotal and Tax added together.
    /// </summary>
    public decimal Total => Subtotal * ( 1 + Tax );

    #region ICloneable Members

    #region Implementation of ICloneable

    /// <inheritdoc />
    public object Clone() {
        var order = new Order {
            OrderID = OrderID,
            OrderDate = OrderDate,
            DeliveryDate = DeliveryDate,
            _orderCompletedDate = _orderCompletedDate,
            Cart = new List< Car >(Cart),
            Tax = Tax,
            Finalized = Finalized,
            Delivered = Delivered
        };
        return order;
    }

    #endregion

    #endregion

    private void GenerateOrderId() {
        OrderDate = DateTime.Now;
        OrderID = OrderDate.Pack() + _nextId++;
    }

    public static Order GetOrderById(long id) {
        var order = new Order();

        // Look into repo and find order by ID

        return order;
    }

    public static Order[] GetOrdersByUsername(string username) {
        List< Order > orders = new();
        // Look into repo and find order by username

        // If there is no order history for this username, return an empty array

        return orders.ToArray();
    }

    public void CompleteOrder() {
        _orderCompletedDate = DateTime.Now;
        DeliveryDate = _orderCompletedDate.AddDays(21);
        Finalized = true;
    }

    public void Clear() {
        Cart.Clear();
        Finalized = false;
        _orderCompletedDate = DateTime.MinValue;
        DeliveryDate = DateTime.MinValue;
        GenerateOrderId();
    }

    #region Overrides of ListTransaction<Cart>

    /// <inheritdoc />
    public override void Add(Car car) {
        if (!Finalized)
            Cart.Add(car);
    }

    /// <inheritdoc />
    public override void Remove(Car car) {
        if (!Finalized)
            Cart.Remove(car);
    }

    #endregion
}