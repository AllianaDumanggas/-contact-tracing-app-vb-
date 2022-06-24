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

namespace Contact_Tracing_App
{
    public partial class RECORDS : Form
    {
        public RECORDS()
        {
            InitializeComponent();
        }

        private void viewallrecords_Click(object sender, EventArgs e)
        {
            StreamReader reader = new StreamReader(@"C:\Users\universal\Documents\contact-tracing.txt");
            String all = reader.ReadToEnd();
            MessageBox.Show(all);

            // while (!reader.EndOfStream)
            //{
            // String line =reader.Readline();
            // MessageBox.Show (line);
            //}
        }
    }
}
