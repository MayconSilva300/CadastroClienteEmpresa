namespace CasdastroClienteEmpresa
{
    partial class CadastroCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastroCliente));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.t_nome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.t_email = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.t_genero = new System.Windows.Forms.ComboBox();
            this.t_data = new System.Windows.Forms.MaskedTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.b_voltar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.t_cpf = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.t_rg = new System.Windows.Forms.MaskedTextBox();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(141, 222);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(169, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nome:";
            // 
            // t_nome
            // 
            this.t_nome.Location = new System.Drawing.Point(213, 45);
            this.t_nome.Name = "t_nome";
            this.t_nome.Size = new System.Drawing.Size(294, 20);
            this.t_nome.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(172, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Email:";
            // 
            // t_email
            // 
            this.t_email.Location = new System.Drawing.Point(213, 79);
            this.t_email.Name = "t_email";
            this.t_email.Size = new System.Drawing.Size(294, 20);
            this.t_email.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(325, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Data de Nascimento:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(162, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Genero:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(155, 154);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Telefone:";
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(213, 147);
            this.maskedTextBox1.Mask = "(99) 00000-0000";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(90, 20);
            this.maskedTextBox1.TabIndex = 9;
            // 
            // t_genero
            // 
            this.t_genero.Cursor = System.Windows.Forms.Cursors.Hand;
            this.t_genero.FormattingEnabled = true;
            this.t_genero.Items.AddRange(new object[] {
            "Masculino\t",
            "Feminino"});
            this.t_genero.Location = new System.Drawing.Point(213, 115);
            this.t_genero.Name = "t_genero";
            this.t_genero.Size = new System.Drawing.Size(144, 21);
            this.t_genero.TabIndex = 10;
            // 
            // t_data
            // 
            this.t_data.Location = new System.Drawing.Point(438, 147);
            this.t_data.Mask = "00/00/0000";
            this.t_data.Name = "t_data";
            this.t_data.Size = new System.Drawing.Size(69, 20);
            this.t_data.TabIndex = 11;
            this.t_data.ValidatingType = typeof(System.DateTime);
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Location = new System.Drawing.Point(417, 190);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 40);
            this.button1.TabIndex = 12;
            this.button1.Text = "Confirmar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // b_voltar
            // 
            this.b_voltar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.b_voltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_voltar.Location = new System.Drawing.Point(321, 190);
            this.b_voltar.Name = "b_voltar";
            this.b_voltar.Size = new System.Drawing.Size(90, 40);
            this.b_voltar.TabIndex = 13;
            this.b_voltar.Text = "Voltar";
            this.b_voltar.UseVisualStyleBackColor = true;
            this.b_voltar.Click += new System.EventHandler(this.b_voltar_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(385, 122);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Cpf:";
            // 
            // t_cpf
            // 
            this.t_cpf.Location = new System.Drawing.Point(417, 115);
            this.t_cpf.Mask = "000-000-000-00";
            this.t_cpf.Name = "t_cpf";
            this.t_cpf.Size = new System.Drawing.Size(90, 20);
            this.t_cpf.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(181, 190);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(26, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "RG:";
            // 
            // t_rg
            // 
            this.t_rg.Location = new System.Drawing.Point(213, 183);
            this.t_rg.Mask = "00.000.000-0";
            this.t_rg.Name = "t_rg";
            this.t_rg.Size = new System.Drawing.Size(75, 20);
            this.t_rg.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(237, 12);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(203, 24);
            this.label8.TabIndex = 18;
            this.label8.Text = "Cadastro de Clientes";
            // 
            // CadastroCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(524, 246);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.t_rg);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.t_cpf);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.b_voltar);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.t_data);
            this.Controls.Add(this.t_genero);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.t_email);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.t_nome);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.MaximizeBox = false;
            this.Name = "CadastroCliente";
            this.ShowIcon = false;
            this.Text = "Cadastro Cliente";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox t_nome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox t_email;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.ComboBox t_genero;
        private System.Windows.Forms.MaskedTextBox t_data;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button b_voltar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox t_cpf;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MaskedTextBox t_rg;
        private System.Windows.Forms.Label label8;
    }
}