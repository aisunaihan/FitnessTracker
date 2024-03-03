using FitnessTrackingSystem.Infrastructure.Data.DataConstants;
using System.ComponentModel.DataAnnotations;

namespace FitnessTrackingSystem.Infrastructure.Data.Models
{
    public class Supplies
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(SuppliesDataConstants.MaxSupplyNameLength)]
        public string Name { get; set; }

    }
}
