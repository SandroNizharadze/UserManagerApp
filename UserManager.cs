namespace Practice;

public class UserManager
{
    private List<User> users = new List<User>();
    
    public void Start()
    {
        bool running = true;
        while (running)
        {
            Console.WriteLine("Choose an option:");
            Console.WriteLine("1. Register");
            Console.WriteLine("2. Login");
            Console.WriteLine("3. Exit");

            int option = int.Parse(Console.ReadLine());
            
            
            switch (option)
            {
                case 1:
                    Register();
                    break;
                case 2:
                    Login();
                    break;
                case 3:
                    Console.WriteLine("Exiting...");
                    running = false;
                    break;
                default:
                    Console.WriteLine("Invalid input...");
                    break;
            }
        }
    }

    public void Register()
    {
        Console.Write("Enter username: ");
        string username = Console.ReadLine();
        Console.Write("Enter password: ");
        string password = Console.ReadLine();
        Console.Write("Enter full name: ");
        string fullname = Console.ReadLine();
        Console.Write("Enter email: ");
        string email = Console.ReadLine();
        Console.Write("Enter age: ");
        int age = int.Parse(Console.ReadLine());
        Console.Write("Enter phone number: ");
        string phone = Console.ReadLine();
        Console.Write("Enter address: ");
        string address = Console.ReadLine();
        Console.Write("Select a role: \n0. Admin\n1. User\n");
        
        int roleOption = int.Parse(Console.ReadLine());
        Role userRole = (Role)roleOption;
        
        User newUser = new User(username, password, fullname, email, age, phone, address,userRole);
        users.Add(newUser);

        if (roleOption == 1)
        {
            Console.WriteLine("Registered User");
        }
        else
        {
            Console.WriteLine("Registered Admin");
        }

    }

    public void Login()
    {
        Console.Write("Enter username: ");
        string username = Console.ReadLine();
        
        Console.Write("Enter password: ");
        string password = Console.ReadLine();
        
        User foundUser = users.Find(user => user.Username == username && user.Password == password);

        if (foundUser != null)
        {
            if (foundUser.UserRole == Role.Admin)
            {
                DisplayAdminOptions(foundUser);
            }
            else
            {
                DisplayUserInfo(foundUser);
            }
        }
        else
        {
            Console.WriteLine("\nInvalid username or password.\n");
        }
    }

    private void DisplayUserInfo(User user)
    {
        Console.WriteLine("User Information:");
        Console.WriteLine($"Username: {user.Username}");
        Console.WriteLine($"Full Name: {user.FullName}");
        Console.WriteLine($"Email: {user.Email}");
        Console.WriteLine($"Age: {user.Age}");
        Console.WriteLine($"Phone Number: {user.PhoneNumber}");
        Console.WriteLine($"Address: {user.Address}");
        Console.WriteLine($"Role: {user.UserRole}");
        Console.WriteLine();
    }
    private void DisplayAllUsersInfo()
    {
        Console.WriteLine("\nAll Users Information:");
        foreach (User user in users)
        {
            DisplayUserInfo(user);
        }
    }
    private void DisplayAdminOptions(User adminUser)
    {
        bool running = true;
        while (running)
        {
            Console.WriteLine("\nAdmin authenticated successfully.");
        
            Console.WriteLine("1. View your own information");
            Console.WriteLine("2. View all users' information");
            Console.WriteLine("3. Logout");

            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    DisplayUserInfo(adminUser);
                    break;
                case 2:
                    DisplayAllUsersInfo();
                    break;
                case 3:
                    Console.WriteLine("Logging out...");
                    running = false;
                    break;
                default:
                    Console.WriteLine("Invalid option.");
                    break;
            }
        }
    }
    
}