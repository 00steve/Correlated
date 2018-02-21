namespace Maintain.Objects.Correlated
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DataPoint.Point")]
    public partial class Point
    {
        [Column(TypeName = "numeric")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public decimal PointID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal DateID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? NValue { get; set; }

        [StringLength(1000)]
        public string SValue { get; set; }

        public bool Interpolated { get; set; }

        public virtual Date Date { get; set; }
    }
}
