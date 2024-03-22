using FitnessTrackingSystem.Infrastructure.Data.DataConstants;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace FitnessTrackingSystem.Core.Models.Trainer
{
    public class BecomeTrainerFormModel
    {
        [Required(ErrorMessage=ErrorMessages.RequiredMessage)]
        [StringLength(
            TrainerDataConstants.MaxTrainerFullNameLength,
            MinimumLength = TrainerDataConstants.MinTrainerFullNameLength,
            ErrorMessage=ErrorMessages.LengthMessage)]
        [Display(Name="Full name")]
        public string FullName { get; set; } =string.Empty;

        [Required(ErrorMessage = ErrorMessages.RequiredMessage)]
        [StringLength(
            TrainerDataConstants.MaxTrainerPhoneNumLength,
            MinimumLength = TrainerDataConstants.MinTrainerPhoneNumLength,
            ErrorMessage = ErrorMessages.LengthMessage)]
        [Display(Name = "Phone number")]
        [Phone]
        public string PhoneNumber { get; set; } = string.Empty;

        [StringLength(
            TrainerDataConstants.MaxTrainerBioLength,
            MinimumLength = TrainerDataConstants.MinTrainerBioLength,
            ErrorMessage = ErrorMessages.LengthMessage)]
        [Display(Name = "Biography")]
        public string Biography {  get; set; } = string.Empty;  

    }
}
