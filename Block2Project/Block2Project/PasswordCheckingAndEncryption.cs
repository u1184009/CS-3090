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
    char[] specialChars = ['!','@', '#','$','%','&','*'];
    
    
    public static void Main()
    {
        string? input = "";

        while (input == "")
        {
            Console.WriteLine("Enter your password");
            Console.WriteLine("Requirements: Password must contain valid special characters (!,@, #,$,%,&,*), contain a upper and lower case letter, and a number.");
            Console.WriteLine(); // Break point for spacing
            input = Console.ReadLine();
        }

        


    }
}

