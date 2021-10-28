using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchFiles
{
    public class RequestString
    {
        [Key]
        public int RequestId { get; set; }
        [Required]
        public string String { get; set; }
    }
}
