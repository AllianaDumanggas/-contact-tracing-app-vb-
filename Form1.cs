using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Contact_Tracing_App
{
    public partial class contacttracing : Form
    {
        public contacttracing()
        {
            InitializeComponent();
        }

         
        private void nametb_TextChanged(object sender, EventArgs e)
        {
           // StreamWriter
           
            StreamWriter file = new StreamWriter(@"C:\Users\universal\Documents\contacttracing.txt");
            file.WriteLine("Complete Name: " + nametb.Text);
            file.Close();
        }

        private void datetb_TextChanged(object sender, EventArgs e)
        {
              
        }
    }
}
