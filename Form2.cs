﻿using System;
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

        

        private void Viewdate_Click(object sender, EventArgs e)
        {
            List<string> DataRecorded01 = new List<string>();
            DataRecorded01.Add("Alliana Dumanggas");
            DataRecorded01.Add("18");
            DataRecorded01.Add("6/20/22");
            DataRecorded01.Add("Danlagan Padre Burgos Quezon");
            DataRecorded01.Add("Pfizer");
            DataRecorded01.Add("Pfizer");
            List<string> DataRecorded02 = new List<string>();
            DataRecorded02.Add("Marie Chan");
            DataRecorded02.Add("41");
            DataRecorded02.Add("6/20/22");
            DataRecorded02.Add("Quezon City");
            DataRecorded02.Add("Pfizer");
            DataRecorded02.Add("Pfizer");
            List<string> DataRecorded03 = new List<string>();
            DataRecorded03.Add("Manuel Cruz");
            DataRecorded03.Add("33");
            DataRecorded03.Add("6/21/22");
            DataRecorded03.Add("Pasay City");
            DataRecorded03.Add("AstraZeneca");
            DataRecorded03.Add("AstraZeneca");
            List<string> DataRecorded04 = new List<string>();
            DataRecorded04.Add("Jose Cruz");
            DataRecorded04.Add("25");
            DataRecorded04.Add("6/21/22");
            DataRecorded04.Add("Pasay City");
            DataRecorded04.Add("Moderna");
            DataRecorded04.Add("Moderna");

            foreach (var item in DataRecorded01 )
            {
                if (DataRecorded01.Contains(finddate.Text)== true)
                {
                    if (true)
                    {
                        var list = string.Join(Environment.NewLine, DataRecorded01.ToArray());
                        MessageBox.Show(list);
                         
                    } 
                }
                else if (DataRecorded02.Contains(finddate.Text) == true)
                {
                    if (true)
                    {
                        var list = string.Join(Environment.NewLine, DataRecorded02.ToArray());
                        MessageBox.Show(list);
                        
                    }
                }
                else if (DataRecorded03.Contains(finddate.Text) == true)
                {
                    if (true)
                    {
                        var list = string.Join(Environment.NewLine, DataRecorded03.ToArray());
                        MessageBox.Show(list);
                         
                    }
                }
                else if (DataRecorded03.Contains(finddate.Text) == true)
                {
                    if (true)
                    {
                        var list = string.Join(Environment.NewLine, DataRecorded03.ToArray());
                        MessageBox.Show(list);
                         
                    }
                }
                else
                {
                    MessageBox.Show("No Results Found");
                    break;
                }

            }


        }
    }
}
