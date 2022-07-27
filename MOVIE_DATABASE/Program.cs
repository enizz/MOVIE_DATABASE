using MOVIE_DATABASE;
using System.Linq;

var movies = new List<Movie>
{
    new Movie("Dune", "Sci-Fi"),
    new Movie("The Grey Man", "Action"),
    new Movie("Tenet", "Thriller"),
    new Movie("Top Gun: Maverick", "Action"),
    new Movie("Hustle", "Drama"),
    new Movie("Snowpiercer", "Sci-Fi"),
    new Movie("Parasite", "Thriller"),
    new Movie("Elvis", "Drama"),
    new Movie("Thor: Love and Thunder", "Comedey"),
    new Movie("Minions: The Rise of Gru", "Comedey")
};
ConsoleKeyInfo key;
bool answered = false;
string answer = "";
Console.WriteLine("Welcome to the Movie List Application!\n");
Console.WriteLine("There are " + movies.Count() + " movies in this list.");


do
{


    do
    {
        if (answered == false)
        {
            Console.WriteLine("What category are you instereted in?");
        }
        else
        {
            Console.WriteLine("I'm sorry, we only have: Sci-Fi, Action, Thriller, Drama or Comedey");
        }
        answered = true;
        answer = Console.ReadLine();

    } while (answer != "Sci-Fi" && answer != "Action" && answer != "Comedey" && answer != "Thriller" && answer != "Drama");

    var categories = movies.Where(x => x.Category == answer);

    foreach (var y in categories)
    {
        Console.WriteLine($"{y.Title}");
    }
    Console.WriteLine("\nWould you like to search again? If so, press Enter or any other key to exit.");
    answered = false;
    key = Console.ReadKey();
} while (key.Key == ConsoleKey.Enter);