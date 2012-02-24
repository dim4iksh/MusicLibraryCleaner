using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CleanerBL;

namespace MusicCleaner
{
    
    public partial class FormMain : Form
    {
        private const string DEFAULTPATH = @"C:\dup_title.xml";
        string fileName = DEFAULTPATH;
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
            //if (textBoxPath.Text == string.Empty)
            //{
            //    MessageBox.Show("First enter a valid xml file");
            //    return;
            //}
            Cleaner cleaner = new Cleaner(fileName);
            try
            {
                cleaner.run(listBoxView);
                
            }
            catch (Exception exception)
            {
                MessageBox.Show("XML Error {0}", exception.ToString());
            }


        }

    }
}
