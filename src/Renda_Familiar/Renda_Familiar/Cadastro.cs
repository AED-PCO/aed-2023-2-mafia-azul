using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.Design.AxImporter;

namespace Renda_Familiar
{
    public partial class Cadastro : Form
    {
        public Cadastro()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0 && textBox2.Text.Length > 0 && textBox3.Text.Length > 0 && textBox4.Text.Length > 0 && textBox5.Text.Length > 0)
            {
                string caminho = "E:\\Trabalhos Puc\\aed-2023-2-mafia-azul\\src\\Renda_Familiar\\Renda_Familiar\\Banco\\Usuarios.json";
                string Json = File.ReadAllText("E:\\Trabalhos Puc\\aed-2023-2-mafia-azul\\src\\Renda_Familiar\\Renda_Familiar\\Banco\\Usuarios.json");
                //Transforma string em json
                List<Usuarios> usu = JsonConvert.DeserializeObject<List<Usuarios>>(Json);

                Usuarios u = new Usuarios();
                u.ID = 123;
                u.usuario = textBox1.Text;
                u.senha = textBox2.Text;
                u.nome = textBox3.Text;
                u.data_de_nascimento = textBox4.Text;
                u.saldo = 0;
                usu.Add(u);

                Json = "";
                Json = JsonConvert.SerializeObject(usu);

                File.WriteAllText(caminho, Json);

                MessageBox.Show("Cadastro Efetuado com sucesso! Faça login para continuar!", "Sucesso", MessageBoxButtons.OK);
                this.Hide();
                Login login = new();
                login.Show();
            }
            else
            {
                MessageBox.Show("Nenhum campo pode estar vazio!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void modoNoturno_CheckedChanged(object sender, EventArgs e)
        {
            if (!modoNoturno.Checked)
            {
                this.BackColor = Color.White;
                groupBox1.ForeColor = Color.Black;

                label1.BackColor = Color.White;
                label2.BackColor = Color.White;
                label3.BackColor = Color.White;
                label4.BackColor = Color.White;
                label10.BackColor = Color.White;

                label1.ForeColor = Color.Black;
                label2.ForeColor = Color.Black;
                label3.ForeColor = Color.Black;
                label4.ForeColor = Color.Black;
                label10.ForeColor = Color.Black;
            }
            else
            {
                this.BackColor = Color.Black;
                groupBox1.ForeColor = Color.White;

                label1.BackColor = Color.Black;
                label2.BackColor = Color.Black;
                label3.BackColor = Color.Black;
                label4.BackColor = Color.Black;
                label10.BackColor = Color.Black;

                label1.ForeColor = Color.White;
                label2.ForeColor = Color.White;
                label3.ForeColor = Color.White;
                label4.ForeColor = Color.White;
                label10.ForeColor = Color.White;
            }
        }

        private void Cadastro_Load(object sender, EventArgs e)
        {

        }
    }
}
