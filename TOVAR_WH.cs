namespace Delivery
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Firebird.TOVAR_WH")]
    public partial class TOVAR_WH
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }

        [Required]
        [StringLength(10)]
        public string ID_WH { get; set; }

        [Required]
        [StringLength(10)]
        public string ID_TOVAR { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? KOL { get; set; }

        public virtual TOVAR TOVAR { get; set; }

        public virtual WAREHOUSE WAREHOUSE { get; set; }
    }
}
