namespace Maintain.Objects.Correlated
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Measure.MeasureCategory")]
    public partial class MeasureCategory
    {
        [Column(TypeName = "numeric")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public decimal MeasureCategoryID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal MeasureID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal CategoryID { get; set; }

        public virtual Category1 Category1 { get; set; }

        public virtual Measure Measure { get; set; }
    }
}
