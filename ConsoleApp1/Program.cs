using BasicSkarpC;
using System;
using System.Drawing;

//KROKODILLESPILL

//    int points = 0;

//    Random ran = new Random();
//bool keepGame = true;
//while (keepGame)
//{

//    int nr1 = ran.Next(1, 12);
//    int nr2 = ran.Next(1, 12);

//    Console.WriteLine("Velkommen til krokodillespillet!");
//    Console.WriteLine($"Du har {points} poeng");
//    Console.WriteLine("Hvilket tall er størst? (velg <, >, eller =");
//    Console.WriteLine($"{nr1}_{nr2}");
//    var input = Console.ReadLine();
//    bool isCorrect = CheckNr();
//    if (isCorrect)
//    {
//        Console.WriteLine("Korrekt!");
//        Console.WriteLine("Ekstra poeng til deg!");
//        points++;
//    }
//    else
//    {
//        Console.WriteLine("Feil!");
//        Console.WriteLine("Mindre poeng til deg!");
//        points--;
//    }
//    Console.ReadKey(true);
//    keepGame = checkInput(input);
//    Console.Clear();


//    bool CheckNr()
//    {
//        if (input == "<") { if (nr1 < nr2) { return true; } else { return false; } }
//        else if (input == ">") { if (nr1 > nr2) { return true; } else { return false; } }
//        else if (input == "=") { if (nr1 == nr2) { return true; } else { return false; } }
//        else { return false; }
//    }

//}
//bool checkInput(string input){
//    if (input != "<" && input != ">" && input != "=")
//    {
//        return false;

//    }
//    else { return true; }
//}

//TEKSTUKLING

//bool oneTwo = false;
//string choice = string.Empty;
//while (!oneTwo)
//{
//    Console.WriteLine("1. Roter Tekst");
//    Console.WriteLine("");
//    Console.WriteLine("2. Endre Ord");
//    choice = Console.ReadLine();
//    if(choice == "1" || choice == "2")
//    {
//        oneTwo = true; 
//    }
//    else { Console.Clear(); }
//}


//Console.Clear();
//Console.WriteLine("Skriv en tekst:");
//string userString = Console.ReadLine();
//int size = userString.Length;

//if(choice == "1")
//{
//    rotate();
//}
//else if(choice == "2")
//{
//    change();
//}

//void rotate()
//{
//    for (int i = 1; i <= size; i++)
//    {
//        Console.Write(userString[size - i]);
//    }

//}

//void change()
//{
//    foreach (var letter in userString)
//    {
//        switch (letter)
//        {
//            case 'e':
//                Console.Write("a");
//                break;
//            case 'E':
//                Console.Write("A");
//                break;
//            default:
//                Console.Write($"{letter}");
//                break;
//        }
//    }
//}


//MYSTERIEKODE

//var range = 250;
//var counts = new int[range];
//string text = "something";
//int letterCount = 0;
//while (!string.IsNullOrWhiteSpace(text))
//{
//    text = Console.ReadLine();
//    foreach (var character in text?.ToLower() ?? string.Empty)
//    {
//        counts[(int)character]++;
//        letterCount++;
//    }
//    for (var i = 0; i < range; i++)
//    {
//        if (counts[i] > 0)
//        {
//            var character = (char)i;
//            var percent = 100 * (double)counts[i] / letterCount;
//            string output = character + " - " + percent.ToString("F2") + "%";
//            Console.CursorLeft = Console.BufferWidth - output.Length - 1;
//            Console.WriteLine(output);
//        }
//    }
//}


//GJETTELEKEN


//bool currentlyPlaying = true;

//while (currentlyPlaying)
//{
//    Console.Clear();
//    Random rnd = new Random();
//    int number = rnd.Next(1, 101);

//    bool keepGoing = true;

//    while (keepGoing)
//    {

//        Console.WriteLine("Gjett tallet mellom 1 og 100!");
//        var userGuess = Console.ReadLine();

//        if (userGuess == number.ToString())
//        {
//            Console.WriteLine("GRATULERER");
//            keepGoing = false;
//            Console.ReadKey(true);
//        }
//        else
//        {
//            Console.WriteLine("FEIL TALL");
//            Console.ReadKey(true);
//            Console.Clear();
//        }
//    }
//    Console.WriteLine("Spille igjen?");
//    Console.WriteLine("Y/N");

//    var input = Console.ReadLine();
//    if(input == "n" || input == "N") { currentlyPlaying = false; }
//   Console.ReadKey(true);
//}


//Weeb-ass shit

//var AssHat = new Pokemon { Name = "AssHat", Level = 69, Health = 420 };
//AssHat.ShowPokemon();

//List<Pokemon> pokedex = new List<Pokemon>
//{
//            new Pokemon{Name = "AssHat", Level = 69, Health = 420 },
//            new Pokemon{Name = "Douchebag", Level = 42, Health = 69 },
//            new Pokemon{Name = "Weebmon", Level = 9001, Health = 777 },

//        };
//Console.WriteLine("Pokemon i pokedexen:");
//foreach (Pokemon pokemon in pokedex)
//{
//    pokemon.ShowPokemon();
//}

//Dette er den beste versjonen
//List<Pokemon> pokedex = new List<Pokemon>
//{
//            new Pokemon("AssHat", 69, 420 ),
//            new Pokemon("Douchebag", 42, 69 ),
//            new Pokemon("Weebmon", 9001, 777 ),
//            new Pokemon("Waifumon"),

//        };
//Console.WriteLine("Pokemon i pokedexen:");
//foreach (Pokemon pokemon in pokedex)
//{
//    pokemon.ShowPokemon();
//}


//Debugging

//var range = 250;

//var counts = new int[range];
//string text = "something";
//while (!string.IsNullOrWhiteSpace(text))
//{
//    text = Console.ReadLine();
//    foreach (var character in text ?? string.Empty)
//    {
//        counts[(int)character]++;
//    }
//    for (var i = 0; i < range; i++)
//    {
//        if (counts[i] > 0)
//        {
//            var character = (char)i;
//            Console.WriteLine(character + " - " + counts[i]);
//        }
//    }
//}


// TIPS TIL BRUK AV \r OG ANIMASJONER

//string[] loading = { "-", "\\", "|", "/" };
//for (int i = 0; i < 100; i++)
//{
//    Console.Write($"\rLoading {loading[i % loading.Length]}");
//    System.Threading.Thread.Sleep(100); // Wait to simulate loading
//}
//Console.WriteLine("\nLoading complete!");

// Create an array of five Point structures.
Point[] points = { new Point(100, 200),
    new Point(150, 250), new Point(250, 375),
    new Point(275, 395), new Point(295, 450) };

// Find the first Point structure for which X times Y
// is greater than 100000.
Point first = Array.Find(points, p => p.X * p.Y > 100000);

// Display the first structure found.
Console.WriteLine("Found: X = {0}, Y = {1}", first.X, first.Y);

