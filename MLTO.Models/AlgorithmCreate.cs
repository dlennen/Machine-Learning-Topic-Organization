using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MLTO.Models
{
    public class AlgorithmCreate
    {
        [Required]
        [Display(Name = "Algorithm")]
        public string LearningAlgorithm { get; set; }

        [Display(Name = "Mastery Level (0 - 10 scale)")]
        [Range(0, 10, ErrorMessage = "Please enter an integer between 0 and 10")]
        public int MasteryLevel { get; set; }

        public override string ToString() => LearningAlgorithm;
    }
}
