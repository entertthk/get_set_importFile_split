using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace movies_setter_getter
{   
    class Movie
    {
        string title;
        string director;
        string ratings;
        int userRating;

        public Movie(string _title, string _director, string _ratings, int _userRating)
        {
            title = _title;
            director = _director;
            Ratings = _ratings;
            UserRating = _userRating;
        }
        public string Title
        {
            get { return title; }
        }
        public string Director
        {
            get { return director; }
        }
        public string Ratings
        {
            get { return ratings; }
            set
            {
                if (value == "G" || value == "PG" || value == "PG-13" || value == "R")
                {
                    ratings = value;
                }
                else
                {
                    ratings = "undefined";
                }
            }
        }
        public int UserRating
        {
            get { return userRating; }
            set
            {

                if (value >=0 && value <=10)
                {
                    userRating = value;
                }
                else
                {
                    userRating = 0;
                }
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            
            //Movies newMovies = new Movies("rambo", "Stallone", "G", 10);

            
            string filePath = @"C:\demo\movies.txt";
            List<string> listFromFile = File.ReadAllLines(filePath).ToList();
            List<Movie> listOfMovies = new List<Movie>();           //loome listi klassi objektide salvestamiseks
            
            foreach(string line in listFromFile)  //võtame failist ja küikide ridade kohta
            {
                string[] tempArray = line.Split('/');  //loome massiivi, temparray-ajutine, eraldame /
                string tempTitle = tempArray[0];
                string tempDir = tempArray[1];
                string tempRating = tempArray[2];
                int tempUserRating = int.Parse(tempArray[3]);

                Movie tempMovieObject = new Movie(tempTitle, tempDir, tempRating, tempUserRating); //uus objekt

                listOfMovies.Add(tempMovieObject);
            }
            
            int i = 1;
            foreach(Movie movieObject in listOfMovies) //object movied in lisofmovies
            {
                Console.WriteLine($"Item {i}: {movieObject.Title} directed by {movieObject.Director}");
                i++;
            }

            Console.WriteLine("Enter the key word:");
            string userSearch = Console.ReadLine().ToLower();
            
            List<Movie> userSearchResult = new List<Movie>();
            //int searchResult = 0;
            foreach (Movie movieObject in listOfMovies)
            {
                if(movieObject.Title.ToLower().Contains(userSearch))  //sisaldab
                {
                    //Console.WriteLine($"{movieObject.Title} directed by {movieObject.Director}");
                    //searchResult++;
                    userSearchResult.Add(movieObject);
                }
            }

            Console.WriteLine($"{userSearchResult.Count } movies found");

            foreach (Movie movieObject in userSearchResult) 
            {
                Console.WriteLine($" {movieObject.Title} ");
            }

            //Console.WriteLine($"{searchResult} movies found");  kuvab search resulti

            Console.ReadLine();

        }
    }
}
