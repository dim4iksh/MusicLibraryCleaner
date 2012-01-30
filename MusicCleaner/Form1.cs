using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MusicCleaner
{
    public partial class FormMain : Form
    {
        string fileName;
        public FormMain()
        {
            InitializeComponent();
        }

        private void buttonBrose_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog1.ShowDialog();
            if (DialogResult.OK == result)
            {
                fileName = openFileDialog1.FileName;
                textBoxPath.Text = openFileDialog1.FileName;
               
            }
        }

        private void buttonRun_Click(object sender, EventArgs e)
        {
            
        }

    }
}
