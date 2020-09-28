using System.ComponentModel.DataAnnotations;

namespace PhoneExp.Data.Models
{
    public class Feature
    {
        public int Id { get; set; }
        [Required]
        [StringLength(255)]
        public string Name { get; set; }
        public FeatureType FeatureType { get; set; }
        public int FeatureTypeId { get; set; }
    }
}