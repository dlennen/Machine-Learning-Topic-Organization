using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MLTO.Data
{
    public class LearningStyleLookUp
    {
        [Key]
        public string LearningAlgorithm { get; set; }
        public string LearningStyle { get; set; }
    }
}
