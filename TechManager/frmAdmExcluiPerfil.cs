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
            lblId.Text = "";
            lblNome.Text = "";
            carregaGrid();
        }

        private void carregaGrid()
        {
            dgvExclui.AutoGenerateColumns = false;
            try
            {
                List<usuarioDTO> ListDto = new List<usuarioDTO>();
                ListDto = new usuarioBLL().listaUsuario();
                dgvExclui.DataSource = ListDto;
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

        private void dgvExclui_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int sel = dgvExclui.CurrentRow.Index;

            lblNome.Text = Convert.ToString(dgvExclui["nome", sel].Value);
            lblId.Text = Convert.ToString(dgvExclui["id", sel].Value);

           
            dto.id = Convert.ToInt32(dgvExclui["id", sel].Value);





        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(lblId.Text == "")
            {
            MessageBox.Show("Selecione um usuário acima clicando sobree ele", "Usuário não selecionado", MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }
            else
            {
                try
                {
                    usuarioBLL bll = new usuarioBLL();
                    bll.deleteUsu(dto);
                }
                catch (Exception erro)
                {
                    throw erro;
                }
                carregaGrid();

            }
        }
    }
}
