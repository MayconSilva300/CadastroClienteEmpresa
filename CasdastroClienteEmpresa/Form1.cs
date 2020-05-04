using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using System.Threading;

namespace CasdastroClienteEmpresa
{
    
    public partial class login : System.Windows.Forms.Form
    {
        //Thread nt;
        public login()
        {
            InitializeComponent();
        }

        private void LOGIN()
        {
            
        }

        private void empresa_Click(object sender, EventArgs e)
        {
            var form3 = new CadastroEmpresa();
            form3.Show();
            Hide();
        }

        private void cliente_Click(object sender, EventArgs e)
        {
            var form2 = new CadastroCliente();
            form2.Show();
            Hide();

           // Close();
           // nt = new Thread(novoForm);
            //nt.SetApartmentState(ApartmentState.STA);
            //Application.Run(new Form2());
        }
        // private void novoForm()
        // {
        // Application.Run(new Form2());
        // }
    }
}
