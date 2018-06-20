using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class probDto
    {
        public int idProb { get; set; }
        public string idMaquina { get; set; }
        public string aula { get; set; }
        public string professor { get; set; }
        public string problema { get; set; }

        public DateTime data { get; set; }
        public string Check { get; set; }


    }
}
