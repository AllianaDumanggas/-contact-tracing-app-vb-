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

        private void submit_Click(object sender, EventArgs e)
        {
            StreamWriter file = new StreamWriter(@"C:\Users\universal\Documents\contact-tracing.txt", true);
            file.WriteLine("Complete Name: "+ nametb.Text);
            file.WriteLine("Date: "+ datetb.Text );
            file.WriteLine("Age: " + agetb.Text);
            file.WriteLine("Gender: " + gendertb.Text);
            file.WriteLine("Contact Number: " + contacttb.Text );
            file.WriteLine("Temparature: " + temptb.Text);
            file.WriteLine("Address: " + addresstb.Text);
            file.WriteLine("Symptoms Experiencing/Experienced: " + q1tb.Text);
            file.WriteLine("Date when Symptoms start Experiencing/Experience: " + ddmmyytb.Text);
            file.WriteLine("Have been Contact with a person with Covid-19: " + q4tb.Text );
            file.WriteLine("Already Received a Covid-19 Vaccine: " + q5tb.Text );
            file.WriteLine("Received the first dose only: "+ firstdosetb.Text);
            file.WriteLine("first dose vaccine type: " + vaccinetype1tb.Text );
            file.WriteLine("Completed the second dose of the Vaccine: " + seconddosetb.Text);
            file.WriteLine("second dose vaccine type: " + vaccinetype2bt.Text );
            file.Close();
            
        }
       
    }
}
