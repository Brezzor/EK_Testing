using System.Text.RegularExpressions;

namespace PasswordCheckerService;

public class PasswordChecker
{
    public bool CheckPassword(string password)
    {
        Regex validateRegex = new Regex("^(?=.*?[A-z]).{5,10}$");

        try
        {
            return validateRegex.Match(password).Success;
        }
        catch (Exception)
        {
            return false;
        }
    }
}
