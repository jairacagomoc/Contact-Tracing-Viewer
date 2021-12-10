using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace CONTACT_TRACING_VIEWER1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Openfile_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "txt Files (*.txt) | *.txt";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.Text = File.ReadAllText(ofd.FileName);
            }
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult iExit;
                iExit = MessageBox.Show("Confirm if you want to exit", "My Contact Tracing Viewer",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (iExit == DialogResult.OK)
                {
                    Application.Exit();
                }

                else if (iExit == DialogResult.Cancel)
                {
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "TRACEme.app", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
