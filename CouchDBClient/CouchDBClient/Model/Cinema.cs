using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CouchDBClient.Model
{
    public class Cinema
    {
        public Guid CinemaId { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
    }
}
