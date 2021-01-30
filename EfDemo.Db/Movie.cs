using System;
using System.Collections.Generic;

#nullable disable

namespace EfDemo.Db
{
    public partial class Movie
    {
        public Movie()
        {
            BoxOffices = new HashSet<BoxOffice>();
        }

        public int Id { get; set; }
        public string Title { get; set; }
        public string Director { get; set; }
        public int Year { get; set; }
        public int LengthMinutes { get; set; }

        public virtual ICollection<BoxOffice> BoxOffices { get; set; }
    }
}
