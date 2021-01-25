using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContextMenuStrip_Kontrola_EM
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void sLijevaNaDesnoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBoxLijevo.Text = textBoxDesno.Text;
        }

        private void sDesnaNaLijevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBoxDesno.Text = textBoxLijevo.Text;
        }
    }
}
