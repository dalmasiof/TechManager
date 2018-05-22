using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class usuarioDTO
    {
        private static string nome;

        public static string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

    }
}
