using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fazenda
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void produtohomeButton_Click(object sender, EventArgs e)
        {
            Produto produto = new Produto();
            produto.Show();
        }
    }
}
