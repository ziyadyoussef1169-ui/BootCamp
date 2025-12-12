Console.WriteLine("Challenge 1: Multiples List Generator");

Console.Write("Enter a number: ");
int number = int.Parse(Console.ReadLine());

Console.Write("Enter the length: ");
int length = int.Parse(Console.ReadLine());

List<int> multiples = new List<int>();

for (int i = 1; i <= length; i++)
{
    multiples.Add(number * i);
}

Console.WriteLine("Result:");
Console.WriteLine(string.Join(", ", multiples));



Console.WriteLine("challenge 2: Remove Consecutive Duplicates");
Console.Write("Enter a string: ");
string input = Console.ReadLine();

string result = "";

for (int i = 0; i < input.Length; i++)
{
    if (i == 0 || input[i] != input[i - 1])
    {
        result += input[i];
    }
}

Console.WriteLine("Result:");
Console.WriteLine(result);
