using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MLTO.Data
{
    public class Algorithm
    {
        public int NoteId { get; set; }
        public Guid OwnerId { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        //ddd​
     public DateTimeOffset CreatedUtc { get; set; }
​
     public DateTimeOffset? ModifiedUtc { get; set; }
    }
}
