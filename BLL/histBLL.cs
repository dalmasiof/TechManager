using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;

namespace BLL
{
    public class histBLL
    {
        public List<histDto> listarTudo()
        {
            try
            {
                return new histDal().carregaTudo();
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

        public List<histDto> listarId(histDto dtovar)
        {
            try
            {
                return new histDal().carregaId(dtovar);
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

        public List<histDto> listarProf(histDto dtovar)
        {
            try
            {
                return new histDal().carregaProf(dtovar);
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

        public List<histDto> listaPorData()
        {
            try
            {
                return new histDal().carregaDataAntiga();
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

        public List<histDto> listaPorDataAtual()
        {
            try
            {
                return new histDal().carregaDataAtual();
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }
    }
}
