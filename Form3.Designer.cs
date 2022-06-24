
namespace Contact_Tracing_App
{
    partial class LISTRECORD
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
            this.showlist = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // showlist
            // 
            this.showlist.Location = new System.Drawing.Point(24, 12);
            this.showlist.Multiline = true;
            this.showlist.Name = "showlist";
            this.showlist.ReadOnly = true;
            this.showlist.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.showlist.Size = new System.Drawing.Size(642, 426);
            this.showlist.TabIndex = 0;
            // 
            // LISTRECORD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(688, 450);
            this.Controls.Add(this.showlist);
            this.Name = "LISTRECORD";
            this.Text = "LIST OF DATA";
            this.Load += new System.EventHandler(this.LISTRECORD_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox showlist;
    }
}