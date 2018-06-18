using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;

namespace BLL
{
    public class advertenciaBLL
    {
        advertenciaDAL dal = new advertenciaDAL();

        public List<advertenciaDTO> listarProb()
        {
            try
            {
                return new advertenciaDAL().carregaTudo();
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }
    }
}
