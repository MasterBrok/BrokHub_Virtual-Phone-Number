using System.Windows.Media;

namespace VirtualPhoneNumber.Models
{
    /// <summary>
    /// Services Platformes (Telefram Or Instagram Or , , , ,)
    /// </summary>
    public class Service
    {
        public int? ID { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public bool? IsActive{ get; set; }
        public PathGeometry? Svg { get; set; }
    }
}
