using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace case_in.Models
{
    public class Error
    {
        public DateTime DateTime { get; set; }
        public int MachineId { get; set; }
        public string ErrorId { get; set; }
    }
}