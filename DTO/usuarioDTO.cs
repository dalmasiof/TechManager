using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class usuarioDTO
    {
        public int id { get; set; }
        public string nome { get; set; }
        public string rg { get; set; }
        public string login { get; set; }
        public string senha { get; set; }
        public string email { get; set; }
        public int tipo { get; set; }
        public string foto { get; set; }

        public string aula { get; set; }


    }
}
