using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FoJaJo.Model
{
    public class Result
    {
        public Result() { }
        public Result(int id, string reason) { ResultId = id; Reason = reason; }

        [Key]
        public int ResultId { get; set; }

        public string Reason { get; set; }
    }
}
