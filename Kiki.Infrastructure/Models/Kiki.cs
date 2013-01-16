
using System.ComponentModel.DataAnnotations;

namespace Kiki.Infrastructure.Models
{
    public class Kiki
    {
        [Key]
        public long Id { get; set; }

        [StringLength(100)]
        public string Saying { get; set; }
    }
}
