using dibeq_mvc.Models;
using System.Collections.Generic;

namespace dibeq_mvc.ViewModels
{
    public class RandomMovieViewModel
    {
        public Movie Movie { get; set; }
        public List<Customer> Customers { get; set; }
    }
}