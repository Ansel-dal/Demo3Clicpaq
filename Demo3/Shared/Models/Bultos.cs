using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo3.Shared.Models
{
    public class Bultos
    {
        public string Id { get; set; }
        public List<string> List = new() { };
        public string CSS { get; set; }
        public int cantidadBultos { get; set; }
        public bool finish = false;
    }
}
