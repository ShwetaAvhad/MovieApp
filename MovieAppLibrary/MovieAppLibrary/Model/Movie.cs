using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieAppLibrary.Model
{
    public class Movie
    {
        public string movieId {  get; set; }
        public string movieName { get; set; }
        public string movieGenre { get; set; }
        public string movieReleaseYear {  get; set; }

        public static int movieCount = 0;
        public Movie()
        {
            movieCount++;
        }
        public Movie(string id,string name,string genre,string release)
        {
            movieCount++;
            movieId = id; 
            movieName = name; 
            movieGenre = genre; 
            movieReleaseYear = release;        
        }
        public override string ToString()
        {
            return $"Movie ID : {movieId}\n" +
                $"Movie Name : {movieName}\n" +
                $"Movie Genre : {movieGenre}\n" +
                $"Movie Release Year : {movieReleaseYear}\n";         
        }
    }
}
