using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TechManager
{
    public partial class frmSplash : Form
    {
        public frmSplash()
        {
            InitializeComponent();
            Desaparece();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            bool ativo = true;

            if (ativo == true)
            {
                bunifuCircleProgressbar1.Value += 1;

            }
            if (bunifuCircleProgressbar1.Value == 99)
            {
                ativo = false;
                timer1.Enabled = false;
                frmLogin janela = new frmLogin();
                janela.Show();
                this.Hide();
            }

        }
        public void Desaparece()
        {
            this.timer1.Tick += new EventHandler(timer1_Tick);
            timer1.Enabled = true;
            bunifuCircleProgressbar1.Value = 1;
        }
    }
}
