﻿using Microsoft.VisualBasic.Devices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Formats.Asn1;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.Security.Principal;

namespace Renda_Familiar
{
    public class Usuarios
    {
        public int ID { get; set; }
        public string login { get; set; }
        public string senha { get; set; }
        public string usuario { get; set; }
        public string Nome { get; set; }
        public string Data_de_nascimento { get; set; }
        public float Saldo { get; set; }
    }
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            Usuarios u = new Usuarios();
            
            string teste = File.ReadAllText("E:\\Trabalhos Puc\\aed-2023-2-mafia-azul\\src\\Renda_Familiar\\Renda_Familiar\\Banco\\Usuarios.json");
            //Como tem mais de um usuario é uma lista
            List<Usuarios> usu  = JsonConvert.DeserializeObject<List<Usuarios>>(teste)
            //usu.Remove(usu[0]);
            //Remove todos que atenderem a condição
            //usu.RemoveAll(x => x.ID == 2);
            //Remove só um
            //usu.Remove(usu.FirstOrDefault(x => x.ID == 2));
            //Serializar = transformar um json ou arquivo de texto em objeto
            //Deserializar = Transformar json em objeto no sistema
            Console.WriteLine(usu);
            //usu[0].ID;
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
