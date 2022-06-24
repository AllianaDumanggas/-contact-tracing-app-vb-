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
    public partial class LISTRECORD : Form
    {
        public LISTRECORD()
        {
            InitializeComponent();
        }

        private void LISTRECORD_Load(object sender, EventArgs e)
        {
 
            showlist.Text = File.ReadAllText(@"C:\Users\universal\Documents\contact-tracing.txt");

            // while (!reader.EndOfStream)
            //{
            // String line =reader.Readline();
            // MessageBox.Show (line);
            //}
        }
    }
}
