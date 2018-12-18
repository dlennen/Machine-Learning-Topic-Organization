using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MLTO.Models
{
    public class AlgorithmDetail
    {
        [Display(Name = "ID")]
        public int AlgorithmId { get; set; }

        [Display(Name = "Algorithm")]
        public string LearningAlgorithm { get; set; }

        [Display(Name = "Mastery Level")]
        public int MasteryLevel { get; set; }

        [Display(Name = "Learning Style")]
        public string LearningStyle { get; set; }

        [Display(Name = "Learning Type")]
        public string LearningType { get; set; }

        [Display(Name = "Created")]
        public DateTimeOffset CreatedUtc { get; set; }

        [Display(Name = "Last Modification")]
        public DateTimeOffset? ModifiedUtc { get; set; }

        public override string ToString() => $"[{AlgorithmId}] {LearningAlgorithm}";
    }
}
