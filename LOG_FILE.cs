namespace Delivery
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Firebird.LOG_FILE")]
    public partial class LOG_FILE
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }

        [StringLength(200)]
        public string INFORM { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DDATA { get; set; }
    }
}
