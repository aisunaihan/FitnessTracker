using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessTrackingSystem.Infrastructure.Data.Models
{
    public class Video
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string VideoName { get; set; }

        [Required]
        public string VideoPath { get; set; }

        public byte[] VideoData { get; set; }
    }
}
