using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedibaScanner.Models
{
    public class MyResult
    {
        public string Name { get; set; }
        public int Count { get; set; }
        public string CountString { get { return "Broj predmeta: " + Count; } }
    }
}
