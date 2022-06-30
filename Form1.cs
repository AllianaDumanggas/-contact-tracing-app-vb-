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
using AForge.Video;
using AForge.Video.DirectShow;
using ZXing;

namespace Contact_Tracing_App
{
    public partial class contacttracing : Form
    {
        public contacttracing()
        {
            InitializeComponent();
        }

        FilterInfoCollection filterInfoCollection;
        VideoCaptureDevice captureDevice;


        private void CheckAllBoxes()
        {
            if (nametb.Text == "")
            {
                MessageBox.Show("Please fill out the form Completely");
            }
            else if (datetb.Text == "")
            {
                MessageBox.Show("Please fill out the form Completely");
            }
            else if (agetb.Text == "")
            {
                MessageBox.Show("Please fill out the form Completely");
            }
            else if (gendertb.Text == "")
            {
                MessageBox.Show("Please fill out the form Completely");
            }
            else if (contacttb.Text == "")
            {
                MessageBox.Show("Please fill out the form Completely");
            }
            else if (addresstb.Text == "")
            {
                MessageBox.Show("Please fill out the form Completely");
            }

            else if (q4tb.Text == "")
            {
                MessageBox.Show("Please fill out the form Completely");
            }
            else if (q5tb.Text == "")
            {
                MessageBox.Show("Please fill out the form Completely");
            }
            else if (firstdosetb.Text == "")
            {
                MessageBox.Show("Please fill out the form Completely");
            }
            else if (vaccinetype1tb.Text == "")
            {
                MessageBox.Show("Please fill out the form Completely");
            }
            else if (seconddosetb.Text == "")
            {
                MessageBox.Show("Please fill out the form Completely");
            }
            else if (vaccinetype2bt.Text == "")
            {
                MessageBox.Show("Please fill out the form Completely");
            }

            else
            {
                MessageBox.Show("We are home to Care");
                MessageBox.Show("Thank you for filling this contact tracing form");
            }



        }
        private void submit_Click(object sender, EventArgs e)
        {

            StreamWriter file = new StreamWriter(@"C:\Users\universal\Documents\contact-tracing.txt", true);
            file.WriteLine("Date: " + datetb.Text);
            file.WriteLine("Complete Name: " + nametb.Text);
            file.WriteLine("Age: " + agetb.Text);
            file.WriteLine("Gender: " + gendertb.Text);
            file.WriteLine("Contact Number: " + contacttb.Text);
            file.WriteLine("Address: " + addresstb.Text);
            file.WriteLine("Symptoms Experiencing/Experienced: " + q1tb.Text);
            file.WriteLine("Date when Symptoms start Experiencing/Experience: " + ddmmyytb.Text);
            file.WriteLine("Have been Contact with a person with Covid-19: " + q4tb.Text);
            file.WriteLine("Already Received a Covid-19 Vaccine: " + q5tb.Text);
            file.WriteLine("Received the first dose only: " + firstdosetb.Text);
            file.WriteLine("first dose vaccine type: " + vaccinetype1tb.Text);
            file.WriteLine("Completed the second dose of the Vaccine: " + seconddosetb.Text);
            file.WriteLine("second dose vaccine type: " + vaccinetype2bt.Text);
            file.WriteLine("   ");
            file.Close();
            CheckAllBoxes();


        }

        private void AnswerAgain()
        {
            Boolean answr_again = true;
            if (answr_again)
                nametb.Text = "";
            datetb.Text = "";
            agetb.Text = "";
            gendertb.Text = "";
            contacttb.Text = "";
            addresstb.Text = "";
            q1tb.Text = "";
            ddmmyytb.Text = "";
            q4tb.Text = "";
            q5tb.Text = "";
            firstdosetb.Text = "";
            vaccinetype1tb.Text = "";
            seconddosetb.Text = "";
            vaccinetype2bt.Text = "";

        }
        private void anweragain_Click(object sender, EventArgs e)
        {
            AnswerAgain();
        }

        private void view_Click(object sender, EventArgs e)
        {
            if (viewtxtbox.Text == "wearehometocare")
            {
                RECORDS f2 = new RECORDS();
                f2.Show();
                Visible = true;
            }
            else
            {
                MessageBox.Show("Incorrect Password");
            }
            
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void contacttracing_Load(object sender, EventArgs e)
        {
            filterInfoCollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo filterInfo in filterInfoCollection)
            {
                combocam.Items.Add(filterInfo.Name);
                combocam.SelectedIndex = 0;
            }
        }

        private void generateqr_Click(object sender, EventArgs e)
        {
            generatingqrcode f4 = new generatingqrcode();
            f4.Show();
            Visible = true;
        }

        private void Start_Click(object sender, EventArgs e)
        {
            captureDevice = new VideoCaptureDevice(filterInfoCollection[combocam.SelectedIndex].MonikerString);
            captureDevice.NewFrame += CaptureDevice_NewFrame;
            captureDevice.Start();

        }

        private void CaptureDevice_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            campicbox.Image = (Bitmap)eventArgs.Frame.Clone();
        }

        private void contacttracing_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (captureDevice.IsRunning)
            {
                captureDevice.Stop();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (campicbox != null)
            {
                BarcodeReader barcodereader = new BarcodeReader();
                Result resultofscanning = barcodereader.Decode((Bitmap)campicbox.Image);

                if (resultofscanning != null)
                {
                    dataofqr.Text = resultofscanning.ToString();
                    
                }
                qrtimer.Stop();
                if (captureDevice.IsRunning)
                {
                    captureDevice.Stop();
                }
            }
        }
    }
}
 
 
