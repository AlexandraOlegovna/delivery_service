namespace Delivery
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Firebird.DELIVERY")]
    public partial class DELIVERY
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID_D { get; set; }

        public int ID_OP { get; set; }

        public TimeSpan TIME_A { get; set; }

        public TimeSpan TIME_D { get; set; }

        [Required]
        [StringLength(10)]
        public string ID_V { get; set; }

        public virtual OPERATION OPERATION { get; set; }

        public virtual VEHICLE VEHICLE { get; set; }
    }
}
