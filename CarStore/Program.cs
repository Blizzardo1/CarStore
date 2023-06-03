using System.Security;
using SalesKingAuto;
using SalesKingAuto.Users;

namespace CarStore; 

internal static class Program {
    private static Store? _store;

    private static readonly Dictionary< string, Action > MenuActions = new() {
        { "Exit", Die },
        { "Add Cart", AddCar },
        { "Remove Cart", RemoveCar },
        { "Print Inventory", () => GetInventory() },
        { "Checkout", Checkout }
    };

    private static Administrator Admin => new("Administrator", 1, "admin@admin.com", "123 Address", "Adminville",
        "Administan", "12345", "8be3c943b1609fffbfc51aad666d0a04adf83c9d", "Admin", "Istrator",
        "+1 (949) 555-1234");

    /// <summary>
    /// Kills the program
    /// </summary>
    private static void Die() {
        try {
            Admin.Logout();
        }
        catch (Exception) {
            // Do Nothing and just die.
        }

        Environment.Exit(0);
    }

    /// <summary>
    /// Prompts for information
    /// </summary>
    /// <typeparam name="T">Constrained to <see cref="Enum"/>.</typeparam>
    /// <param name="description">The description</param>
    /// <returns>A <see cref="T"/> object that can be safely cast</returns>
    private static T Prompt< T >(string description) where T : Enum {
        Console.WriteLine($"What's the {description}?");
        string[] arr = Enum.GetNames(typeof(T));
        for (int i = 0; i < arr.Length; i++) Console.WriteLine($"{i}) {arr[ i ]}");
        Console.Write($"Select {description} by Number> ");
        int a = int.Parse(Console.ReadLine()!);
        return
            (T)Enum.Parse(typeof(T),
                arr[ a ]); // Ugh, the old-fashioned way. Really wanted to Enum.Parse<T>(arr[a]); oh well.
    }

    /// <summary>
    /// Adds a car to the store
    /// </summary>
    private static void AddCar() {
        // Make, Model, Year, Color, TransferCase, Price
        try {
            Console.Write("What's the Make? ");
            string make = Console.ReadLine() ?? "No Make";

            Console.Write("What's the Model? ");
            string model = Console.ReadLine() ?? "No Model";

            Console.Write("What's the Year? ");
            int year = int.Parse(Console.ReadLine()!);

            Console.Write("What's the Color? ");
            string color = Console.ReadLine() ?? "No Color";

            var transferCase = Prompt< TransferCase >("Transfer Case");

            var condition = Prompt< Condition >("Condition");

            var engine = Prompt< EngineSize >("Engine Size");

            Console.Write("What's the Price? ");
            decimal price = decimal.Parse(Console.ReadLine()!);

            Car car = new(make, model, year, color, transferCase, price, condition, engine);
            _store!.Add(car);
        }
        catch (Exception ex) {
            Console.WriteLine($"Failed to add car. {ex.Message}\n");
        }
    }

    /// <summary>
    /// Finds a car by Index
    /// </summary>
    /// <param name="prompt">The prompt to help the user select.</param>
    /// <returns>A Car if found</returns>
    private static Car? ChooseCar(string prompt) {
        Console.Write(prompt);
        int result = int.Parse(Console.ReadLine()!);
        try {
            return _store!.GetCarByIndex(result - 1);
        }
        catch (Exception) {
            Console.WriteLine("Not a valid selection.");
        }

        return null;
    }

    /// <summary>
    /// Removes a car from the store
    /// </summary>
    private static void RemoveCar() {
        if (!GetInventory()) return;

        Car? c = ChooseCar("Which car would you like to remove? ");
        if (c is null) return;

        _store!.Remove(c);
    }

    /// <summary>
    /// Gets the inventory
    /// </summary>
    /// <returns>True if there are cars in the store.</returns>
    private static bool GetInventory() {
        string[] a = _store!.GetInventory();

        if (a.Length == 0) {
            Console.WriteLine("There are no cars available.\n\n");
            return false;
        }

        for (int i = 0; i < a.Length; i++) Console.WriteLine($"{i + 1}) {a[ i ]}");

        Console.WriteLine();
        return true;
    }

    /// <summary>
    /// Checks out the customer to remit payment
    /// </summary>
    private static void Checkout() {
        Order o = new() {
            Tax = 0.08m
        };

        char response = 'y';
        while (char.ToLower(response) == 'y') {
            if (!GetInventory()) return;
            Car? c = ChooseCar("Which car would you like to buy? ");
            o.Add(c!);
            byq:
            Console.Write("Would you like to add another car? [y/n]");
            response = Console.ReadKey(false).KeyChar;
            Console.WriteLine();
            if (response is not ('y' or 'n')) {
                Console.WriteLine("Invalid Selection.\n");
                goto byq;
            }
        }

        Console.WriteLine("Order Summary:");
        o.Cart.ForEach(c => Console.WriteLine(c.ToString()));
        Console.WriteLine();
        Console.WriteLine($"Order Subtotal: {o.Subtotal:C}");
        Console.WriteLine($"Order Tax: {o.Tax:P}");
        Console.WriteLine(new string('-', 32));
        Console.WriteLine($"Order Total: {o.Total:C}");

        o.CompleteOrder();
        Console.WriteLine("Order Complete!");
    }

    /// <summary>
    /// The main Menu
    /// </summary>
    private static void DisplayMenu() {
        while (true)
            try {
                int i = 0;
                foreach (( string? key, _ ) in MenuActions) Console.WriteLine($"{i++}) {key}");

                Console.Write("Enter a number: ");
                string input = Console.ReadLine() ?? "";

                if (!int.TryParse(input, out int choice) || choice > MenuActions.Count || choice < 0) {
                    Console.WriteLine("Invalid choice\n");
                    continue;
                }

                MenuActions.ElementAt(choice).Value.Invoke();
            }
            catch (Exception) {
                Console.WriteLine("Invalid menu selection.\n");
            }
        // ReSharper disable once FunctionNeverReturns
    }

    /// <summary>
    /// Login Prompt
    /// </summary>
    private static void Login() {
        while (true)
            try {
                Console.Write("Username: ");
                string username = "Administrator";
                Console.WriteLine(username);

                Console.Write("Password: ");
                string password = "Password".ToSha1();
                Console.WriteLine(password.Mask('*'));
                if (password == string.Empty) throw new SecurityException("Invalid password");

                Console.WriteLine("\n\n");

                if (!Admin.Login(password)) throw new SecurityException("Invalid username or password");
                Console.WriteLine($"Welcome, {Admin.Username}!");
                break;
            }
            catch (SecurityException se) {
                Console.WriteLine(se.Message);
            }
    }

    /// <summary>
    /// The main entry point for the application.
    /// </summary>
    /// <param name="args"></param>
    private static void Main(string[] args) {
        Console.Title = "Sales King Automotive Terminal";
        Console.WriteLine("Welcome to Sales King Auto Store backend service!\n");
        Console.WriteLine("This service requires a login. Please login below.\n\n");

        Login();

        _store = new Store();
        BuildSampleInventory();
        DisplayMenu();
    }

    /// <summary>
    /// Builds a sample inventory
    /// </summary>
    private static void BuildSampleInventory() {
        _store!.Add(new Car("Toyota", "Tacoma", 2024, "Blue", TransferCase.FourWheelDrive, 50000,
            Engine: EngineSize.V6));
        _store.Add(new Car("Toyota", "Tacoma", 2024, "Red", TransferCase.TwoWheelDrive, 30000,
            Engine: EngineSize.V6));
        _store.Add(new Car("Toyota", "Tacoma", 2024, "Red", TransferCase.FourWheelDrive, 50000,
            Engine: EngineSize.V6));
        _store.Add(new Car("Toyota", "Tacoma", 2024, "Green", TransferCase.TwoWheelDrive, 30000,
            Engine: EngineSize.V6));
        _store.Add(new Car("Toyota", "Tacoma", 2024, "Green", TransferCase.FourWheelDrive, 50000,
            Engine: EngineSize.V6));
        _store.Add(new Car("Toyota", "Tacoma", 2024, "Black", TransferCase.FourWheelDrive, 50000,
            Engine: EngineSize.V6));
        _store.Add(new Car("Toyota", "Tacoma", 2024, "White", TransferCase.FourWheelDrive, 50000,
            Engine: EngineSize.V6));
    }
}