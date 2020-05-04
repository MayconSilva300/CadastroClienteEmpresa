namespace CasdastroClienteEmpresa
{
    partial class login
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(login));
            this.bEntrar = new System.Windows.Forms.Button();
            this.BoxNome = new System.Windows.Forms.TextBox();
            this.BoxSenha = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.empresa = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cliente = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // bEntrar
            // 
            this.bEntrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bEntrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bEntrar.ForeColor = System.Drawing.Color.Black;
            this.bEntrar.Location = new System.Drawing.Point(164, 151);
            this.bEntrar.Name = "bEntrar";
            this.bEntrar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bEntrar.Size = new System.Drawing.Size(111, 60);
            this.bEntrar.TabIndex = 0;
            this.bEntrar.Text = "ENTRAR";
            this.bEntrar.UseVisualStyleBackColor = true;
            // 
            // BoxNome
            // 
            this.BoxNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BoxNome.Location = new System.Drawing.Point(202, 51);
            this.BoxNome.Multiline = true;
            this.BoxNome.Name = "BoxNome";
            this.BoxNome.Size = new System.Drawing.Size(251, 29);
            this.BoxNome.TabIndex = 3;
            // 
            // BoxSenha
            // 
            this.BoxSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BoxSenha.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.BoxSenha.Location = new System.Drawing.Point(201, 95);
            this.BoxSenha.Multiline = true;
            this.BoxSenha.Name = "BoxSenha";
            this.BoxSenha.PasswordChar = '*';
            this.BoxSenha.Size = new System.Drawing.Size(251, 29);
            this.BoxSenha.TabIndex = 4;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-2, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(160, 229);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(164, 95);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(31, 29);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(165, 51);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(31, 29);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 7;
            this.pictureBox3.TabStop = false;
            // 
            // empresa
            // 
            this.empresa.AutoSize = true;
            this.empresa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.empresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.empresa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.empresa.Location = new System.Drawing.Point(362, 188);
            this.empresa.Name = "empresa";
            this.empresa.Size = new System.Drawing.Size(66, 13);
            this.empresa.TabIndex = 8;
            this.empresa.Text = "EMPRESA";
            this.empresa.Click += new System.EventHandler(this.empresa_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(321, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "CADASTRO";
            // 
            // cliente
            // 
            this.cliente.AutoSize = true;
            this.cliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.cliente.Location = new System.Drawing.Point(297, 188);
            this.cliente.Name = "cliente";
            this.cliente.Size = new System.Drawing.Size(59, 13);
            this.cliente.TabIndex = 10;
            this.cliente.Text = "CLIENTE";
            this.cliente.Click += new System.EventHandler(this.cliente_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(233, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(162, 19);
            this.label3.TabIndex = 12;
            this.label3.Text = "LOGIN NO SISTEMA";
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(465, 223);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cliente);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.empresa);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.BoxSenha);
            this.Controls.Add(this.BoxNome);
            this.Controls.Add(this.bEntrar);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.MaximizeBox = false;
            this.Name = "login";
            this.ShowIcon = false;
            this.Text = "LOGIN";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bEntrar;
        private System.Windows.Forms.TextBox BoxNome;
        private System.Windows.Forms.TextBox BoxSenha;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label empresa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label cliente;
        private System.Windows.Forms.Label label3;
    }
}

