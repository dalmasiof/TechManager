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
        usuarioDAL dal = new usuarioDAL();

        public void novoUsuario(usuarioDTO dtovar)
        {
            try
            {

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

        public List<usuarioDTO> listaUsuario()
        {
            try
            {
                return new usuarioDAL().lista();
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }
        public void deleteUsu (usuarioDTO dto)
        {
            try
            {
                dal.deletaUsuario(dto);
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }
    }
}
