using System;
using System.Text.RegularExpressions;

public interface IValidator
{
    bool Validate(string input);
}

public class PasswordValidator : IValidator
{
    public bool Validate(string input)
    {
        return input.Length >= 8 && Regex.IsMatch(input, "[A-Z]") && Regex.IsMatch(input, "[0-9]");
    }
}
public class EmailValidator : IValidator
{
    public bool Validate(string input)
    {
        return Regex.IsMatch(input, @"^[^\s@]+@[^\s@]+\.[^\s@]+$");
    }
}
class Program
{
    static void Main()
    {
        IValidator passwordValidator = new PasswordValidator();
        Console.WriteLine($"Password '12345678' valid: {passwordValidator.Validate("12345678")}");
        Console.WriteLine($"Password 'Ghj876KL' valid: {passwordValidator.Validate("Ghj876KL")}");

        IValidator emailValidator = new EmailValidator();
        Console.WriteLine($"Email 'darlin@gmail.com' valid: {emailValidator.Validate("darlin@gmail.com")}");
        Console.WriteLine($"Email 'tot@gmail.com' valid: {emailValidator.Validate("tot@gmail.com")}");
    }
}
