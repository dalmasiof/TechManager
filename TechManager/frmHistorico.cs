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

            lblNome.Text = information.nome;
            pcbProfessor.ImageLocation = information.foto;

            cmbHist.AddItem("Consultar por:");
            cmbHist.AddItem("ID Máquina");
            cmbHist.AddItem("Professor");
            cmbHist.AddItem("Data mais antiga");
            cmbHist.AddItem("Data mais atual");

            cmbHist.selectedIndex = 0;

            carregaGrid();

                      

        }





        private void txtUser_TextChanged(object sender, EventArgs e)
        {
            carregaGrid();
            if (txtUser.Text == "")
            {

                carregaGrid();
            }
        }

        private void carregaGrid()
        {
            dgvHist.AutoGenerateColumns = false;
            try
            {
                List<probDto> ListDto = new List<probDto>();
                ListDto = new probBll().listaHist();


                dgvHist.DataSource = ListDto;

                Pintalinhas();
            }
            catch (Exception erro)
            {
                throw erro;
            }


        }



        private void txtUser_KeyPress(object sender, KeyPressEventArgs e)
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

                        Pintalinhas();

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

                        Pintalinhas();
                    }
                    catch (Exception erro)
                    {
                        throw erro;
                    }
                    break;

                
            }
        }
        private void Pintalinhas()
        {
            foreach (DataGridViewRow row in dgvHist.Rows)
            {

                if (Convert.ToString(row.Cells[5].Value) == "1")

                {
                    row.DefaultCellStyle.BackColor = Color.ForestGreen;
                    row.Cells[5].Value = Convert.ToString("Resolvido");

                }

                else
                {
                    row.DefaultCellStyle.BackColor = Color.Maroon;
                    row.Cells[5].Value = Convert.ToString("Não resolvido");


                }


            }
        }
        private void cmbHist_onItemSelected(object sender, EventArgs e)
        {
            if (cmbHist.selectedIndex == 0)
            {
                txtUser.Text = "Escolha um método de pesquisa";
                txtUser.Enabled = false;
            }
            else if (cmbHist.selectedIndex == 3)
            {
                txtUser.Enabled = false;
                txtUser.Text = "Data mais antiga";
                try
                {
                    List<probDto> ListDto = new List<probDto>();
                    ListDto = new probBll().listaPorData();
                    dgvHist.DataSource = ListDto;

                    Pintalinhas();

                }
                catch (Exception erro)
                {
                    throw erro;
                }
            }
            else if(cmbHist.selectedIndex == 4)
                {
                txtUser.Enabled = false;
                txtUser.Text = "Data mais atual";
                try
                {
                    List<probDto> ListDto = new List<probDto>();
                    ListDto = new probBll().listaPorDataAtual();
                    dgvHist.DataSource = ListDto;

                    Pintalinhas();

                }
                catch (Exception erro)
                {
                    throw erro;
                }
            }
            else
            {
                txtUser.Clear();
                txtUser.Enabled = true;
                txtUser.Focus();
            }
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvHist_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {


            foreach (DataGridViewRow row in dgvHist.Rows)
            {

                if (Convert.ToInt32(row.Cells[5].Value) == 1)

                {
                    row.DefaultCellStyle.BackColor = Color.ForestGreen;
                    row.Cells[5].Value = Convert.ToString("Checado");




                }

                else
                {
                    row.DefaultCellStyle.BackColor = Color.Maroon;
                    row.Cells[5].Value = Convert.ToString("Não checado");


                }
                
            }
        }

        private void dgvHist_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}


