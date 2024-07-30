using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MovieAppLibrary.Model;
using MovieAppLibrary.ExceptionHandling;

namespace MovieAppLibrary.Services
{
    public class MovieManager
    {
        public const int MOVIE_CAPACITY = 5;
        
        Movie movie=new Movie();

        public static List<Movie> movies = new List<Movie>();
       
        public MovieManager()
        {
            movies = SerializeDeserialize.DeserializedData();
        }
        public static void AddMovie()
        {
            try
            {
                if(movies.Count == MOVIE_CAPACITY)
                {
                    throw new StoreCapacityException("Movie Capacity if Full");
                    
                }
                else
                {
                    Console.WriteLine("Enter Movie Name : ");
                    string name = Console.ReadLine();
                    Console.WriteLine("Enter Movie Genre : ");
                    string genre = Console.ReadLine();
                    Console.WriteLine("Enter Year Of Release (yyyy) : ");
                    string release = Console.ReadLine();

                    string id = ((name.Substring(0, 2)) + (genre.Substring(0, 2)) + (release.Substring(release.Length - 2)));

                    movies.Add(new Movie(id, name, genre, release));
                    Console.WriteLine("Movie Added Successfully!!");

                    SerializeDeserialize.SerializedData(movies);
                }
                
            }
            catch(StoreCapacityException e) 
            {
                Console.WriteLine(e.Message);
            }
            
        }

        public static void DeleteMovie()
        {
            try
            {
                if (movies.Count != 0)
                {
                    Console.WriteLine("Enter Movie ID to delete : ");
                    string inputId = Console.ReadLine();
                    foreach (Movie movie in movies.ToList())
                    {
                        if (movie.movieId.Equals(inputId))
                            {
                                movies.Remove(movie);
                                break;
                            }
                    }
                    Movie.movieCount--;
                    Console.WriteLine("Movie Deleted Successfully!!");
                    SerializeDeserialize.SerializedData(movies);
                }
                else
                {
                    throw new EmptyStoreException("Movie Store Is Empty");
                }
            }
            catch(EmptyStoreException e) 
            {
                Console.WriteLine(e.Message);
            }          
        }

        public static void FindMovieById()
        {            
            try
            {
                if (movies.Count!=0)
                {
                    Console.WriteLine("Enter Movie ID : ");
                    string inputId = Console.ReadLine();

                    try
                        {
                        foreach (Movie movie in movies)
                        {
                            if (movie.movieId.Equals(inputId))
                            {
                                Console.WriteLine(movie);                                
                                break;
                            }
                            else
                            {
                                throw new FindAccountException("Account Not Found");
                            }
                            
                        }                        
                    }
                    catch (FindAccountException e)
                    {
                        Console.WriteLine(e.Message);
                    }
                }
                else
                {
                    throw new EmptyStoreException("Movie Store Is Empty");
                }                
            }
            catch (EmptyStoreException e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public static void DisplayAll()
        {
            try
            {
                if (movies.Count != 0)
                {
                    foreach (Movie movie in movies)
                    {
                        Console.WriteLine(movie);
                    }
                }
                else
                {
                    throw new EmptyStoreException("Movie Store Is Empty");
                }
            }
            catch (EmptyStoreException e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public static void ClearAllMovies()
        {
            Console.WriteLine("All movies clear");
            movies.Clear();
        }

    }
}
