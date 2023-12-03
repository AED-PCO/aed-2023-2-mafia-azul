using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Renda_Familiar
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void modoNoturno_CheckedChanged(object sender, EventArgs e)
        {
            if (modoNoturno.Checked)
            {
                BackColor = Color.Black;
                groupBox1.ForeColor = Color.Black;
                groupBox1.ForeColor = Color.White;
                label10.ForeColor = Color.White;
                label10.BackColor = Color.Black;
                label1.ForeColor = Color.White;
                label1.BackColor = Color.Black;
                modoNoturno.BackColor = Color.Black;
                modoNoturno.ForeColor = Color.White;
            }
            else
            {
                BackColor = Color.White;
                groupBox1.ForeColor = Color.Black;
                label10.ForeColor = Color.Black;
                label10.BackColor = Color.White;
                label1.ForeColor = Color.Black;
                label1.BackColor = Color.White;
                modoNoturno.BackColor = Color.White;
                modoNoturno.ForeColor = Color.Black;
            }
        }

        public void button1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new ();
            form1.Show();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
