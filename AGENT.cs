namespace Delivery
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Firebird.AGENT")]
    public partial class AGENT
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public AGENT()
        {
            OPERATIONs = new HashSet<OPERATION>();
        }

        [Key]
        [StringLength(10)]
        public string ID_AG { get; set; }

        [Required]
        [StringLength(20)]
        public string NAME_AG { get; set; }

        [StringLength(20)]
        public string TOWN { get; set; }

        [StringLength(10)]
        public string PHONE { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OPERATION> OPERATIONs { get; set; }
    }
}
