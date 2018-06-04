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
        public List<probDto> listarProb()
        {
            try
            {
                return new ProblemaDal().carregaTudo();
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

        public List<probDto> listaPorId(probDto dtovar)
        {
            try
            {
                return new ProblemaDal().carregaPorId(dtovar);
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }
        public List<probDto> listaPorProf(probDto dtovar)
        {
            try
            {
                return new ProblemaDal().carregaPorProfessor(dtovar);
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }
        public List<probDto> listaPorData(probDto dtovar)
        {
            try
            {
                return new ProblemaDal().carregaPorData(dtovar);
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }
    }
}
