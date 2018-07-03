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

        public List<advertenciaDTO> listarProbProTec()
        {
            try
            {
                return new advertenciaDAL().carregaTudoPraJustificar();
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }
        public List<advertenciaDTO> notificacaAdv(advertenciaDTO dtovar)
        {
            try
            {
                return new advertenciaDAL().notificaAviso(dtovar);
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }
        public List<advertenciaDTO> listarProbProProf()
        {
            try
            {
                return new advertenciaDAL().carregaTudoPraAdvertencia();
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

        public void novaAdvertencia(advertenciaDTO dtovar)
        {
            try
            {
                dal.novaAdvertencia(dtovar);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void novaJustificativa(advertenciaDTO dtovar)
        {
            try
            {
                dal.novaJustificativa(dtovar);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
