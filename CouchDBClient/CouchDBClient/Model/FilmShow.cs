using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CouchDBClient.Model
{
    public class FilmShow
    {
        public Guid FilmShowId { get; set; }
        public DateTime FilmShowTime { get; set; }
        public string HallName { get; set; }
        public Film Film { get; set; }
        public Cinema Cinema { get; set; }
    }
}
