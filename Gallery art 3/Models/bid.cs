namespace Gallery_art_3.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("bid")]
    public partial class bid
    {
        public int Id { get; set; }

        public double Start_Price { get; set; }

        public double End_Price { get; set; }

        public int Art_id { get; set; }

        [StringLength(100)]
        public string Date_start { get; set; }

        [StringLength(100)]
        public string Date_end { get; set; }


        
        public virtual artwork artwork { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Update_bidding> update_bidding { get; set; }
    }
}
