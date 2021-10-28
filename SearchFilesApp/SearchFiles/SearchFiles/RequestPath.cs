using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchFiles
{
    public class RequestPath
    {
        [Key]
        public int PathId { get; set; }
        [Required]
        
        public string Path { get; set; }

    }
}
