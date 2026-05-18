namespace ChapterTwo;

class Program
{
    static void Main(string[] args)
    {
      // 2. Integer - a whole number, no decimals
int age = 29;
Console.WriteLine("Age: " + age);

// 3. Double - a floating-point number for scientific/statistical calculations
double accountBalance = 15_247.83;
Console.WriteLine("Balance: " + accountBalance);

// 4. Decimal - the type you MUST use for money in enterprise applications
decimal preciseBalance = 15_247.83m;
Console.WriteLine("Precise Balance: " + preciseBalance);

// 5. Boolean - true or false, nothing else
bool isActive = true;

Console.WriteLine("Account Active: " + isActive);

// This is illegal and will cause a compile-time error
    }
}
