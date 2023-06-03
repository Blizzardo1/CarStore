using SalesKingAuto;

namespace CarApp; 

public partial class Form1 : Form {
    private readonly BindingSource _inventoryBindingSource;
    private readonly BindingSource _ordersBindingSource;
    private readonly Store _store;

    private readonly Order _order;
    private readonly List< Order > _orders;

    public Form1() {
        InitializeComponent();
        _orders = new List< Order >();
        _store = new Store();
        _order = new Order();
        _inventoryBindingSource = new BindingSource();
        _ordersBindingSource = new BindingSource();
        SetBindings();
        transferCaseCbx.DataSource = Enum.GetValues(typeof(TransferCase));
        engineSizeCbx.DataSource = Enum.GetValues(typeof(EngineSize));
        conditionCbx.DataSource = Enum.GetValues(typeof(Condition));
        UpdateTotals();
    }

    /// <summary>
    /// Creates bindings for the Store's inventory and the Order sheet
    /// </summary>
    private void SetBindings() {
        _inventoryBindingSource.DataSource = _store.Inventory;
        _ordersBindingSource.DataSource = _order.Cart;

        inventoryLst.DataSource = _inventoryBindingSource;
        inventoryLst.DisplayMember = "Display";

        shoppingLst.DataSource = _ordersBindingSource;
        shoppingLst.DisplayMember = "Display";
    }

    /// <summary>
    /// Adds a car to the store
    /// </summary>
    /// <param name="car">Your brand new <see cref="Car"/>!</param>
    private void AddCar(Car car) {
        _store.Add(car);
        _inventoryBindingSource.ResetBindings(false);
    }

    /// <summary>
    /// Removes a car from the store
    /// </summary>
    /// <param name="car">The <see cref="Car"/>to remove from inventory</param>
    private void RemoveCar(Car car) {
        _store.Remove(car);
        _inventoryBindingSource.ResetBindings(false);
    }

    /// <summary>
    /// Adds a car to the order
    /// </summary>
    /// <param name="car">The <see cref="Car"/> to add</param>
    private void AddToOrder(Car car) {
        _order.Add(car);
        _ordersBindingSource.ResetBindings(false);
        UpdateTotals();
    }

    /// <summary>
    /// Removes a car from the order
    /// </summary>
    /// <param name="car">The <see cref="Car"/> to remove</param>
    private void RemoveFromOrder(Car car) {
        _order.Remove(car);
        _ordersBindingSource.ResetBindings(false);
        UpdateTotals();
    }

    /// <summary>
    /// Clears the entire order and updates the totals
    /// </summary>
    private void ClearOrder() {
        _order.Clear();
        _ordersBindingSource.ResetBindings(false);
        UpdateTotals();
    }

    /// <summary>
    /// Updates the totals of the order
    /// </summary>
    private void UpdateTotals() {
        _order.Tax = 0.0875m;
        groupBox3.Text = $"Order: {_order.OrderID:G}";
        subtotalLbl.Text = $"{_order.Subtotal:C}";
        taxLbl.Text = $"{_order.Tax:P}";
        totalLbl.Text = $"{_order.Total:C}";
    }

    private void addCarBtn_Click(object sender, EventArgs e) {
        try {
            AddCar(new Car(makeTxt.Text, modelTxt.Text, (int)yearNud.Value, colorTxt.Text,
                (TransferCase)transferCaseCbx.SelectedItem, priceNud.Value, (Condition)conditionCbx.SelectedItem,
                (EngineSize)engineSizeCbx.SelectedItem));
            ClearForm(); // Only on success do we clear the form.
        }
        catch (Exception ex) {
            MessageBox.Show(this, ex.Message, null, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    /// <summary>
    /// Clears the form
    /// </summary>
    private void ClearForm() {
        makeTxt.Clear();
        modelTxt.Clear();
        yearNud.Value = 2024;
        colorTxt.Clear();
        transferCaseCbx.SelectedIndex = 0;
        priceNud.Value = 0;
        conditionCbx.SelectedIndex = 0;
        engineSizeCbx.SelectedIndex = 0;
    }

    private void removeCarBtn_Click(object sender, EventArgs e) {
        if (inventoryLst.SelectedItem is Car car) RemoveCar(car);
    }

    private void removeShoppingBtn_Click(object sender, EventArgs e) {
        if (shoppingLst.SelectedItem is Car car) RemoveFromOrder(car);
    }

    private void addShoppingBtn_Click(object sender, EventArgs e) {
        if (inventoryLst.SelectedItem is Car car) AddToOrder(car);
    }

    private void checkoutBtn_Click(object sender, EventArgs e) {
        if (shoppingLst.Items.Count == 0) {
            MessageBox.Show(this, @"Please add items to your cart.", @"Empty Cart", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
            return;
        }

        _order.CompleteOrder();
        MessageBox.Show(this,
            $"Thank you for shopping Sales King Automotive!\nYour expected Delivery Date is {_order.DeliveryDate}",
            "Thank You!", MessageBoxButtons.OK,
            MessageBoxIcon.Information);
        _orders.Add((Order)_order.Clone());
        ClearOrder();
    }
}