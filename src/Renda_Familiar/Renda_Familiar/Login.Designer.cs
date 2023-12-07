namespace Renda_Familiar
{
    partial class Login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            linkLabel1 = new LinkLabel();
            textBox2 = new TextBox();
            label1 = new Label();
            textBox1 = new TextBox();
            button1 = new Button();
            label10 = new Label();
            modoNoturno = new CheckBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(linkLabel1);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(label10);
            groupBox1.Font = new Font("Roboto", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.ForeColor = SystemColors.ControlLightLight;
            groupBox1.Location = new Point(157, 125);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(503, 219);
            groupBox1.TabIndex = 21;
            groupBox1.TabStop = false;
            groupBox1.Text = "Login";
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Font = new Font("Roboto", 12F, FontStyle.Bold, GraphicsUnit.Point);
            linkLabel1.Location = new Point(197, 126);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(103, 19);
            linkLabel1.TabIndex = 18;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Cadastre-se";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(224, 84);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(226, 19);
            textBox2.TabIndex = 17;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.InactiveCaptionText;
            label1.Font = new Font("Roboto", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(38, 84);
            label1.Name = "label1";
            label1.Size = new Size(58, 19);
            label1.TabIndex = 16;
            label1.Text = "Senha:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(224, 46);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(226, 19);
            textBox1.TabIndex = 11;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // button1
            // 
            button1.BackColor = Color.White;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Roboto", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = Color.Black;
            button1.Location = new Point(154, 162);
            button1.Name = "button1";
            button1.Size = new Size(207, 31);
            button1.TabIndex = 15;
            button1.Text = "Enviar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = SystemColors.InactiveCaptionText;
            label10.Font = new Font("Roboto", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label10.ForeColor = SystemColors.ButtonHighlight;
            label10.Location = new Point(38, 46);
            label10.Name = "label10";
            label10.Size = new Size(67, 19);
            label10.TabIndex = 14;
            label10.Text = "Usuário:";
            // 
            // modoNoturno
            // 
            modoNoturno.AutoSize = true;
            modoNoturno.Checked = true;
            modoNoturno.CheckState = CheckState.Checked;
            modoNoturno.ForeColor = SystemColors.ButtonHighlight;
            modoNoturno.Location = new Point(684, 419);
            modoNoturno.Name = "modoNoturno";
            modoNoturno.Size = new Size(104, 19);
            modoNoturno.TabIndex = 24;
            modoNoturno.Text = "Modo noturno";
            modoNoturno.UseVisualStyleBackColor = true;
            modoNoturno.CheckedChanged += modoNoturno_CheckedChanged;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(800, 450);
            Controls.Add(modoNoturno);
            Controls.Add(groupBox1);
            Name = "Login";
            Text = "Login";
            Load += Login_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox textBox1;
        private Button button1;
        private Label label10;
        private TextBox textBox2;
        private Label label1;
        public CheckBox modoNoturno;
        private LinkLabel linkLabel1;
    }
}