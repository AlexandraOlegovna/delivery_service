namespace Delivery
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Firebird.IBE$LOG_BLOB_FIELDS")]
    public partial class IBE_LOG_BLOB_FIELDS
    {
        [Key]
        [Column(Order = 0, TypeName = "numeric")]
        public decimal LOG_TABLES_ID { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(67)]
        public string FIELD_NAME { get; set; }

        [StringLength(8000)]
        public string OLD_CHAR_VALUE { get; set; }

        [StringLength(8000)]
        public string NEW_CHAR_VALUE { get; set; }

        public byte[] OLD_BLOB_VALUE { get; set; }

        public byte[] NEW_BLOB_VALUE { get; set; }
    }
}
