  Console.WriteLine("## exercise:FizzBuzz ");

Console.Write("Enter a number between 1 and 100: ");
int num = int.Parse(Console.ReadLine());

if (num % 3 == 0 && num % 5 == 0)
{
    Console.WriteLine("FizzBuzz");
}
else if (num % 3 == 0)
{
    Console.WriteLine("Fizz");
}
else if (num % 5 == 0)
{
    Console.WriteLine("Buzz");
}
else
{
    Console.WriteLine("ereur");
}


 
for (int i = 1; i <= 5; i++)
{
    Console.WriteLine(new string('*', i));
}


Console.WriteLine("Exercise :Reverse a Word ");


Console.Write("Enter a word: ");
string word = Console.ReadLine();

string reversed = "";

foreach (char c in word)
{
    reversed = c + reversed;
}

Console.WriteLine(reversed);
