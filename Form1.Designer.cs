﻿
namespace Contact_Tracing_App
{
    partial class contacttracing
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(contacttracing));
            this.name = new System.Windows.Forms.Label();
            this.address = new System.Windows.Forms.Label();
            this.age = new System.Windows.Forms.Label();
            this.gender = new System.Windows.Forms.Label();
            this.date = new System.Windows.Forms.Label();
            this.contactnumber = new System.Windows.Forms.Label();
            this.nametb = new System.Windows.Forms.TextBox();
            this.datetb = new System.Windows.Forms.TextBox();
            this.agetb = new System.Windows.Forms.TextBox();
            this.gendertb = new System.Windows.Forms.TextBox();
            this.addresstb = new System.Windows.Forms.TextBox();
            this.contacttb = new System.Windows.Forms.TextBox();
            this.q1 = new System.Windows.Forms.Label();
            this.q1tb = new System.Windows.Forms.TextBox();
            this.a1 = new System.Windows.Forms.Label();
            this.b1 = new System.Windows.Forms.Label();
            this.c1 = new System.Windows.Forms.Label();
            this.d1 = new System.Windows.Forms.Label();
            this.e1 = new System.Windows.Forms.Label();
            this.f1 = new System.Windows.Forms.Label();
            this.g1 = new System.Windows.Forms.Label();
            this.input1 = new System.Windows.Forms.Label();
            this.q2 = new System.Windows.Forms.Label();
            this.ddmmyytb = new System.Windows.Forms.TextBox();
            this.ddmmyy = new System.Windows.Forms.Label();
            this.q3 = new System.Windows.Forms.Label();
            this.q4 = new System.Windows.Forms.Label();
            this.q4tb = new System.Windows.Forms.TextBox();
            this.q5 = new System.Windows.Forms.Label();
            this.q5tb = new System.Windows.Forms.TextBox();
            this.ifyes = new System.Windows.Forms.Label();
            this.firstdose = new System.Windows.Forms.Label();
            this.firstdosetb = new System.Windows.Forms.TextBox();
            this.vaccinetype1 = new System.Windows.Forms.Label();
            this.vaccinetype1tb = new System.Windows.Forms.TextBox();
            this.seconddose = new System.Windows.Forms.Label();
            this.seconddosetb = new System.Windows.Forms.TextBox();
            this.vaccinetype2 = new System.Windows.Forms.Label();
            this.vaccinetype2bt = new System.Windows.Forms.TextBox();
            this.temp = new System.Windows.Forms.Label();
            this.temptb = new System.Windows.Forms.TextBox();
            this.submit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name.Location = new System.Drawing.Point(42, 183);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(109, 16);
            this.name.TabIndex = 0;
            this.name.Text = "Complete Name:";
            // 
            // address
            // 
            this.address.AutoSize = true;
            this.address.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.address.Location = new System.Drawing.Point(42, 253);
            this.address.Name = "address";
            this.address.Size = new System.Drawing.Size(62, 16);
            this.address.TabIndex = 1;
            this.address.Text = "Address:";
            // 
            // age
            // 
            this.age.AutoSize = true;
            this.age.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.age.Location = new System.Drawing.Point(42, 219);
            this.age.Name = "age";
            this.age.Size = new System.Drawing.Size(36, 16);
            this.age.TabIndex = 2;
            this.age.Text = "Age:";
            // 
            // gender
            // 
            this.gender.AutoSize = true;
            this.gender.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gender.Location = new System.Drawing.Point(128, 218);
            this.gender.Name = "gender";
            this.gender.Size = new System.Drawing.Size(56, 16);
            this.gender.TabIndex = 3;
            this.gender.Text = "Gender:";
            // 
            // date
            // 
            this.date.AutoSize = true;
            this.date.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date.Location = new System.Drawing.Point(465, 183);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(40, 16);
            this.date.TabIndex = 4;
            this.date.Text = "Date:";
            // 
            // contactnumber
            // 
            this.contactnumber.AutoSize = true;
            this.contactnumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contactnumber.Location = new System.Drawing.Point(266, 219);
            this.contactnumber.Name = "contactnumber";
            this.contactnumber.Size = new System.Drawing.Size(66, 16);
            this.contactnumber.TabIndex = 5;
            this.contactnumber.Text = "Contact #:";
            // 
            // nametb
            // 
            this.nametb.Location = new System.Drawing.Point(163, 179);
            this.nametb.Name = "nametb";
            this.nametb.Size = new System.Drawing.Size(267, 20);
            this.nametb.TabIndex = 6;
            this.nametb.TextChanged += new System.EventHandler(this.nametb_TextChanged);
            // 
            // datetb
            // 
            this.datetb.Location = new System.Drawing.Point(511, 179);
            this.datetb.Name = "datetb";
            this.datetb.Size = new System.Drawing.Size(100, 20);
            this.datetb.TabIndex = 7;
            this.datetb.TextChanged += new System.EventHandler(this.datetb_TextChanged);
            // 
            // agetb
            // 
            this.agetb.Location = new System.Drawing.Point(84, 215);
            this.agetb.Name = "agetb";
            this.agetb.Size = new System.Drawing.Size(38, 20);
            this.agetb.TabIndex = 8;
            // 
            // gendertb
            // 
            this.gendertb.Location = new System.Drawing.Point(190, 215);
            this.gendertb.Name = "gendertb";
            this.gendertb.Size = new System.Drawing.Size(70, 20);
            this.gendertb.TabIndex = 9;
            // 
            // addresstb
            // 
            this.addresstb.Location = new System.Drawing.Point(110, 249);
            this.addresstb.Name = "addresstb";
            this.addresstb.Size = new System.Drawing.Size(501, 20);
            this.addresstb.TabIndex = 10;
            // 
            // contacttb
            // 
            this.contacttb.Location = new System.Drawing.Point(338, 214);
            this.contacttb.Name = "contacttb";
            this.contacttb.Size = new System.Drawing.Size(115, 20);
            this.contacttb.TabIndex = 11;
            // 
            // q1
            // 
            this.q1.AutoSize = true;
            this.q1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.q1.Location = new System.Drawing.Point(42, 278);
            this.q1.Name = "q1";
            this.q1.Size = new System.Drawing.Size(517, 16);
            this.q1.TabIndex = 12;
            this.q1.Text = "Are you currently experiencing/previously experienced any of the follywing sympto" +
    "ms?";
            // 
            // q1tb
            // 
            this.q1tb.Location = new System.Drawing.Point(488, 300);
            this.q1tb.Name = "q1tb";
            this.q1tb.Size = new System.Drawing.Size(123, 20);
            this.q1tb.TabIndex = 13;
            // 
            // a1
            // 
            this.a1.AutoSize = true;
            this.a1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.a1.Location = new System.Drawing.Point(63, 326);
            this.a1.Name = "a1";
            this.a1.Size = new System.Drawing.Size(88, 15);
            this.a1.TabIndex = 14;
            this.a1.Text = "a. Loss of taste";
            // 
            // b1
            // 
            this.b1.AutoSize = true;
            this.b1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b1.Location = new System.Drawing.Point(63, 353);
            this.b1.Name = "b1";
            this.b1.Size = new System.Drawing.Size(88, 15);
            this.b1.TabIndex = 15;
            this.b1.Text = "b. loss of smell";
            // 
            // c1
            // 
            this.c1.AutoSize = true;
            this.c1.Enabled = false;
            this.c1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.c1.Location = new System.Drawing.Point(160, 326);
            this.c1.Name = "c1";
            this.c1.Size = new System.Drawing.Size(123, 15);
            this.c1.TabIndex = 16;
            this.c1.Text = "c. shortness of breath";
            // 
            // d1
            // 
            this.d1.AutoSize = true;
            this.d1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.d1.Location = new System.Drawing.Point(160, 353);
            this.d1.Name = "d1";
            this.d1.Size = new System.Drawing.Size(54, 15);
            this.d1.TabIndex = 17;
            this.d1.Text = "d. cough";
            // 
            // e1
            // 
            this.e1.AutoSize = true;
            this.e1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.e1.Location = new System.Drawing.Point(296, 326);
            this.e1.Name = "e1";
            this.e1.Size = new System.Drawing.Size(50, 15);
            this.e1.TabIndex = 18;
            this.e1.Text = "e. Fever";
            // 
            // f1
            // 
            this.f1.AutoSize = true;
            this.f1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.f1.Location = new System.Drawing.Point(296, 353);
            this.f1.Name = "f1";
            this.f1.Size = new System.Drawing.Size(127, 15);
            this.f1.TabIndex = 19;
            this.f1.Text = "f. difficulty of breathing";
            // 
            // g1
            // 
            this.g1.AutoSize = true;
            this.g1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.g1.Location = new System.Drawing.Point(438, 326);
            this.g1.Name = "g1";
            this.g1.Size = new System.Drawing.Size(79, 15);
            this.g1.TabIndex = 20;
            this.g1.Text = "g. body pains";
            // 
            // input1
            // 
            this.input1.AutoSize = true;
            this.input1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.input1.Location = new System.Drawing.Point(229, 304);
            this.input1.Name = "input1";
            this.input1.Size = new System.Drawing.Size(241, 16);
            this.input1.TabIndex = 21;
            this.input1.Text = "(Type all letters that apply e.g.  a , b, g ) ";
            // 
            // q2
            // 
            this.q2.AutoSize = true;
            this.q2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.q2.Location = new System.Drawing.Point(42, 382);
            this.q2.Name = "q2";
            this.q2.Size = new System.Drawing.Size(307, 16);
            this.q2.TabIndex = 22;
            this.q2.Text = "When did you start Experiencing those symptoms?";
            // 
            // ddmmyytb
            // 
            this.ddmmyytb.Location = new System.Drawing.Point(470, 381);
            this.ddmmyytb.Name = "ddmmyytb";
            this.ddmmyytb.Size = new System.Drawing.Size(141, 20);
            this.ddmmyytb.TabIndex = 23;
            // 
            // ddmmyy
            // 
            this.ddmmyy.AutoSize = true;
            this.ddmmyy.Location = new System.Drawing.Point(372, 385);
            this.ddmmyy.Name = "ddmmyy";
            this.ddmmyy.Size = new System.Drawing.Size(92, 13);
            this.ddmmyy.TabIndex = 24;
            this.ddmmyy.Text = "Year/Month/Date";
            // 
            // q3
            // 
            this.q3.AutoSize = true;
            this.q3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.q3.Location = new System.Drawing.Point(42, 415);
            this.q3.Name = "q3";
            this.q3.Size = new System.Drawing.Size(587, 16);
            this.q3.TabIndex = 25;
            this.q3.Text = "Have you been closed contact with someone who has been exposed to/ or experienced" +
    " Covid-19 ";
            // 
            // q4
            // 
            this.q4.AutoSize = true;
            this.q4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.q4.Location = new System.Drawing.Point(112, 440);
            this.q4.Name = "q4";
            this.q4.Size = new System.Drawing.Size(266, 15);
            this.q4.TabIndex = 26;
            this.q4.Text = "(Please Type the Applicable answer: Yes or NO)";
            // 
            // q4tb
            // 
            this.q4tb.Location = new System.Drawing.Point(386, 439);
            this.q4tb.Name = "q4tb";
            this.q4tb.Size = new System.Drawing.Size(145, 20);
            this.q4tb.TabIndex = 27;
            // 
            // q5
            // 
            this.q5.AutoSize = true;
            this.q5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.q5.Location = new System.Drawing.Point(44, 473);
            this.q5.Name = "q5";
            this.q5.Size = new System.Drawing.Size(326, 16);
            this.q5.TabIndex = 28;
            this.q5.Text = "Have you Received a COVID-19 Vaccine? YEs or NO";
            // 
            // q5tb
            // 
            this.q5tb.Location = new System.Drawing.Point(377, 473);
            this.q5tb.Name = "q5tb";
            this.q5tb.Size = new System.Drawing.Size(113, 20);
            this.q5tb.TabIndex = 29;
            // 
            // ifyes
            // 
            this.ifyes.AutoSize = true;
            this.ifyes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ifyes.Location = new System.Drawing.Point(44, 498);
            this.ifyes.Name = "ifyes";
            this.ifyes.Size = new System.Drawing.Size(42, 16);
            this.ifyes.TabIndex = 30;
            this.ifyes.Text = "If yes:";
            // 
            // firstdose
            // 
            this.firstdose.AutoSize = true;
            this.firstdose.Location = new System.Drawing.Point(95, 515);
            this.firstdose.Name = "firstdose";
            this.firstdose.Size = new System.Drawing.Size(104, 13);
            this.firstdose.TabIndex = 31;
            this.firstdose.Text = "1st Dose (yes or no):";
            // 
            // firstdosetb
            // 
            this.firstdosetb.Location = new System.Drawing.Point(205, 512);
            this.firstdosetb.Name = "firstdosetb";
            this.firstdosetb.Size = new System.Drawing.Size(100, 20);
            this.firstdosetb.TabIndex = 32;
            // 
            // vaccinetype1
            // 
            this.vaccinetype1.AutoSize = true;
            this.vaccinetype1.Location = new System.Drawing.Point(336, 515);
            this.vaccinetype1.Name = "vaccinetype1";
            this.vaccinetype1.Size = new System.Drawing.Size(76, 13);
            this.vaccinetype1.TabIndex = 33;
            this.vaccinetype1.Text = "Vaccine Type:";
            // 
            // vaccinetype1tb
            // 
            this.vaccinetype1tb.Location = new System.Drawing.Point(418, 512);
            this.vaccinetype1tb.Name = "vaccinetype1tb";
            this.vaccinetype1tb.Size = new System.Drawing.Size(128, 20);
            this.vaccinetype1tb.TabIndex = 34;
            // 
            // seconddose
            // 
            this.seconddose.AutoSize = true;
            this.seconddose.Location = new System.Drawing.Point(95, 540);
            this.seconddose.Name = "seconddose";
            this.seconddose.Size = new System.Drawing.Size(108, 13);
            this.seconddose.TabIndex = 35;
            this.seconddose.Text = "2nd Dose (yes or no):";
            // 
            // seconddosetb
            // 
            this.seconddosetb.Location = new System.Drawing.Point(205, 537);
            this.seconddosetb.Name = "seconddosetb";
            this.seconddosetb.Size = new System.Drawing.Size(100, 20);
            this.seconddosetb.TabIndex = 36;
            // 
            // vaccinetype2
            // 
            this.vaccinetype2.AutoSize = true;
            this.vaccinetype2.Location = new System.Drawing.Point(336, 540);
            this.vaccinetype2.Name = "vaccinetype2";
            this.vaccinetype2.Size = new System.Drawing.Size(76, 13);
            this.vaccinetype2.TabIndex = 37;
            this.vaccinetype2.Text = "Vaccine Type:";
            // 
            // vaccinetype2bt
            // 
            this.vaccinetype2bt.Location = new System.Drawing.Point(418, 540);
            this.vaccinetype2bt.Name = "vaccinetype2bt";
            this.vaccinetype2bt.Size = new System.Drawing.Size(128, 20);
            this.vaccinetype2bt.TabIndex = 38;
            // 
            // temp
            // 
            this.temp.AutoSize = true;
            this.temp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.temp.Location = new System.Drawing.Point(467, 220);
            this.temp.Name = "temp";
            this.temp.Size = new System.Drawing.Size(89, 16);
            this.temp.TabIndex = 39;
            this.temp.Text = "Temperature:";
            // 
            // temptb
            // 
            this.temptb.Location = new System.Drawing.Point(564, 218);
            this.temptb.Name = "temptb";
            this.temptb.Size = new System.Drawing.Size(47, 20);
            this.temptb.TabIndex = 40;
            // 
            // submit
            // 
            this.submit.Location = new System.Drawing.Point(320, 683);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(92, 33);
            this.submit.TabIndex = 41;
            this.submit.Text = "SUBMIT";
            this.submit.UseVisualStyleBackColor = true;
            // 
            // contacttracing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(650, 749);
            this.Controls.Add(this.submit);
            this.Controls.Add(this.temptb);
            this.Controls.Add(this.temp);
            this.Controls.Add(this.vaccinetype2bt);
            this.Controls.Add(this.vaccinetype2);
            this.Controls.Add(this.seconddosetb);
            this.Controls.Add(this.seconddose);
            this.Controls.Add(this.vaccinetype1tb);
            this.Controls.Add(this.vaccinetype1);
            this.Controls.Add(this.firstdosetb);
            this.Controls.Add(this.firstdose);
            this.Controls.Add(this.ifyes);
            this.Controls.Add(this.q5tb);
            this.Controls.Add(this.q5);
            this.Controls.Add(this.q4tb);
            this.Controls.Add(this.q4);
            this.Controls.Add(this.q3);
            this.Controls.Add(this.ddmmyy);
            this.Controls.Add(this.ddmmyytb);
            this.Controls.Add(this.q2);
            this.Controls.Add(this.input1);
            this.Controls.Add(this.g1);
            this.Controls.Add(this.f1);
            this.Controls.Add(this.e1);
            this.Controls.Add(this.d1);
            this.Controls.Add(this.c1);
            this.Controls.Add(this.b1);
            this.Controls.Add(this.a1);
            this.Controls.Add(this.q1tb);
            this.Controls.Add(this.q1);
            this.Controls.Add(this.contacttb);
            this.Controls.Add(this.addresstb);
            this.Controls.Add(this.gendertb);
            this.Controls.Add(this.agetb);
            this.Controls.Add(this.datetb);
            this.Controls.Add(this.nametb);
            this.Controls.Add(this.contactnumber);
            this.Controls.Add(this.date);
            this.Controls.Add(this.gender);
            this.Controls.Add(this.age);
            this.Controls.Add(this.address);
            this.Controls.Add(this.name);
            this.DoubleBuffered = true;
            this.Name = "contacttracing";
            this.Text = "CONTACT TRACING";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Label address;
        private System.Windows.Forms.Label age;
        private System.Windows.Forms.Label gender;
        private System.Windows.Forms.Label date;
        private System.Windows.Forms.Label contactnumber;
        private System.Windows.Forms.TextBox nametb;
        private System.Windows.Forms.TextBox datetb;
        private System.Windows.Forms.TextBox agetb;
        private System.Windows.Forms.TextBox gendertb;
        private System.Windows.Forms.TextBox addresstb;
        private System.Windows.Forms.TextBox contacttb;
        private System.Windows.Forms.Label q1;
        private System.Windows.Forms.TextBox q1tb;
        private System.Windows.Forms.Label a1;
        private System.Windows.Forms.Label b1;
        private System.Windows.Forms.Label c1;
        private System.Windows.Forms.Label d1;
        private System.Windows.Forms.Label e1;
        private System.Windows.Forms.Label f1;
        private System.Windows.Forms.Label g1;
        private System.Windows.Forms.Label input1;
        private System.Windows.Forms.Label q2;
        private System.Windows.Forms.TextBox ddmmyytb;
        private System.Windows.Forms.Label ddmmyy;
        private System.Windows.Forms.Label q3;
        private System.Windows.Forms.Label q4;
        private System.Windows.Forms.TextBox q4tb;
        private System.Windows.Forms.Label q5;
        private System.Windows.Forms.TextBox q5tb;
        private System.Windows.Forms.Label ifyes;
        private System.Windows.Forms.Label firstdose;
        private System.Windows.Forms.TextBox firstdosetb;
        private System.Windows.Forms.Label vaccinetype1;
        private System.Windows.Forms.TextBox vaccinetype1tb;
        private System.Windows.Forms.Label seconddose;
        private System.Windows.Forms.TextBox seconddosetb;
        private System.Windows.Forms.Label vaccinetype2;
        private System.Windows.Forms.TextBox vaccinetype2bt;
        private System.Windows.Forms.Label temp;
        private System.Windows.Forms.TextBox temptb;
        private System.Windows.Forms.Button submit;
    }
}

