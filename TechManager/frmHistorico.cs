using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;

namespace TechManager
{
    public partial class frmHistorico : Form
    {
        public frmHistorico()
        {
            InitializeComponent();
        }
        probDto dtoVar = new probDto();
        private void frmHistorico_Load(object sender, EventArgs e)
        {
            usuarioDTO dto = new usuarioDTO();

            lblNome.Text = dto.nome;

            cmbHist.AddItem("Consultar por:");
            cmbHist.AddItem("ID Máquina");
            cmbHist.AddItem("Professor");
            cmbHist.AddItem("Data");

            cmbHist.selectedIndex = 0;

            carregaGrid();


        }

        private void txtUser_MouseClick(object sender, MouseEventArgs e)
        {
            if(txtUser.Text == ("Selecione um método de consulta") || txtUser.Text == ("Digite o ID da máquina") || 
                txtUser.Text == ("Digite o nome do Professor") || txtUser.Text == ("Digite a data"))
            {
                txtUser.Clear();
            }
            
        }

        private void cmbHist_onItemSelected(object sender, EventArgs e)
        {
           switch (cmbHist.selectedIndex)
            {
                case 0:
                    txtUser.Enabled = false;
                    txtUser.Text = "Selecione um método de consulta";
                    txtUser.ForeColor = Color.Gray;
                    break;

                    case 1:
                    txtUser.Enabled = true;
                    txtUser.ForeColor = Color.Black;
                    txtUser.Text = "Digite o ID da máquina";
                    break;

                case 2:
                    txtUser.Enabled = true;
                    txtUser.ForeColor = Color.Black;
                    txtUser.Text = "Digite o nome do Professor";
                    break;

                case 3:
                    txtUser.Enabled = true;
                    txtUser.ForeColor = Color.Black;
                    txtUser.Text = Convert.ToString(DateTime.Now);
                    break;



            }
        }

        private void txtUser_TextChanged(object sender, EventArgs e)
        {
            switch (cmbHist.selectedIndex)
            {
                case 0:
                    {
                        carregaGrid();
                        break;
                    }
                case 1:
                    dtoVar.idMaquina = (txtUser.Text);
                    try
                    {
                        List<probDto> ListDto = new List<probDto>();
                        ListDto = new probBll().listaPorId(dtoVar);
                        dgvHist.DataSource = ListDto;
                    }
                    catch (Exception erro)
                    {
                        throw erro;
                    }
                    break;

                case 2:
                    dtoVar.professor = (txtUser.Text);
                    try
                    {
                        List<probDto> ListDto = new List<probDto>();
                        ListDto = new probBll().listaPorProf(dtoVar);
                        dgvHist.DataSource = ListDto;
                    }
                    catch (Exception erro)
                    {
                        throw erro;
                    }
                    break;

                case 3:
                    
                    dtoVar.data = Convert.ToString(txtUser.Text);
                    try
                    {
                        List<probDto> ListDto = new List<probDto>();
                        ListDto = new probBll().listaPorData(dtoVar);
                        dgvHist.DataSource = ListDto;
                    }
                    catch (Exception erro)
                    {
                        throw erro;
                    }
                    break;
            }
        }

        private void carregaGrid()
        {
            dgvHist.AutoGenerateColumns = false;
            try
            {
                List<probDto> ListDto = new List<probDto>();
                ListDto = new probBll().listarProb();
                dgvHist.DataSource = ListDto;
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dtoVar.idMaquina = (txtUser.Text);
            try
            {
                List<probDto> ListDto = new List<probDto>();
                ListDto = new probBll().listaPorId(dtoVar);
                dgvHist.DataSource = ListDto;
            }
            catch (Exception erro)
            {
                throw erro;
            }


        }
    }
}
