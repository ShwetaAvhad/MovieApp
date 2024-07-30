using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using MovieAppLibrary.Model;
using Newtonsoft.Json;

namespace MovieAppLibrary.Services
{
    public class SerializeDeserialize
    {
        public static void SerializedData(List<Movie> movie)
        {
            File.WriteAllText("Movies.json", JsonConvert.SerializeObject(movie));
        }
        public static List<Movie> DeserializedData()
        {
            List<Movie> movie = new List<Movie>();
            string fileName = "Movies.json";
            if (File.Exists(fileName))
            {
                string json = File.ReadAllText(fileName);
                movie = JsonConvert.DeserializeObject<List<Movie>>(json);
            }
            else
            {
                File.WriteAllText("Movies.json", JsonConvert.SerializeObject(movie));
            }
            return movie;
        }
    }
}
