
namespace Contact_Tracing_App
{
    partial class RECORDS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RECORDS));
            this.viewallrecords = new System.Windows.Forms.Button();
            this.viewallname = new System.Windows.Forms.Button();
            this.datefind = new System.Windows.Forms.TextBox();
            this.finddate = new System.Windows.Forms.Button();
            this.findbttn = new System.Windows.Forms.Button();
            this.findtxt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // viewallrecords
            // 
            this.viewallrecords.Location = new System.Drawing.Point(173, 115);
            this.viewallrecords.Name = "viewallrecords";
            this.viewallrecords.Size = new System.Drawing.Size(137, 40);
            this.viewallrecords.TabIndex = 0;
            this.viewallrecords.Text = "VIEW ALL RECORDS";
            this.viewallrecords.UseVisualStyleBackColor = true;
            this.viewallrecords.Click += new System.EventHandler(this.viewallrecords_Click);
            // 
            // viewallname
            // 
            this.viewallname.Location = new System.Drawing.Point(173, 161);
            this.viewallname.Name = "viewallname";
            this.viewallname.Size = new System.Drawing.Size(137, 41);
            this.viewallname.TabIndex = 3;
            this.viewallname.Text = "VIEW NAMES";
            this.viewallname.UseVisualStyleBackColor = true;
            this.viewallname.Click += new System.EventHandler(this.viewallname_Click);
            // 
            // datefind
            // 
            this.datefind.Location = new System.Drawing.Point(316, 219);
            this.datefind.Name = "datefind";
            this.datefind.Size = new System.Drawing.Size(133, 20);
            this.datefind.TabIndex = 5;
            this.datefind.Text = "m/dd/yy";
            // 
            // finddate
            // 
            this.finddate.Location = new System.Drawing.Point(173, 208);
            this.finddate.Name = "finddate";
            this.finddate.Size = new System.Drawing.Size(137, 41);
            this.finddate.TabIndex = 7;
            this.finddate.Text = "FIND BY DATE";
            this.finddate.UseVisualStyleBackColor = true;
            this.finddate.Click += new System.EventHandler(this.finddate_Click);
            // 
            // findbttn
            // 
            this.findbttn.Location = new System.Drawing.Point(463, 40);
            this.findbttn.Name = "findbttn";
            this.findbttn.Size = new System.Drawing.Size(75, 23);
            this.findbttn.TabIndex = 8;
            this.findbttn.Text = "FIND";
            this.findbttn.UseVisualStyleBackColor = true;
            this.findbttn.Click += new System.EventHandler(this.findbttn_Click);
            // 
            // findtxt
            // 
            this.findtxt.Location = new System.Drawing.Point(326, 40);
            this.findtxt.Name = "findtxt";
            this.findtxt.Size = new System.Drawing.Size(131, 20);
            this.findtxt.TabIndex = 9;
            this.findtxt.Text = "Input word";
            // 
            // RECORDS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(569, 450);
            this.Controls.Add(this.findtxt);
            this.Controls.Add(this.findbttn);
            this.Controls.Add(this.finddate);
            this.Controls.Add(this.datefind);
            this.Controls.Add(this.viewallname);
            this.Controls.Add(this.viewallrecords);
            this.DoubleBuffered = true;
            this.Name = "RECORDS";
            this.Text = "Display";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button viewallrecords;
        private System.Windows.Forms.Button viewallname;
        private System.Windows.Forms.TextBox datefind;
        private System.Windows.Forms.Button finddate;
        private System.Windows.Forms.Button findbttn;
        private System.Windows.Forms.TextBox findtxt;
    }
}