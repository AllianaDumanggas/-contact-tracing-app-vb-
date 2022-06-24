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
            LISTRECORD f3 = new LISTRECORD();
            f3.Show();
            Visible = true;
            
        }

        

        private void Viewdate_Click(object sender, EventArgs e)
        {
            List<string> DataRecorded01 = new List<string>();
            DataRecorded01.Add("Alliana Dumanggas");
            DataRecorded01.Add("18");
            DataRecorded01.Add("Female");
            DataRecorded01.Add("6/20/22");
            DataRecorded01.Add("Danlagan Padre Burgos Quezon");
            DataRecorded01.Add("Pfizer");
            DataRecorded01.Add("Pfizer");
            List<string> DataRecorded02 = new List<string>();
            DataRecorded02.Add("Marie Chan");
            DataRecorded02.Add("Female");
            DataRecorded02.Add("41");
            DataRecorded02.Add("6/20/22");
            DataRecorded02.Add("Quezon City");
            DataRecorded02.Add("Pfizer");
            DataRecorded02.Add("Pfizer");
            List<string> DataRecorded03 = new List<string>();
            DataRecorded03.Add("Manuel Cruz");
            DataRecorded03.Add("Male");
            DataRecorded03.Add("33");
            DataRecorded03.Add("6/21/22");
            DataRecorded03.Add("Pasay City");
            DataRecorded03.Add("AstraZeneca");
            DataRecorded03.Add("AstraZeneca");
            List<string> DataRecorded04 = new List<string>();
            DataRecorded04.Add("Jose Cruz");
            DataRecorded04.Add("Male");
            DataRecorded04.Add("25");
            DataRecorded04.Add("6/21/22");
            DataRecorded04.Add("Pasay City");
            DataRecorded04.Add("Moderna");
            DataRecorded04.Add("Moderna");


            foreach (var item in DataRecorded01 )
            {
                if (DataRecorded01.Contains(findatxtbox.Text)== true)
                {
                    if (true)
                    {
                        var list = string.Join(Environment.NewLine, DataRecorded01.ToArray());
                        MessageBox.Show(list);
                        break;
                         
                    } 
                }
                else if (DataRecorded02.Contains(findatxtbox.Text) == true)
                {
                    if (true)
                    {
                        var list = string.Join(Environment.NewLine, DataRecorded02.ToArray());
                        MessageBox.Show(list);
                        break;
                        
                    }
                    
                }
                else if (DataRecorded03.Contains(findatxtbox.Text) == true)
                {
                    if (true)
                    {
                        var list = string.Join(Environment.NewLine, DataRecorded03.ToArray());
                        MessageBox.Show(list);
                        break;
                         
                    }
                }
                else if (DataRecorded04.Contains(findatxtbox.Text) == true)
                {
                    if (true)
                    {
                        var list = string.Join(Environment.NewLine, DataRecorded04.ToArray());
                        MessageBox.Show(list);
                        break;
                         
                    }
                }
                else
                {
                    MessageBox.Show("No Results Found");
                    break;
                }

            }


        }

        private void viewallname_Click(object sender, EventArgs e)
        {
            List<string> Allname = new List<string>();
            Allname.Add("Alliana Dumanggas");
            Allname.Add("Marie Chan");
            Allname.Add("Manuel Cruz");
            Allname.Add("Jose Cruz ");

            var names = string.Join(Environment.NewLine, Allname.ToArray());
            MessageBox.Show(names);
        }

        private void viewdate_Click_1(object sender, EventArgs e)
        {
            List<string> Date = new List<string>();
            Date.Add("6/20/22, Alliana Dumanggas");
            Date.Add("6/20/22, Marie Chan");
            Date.Add("6/21/22, Manuel Cruz");
            Date.Add("6/21/22, Jose Cruz ");


            var date = string.Join(Environment.NewLine, Date.ToArray());
            MessageBox.Show(date);
        }
    }
}
