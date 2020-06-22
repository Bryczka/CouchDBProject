using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CouchDBClient.Model
{
    public class Film
    {
        public Guid FilmId { get; set; }
        public string Title { get; set; }
        public string FilmDescription { get; set; }
        public int Duration { get; set; }
        public int AgeLimit { get; set; }
    }
}
