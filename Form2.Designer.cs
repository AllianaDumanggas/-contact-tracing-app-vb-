﻿
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
            this.Viewname = new System.Windows.Forms.Button();
            this.finddate = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // viewallrecords
            // 
            this.viewallrecords.Location = new System.Drawing.Point(220, 70);
            this.viewallrecords.Name = "viewallrecords";
            this.viewallrecords.Size = new System.Drawing.Size(137, 40);
            this.viewallrecords.TabIndex = 0;
            this.viewallrecords.Text = "VIEW ALL RECORDS";
            this.viewallrecords.UseVisualStyleBackColor = true;
            this.viewallrecords.Click += new System.EventHandler(this.viewallrecords_Click);
            // 
            // Viewname
            // 
            this.Viewname.Location = new System.Drawing.Point(329, 116);
            this.Viewname.Name = "Viewname";
            this.Viewname.Size = new System.Drawing.Size(137, 34);
            this.Viewname.TabIndex = 1;
            this.Viewname.Text = "View Name";
            this.Viewname.UseVisualStyleBackColor = true;
            this.Viewname.Click += new System.EventHandler(this.Viewdate_Click);
            // 
            // finddate
            // 
            this.finddate.Location = new System.Drawing.Point(136, 124);
            this.finddate.Name = "finddate";
            this.finddate.Size = new System.Drawing.Size(187, 20);
            this.finddate.TabIndex = 2;
            this.finddate.Text = "Insert Full Name";
            // 
            // RECORDS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(569, 450);
            this.Controls.Add(this.finddate);
            this.Controls.Add(this.viewallrecords);
            this.Controls.Add(this.Viewname);
            this.DoubleBuffered = true;
            this.Name = "RECORDS";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button viewallrecords;
        private System.Windows.Forms.Button Viewname;
        private System.Windows.Forms.TextBox finddate;
    }
}