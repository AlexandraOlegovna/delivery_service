namespace Delivery
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Firebird.IBE$LOG_KEYS")]
    public partial class IBE_LOG_KEYS
    {
        [Key]
        [Column(Order = 0, TypeName = "numeric")]
        public decimal LOG_TABLES_ID { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(67)]
        public string KEY_FIELD { get; set; }

        [StringLength(255)]
        public string KEY_VALUE { get; set; }
    }
}
