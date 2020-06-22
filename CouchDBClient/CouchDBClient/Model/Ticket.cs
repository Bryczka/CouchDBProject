using CouchDB.Driver.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CouchDBClient.Model
{
    public class Ticket : CouchDocument
    {
        public Guid TicketId { get; set; }
        public string TicketType { get; set; }
        public float TicketPrice { get; set; }
        public Person Person { get; set; }
        public FilmShow FilmShow { get; set; }
    }
}
