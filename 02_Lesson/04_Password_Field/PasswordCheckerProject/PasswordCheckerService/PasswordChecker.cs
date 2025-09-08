namespace PasswordCheckerService;

public class PasswordChecker
{
    public void CheckPassword(string password)
    {
        if (string.IsNullOrEmpty(password))
        {
            throw new ArgumentException("Password cannot be null or empty.");
        }
        else if (password.Length < 5)
        {
            throw new ArgumentException("Password must be at least 5 characters long.");
        }
        else if (password.Length > 10)
        {
            throw new ArgumentException("Password cannot be more than 10 characters long.");
        }
    }
}
