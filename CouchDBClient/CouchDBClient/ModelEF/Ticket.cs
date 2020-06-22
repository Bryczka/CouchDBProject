namespace CouchDBClient.ModelEF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Ticket")]
    public partial class Ticket
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string TicketType { get; set; }

        public double? TicketPrice { get; set; }

        public int PersonId { get; set; }

        public int FilmShowId { get; set; }

        public virtual FilmShow FilmShow { get; set; }

        public virtual Person Person { get; set; }
    }
}
