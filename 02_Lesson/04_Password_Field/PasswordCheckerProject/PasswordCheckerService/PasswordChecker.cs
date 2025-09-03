namespace PasswordCheckerService;

public class PasswordChecker
{
    public void CheckPassword(string password)
    {
        if (string.IsNullOrEmpty(password))
        {
            throw new ArgumentException("Password cannot be null or empty.");
        }
    }
}
