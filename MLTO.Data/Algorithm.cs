using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MLTO.Data
{
    public class Algorithm
    {
        [Key]
        public int AlgorithmId { get; set; }

        [Required]
        public Guid OwnerId { get; set; }

        [Required]
        public string LearningAlgorithm { get; set; }

        [Display(Prompt = "Self-estimated level of mastery  (0-10 scale)")]
        [Range(0,10, ErrorMessage = "Please enter an integer between 0 and 10")]
        public int MasteryLevel { get; set; }

        [Required]
        public DateTimeOffset CreatedUtc { get; set; }
        
        public DateTimeOffset? ModifiedUtc { get; set; }
    }
}
