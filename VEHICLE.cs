namespace Delivery
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Firebird.VEHICLE")]
    public partial class VEHICLE
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public VEHICLE()
        {
            DELIVERies = new HashSet<DELIVERY>();
        }

        [Key]
        [StringLength(10)]
        public string ID_V { get; set; }

        [Required]
        [StringLength(10)]
        public string NUM_V { get; set; }

        public int CAPACITY { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DELIVERY> DELIVERies { get; set; }
    }
}
