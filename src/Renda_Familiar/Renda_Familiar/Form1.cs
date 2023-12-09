namespace Renda_Familiar
{
    public partial class Form1 : Form
    {
        public Form1(List<Usuarios> usu, Usuarios u)
        {
            InitializeComponent();

            atualizaValores(u);
        }

        public void atualizaValores(Usuarios u)
        {
            label9.Text = "Bem vindo (a)" + u.nome;
            float saldoAtual = 0;

            listBox1.Items.Add("|     ID     | ------- |      TIPO       | -------- |        DATA       | --------------- |       VALOR      |");
            foreach (Transacao tra in u.transacoes)
            {
                listBox1.Items.Add("|    " + tra.ID.ToString() + "   |         |      " + tra.tipo.ToString() + "   |           |     " + tra.data.ToString() + "   |   " + tra.valor.ToString() + "    |");
                if(tra.tipo == "Receita")
                {
                    saldoAtual += tra.valor;
                }
                else
                {
                    saldoAtual -= tra.valor;
                }
            }
            label6.Text = saldoAtual.ToString();
        }

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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }
    }
}