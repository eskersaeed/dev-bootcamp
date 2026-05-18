namespace ChapterThree;

class Program
{
    static void Main(string[] args)
    {
       Console.WriteLine("--- Logical Operators ---");

bool isEmployed = true;
bool hasGoodCredit = false;

// AND (&&): BOTH conditions must be true
bool loanApproved = isEmployed && hasGoodCredit;
Console.WriteLine("Loan Approved (AND): " + loanApproved);

// OR (||): AT LEAST ONE condition must be true
bool provisionalApproval = isEmployed || hasGoodCredit;
Console.WriteLine("Provisional Approval (OR): " + provisionalApproval);

// NOT (!): Negates the boolean value
bool isUnemployed = !isEmployed;
Console.WriteLine("Is Unemployed (NOT): " + isUnemployed); 
    }
}
