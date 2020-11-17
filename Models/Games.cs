using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace RazorPagesMovie.Models
{
    public class Games
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string Genre { get; set; }
        public decimal Price { get; set; }

        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }



    }
}
