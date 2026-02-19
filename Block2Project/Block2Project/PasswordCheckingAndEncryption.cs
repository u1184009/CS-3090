namespace Block2Project;
/*
 * Simple Program to take in password, check, and encrypt it
 *
 * By Mike Pham
 *
 * 2026-19-2
 */
public class PasswordCheckingAndEncryption
{
    /**
     * Returns if it contains valid special characters (!,@, #,$,%,&,*), if it doesn't or contains a space, return false.
     * 
     * @param password - string input to check
     * @return boolean - true if contains valid special character, false otherwise
     */
    private static bool containsSpecialChar(string password)
    {
        char[] specialChars = ['!','@', '#','$','%','&','*'];
        foreach(char character in password)
        {
            if (specialChars.Contains(character))
            {
                return true;
            }

            if (character is ' ')
            {
                Console.WriteLine("Password cannot have spaces");
                return false;
            }
        }
        Console.WriteLine("Password must have special characters");
        return false;
    }

    /**
     * Checks input for numbers.
     * 
     * @param: password - string input to check
     * @return boolean - true if contains number, false other wise
     */
    private static bool containsNumber(string password)
    {
        foreach (char character in password)
        {
            if (char.IsDigit(character))
            {
                return true;
            }
        }
        
        Console.WriteLine("Password must have numbers");
        return false;
    }

    /**
     * Check input for upper and lower case letters.
     * 
      * @param: password - string input to check
      * @return boolean - true if contains both an upper and lower case, false otherwise
      */
    private static bool containsUpperAndLowercase(string password)
    {
        bool upper = false;
        bool lower = false;

        foreach (char character in password)
        {
            if (char.IsLetter(character))
            {
                if (char.IsUpper(character))
                {
                    upper = true;
                }

                if (char.IsLower(character))
                {
                    lower = true;
                }
            }

            if (upper && lower)
            {
                return true;
            }
        }
        Console.WriteLine("Password must include both an upper and lowercase letters");
        return false;

    }

    /**
     * Checks length of input.
     * 
      * @param: password - string input to check
      * @return boolean - true if length is greater than 5, false other wise
      */
    private static bool lengthCheck(string password)
    {
        return password.Length > 5;
    }

    /**
     * Encrypts password
     * 
      * @param: password - string input to check
      * @return  -
      */
    private static string encryptPassword(string password)
    {
        string encryptedPassword = "";
        for(int i = password.Length-1; i >= 0;i--) // Reverse
        {
            encryptedPassword += (int)password[i] + 76; // take in ASCII value + an arbitrary value: 76
            if (i != 0)
            {
                encryptedPassword += " ";
            }
        }

        return encryptedPassword;
    }
    
    /**
     * Main
     */
    public static void Main()
    {
        string input = "";
        Console.WriteLine("Enter your password");
        Console.WriteLine("Requirements: Password must contain valid special characters (!,@, #,$,%,&,*), contain a upper and lower case letter, a number, be at least 5 characters long. No spaces");
        Console.WriteLine();
        // Break point for spacing
        while (input == "" || input?.Length < 5)
        {
            // Break point for spacing
            input = Console.ReadLine();

            if (input == ""|| input?.Length < 5)
            {
                Console.WriteLine("Enter a valid password");
                Console.WriteLine(); 
            }
        }
        
        Console.WriteLine("Password Entered:  " + input);

        // If false, will print message to make password stronger
        int strength = 0;

        if (containsNumber(input))
        {
            strength++;
        }

        if (containsUpperAndLowercase(input))
        {
            strength++;
        }

        if (lengthCheck(input))
        {
            strength++;
        }

        if (containsSpecialChar(input))
        {
            strength++;
        }
        
        // Strength is printed out
        if (strength == 4)
        {
            Console.WriteLine("Password is strong");
        }
        else if (strength > 1)
        {
            Console.WriteLine("Password is okay");
        }
        else
        {
            Console.WriteLine("Password is weak");
        }
        
        Console.WriteLine("Encryption: "+encryptPassword(input));

    }
}

