public class User
{
    public string Username { get; set; }
    public string Password { get; set; }
    public string FullName { get; set; }
    public string Email { get; set; }
    public int Age { get; set; }
    public string PhoneNumber { get; set; }
    public string Address { get; set; }
    public Role UserRole { get; set; }

    public User(
        string username, 
        string password, 
        string fullName, 
        string email, 
        int age, 
        string phoneNumber,
        string address,
        Role userRole)
    {
        Username = username;
        Password = password;
        FullName = fullName;
        Email = email;
        Age = age;
        PhoneNumber = phoneNumber;
        Address = address;
        UserRole = userRole;
    }
    
}

public enum Role
{
    Admin,
    User
}