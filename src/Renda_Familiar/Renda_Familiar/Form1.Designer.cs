namespace Renda_Familiar
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);


        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        public void InitializeComponent()
        {
            label2 = new Label();
            label1 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            textBox1 = new TextBox();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            label10 = new Label();
            button1 = new Button();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            label14 = new Label();
            label15 = new Label();
            label12 = new Label();
            label13 = new Label();
            modoNoturno = new CheckBox();
            linkLabel1 = new LinkLabel();
            label9 = new Label();
            dataGridView1 = new DataGridView();
            label11 = new Label();
            linkLabel3 = new LinkLabel();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 32.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ActiveCaption;
            label2.Location = new Point(23, 34);
            label2.Name = "label2";
            label2.Size = new Size(437, 51);
            label2.TabIndex = 1;
            label2.Text = "Controle de finanças";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.InactiveCaptionText;
            label1.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(38, 73);
            label1.Name = "label1";
            label1.Size = new Size(187, 31);
            label1.TabIndex = 3;
            label1.Text = "Total entrada";
            label1.Click += label1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.InactiveCaptionText;
            label3.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(749, 186);
            label3.Name = "label3";
            label3.Size = new Size(0, 37);
            label3.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.InactiveCaptionText;
            label4.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(287, 73);
            label4.Name = "label4";
            label4.Size = new Size(158, 31);
            label4.TabIndex = 5;
            label4.Text = "Total saída";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.ControlLightLight;
            label5.Location = new Point(23, 116);
            label5.Name = "label5";
            label5.Size = new Size(199, 37);
            label5.TabIndex = 6;
            label5.Text = "Saldo atual:";
            label5.Click += label5_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = SystemColors.ControlLightLight;
            label6.Location = new Point(391, 116);
            label6.Name = "label6";
            label6.Size = new Size(136, 37);
            label6.TabIndex = 7;
            label6.Text = "R$10:00";
            label6.Click += label6_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = Color.SpringGreen;
            label7.Location = new Point(74, 125);
            label7.Name = "label7";
            label7.Size = new Size(101, 29);
            label7.TabIndex = 8;
            label7.Text = "R$10:00";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label8.ForeColor = Color.Red;
            label8.Location = new Point(313, 125);
            label8.Name = "label8";
            label8.Size = new Size(101, 29);
            label8.TabIndex = 9;
            label8.Text = "R$10:00";
            label8.Click += label8_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(252, 77);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(226, 29);
            textBox1.TabIndex = 11;
            textBox1.Text = "00.00";
            textBox1.TextAlign = HorizontalAlignment.Right;
            textBox1.TextChanged += textBox1_TextChanged;
            textBox1.KeyPress += textBox1_KeyPress;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            radioButton1.ForeColor = SystemColors.ControlLightLight;
            radioButton1.Location = new Point(37, 39);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(74, 24);
            radioButton1.TabIndex = 12;
            radioButton1.TabStop = true;
            radioButton1.Text = "Débito";
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            radioButton2.ForeColor = SystemColors.ControlLightLight;
            radioButton2.Location = new Point(37, 84);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(78, 24);
            radioButton2.TabIndex = 13;
            radioButton2.TabStop = true;
            radioButton2.Text = "Crédito";
            radioButton2.UseVisualStyleBackColor = true;
            radioButton2.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = SystemColors.InactiveCaptionText;
            label10.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label10.ForeColor = SystemColors.ButtonHighlight;
            label10.Location = new Point(252, 41);
            label10.Name = "label10";
            label10.Size = new Size(50, 20);
            label10.TabIndex = 14;
            label10.Text = "Valor:";
            // 
            // button1
            // 
            button1.BackColor = Color.DodgerBlue;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = Color.Black;
            button1.Location = new Point(153, 136);
            button1.Name = "button1";
            button1.Size = new Size(207, 31);
            button1.TabIndex = 15;
            button1.Text = "Enviar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(radioButton1);
            groupBox1.Controls.Add(radioButton2);
            groupBox1.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.ForeColor = SystemColors.ControlLightLight;
            groupBox1.Location = new Point(23, 186);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(503, 189);
            groupBox1.TabIndex = 20;
            groupBox1.TabStop = false;
            groupBox1.Text = "Nova operação";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label14);
            groupBox2.Controls.Add(label15);
            groupBox2.Controls.Add(label12);
            groupBox2.Controls.Add(label13);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(label4);
            groupBox2.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox2.ForeColor = SystemColors.ControlLightLight;
            groupBox2.Location = new Point(558, 186);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(483, 403);
            groupBox2.TabIndex = 21;
            groupBox2.TabStop = false;
            groupBox2.Text = "Operações";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label14.ForeColor = Color.SpringGreen;
            label14.Location = new Point(74, 282);
            label14.Name = "label14";
            label14.Size = new Size(101, 29);
            label14.TabIndex = 12;
            label14.Text = "R$10:00";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label15.ForeColor = Color.Red;
            label15.Location = new Point(313, 282);
            label15.Name = "label15";
            label15.Size = new Size(101, 29);
            label15.TabIndex = 13;
            label15.Text = "R$10:00";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = SystemColors.InactiveCaptionText;
            label12.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label12.ForeColor = SystemColors.ButtonHighlight;
            label12.Location = new Point(38, 227);
            label12.Name = "label12";
            label12.Size = new Size(193, 31);
            label12.TabIndex = 10;
            label12.Text = "Maior entrada";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.BackColor = SystemColors.InactiveCaptionText;
            label13.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label13.ForeColor = SystemColors.ButtonHighlight;
            label13.Location = new Point(287, 227);
            label13.Name = "label13";
            label13.Size = new Size(164, 31);
            label13.TabIndex = 11;
            label13.Text = "Maior saida";
            // 
            // modoNoturno
            // 
            modoNoturno.AutoSize = true;
            modoNoturno.Checked = true;
            modoNoturno.CheckState = CheckState.Checked;
            modoNoturno.ForeColor = SystemColors.ButtonHighlight;
            modoNoturno.Location = new Point(937, 782);
            modoNoturno.Name = "modoNoturno";
            modoNoturno.Size = new Size(104, 19);
            modoNoturno.TabIndex = 23;
            modoNoturno.Text = "Modo noturno";
            modoNoturno.UseVisualStyleBackColor = true;
            modoNoturno.CheckedChanged += modoNoturno_CheckedChanged;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            linkLabel1.Location = new Point(23, 778);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(37, 21);
            linkLabel1.TabIndex = 24;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Sair";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Microsoft Sans Serif", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = Color.Transparent;
            label9.Location = new Point(536, 42);
            label9.Name = "label9";
            label9.Size = new Size(514, 42);
            label9.TabIndex = 25;
            label9.Text = "Bem vindo Matheus Canuto!";
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.Black;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.GridColor = Color.White;
            dataGridView1.Location = new Point(23, 468);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(503, 121);
            dataGridView1.TabIndex = 26;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label11.ForeColor = Color.Transparent;
            label11.Location = new Point(23, 401);
            label11.Name = "label11";
            label11.Size = new Size(239, 29);
            label11.TabIndex = 27;
            label11.Text = "Lista de transações";
            // 
            // linkLabel3
            // 
            linkLabel3.AutoSize = true;
            linkLabel3.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            linkLabel3.Location = new Point(520, 663);
            linkLabel3.Name = "linkLabel3";
            linkLabel3.Size = new Size(44, 25);
            linkLabel3.TabIndex = 29;
            linkLabel3.TabStop = true;
            linkLabel3.Text = "Sair";
            linkLabel3.LinkClicked += linkLabel3_LinkClicked;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(1053, 758);
            Controls.Add(linkLabel3);
            Controls.Add(label11);
            Controls.Add(dataGridView1);
            Controls.Add(label9);
            Controls.Add(linkLabel1);
            Controls.Add(modoNoturno);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label2);
            Name = "Form1";
            Text = "Controle de finanças";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private Label label1;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox textBox1;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private Label label10;
        private Button button1;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        public CheckBox modoNoturno;
        private LinkLabel linkLabel1;
        private Label label9;
        private DataGridView dataGridView1;
        private Label label11;
        private LinkLabel linkLabel3;
        private Label label14;
        private Label label15;
        private Label label12;
        private Label label13;
    }
}