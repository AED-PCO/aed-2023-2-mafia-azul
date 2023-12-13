using Renda_Familiar.Classes;

namespace Renda_Familiar
{
    public partial class Form1 : Form
    {
        public void setValores(List<Usuarios> usu, Usuarios u)
        {
            List<Usuarios> uList = usu;
            Usuarios usua = u;
        }
        public Form1(List<Usuarios> usu, Usuarios u)
        {
            InitializeComponent();
            atualizaValores(u);
            //Criar uma pasta para as classes e colocar cada uma em um arquivo
        }

        public void atualizaValores(Usuarios u)
        {
            label9.Text = "Bem vindo (a)" + u.nome;
            Decimal saldoAtual = 0;
            Decimal totalEntrada = 0;
            Decimal totalSaida = 0;

            foreach (Transacao tra in u.transacoes)
            {
                if (tra.tipo == "Receita")
                {
                    totalEntrada += tra.valor;
                    saldoAtual += tra.valor;
                }
                else
                {
                    totalSaida += tra.valor;
                    saldoAtual -= tra.valor;
                }
            }
            label7.Text = "R$" + totalEntrada.ToString();
            label8.Text = "R$" + totalSaida.ToString();
            label6.Text = "R$" + (totalEntrada - totalSaida).ToString();
            u.saldo = totalEntrada - totalSaida;

            dataGridView1.DataSource = u.transacoes;
        }
        #region eventos
        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        #endregion

        private void modoNoturno_CheckedChanged(object sender, EventArgs e)
        {
            if (modoNoturno.Checked)
            {
                BackColor = Color.Black;
            }
            else
            {
                BackColor = Color.White;
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.Show();
        }

        #region TrocaRadio
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            radioButton2.Checked = false;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            radioButton1.Checked = false;
        }
        #endregion

        private void button1_Click_1(object sender, EventArgs e)
        {
            if ((radioButton1.Checked || radioButton2.Checked) && textBox1.TextLength > 0)
            {
                string data = DateTime.Now.ToString("yyyy-MM-dd");
                Usuarios u = new Usuarios();
                Transacao tran = new Transacao();

                if (radioButton1.Checked)
                {
                    tran.tipo = "Receita";
                }
                else
                {
                    tran.tipo = "Despesa";
                }
                tran.valor = Convert.ToDecimal(textBox1.Text);
                tran.data = data;
                tran.ID = 123;

                u.transacoes.Add(tran);
                atualizaValores(u);
            }
            else
            {
                MessageBox.Show("Não é possível fazer uma transação sem selecionar um tipo ou digitar um valor", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
    }
}