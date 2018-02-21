namespace Maintain.Objects.Correlated
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Maintenance.VW_MeasureDetails")]
    public partial class VW_MeasureDetails
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(50)]
        public string Unit { get; set; }

        [Key]
        [Column("Unit Category", Order = 1)]
        [StringLength(100)]
        public string Unit_Category { get; set; }

        [StringLength(100)]
        public string Region { get; set; }

        [StringLength(300)]
        public string Country { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(200)]
        public string Name { get; set; }

        [StringLength(1000)]
        public string Description { get; set; }

        [Key]
        [Column("Measure Category", Order = 3)]
        [StringLength(100)]
        public string Measure_Category { get; set; }
    }
}
