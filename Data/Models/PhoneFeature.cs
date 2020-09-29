namespace PhoneExp.Data.Models
{
    public class PhoneFeature
    {
        public Phone Phone { get; set; }
        public int PhoneId { get; set; }
        public Feature Feature { get; set; }
        public int FeatureId { get; set; }
    }
}