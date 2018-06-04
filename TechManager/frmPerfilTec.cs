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

namespace TechManager
{
    public partial class frmPerfilTec : Form
    {
        public frmPerfilTec(int idLogon, string nomeLogon)
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void frmPerfilTec_Load(object sender, EventArgs e)
        {
            lblNome.Text = Convert.ToString(information.id);
        }

       
    }
}
