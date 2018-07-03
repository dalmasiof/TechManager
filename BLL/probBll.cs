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
        ProblemaDal dal = new ProblemaDal();

        public List<probDto> listarProb()
        {
            try
            {
                return new ProblemaDal().carregaTec();
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }
        public List<probDto> listarTec()
        {
            try
            {
                return new ProblemaDal().carregaTec();
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

       
       
       
        public void novoProb(probDto dto)
        {
            try
            {

                dal.cadProd(dto);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void alteraSituacao(probDto dtoVar)
        {
            try
            {
                dal.alteraSituacao(dtoVar);
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }
        public List<probDto> notificacao(probDto dtovar)
        {
            try
            {
                return new ProblemaDal().notificaProb(dtovar);
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }
       


        public void alteraProblema(probDto dtovar)
        {
            try
            {
                dal.alteraProb(dtovar);
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

        public void deletaProb(probDto dto)
        {
            try
            {
                dal.deletaProb(dto);
            }
            catch(Exception erro)
            {
                throw erro;
            }
        }
    }
}
