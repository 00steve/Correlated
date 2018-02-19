namespace Maintain.Objects
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Measure.Source")]
    public partial class Source
    {
        [Column(TypeName = "numeric")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public decimal SourceID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal MeasureID { get; set; }

        [Required]
        [StringLength(200)]
        public string SourceName { get; set; }

        [StringLength(1000)]
        public string SourceDescription { get; set; }

        [Required]
        [StringLength(1000)]
        public string SourceURL { get; set; }

        public virtual Measure Measure { get; set; }
    }
}
