// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

int number;
var isNumber = false;
Console.Write("Enter evaluation number: ");
do
{
    isNumber = int.TryParse(Console.ReadLine(), out number);
    if (!isNumber && number < 0 && ((number % 1) > 0) && number>1000000000)
    {
        Console.WriteLine("Make sure you've entered a whole number that is also greater than zero", number);
    }
} while (!isNumber);

Console.WriteLine(evaluateX(number));


int evaluateX(int n)
{
    var numbersTaken = new List<int>();
    var result = 1;
    int i = 0;
    while (numbersTaken.Count() <= n)
    {
        result += i;
        if(!numbersTaken.Any(x => x == result))
        {
            numbersTaken.Add(result);
        }
        i++;
    }
    return numbersTaken.LastOrDefault();
}