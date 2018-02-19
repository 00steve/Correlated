namespace Maintain.Objects
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Measure.Measure")]
    public partial class Measure
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Measure()
        {
            MeasureCategories = new HashSet<MeasureCategory>();
            Sources = new HashSet<Source>();
        }

        [Column(TypeName = "numeric")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public decimal MeasureID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal UnitID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal CategoryID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? RegionID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? CountryID { get; set; }

        [Required]
        [StringLength(200)]
        public string MeasureName { get; set; }

        [StringLength(1000)]
        public string MeasureDescription { get; set; }

        public virtual Unit Unit { get; set; }

        public virtual MCategory Category1 { get; set; }

        public virtual Country Country { get; set; }

        public virtual Region Region { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MeasureCategory> MeasureCategories { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Source> Sources { get; set; }
    }
}
