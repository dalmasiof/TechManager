using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;

namespace BLL
{
    public class usuarioBLL
    {
        public void novoUsuario(usuarioDTO dtovar)
        {
            try
            {
                usuarioDAL dal = new usuarioDAL();

                dal.novoUsuario(dtovar);
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public void alterarUsuario(usuarioDTO dtovar)
        {
            try
            {
                usuarioDAL dal = new usuarioDAL();

                dal.alterarUsuario(dtovar);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<usuarioDTO> validar(usuarioDTO dto)
        {
            try
            {
                return new usuarioDAL().validar(dto);
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

        public List<usuarioDTO> validar(object dto)
        {
            throw new NotImplementedException();
        }
    }
}
