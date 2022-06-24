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

        private void list()
        {
            List<string> Name= new List<string>();
            Name.Add("Alliana Dumanggas");
            Name.Add("Marie Chan");
            Name.Add("Manuel Cruz");
            Name.Add("Jose Cruz");

            List<string> Age = new List<string>();
            Age.Add("18");
            Age.Add("41");
            Age.Add("33");
            Age.Add("25");

            List<string> Date = new List<string>();
            Date.Add("6/20/22");
            Date.Add("6/20/22");
            Date.Add("06/21/22");
            Date.Add("06/21/22");

            List<string> Address = new List<string>();
            Address.Add("Danlagan Padre Burgos Quezon");
            Address.Add("Quezon City");
            Address.Add("Pasay City");
            Address.Add("Pasay City");

            List<string> VaccineTypefirstdose = new List<string>();
            VaccineTypefirstdose.Add("Pfizer");
            VaccineTypefirstdose.Add("AstraZeneca");
            VaccineTypefirstdose.Add("Pfizer");
            VaccineTypefirstdose.Add("Moderna");

            List<string> VaccineTypeseconddose = new List<string>();
            VaccineTypeseconddose.Add("Pfizer");
            VaccineTypeseconddose.Add("AstraZeneca");
            VaccineTypeseconddose.Add("Pfizer");
            VaccineTypeseconddose.Add("Moderna");


        }

        private void Viewdate_Click(object sender, EventArgs e)
        {
            List<string> Name = new List<string>();
            Name.Add("Alliana Dumanggas");
            Name.Add("Marie Chan");
            Name.Add("Manuel Cruz");
            Name.Add("Jose Cruz");

            foreach (var item in Name)
            {
                if (Name.Contains(finddate.Text))
                {
                    MessageBox.Show(item.ToString());
                }
            }
            

        }
    }
}
