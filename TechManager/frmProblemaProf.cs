using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BLL;

namespace TechManager
{
    public partial class frmProblemaProf : Form
    {
        probDto dto = new probDto();
        public frmProblemaProf()
        {
            InitializeComponent();
        }
        probBll bll = new probBll();
        private void frmProblema_Load(object sender, EventArgs e)
        {
            pcbProfessor.ImageLocation = information.foto; 
            lblData.Text = DateTime.Now.ToString();
            lblNome.Text = information.nome;
            carregaGrid();
            lblAviso.Text = "";
            

        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdve_Click(object sender, EventArgs e)
        {
            frmAdvertenciaTecnico adv = new frmAdvertenciaTecnico();
            adv.ShowDialog();
        }

        private void btngravar_Click(object sender, EventArgs e)
        {
            if(!verificaCampos())
            {
                lblAviso.Text = "Preencha os campos vazios";
                lblAviso.ForeColor = Color.Red;

            }
            else
            {
            try
            {
                dto.aula = txtAula.Text;
                dto.data = DateTime.Now;
                dto.idMaquina = txtID.Text;
                dto.professor = information.nome;
                dto.problema = txtProblema.Text;
                

                bll.novoProb(dto);
                carregaGrid();
                lblAviso.Text = "Cadastrado com sucesso";
                lblAviso.ForeColor = Color.Green;
                foreach(Control c in this.Controls)
                    {
                         if(c is TextBox)
                        {
                            (c as Control).Text = "";
                        }
                    }
            }
            catch (Exception erro)
            {
                MessageBox.Show("" + erro);
            }

            }
        }
        private bool verificaCampos()
        {
            if ((txtAula.Text == "") || (txtID.Text == "") || (txtProblema.Text == ""))
            {
                
                return false;
            }
            return true;

        }
      
        private void carregaGrid()
        {
            bunifuCustomDataGrid1.AutoGenerateColumns = false;
            try
            {
                List<probDto> ListDto = new List<probDto>();
                ListDto = new probBll().listarProb();
                bunifuCustomDataGrid1.DataSource = ListDto;
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {

        }
    }
}
