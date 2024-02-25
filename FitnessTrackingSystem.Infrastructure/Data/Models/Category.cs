using FitnessTrackingSystem.Infrastructure.Data.DataConstants;
using System.ComponentModel.DataAnnotations;

namespace FitnessTrackingSystem.Infrastructure.Data.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(CategoryDataConstants.MaxCategoryNameLength)]
        public string Name { get; set; } = string.Empty;
    }
}
