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
        private void RECORDLIST()
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
            List<string> DataRecorded05 = new List<string>();
            DataRecorded05.Add("Bubbles Dela Cruz");
            DataRecorded05.Add("Female");
            DataRecorded05.Add("56");
            DataRecorded05.Add("6/22/22");
            DataRecorded05.Add("Calamba,Laguna");
            DataRecorded05.Add("Moderna");
            DataRecorded05.Add("Moderna");
            List<string> DataRecorded06 = new List<string>();
            DataRecorded06.Add("Hannie Santos");
            DataRecorded06.Add("Female");
            DataRecorded06.Add("22");
            DataRecorded06.Add("6/22/22");
            DataRecorded06.Add("Sta.Mesa, Manila");
            DataRecorded06.Add("Pfizer");
            DataRecorded06.Add("Pfizer");


            foreach (var item in DataRecorded01)
            {
                if (DataRecorded01.Contains(findtxt.Text) == true)
                {
                    if (true)
                    {
                        var list = string.Join(Environment.NewLine, DataRecorded01.ToArray());
                        MessageBox.Show(list);
                        break;
                    }
                }
            }
            foreach (var item in DataRecorded02)
            {
                if (DataRecorded02.Contains(findtxt.Text) == true)
                {
                    if (true)
                    {
                        var list = string.Join(Environment.NewLine, DataRecorded02.ToArray());
                        MessageBox.Show(list);
                        break;
                    }
                }
            }
            foreach (var item in DataRecorded03)
            {
                if (DataRecorded03.Contains(findtxt.Text) == true)
                {
                    if (true)
                    {
                        var list = string.Join(Environment.NewLine, DataRecorded03.ToArray());
                        MessageBox.Show(list);
                        break;
                    }
                }
            }
            foreach (var item in DataRecorded04)
            {
                if (DataRecorded04.Contains(findtxt.Text) == true)
                {
                    if (true)
                    {
                        var list = string.Join(Environment.NewLine, DataRecorded04.ToArray());
                        MessageBox.Show(list);
                        break;
                    }
                }
            }
            foreach (var item in DataRecorded05)
            {
                if (DataRecorded05.Contains(findtxt.Text) == true)
                {
                    if (true)
                    {
                        var list = string.Join(Environment.NewLine, DataRecorded05.ToArray());
                        MessageBox.Show(list);
                        break;
                    }
                }
            }
            foreach (var item in DataRecorded06 )
            {
                if (DataRecorded06.Contains(findtxt.Text) == true)
                {
                    if (true)
                    {
                        var list = string.Join(Environment.NewLine, DataRecorded06.ToArray());
                        MessageBox.Show(list);
                        break;
                    }
                }
            }
        }

            private void ViewName()
        {
            List<string> Allname = new List<string>();
            Allname.Add("Alliana Dumanggas");
            Allname.Add("Marie Chan");
            Allname.Add("Manuel Cruz");
            Allname.Add("Jose Cruz ");
            Allname.Add("Bubbles Dela Cruz ");
            Allname.Add("Hannie Santos ");
            var names = string.Join(Environment.NewLine, Allname.ToArray());
            Array.Sort(Allname.ToArray());
            MessageBox.Show(names);
        }

        private void viewallname_Click(object sender, EventArgs e)
        {
            ViewName();
        }
         
        private void finddate_Click(object sender, EventArgs e)
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
            List<string> DataRecorded05 = new List<string>();
            DataRecorded05.Add("Bubbles Dela Cruz");
            DataRecorded05.Add("female");
            DataRecorded05.Add("56");
            DataRecorded05.Add("6/22/22");
            DataRecorded05.Add("Calamba,Laguna");
            DataRecorded05.Add("Moderna");
            DataRecorded05.Add("Moderna");
            List<string> DataRecorded06 = new List<string>();
            DataRecorded06.Add("Hannie Santos");
            DataRecorded06.Add("female");
            DataRecorded06.Add("22");
            DataRecorded06.Add("6/22/22");
            DataRecorded06.Add("Sta.Mesa, Manila");
            DataRecorded06.Add("Pfizer");
            DataRecorded06.Add("Pfizer");


            foreach (var item in DataRecorded01)
            {
                if (DataRecorded01.Contains(datefind.Text) == true)
                {
                    if (true)
                    {
                        var list = string.Join(Environment.NewLine, DataRecorded01.ToArray());
                        MessageBox.Show(list);
                        break;
                    }
                     
                }
            }
            foreach (var item in DataRecorded02)
            {
                if (DataRecorded02.Contains(datefind.Text) == true)
                {
                    if (true)
                    {
                        var list = string.Join(Environment.NewLine, DataRecorded02.ToArray());
                        MessageBox.Show(list);
                        break;
                    }

                }
            }
            foreach (var item in DataRecorded03)
            {
                if (DataRecorded03.Contains(datefind.Text) == true)
                {
                    if (true)
                    {
                        var list = string.Join(Environment.NewLine, DataRecorded03.ToArray());
                        MessageBox.Show(list);
                        break;
                    }

                }
            }
            foreach (var item in DataRecorded04)
            {
                if (DataRecorded04.Contains(datefind.Text) == true)
                {
                    if (true)
                    {
                        var list = string.Join(Environment.NewLine, DataRecorded04.ToArray());
                        MessageBox.Show(list);
                        break;
                    }

                }
            }
            foreach (var item in DataRecorded05)
            {
                if (DataRecorded05.Contains(datefind.Text) == true)
                {
                    if (true)
                    {
                        var list = string.Join(Environment.NewLine, DataRecorded05.ToArray());
                        MessageBox.Show(list);
                        break;
                    }

                }
            }
            foreach (var item in DataRecorded06)
            {
                if (DataRecorded06.Contains(datefind.Text) == true)
                {
                    if (true)
                    {
                        var list = string.Join(Environment.NewLine, DataRecorded06.ToArray());
                        MessageBox.Show(list);
                        break;
                    }

                }
            }
        }

        private void findbttn_Click(object sender, EventArgs e)
        {
            RECORDLIST();
        }
    }
}
