using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace PhoneExp.Controllers.Dtos
{
    public class PhoneDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string DescriptionUrl { get; set; }
        public string ImageUrl { get; set; }
        public ICollection<int> FeaturesIds { get; set; }
        public PhoneDto()
        {
            FeaturesIds = new Collection<int>();
        }
    }
}