namespace ChapterFour;

class Program
{
    static void Main(string[] args)
    {
      Console.WriteLine("\n--- Processing a Loan Portfolio ---");

decimal[] loanAmounts = { 250_000m, 180_000m, 420_000m, 95_000m, 310_000m };
decimal totalPortfolioValue = 0m;

for (int i = 0; i < loanAmounts.Length; i++)
{
    decimal currentLoan = loanAmounts[i];
    totalPortfolioValue += currentLoan;
    Console.WriteLine("Loan #" + (i + 1) + ": $" + currentLoan);
}

Console.WriteLine("Total portfolio value: $" + totalPortfolioValue);

    }
}
