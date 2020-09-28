using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;

namespace PhoneExp.Data.Models
{
    public class FeatureType
    {
        public int Id { get; set; }
        [Required]
        [StringLength(255)]
        public string Name { get; set; }
        public ICollection<Feature> Features { get; set; }
        public FeatureType()
        {
            Features = new Collection<Feature>();
        }
    }
}