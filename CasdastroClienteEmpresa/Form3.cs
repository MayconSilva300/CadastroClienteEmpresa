﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CasdastroClienteEmpresa
{
    public partial class CadastroEmpresa : Form
    {
        public CadastroEmpresa()
        {
            InitializeComponent();
        }

        private void b_voltar_Click(object sender, EventArgs e)
        {
            var form1 = new login();
            form1.Show();
            Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
