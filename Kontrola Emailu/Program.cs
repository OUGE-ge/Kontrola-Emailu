Console.WriteLine("Napište email: ");
string email = Console.ReadLine();
string trim = email.Trim();
if (email.Contains("@") && email.EndsWith(".cz"))
{
    Console.WriteLine($"Váš email je dlouhý {trim.Length} znaků");
}
else if (email.Contains("@") && email.EndsWith(".sk"))
{
    Console.WriteLine($"Váš email je dlhý {trim.Length} znaků.");
}
else if (email.Contains("@") && email.EndsWith(".com"))
{
    Console.WriteLine($"Your email is {trim.Length} characters long. ");
}
else
{
    Console.WriteLine("Toto není platný email");
}
