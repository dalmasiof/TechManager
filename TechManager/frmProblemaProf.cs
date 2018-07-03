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
            txtAula.Text = information.aula;
            carregaGrid();
            lblAviso.Text = "";
            dto.idProb = -1;
            

        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdve_Click(object sender, EventArgs e)
        {
            frmAdvertenciaProf adv = new frmAdvertenciaProf();
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
                    dto.aula = information.aula;
                    dto.data = DateTime.Now;
                    dto.idMaquina = txtID.Text;
                    dto.professor = information.nome;
                    dto.problema = txtProblema.Text;
                

                    bll.novoProb(dto);
                    carregaGrid();
                    lblAviso.Text = "Cadastrado com sucesso";
                    lblAviso.ForeColor = Color.Green;
                    LimpaCampos();
                    txtAula.Text = information.aula;
               
                }
                catch (Exception erro)
                {
                    MessageBox.Show("Falha na conexão com o banco de dados, favor entrar em contato com o T.I.", "Erro de conexão", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

                CurrencyManager cm = (CurrencyManager)BindingContext[bunifuCustomDataGrid1.DataSource];
                cm.EndCurrentEdit();
                cm.ResumeBinding();
                cm.SuspendBinding();

                foreach (DataGridViewRow row in bunifuCustomDataGrid1.Rows)
                {

                    if (Convert.ToString(row.Cells["checado"].Value) == "")

                    {
                        row.Visible = true;

                    }

                    else
                    {
                        row.Visible = false;


                    }


                }
            }
            catch (Exception erro)
            {
                MessageBox.Show("Falha na conexão com o banco de dados, favor entrar em contato com o T.I." , "Erro de conexão", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if(dto.idProb == -1)
            {
                lblAviso.Text = "É precio escolher um problema clicando sobre ele para altera-lo";
                lblAviso.ForeColor = Color.Red;
                return;
            }
            dto.idMaquina = txtID.Text;
            dto.problema = txtProblema.Text;
            
            try
            {
                bll.alteraProblema(dto);
                carregaGrid();
                lblAviso.Text = "Problema alterado com sucesso";
                lblAviso.ForeColor = Color.Green;
            }
            catch(Exception erro)
            {
                MessageBox.Show(""+erro);
            }
           
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (dto.idProb == -1)
            {
                lblAviso.Text = "É precio escolher um problema clicando sobre ele para deleta-lo";
                lblAviso.ForeColor = Color.Red;
                return;
            }
            try
            {
                bll.deletaProb(dto);
                carregaGrid();
                lblAviso.Text = "Problema deletado com sucesso";
                lblAviso.ForeColor = Color.Green;
                LimpaCampos();
            }
            catch (Exception erro)
            {
                MessageBox.Show("" + erro);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpaCampos();
            dto.idProb = -1;
            lblAviso.Text = "Clique em um problema para alterá-lo ou exclui-lo";
            lblAviso.ForeColor = Color.Black;
        }
        private void LimpaCampos()
        {
            foreach (Control c in this.Controls)
            {
                if (c is TextBox)
                {
                    (c as Control).Text = "";
                }
            }
        }

        private void bunifuCustomDataGrid1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int sel = bunifuCustomDataGrid1.CurrentRow.Index;
            txtID.Text = Convert.ToString(bunifuCustomDataGrid1["Column3", sel].Value);
            txtProblema.Text = Convert.ToString(bunifuCustomDataGrid1["Column4", sel].Value);
            dto.idProb = Convert.ToInt32(bunifuCustomDataGrid1["id", sel].Value);
        }
    }
}
