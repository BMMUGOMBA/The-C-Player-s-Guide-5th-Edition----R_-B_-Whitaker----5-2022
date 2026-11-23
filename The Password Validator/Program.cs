namespace The_Password_Validator;


internal class PasswordValidator
{
    public bool IsValid(string password)
    {
        // Rule 1: Check password length
        if (password.Length < 6 || password.Length > 13)
        {
            return false;
        }

        bool hasUppercase = false;
        bool hasLowercase = false;
        bool hasDigit = false;

        // Check every character in the password
        foreach (char character in password)
        {
            // Rule 5: Forbidden characters
            if (character == 'T' || character == '&')
            {
                return false;
            }

            if (char.IsUpper(character))
            {
                hasUppercase = true;
            }

            if (char.IsLower(character))
            {
                hasLowercase = true;
            }

            if (char.IsDigit(character))
            {
                hasDigit = true;
            }
        }

        // All three conditions must be true
        return hasUppercase && hasLowercase && hasDigit;
    }
}


internal class Program
{
    static void Main(string[] args)
    {
        PasswordValidator validator = new PasswordValidator();

        while (true)
        {
            Console.Write("Enter a password: ");

            string password = Console.ReadLine() ?? "";

            bool isValid = validator.IsValid(password);

            if (isValid)
            {
                Console.WriteLine("Password is valid!");
            }
            else
            {
                Console.WriteLine("Password is invalid!");
            }

            Console.WriteLine();
        }
    }
}

