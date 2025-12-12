     void SayHello(string name)
    {
        Console.WriteLine($"Hello, {name}!");
    }

 
      
        Console.WriteLine("## Exercise 1");
        Console.WriteLine("Welcome to C# Programming!");
        Console.WriteLine("\n");


       
        Console.WriteLine("## Exercise 2");
        string name = "ayat mohamed"; 
        int age = 21;           

        Console.WriteLine($"My name is {name} and I am {age} years old.");
        Console.WriteLine("\n"); 


        Console.WriteLine("## Exercise 3");
        int num1 = 45;
        int num2 = 12;

        int sum = num1 + num2;

        Console.WriteLine($"The result of {num1} + {num2} is: {sum}");
        Console.WriteLine("\n");


     
        Console.WriteLine("## Exercise 4");
        
        int userAge =15;

        if (userAge >= 18)
        {
            Console.WriteLine("access granted");
        }
        else 
        {
            Console.WriteLine("access denied");
        }
        Console.WriteLine("\n");


    
        Console.WriteLine("#ex 5");
        int counter =10;
        while (counter >=1)

            {
                Console.WriteLine(counter);
                counter--;
            }
    
                Console.WriteLine("Liftoff!!");
                Console.WriteLine("\n");


            Console.WriteLine("ex 6");
            SayHello ("ayat");
            SayHello ("mohamed");
            SayHello ("miliodas");
            

          Console.WriteLine("ex 7");
            for (int i=1 ; i<=10 ; i++)
        {
            if (i % 2 == 0)
            {
                Console.WriteLine($"{i} is even");
            }
            else
            {
                Console.WriteLine($"{i} is odd");
            }
        }

Console.WriteLine("Ex 8");
Console.Write("Enter temperature in Celsius: ");

double celsius = double.Parse(Console.ReadLine());
double fahrenheit = celsius * 9.0 / 5.0 + 32;

Console.WriteLine($"{celsius}°C = {fahrenheit}°F");
Console.WriteLine();



Console.WriteLine("Ex 9");

int a = 10;
int b = 20;

Console.WriteLine($"Before swap: a = {a}, b = {b}");

int temp = a;
a = b;
b = temp;

Console.WriteLine($"After swap: a = {a}, b = {b}");
Console.WriteLine();


Console.WriteLine("Ex 10");

Console.Write("Enter a number: ");

int number = int.Parse(Console.ReadLine());

for (int i = 1; i <= 10; i++)
{
    Console.WriteLine($"{number} x {i} = {number * i}");
}
Console.WriteLine();
