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
    public partial class frmAdmExcluiPerfil : Form
    {
        public frmAdmExcluiPerfil()
        {
            InitializeComponent();
        }

        usuarioDTO dto = new usuarioDTO();


        private void pcbHome_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmAdmExcluiPerfil_Load(object sender, EventArgs e)
        {
            lblAdnm.Text = information.nome;
            carregaGrid();
            lblId.Text = "";
            lblNome.Text = "";
            lblTipo.Text = "";
            dto.id = -1;

        }

       
        
        private void carregaGrid()
        {

            dgvExclui.AutoGenerateColumns = false;
            try
            {
                List<usuarioDTO> ListDto = new List<usuarioDTO>();
                ListDto = new usuarioBLL().listaUsuario();
                dgvExclui.DataSource = ListDto;
                CurrencyManager cm = (CurrencyManager)BindingContext[dgvExclui.DataSource];
                cm.EndCurrentEdit();
                cm.ResumeBinding();
                cm.SuspendBinding();

                foreach (DataGridViewRow row in dgvExclui.Rows)
                {

                    if (Convert.ToInt32(row.Cells["tipo"].Value) == 1)
                    {
                        row.Cells["teste"].Value = Convert.ToString("Professor");
                    }
                    else if (Convert.ToInt32(row.Cells["tipo"].Value) == 2)
                    {
                        row.Cells["teste"].Value = Convert.ToString("Técnico");

                    }

                    else
                    {
                        row.Visible = false;


                    }


                }
            }
            catch (Exception erro)
            {
                throw erro;
            }

        }

        private void dgvExclui_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int sel = dgvExclui.CurrentRow.Index;
            string nome = Convert.ToString(dgvExclui["nome", sel].Value);

            lblNome.Text = Convert.ToString(dgvExclui["nome", sel].Value);
            lblId.Text = Convert.ToString(dgvExclui["idUsuario", sel].Value);
            
            int tipo = Convert.ToInt32(dgvExclui["tipo", sel].Value);
            switch (tipo)
            {
                case 1:
                    lblTipo.Text = "Professor";
                    break;

                case 2:
                     lblTipo.Text = "Técnico";
                    break;

                case 3:
                     lblTipo.Text = "Administrador";
                    break;

            }

            dto.id = Convert.ToInt32(dgvExclui["idUsuario", sel].Value);





        }



        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (dto.id == -1)
            {
                MessageBox.Show("Selecione um usuário acima clicando sobre ele", "Usuário não selecionado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                int sel = dgvExclui.CurrentRow.Index;

                if (DialogResult.Yes == MessageBox.Show("Certeza que deseja excluir o registro de " + Convert.ToString(dgvExclui["nome", sel].Value) +
                   "?", "Excluir registro", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                {
                    try
                    {
                        usuarioBLL bll = new usuarioBLL();
                        bll.deleteUsu(dto);
                        dto.id = -1;
                    }
                    catch (Exception erro)
                    {
                        MessageBox.Show("Erro Inexperado, contate o T.I." , "Erro de conexão", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    carregaGrid();
                    lblNome.Text = "";
                    lblId.Text = "";
                    lblTipo.Text = "";

                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            lblNome.Text = "";
            lblId.Text = "";
            lblTipo.Text = "";
        }
    }
}
