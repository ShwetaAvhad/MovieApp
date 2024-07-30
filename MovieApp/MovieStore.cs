using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MovieAppLibrary;
using MovieAppLibrary.Model;
using MovieAppLibrary.Services;

namespace MovieApp
{
    public class MovieStore
    {
        public static void MenuDriven()
        {
            Console.WriteLine("Welcome to the Movie Store");
            Console.WriteLine("---------------------------");
            Console.WriteLine("---------------------------");

            char yesOrNo;

            MovieManager movieManager = new MovieManager();

            do
            {
                Console.WriteLine("Total Movies Available : " + MovieManager.movies.Count);
                Console.WriteLine("1 . Add Movie\n" +
                                  "2 . Find Movie\n" +
                                  "3 . Delete Movie\n" +
                                  "4 . Display All\n" +
                                  "5 . Clear All\n" +
                                  "6 . Exit\n");
                             
                Console.WriteLine("Enter Your Choice : ");
                int userInput = int.Parse(Console.ReadLine());

                switch (userInput)
                {
                    case 1:
                        MovieManager.AddMovie();
                        break;
                    case 2:
                        MovieManager.FindMovieById();
                        break;
                    case 3:
                        MovieManager.DeleteMovie();
                        break;
                    case 4:
                        MovieManager.DisplayAll();
                        break;
                    case 5:
                        MovieManager.ClearAllMovies();
                        break;
                    case 6:
                        Environment.Exit(0);
                        break;
                   
                }
                Console.WriteLine("Do you want to continue (Y/N)");
                yesOrNo = Char.Parse(Console.ReadLine());
            }
            while (yesOrNo != 'n');
        }
    }
}
