using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;

namespace BLL
{
   public class probBll
    {
        public List<probDto> listarProb(probDto dtovar)
        {
            try
            {
                return new ProblemaDal().cargaUsuario(dtovar);
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }
    }
}
