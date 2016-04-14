namespace Delivery
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Firebird.TOVAR")]
    public partial class TOVAR
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TOVAR()
        {
            OPERATIONs = new HashSet<OPERATION>();
            TOVAR_WH = new HashSet<TOVAR_WH>();
        }

        [Key]
        [StringLength(10)]
        public string ID_TOVAR { get; set; }

        [Required]
        [StringLength(20)]
        public string NOMENCLATURE { get; set; }

        public int VOLUME { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OPERATION> OPERATIONs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TOVAR_WH> TOVAR_WH { get; set; }
    }
}
