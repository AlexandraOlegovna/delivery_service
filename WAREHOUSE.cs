namespace Delivery
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Firebird.WAREHOUSE")]
    public partial class WAREHOUSE
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public WAREHOUSE()
        {
            OPERATIONs = new HashSet<OPERATION>();
            TOVAR_WH = new HashSet<TOVAR_WH>();
        }

        [Key]
        [StringLength(10)]
        public string ID_WH { get; set; }

        [Required]
        [StringLength(20)]
        public string NAIMEN { get; set; }

        [StringLength(10)]
        public string TOWN { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OPERATION> OPERATIONs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TOVAR_WH> TOVAR_WH { get; set; }
    }
}
