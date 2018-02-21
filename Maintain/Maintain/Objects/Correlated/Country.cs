namespace Maintain.Objects.Correlated
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Measure.Country")]
    public partial class Country
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Country()
        {
            Measures = new HashSet<Measure>();
        }

        [Column(TypeName = "numeric")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public decimal CountryID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? CurrentRegionID { get; set; }

        [StringLength(300)]
        public string CountryName { get; set; }

        public virtual Region Region { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Measure> Measures { get; set; }
    }
}
