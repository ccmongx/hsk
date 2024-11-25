using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HSK253
{
    public partial class Form2 : Form
    {
        public Form2(string v)
        {
            InitializeComponent();
            boxChuoidanhap.Text=v;
        }

        private void boxChuoidanhap_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
