namespace SalesKingAuto; 

public class Store : ListTransaction< Car > {
    public Store() {
        Inventory = new List< Car >();
    }

    public List< Car > Inventory { get; }

    /// <summary>
    /// Adds a car to the store
    /// </summary>
    /// <param name="car"></param>
    /// <exception cref="ArgumentException">If the <see cref="Car"/> already exists</exception>
    public override void Add(Car car) {
        Inventory.ForEach(c => {
            if (c.Equals(car)) throw new ArgumentException("Car already exists in inventory");
        });
        Inventory.Add(car);
    }

    /// <summary>
    /// Removes a car from the store
    /// </summary>
    /// <param name="car"></param>
    /// <exception cref="ArgumentException">If the car is not present</exception>
    public override void Remove(Car car) {
        if (!Inventory.Remove(car)) throw new ArgumentException("Cart not found");
    }

    /// <summary>
    /// Updates the price of a car
    /// </summary>
    /// <param name="car"></param>
    /// <param name="newPrice"></param>
    /// <exception cref="ArgumentException">If the car is not present</exception>
    public void UpdatePrice(Car car, decimal newPrice) {
        int index = Inventory.IndexOf(car);
        if (index == -1) throw new ArgumentException("Cart not found");
        Inventory[ index ] = car with { Price = newPrice };
    }

    /// <summary>
    /// Updates the Make of a car
    /// </summary>
    /// <param name="car"></param>
    /// <param name="newMake"></param>
    /// <exception cref="ArgumentException">If the car is not present</exception>
    public void UpdateMake(Car car, string newMake) {
        int index = Inventory.IndexOf(car);
        if (index == -1) throw new ArgumentException("Cart not found");
        Inventory[ index ] = car with { Make = newMake };
    }

    /// <summary>
    /// Updates the Model of a car
    /// </summary>
    /// <param name="car"></param>
    /// <param name="newModel"></param>
    /// <exception cref="ArgumentException">If the car is not present</exception>
    public void UpdateModel(Car car, string newModel) {
        int index = Inventory.IndexOf(car);
        if (index == -1) throw new ArgumentException("Cart not found");
        Inventory[ index ] = car with { Model = newModel };
    }

    /// <summary>
    /// Get a car by inventory index
    /// </summary>
    /// <param name="index"></param>
    /// <returns></returns>
    public Car GetCarByIndex(int index) {
        return Inventory[ index ];
    }

    /// <summary>
    /// Returns entire inventory
    /// </summary>
    /// <returns>The entire Inventory in a <see cref="string"/> array</returns>
    public string[] GetInventory() {
        return Inventory.Select(c => c.ToString()).ToArray();
    }
}