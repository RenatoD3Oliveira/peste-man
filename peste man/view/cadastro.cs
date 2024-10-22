using peste_man.view;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace peste_man
{
    public partial class cadastro : Form
    {
        public cadastro()
        {
            InitializeComponent();
            this.Size
                = new System.Drawing.Size(1114, 618);
        }

        private void entrar(object sender, EventArgs e)
        {
            login login = new login();
            login.ShowDialog();
        }
    }
}
