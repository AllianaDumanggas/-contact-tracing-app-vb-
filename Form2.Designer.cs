
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
            this.find = new System.Windows.Forms.Button();
            this.findatxtbox = new System.Windows.Forms.TextBox();
            this.viewallname = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // viewallrecords
            // 
            this.viewallrecords.Location = new System.Drawing.Point(220, 124);
            this.viewallrecords.Name = "viewallrecords";
            this.viewallrecords.Size = new System.Drawing.Size(137, 40);
            this.viewallrecords.TabIndex = 0;
            this.viewallrecords.Text = "VIEW ALL RECORDS";
            this.viewallrecords.UseVisualStyleBackColor = true;
            this.viewallrecords.Click += new System.EventHandler(this.viewallrecords_Click);
            // 
            // find
            // 
            this.find.Location = new System.Drawing.Point(420, 36);
            this.find.Name = "find";
            this.find.Size = new System.Drawing.Size(137, 34);
            this.find.TabIndex = 1;
            this.find.Text = "Find";
            this.find.UseVisualStyleBackColor = true;
            this.find.Click += new System.EventHandler(this.Viewdate_Click);
            // 
            // findatxtbox
            // 
            this.findatxtbox.Location = new System.Drawing.Point(220, 44);
            this.findatxtbox.Name = "findatxtbox";
            this.findatxtbox.Size = new System.Drawing.Size(187, 20);
            this.findatxtbox.TabIndex = 2;
            this.findatxtbox.Text = " ";
            // 
            // viewallname
            // 
            this.viewallname.Location = new System.Drawing.Point(220, 170);
            this.viewallname.Name = "viewallname";
            this.viewallname.Size = new System.Drawing.Size(137, 40);
            this.viewallname.TabIndex = 3;
            this.viewallname.Text = "VIEW NAMES";
            this.viewallname.UseVisualStyleBackColor = true;
            this.viewallname.Click += new System.EventHandler(this.viewallname_Click);
            // 
            // RECORDS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(569, 450);
            this.Controls.Add(this.viewallname);
            this.Controls.Add(this.findatxtbox);
            this.Controls.Add(this.viewallrecords);
            this.Controls.Add(this.find);
            this.DoubleBuffered = true;
            this.Name = "RECORDS";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button viewallrecords;
        private System.Windows.Forms.Button find;
        private System.Windows.Forms.TextBox findatxtbox;
        private System.Windows.Forms.Button viewallname;
    }
}