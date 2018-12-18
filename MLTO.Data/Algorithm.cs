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

        public string LearningStyle { get; set; }

        public string LearningType { get; set; }

        [Required]
        public int MasteryLevel { get; set; }
        
        [Required]
        public DateTimeOffset CreatedUtc { get; set; }
        
        public DateTimeOffset? ModifiedUtc { get; set; }
    }
}
