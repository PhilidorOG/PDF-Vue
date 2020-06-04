using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevComponents.DotNetBar;

namespace PDF_Vue
{
    public partial class Form1 : Office2007Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void OpenpdfToolStripMenuItem_Click(object sender, EventArgs e)
        {
            private System.Windows.Forms.OpenFileDialog openpdf;
            this.openpdf = new System.Windows.Forms.OpenFileDialog();
        }
    }
}
