//Exercise 1: Convert Lists into Dictionaries

class Program
{
    static void Main()
    {
        Console.WriteLine("Exercise 1: Convert Lists into Dictionaries");

        List<string> keys = new List<string> { "Ten", "Twenty", "Thirty" };
        List<int> values = new List<int> { 10, 20, 30 };

        Dictionary<string, int> dictionary = keys.Zip(values, (k, v) => new { Key = k, Value = v })
                                                 .ToDictionary(item => item.Key, item => item.Value);

        Console.WriteLine("Dictionary created:");
        Console.Write("{");
        foreach (var s in dictionary)
        {
            
            Console.Write($"\"{s.Key}\", {s.Value} ");
            
        }
        Console.Write("}");
    }
}

// //Exercise 2: Cinemax #2
// class CinemaxSimple
// {
//     static void Main()
//     {
//         Dictionary<string, int> family = new Dictionary<string, int>
//         {
//             {"rick", 43}, {"beth", 13}, {"morty", 5}, {"summer", 8}
//         };

//         int totalCost = 0;

//         foreach (var member in family)
//         {
//             string name = member.Key;
//             int age = member.Value;
//             int price;

//             if (age < 3)
//             {
//                 price = 0;
//             }
//             else if (age <= 12)
//             {
//                 price = 10;
//             }
//             else
//             {
//                 price = 15;
//             }

//             totalCost += price;
//             Console.WriteLine($"{name} pays: ${price}");
//         }

//         Console.WriteLine($"\nTotal family cost: ${totalCost}");
//     }
// }  

// //exercise 3 zara brand dictionary
// class ZaraBrand 
// {
//    static void Main(string[] args)
//    {
//         var brand = new Dictionary<string, object>
//         {
//             {"name", "Zara"},
//             {"creation_date", 1975},
//             {"creator_name", "Amancio Ortega Gaona"},
//             {"country_creation", "Spain"},
//             {"type_of_clothes", new List<string>{"men", "women", "children", "home"}},
//             {"international_competitors", new List<string>{"Gap", "H&M", "Benetton"}},
//             {"number_stores", 2},
//             {"major_color", new Dictionary<string, List<string>>
//                 {
//                     {"France", new List<string>{"blue"}},
//                     {"Spain", new List<string>{"red"}},
//                     {"US", new List<string>{"pink", "green"}}
//                 }
//             }
//         };

//         // 1. Change number stores to 2
//         brand["number_stores"] = 2;

//         // 2. Print clients
//         var types = (List<string>)brand["type_of_clothes"];
//         Console.WriteLine($"Zara serves clients including {string.Join(", ", types)}.");

//         // 3. Add country creation
//         brand["country_creation"] = "Spain";

//         // 4. Add Desigual
//         if (brand.ContainsKey("international_competitors"))
//         {
//             var competitors = (List<string>)brand["international_competitors"];
//             competitors.Add("Desigual");
//         }

//         // 5. Remove creation date
//         brand.Remove("creation_date");

//         // 6. Print last competitor
//         var competitorsList = (List<string>)brand["international_competitors"];
//         Console.WriteLine("Last international competitor: " + competitorsList[^1]);

//         // 7. Print US colors
//         var majorColors = (Dictionary<string, List<string>>)brand["major_color"];
//         Console.WriteLine("Major colors in the US: " + string.Join(", ", majorColors["US"]));

//         // 8. Print number of key-value pairs
//         Console.WriteLine("Number of key-value pairs: " + brand.Count);

//         // 9. Print all keys
//         Console.WriteLine("All keys: " + string.Join(", ", brand.Keys));

//         // 10. Merge dictionaries
//         var more_on_zara = new Dictionary<string, object>
//         {
//             {"creation_date", 1975},
//             {"number_stores", 10000}
//         };

//         foreach (var kv in more_on_zara)
//         {
//             brand[kv.Key] = kv.Value;
//         }

//         // 11. Explain overwrite
//         Console.WriteLine("Updated number_stores: " + brand["number_stores"]);
//         Console.WriteLine("Explanation: number_stores was overwritten by the new dictionary.");
//    }
// }


// //Exercise 4: Some Geography
// class Geography
// {
//     static void DescribeCity(string city, string country = "morocco")
//     {
//         Console.WriteLine($"{city} is in {country}.");
//     }

//     static void Main(string[] args)
//     {
       
//         DescribeCity("casablanca");          
//         DescribeCity("Paris", "France");     
//         DescribeCity("Tokyo", "Japan");      
//         DescribeCity("fes");           
// }

// }

// //Exercise 5: Random Number Guess
// class RandomNumberGuess
// {
//     static void GuessNumber(int number)
//     {
//         int randomNum = new Random().Next(1, 101); 
//         if (number == randomNum)
//             Console.WriteLine("Success! You guessed the number!");
//         else
//             Console.WriteLine($"Fail! You chose {number}, random number was {randomNum}.");
//     }

//     static void Main()
//     {
//         GuessNumber(10);
//         GuessNumber(50);
//         GuessNumber(75);
//     }
// }


// //Exercise 6: Personalized Shirts

// class PersonalizedShirts
// {
//     // Method definition
//     static void MakeShirt(string size = "Large", string text = "I love C#")
//     {
//         Console.WriteLine($"The size of the shirt is {size} and the text is '{text}'.");
//     }

//     static void Main(string[] args)
//     {
//         // 1. Large shirt with default message
//         MakeShirt();

//         // 2. Medium shirt with default message
//         MakeShirt("Medium");

//         // 3. Any size with a custom message
//         MakeShirt("Small", "Code is life");

//         // Bonus: Using named arguments
//         MakeShirt(text: "Debugging rocks", size: "Extra Large");
//     }
// }


// //Exercise 7: Temperature Advice
// class TemperatureAdvice
// {
//     static int GetRandomTemp(string season)
//     {
//         Random rnd = new Random();
//         int min = -10, max = 40;

//         if (season.ToLower() == "winter") { min = -10; max = 16; }
//         if (season.ToLower() == "spring") { min = 0; max = 23; }
//         if (season.ToLower() == "summer") { min = 16; max = 40; }
//         if (season.ToLower() == "autumn") { min = 0; max = 23; }

//         return rnd.Next(min, max + 1);
//     }

//     static void Main()
//     {
//         Console.Write("Enter a season (winter, spring, summer, autumn): ");
//         string season = Console.ReadLine() ?? "summer";

//         int temp = GetRandomTemp(season);
//         Console.WriteLine($"Temperature: {temp}°C");

//         if (temp < 0)
//             Console.WriteLine("Wear a heavy coat!");
//         else if (temp <= 16)
//             Console.WriteLine("Wear a jacket or sweater.");
//         else if (temp <= 23)
//             Console.WriteLine("Mild weather, light sweater is fine.");
//         else
//             Console.WriteLine("Hot weather, wear light clothes.");
//     }
// }
// //Exercise 8: Star Wars Quiz


// class StarWarsQuiz
// {
//     static void Main()
//     {
//         var data = new List<Dictionary<string, string>>
//         {
//             new() { {"question", "What is Baby Yoda's real name?"}, {"answer", "Grogu"} },
//             new() { {"question", "Where did Obi-Wan take Luke after his birth?"}, {"answer", "Tatooine"} },
//             new() { {"question", "What year did the first Star Wars movie come out?"}, {"answer", "1977"} },
//             new() { {"question", "Who built C-3PO?"}, {"answer", "Anakin Skywalker"} },
//             new() { {"question", "Anakin Skywalker grew up to be who?"}, {"answer", "Darth Vader"} },
//             new() { {"question", "What species is Chewbacca?"}, {"answer", "Wookiee"} }
//         };

//         int correct = 0;
//         var wrongAnswers = new List<string>();

//         foreach (var q in data)
//         {
//             Console.Write(q["question"] + " ");
//             string userAnswer = Console.ReadLine() ?? "";
//             if (userAnswer.Trim().ToLower() == q["answer"].ToLower())
//                 correct++;
//             else
//                 wrongAnswers.Add($"{q["question"]} | Your answer: {userAnswer} | Correct: {q["answer"]}");
//         }

//         Console.WriteLine($"\nCorrect: {correct}, Incorrect: {data.Count - correct}");

//         if (wrongAnswers.Count > 0)
//         {
//             Console.WriteLine("Wrong answers:");
//             foreach (var w in wrongAnswers)
//                 Console.WriteLine(w);
//         }

//         if (wrongAnswers.Count > 3)
//             Console.WriteLine("Too many wrong answers! Try again.");
//     }
// }
// //Exercise 9: Cats


// class Cat
// {
//     public string Name;
//     public int Age;

//     public Cat(string catName, int catAge)
//     {
//         Name = catName;
//         Age = catAge;
//     }
// }

// class Program
// {
//     static Cat OldestCat(Cat[] cats)
//     {
//         Cat oldest = cats[0];
//         foreach (var cat in cats)
//             if (cat.Age > oldest.Age) oldest = cat;
//         return oldest;
//     }

//     static void Main()
//     {
//         Cat c1 = new Cat("Mittens", 3);
//         Cat c2 = new Cat("Whiskers", 5);
//         Cat c3 = new Cat("Shadow", 2);

//         Cat oldest = OldestCat(new Cat[] { c1, c2, c3 });
//         Console.WriteLine($"The oldest cat is {oldest.Name}, and is {oldest.Age} years old.");
//     }
// }


// //Exercise 10: Dogs

// class Dog
// {
//     public string Name;
//     public int Height;

//     public Dog(string name, int height)
//     {
//         Name = name;
//         Height = height;
//     }

//     public void Bark() => Console.WriteLine($"{Name} goes woof!");
//     public void Jump() => Console.WriteLine($"{Name} jumps {Height * 2} cm high!");
// }

// class Program
// {
//     static void Main()
//     {
//         Dog davidsDog = new Dog("Rex", 50);
//         Dog sarahsDog = new Dog("Teacup", 20);

//         davidsDog.Bark(); davidsDog.Jump();
//         sarahsDog.Bark(); sarahsDog.Jump();

//         Console.WriteLine(davidsDog.Height > sarahsDog.Height ? davidsDog.Name : sarahsDog.Name + " is taller");
//     }
// }








// //Exercise 11:  Who’s the Song Producer?

// class Song
// {
//     private List<string> Lyrics;

//     public Song(List<string> lyrics) => Lyrics = lyrics;

//     public void SingMeASong()
//     {
//         foreach (var line in Lyrics)
//             Console.WriteLine(line);
//     }
// }

// class Program
// {
//     static void Main()
//     {
//         var stairway = new Song(new List<string>{
//             "There’s a lady who's sure",
//             "all that glitters is gold",
//             "and she’s buying a stairway to heaven"
//         });

//         stairway.SingMeASong();
//     }
// }









// //Exercise 12: Afternoon at the Zoo


// class Zoo
// {
//     public string Name;
//     public List<string> Animals = new List<string>();

//     public Zoo(string zooName) => Name = zooName;

//     public void AddAnimal(string a) { if (!Animals.Contains(a)) Animals.Add(a); }
//     public void GetAnimals() => Console.WriteLine(string.Join(", ", Animals));
//     public void SellAnimal(string a) { Animals.Remove(a); }

//     public void SortAnimals()
//     {
//         var groups = Animals.GroupBy(a => a[0])
//                             .OrderBy(g => g.Key)
//                             .ToDictionary(g => g.Key, g => g.ToList());

//         foreach (var g in groups)
//             Console.WriteLine($"{g.Key}: {string.Join(", ", g.Value)}");
//     }
// }

// class Program
// {
//     static void Main()
//     {
//         Zoo newYorkZoo = new Zoo("NY Zoo");

//         newYorkZoo.AddAnimal("Giraffe");
//         newYorkZoo.AddAnimal("Baboon");
//         newYorkZoo.AddAnimal("Cat");
//         newYorkZoo.GetAnimals();
//         newYorkZoo.SortAnimals();
//         newYorkZoo.SellAnimal("Baboon");
//         newYorkZoo.GetAnimals();
//     }
// }
