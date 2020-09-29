using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PhoneExp.Data.Models
{
    public class Phone
    {
        public int Id { get; set; }
        [Required]
        [StringLength(255)]
        public string Name { get; set; }
        [Required]
        [StringLength(255)]
        public string DescriptionUrl { get; set; }
        [Required]
        [StringLength(255)]
        public string ImageUrl { get; set; }
        public ICollection<PhoneFeature> Features { get; set; }

        public Phone()
        {
            Features = new Collection<PhoneFeature>();
        }
    }
}