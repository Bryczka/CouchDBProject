namespace CouchDBClient.ModelEF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("FilmShow")]
    public partial class FilmShow
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public FilmShow()
        {
            Ticket = new HashSet<Ticket>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        [Column(TypeName = "date")]
        public DateTime FilmShowTime { get; set; }

        [StringLength(255)]
        public string HallName { get; set; }

        public int FilmId { get; set; }

        public int CinemaId { get; set; }

        public virtual Cinema Cinema { get; set; }

        public virtual Film Film { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Ticket> Ticket { get; set; }
    }
}
