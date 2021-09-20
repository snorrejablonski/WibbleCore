using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WibbleCore.Models;

namespace WibbleCore.ViewModels
{
    public class MoviesViewModel
    {
        public List<Movie> Movies { get; set; }

        public MoviesViewModel()
        {
            Movies = new List<Movie>
            {
                new Movie
                {
                    Name = "Erin Brockovich",
                    ReleaseDate = DateTime.Now.AddDays(-7492),
                    DateAdded = DateTime.Now,
                    NumberInStock = 4,
                    Id = 1
                },
                new Movie
                {
                    Name = "Legends of The Fall",
                    ReleaseDate = DateTime.Now.AddDays(-8500),
                    DateAdded = DateTime.Now.AddDays(-23),
                    NumberInStock = 1,
                    Id = 2
                },
                new Movie
                {
                    Name = "Inception",
                    ReleaseDate = DateTime.Now.AddDays(-1396),
                    DateAdded = DateTime.Now.AddDays(-10),
                    NumberInStock = 2,
                    Id = 3
                }
            };
        }

        public Movie Get(int id) => Movies.FirstOrDefault(p => p.Id == id);
    }
}
