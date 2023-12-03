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
            groupBox3 = new GroupBox();
            modoNoturno = new CheckBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Roboto", 32.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ActiveCaption;
            label2.Location = new Point(23, 34);
            label2.Name = "label2";
            label2.Size = new Size(437, 52);
            label2.TabIndex = 1;
            label2.Text = "Controle de finanças";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.InactiveCaptionText;
            label1.Font = new Font("Roboto", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(38, 59);
            label1.Name = "label1";
            label1.Size = new Size(153, 27);
            label1.TabIndex = 3;
            label1.Text = "Total entrada";
            label1.Click += label1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.InactiveCaptionText;
            label3.Font = new Font("Roboto", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(749, 186);
            label3.Name = "label3";
            label3.Size = new Size(0, 38);
            label3.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.InactiveCaptionText;
            label4.Font = new Font("Roboto", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(287, 59);
            label4.Name = "label4";
            label4.Size = new Size(129, 27);
            label4.TabIndex = 5;
            label4.Text = "Total saída";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Roboto", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.ControlLightLight;
            label5.Location = new Point(616, 45);
            label5.Name = "label5";
            label5.Size = new Size(195, 38);
            label5.TabIndex = 6;
            label5.Text = "Saldo atual:";
            label5.Click += label5_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Roboto", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = SystemColors.ControlLightLight;
            label6.Location = new Point(817, 45);
            label6.Name = "label6";
            label6.Size = new Size(135, 38);
            label6.TabIndex = 7;
            label6.Text = "R$10:00";
            label6.Click += label6_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = Color.SpringGreen;
            label7.Location = new Point(73, 96);
            label7.Name = "label7";
            label7.Size = new Size(82, 23);
            label7.TabIndex = 8;
            label7.Text = "R$10:00";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label8.ForeColor = Color.Red;
            label8.Location = new Point(312, 96);
            label8.Name = "label8";
            label8.Size = new Size(82, 23);
            label8.TabIndex = 9;
            label8.Text = "R$10:00";
            label8.Click += label8_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(252, 77);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(226, 30);
            textBox1.TabIndex = 11;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Font = new Font("Roboto", 12F, FontStyle.Regular, GraphicsUnit.Point);
            radioButton1.ForeColor = SystemColors.ControlLightLight;
            radioButton1.Location = new Point(37, 39);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(73, 23);
            radioButton1.TabIndex = 12;
            radioButton1.TabStop = true;
            radioButton1.Text = "Débito";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Font = new Font("Roboto", 12F, FontStyle.Regular, GraphicsUnit.Point);
            radioButton2.ForeColor = SystemColors.ControlLightLight;
            radioButton2.Location = new Point(37, 84);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(77, 23);
            radioButton2.TabIndex = 13;
            radioButton2.TabStop = true;
            radioButton2.Text = "Crédito";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = SystemColors.InactiveCaptionText;
            label10.Font = new Font("Roboto", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label10.ForeColor = SystemColors.ButtonHighlight;
            label10.Location = new Point(252, 41);
            label10.Name = "label10";
            label10.Size = new Size(50, 19);
            label10.TabIndex = 14;
            label10.Text = "Valor:";
            // 
            // button1
            // 
            button1.BackColor = Color.DodgerBlue;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Roboto", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = Color.Black;
            button1.Location = new Point(153, 136);
            button1.Name = "button1";
            button1.Size = new Size(207, 31);
            button1.TabIndex = 15;
            button1.Text = "Enviar";
            button1.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(radioButton1);
            groupBox1.Controls.Add(radioButton2);
            groupBox1.Font = new Font("Roboto", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.ForeColor = SystemColors.ControlLightLight;
            groupBox1.Location = new Point(23, 138);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(503, 189);
            groupBox1.TabIndex = 20;
            groupBox1.TabStop = false;
            groupBox1.Text = "Nova operação";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(label4);
            groupBox2.Font = new Font("Roboto", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox2.ForeColor = SystemColors.ControlLightLight;
            groupBox2.Location = new Point(558, 138);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(483, 189);
            groupBox2.TabIndex = 21;
            groupBox2.TabStop = false;
            groupBox2.Text = "Operações";
            // 
            // groupBox3
            // 
            groupBox3.Font = new Font("Roboto", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox3.ForeColor = SystemColors.ControlLightLight;
            groupBox3.Location = new Point(23, 347);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(1018, 225);
            groupBox3.TabIndex = 22;
            groupBox3.TabStop = false;
            groupBox3.Text = "Extrato";
            // 
            // modoNoturno
            // 
            modoNoturno.Checked = true;
            modoNoturno.AutoSize = true;
            modoNoturno.ForeColor = SystemColors.ButtonHighlight;
            modoNoturno.Location = new Point(937, 782);
            modoNoturno.Name = "modoNoturno";
            modoNoturno.Size = new Size(104, 19);
            modoNoturno.TabIndex = 23;
            modoNoturno.Text = "Modo noturno";
            modoNoturno.UseVisualStyleBackColor = true;
            modoNoturno.CheckedChanged += modoNoturno_CheckedChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(1053, 813);
            Controls.Add(modoNoturno);
            Controls.Add(groupBox3);
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
        private GroupBox groupBox3;
        public CheckBox modoNoturno;
        
    }
}