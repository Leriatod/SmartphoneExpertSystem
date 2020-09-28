using System.Collections.ObjectModel;
using System.Collections.Generic;

namespace PhoneExp.Controllers.Dtos
{
    public class FeatureTypeDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<FeatureDto> Features { get; set; }
        public FeatureTypeDto()
        {
            Features = new Collection<FeatureDto>();
        }
    }
}