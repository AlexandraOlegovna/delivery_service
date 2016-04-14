namespace Delivery
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Firebird.OPERATION")]
    public partial class OPERATION
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public OPERATION()
        {
            DELIVERies = new HashSet<DELIVERY>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }

        [Required]
        [StringLength(10)]
        public string ID_TOVAR { get; set; }

        [Required]
        [StringLength(10)]
        public string ID_AG { get; set; }

        [Required]
        [StringLength(10)]
        public string ID_WH { get; set; }

        [Required]
        [StringLength(1)]
        public string TYPEOP { get; set; }

        [Column(TypeName = "numeric")]
        public decimal KOL { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? PRICE { get; set; }

        [Column(TypeName = "date")]
        public DateTime? POST_DATE { get; set; }

        [Required]
        [StringLength(1)]
        public string DELIVERY { get; set; }

        public virtual AGENT AGENT { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DELIVERY> DELIVERies { get; set; }

        public virtual TOVAR TOVAR { get; set; }

        public virtual WAREHOUSE WAREHOUSE { get; set; }
    }
}
