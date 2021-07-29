using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EAS_Maker
{
    public partial class EAS_Editor : Form
    {
        public EAS_Editor()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            richTextBox1.Text = System.IO.File.ReadAllText(openFileDialog1.FileName);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
            System.IO.File.WriteAllText(saveFileDialog1.FileName, richTextBox1.Text);
        }
    }
}
