using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_11_MoviesByCategory
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Movie> movieList = new List<Movie>();
            movieList.Add(new Movie("Horror", "Halloween"));


            movieList.Add(new Movie("Horror", "The Shining"));


            movieList.Add(new Movie("Horror", "The Exorcist"));


            movieList.Add(new Movie("SiFi", "Hunger Games"));


            movieList.Add(new Movie("SiFi", "E.T."));


            movieList.Add(new Movie("SiFi", "Blade Runner"));


            movieList.Add(new Movie("Animated", "Finding Nemo"));


            movieList.Add(new Movie("Animated", "Toy Story"));


            movieList.Add(new Movie("Animated", "Spirited Away"));


            movieList.Add(new Movie("Drama", "American Beauty"));

            bool repeat = true;
            while (repeat)
            {

                {
                    Console.WriteLine("please enter a category: 1. Horror, 2. Drama, 3. SiFi," +
                        "4. Animated");
                    string category = Console.ReadLine();


                    if (category == "1")
                    {
                        foreach (Movie movie in movieList)
                        {

                            if (movie.Category.ToLower() == "horror")
                            {
                                movie.PrintInfo();
                            }
                        }
                    }
                    else if (category == "2")
                    {
                        foreach (Movie movie in movieList)
                        {

                            if (movie.Category.ToLower() == "drama")
                            {
                                movie.PrintInfo();
                            }
                        }
                    }
                    else if (category == "3")
                    {
                        foreach (Movie movie in movieList)
                        {

                            if (movie.Category.ToLower() == "sifi")
                            {
                                movie.PrintInfo();
                            }
                        }
                    }
                    else if (category == "4")
                    {
                        foreach (Movie movie in movieList)
                        {

                            if (movie.Category.ToLower() == "animated")
                            {
                                movie.PrintInfo();
                            }
                        }
                    }
                    Console.WriteLine(" invalid input, please try again");
                }
                Console.WriteLine("would you like to continue: 1. to continue or 2. to quit");
                string response = Console.ReadLine();
                if (response == "1")
                {
                    break;
                }
                else if (response == "2")
                {
                    Console.WriteLine("goodbye");
                    repeat = false;
                }
                Console.WriteLine(" invalid input, please try again");

            }
            
        }
        
    }
}
