
namespace Contact_Tracing_App
{
    partial class generatingqrcode
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
            this.qrpicbox = new System.Windows.Forms.PictureBox();
            this.info = new System.Windows.Forms.TextBox();
            this.generate_qr = new System.Windows.Forms.Button();
            this.generatedqrlabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.qrpicbox)).BeginInit();
            this.SuspendLayout();
            // 
            // qrpicbox
            // 
            this.qrpicbox.BackColor = System.Drawing.Color.MistyRose;
            this.qrpicbox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.qrpicbox.Location = new System.Drawing.Point(26, 66);
            this.qrpicbox.Name = "qrpicbox";
            this.qrpicbox.Size = new System.Drawing.Size(401, 329);
            this.qrpicbox.TabIndex = 0;
            this.qrpicbox.TabStop = false;
            // 
            // info
            // 
            this.info.Location = new System.Drawing.Point(449, 75);
            this.info.Multiline = true;
            this.info.Name = "info";
            this.info.Size = new System.Drawing.Size(252, 173);
            this.info.TabIndex = 1;
            // 
            // generate_qr
            // 
            this.generate_qr.BackColor = System.Drawing.Color.Gray;
            this.generate_qr.ForeColor = System.Drawing.Color.White;
            this.generate_qr.Location = new System.Drawing.Point(534, 279);
            this.generate_qr.Name = "generate_qr";
            this.generate_qr.Size = new System.Drawing.Size(113, 34);
            this.generate_qr.TabIndex = 2;
            this.generate_qr.Text = "Generate";
            this.generate_qr.UseVisualStyleBackColor = false;
            this.generate_qr.Click += new System.EventHandler(this.generate_qr_Click);
            // 
            // generatedqrlabel
            // 
            this.generatedqrlabel.AutoSize = true;
            this.generatedqrlabel.Location = new System.Drawing.Point(23, 50);
            this.generatedqrlabel.Name = "generatedqrlabel";
            this.generatedqrlabel.Size = new System.Drawing.Size(79, 13);
            this.generatedqrlabel.TabIndex = 3;
            this.generatedqrlabel.Text = "Generated QR:";
            // 
            // generatingqrcode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(727, 511);
            this.Controls.Add(this.generatedqrlabel);
            this.Controls.Add(this.generate_qr);
            this.Controls.Add(this.info);
            this.Controls.Add(this.qrpicbox);
            this.Name = "generatingqrcode";
            this.Text = "Generating QR Code";
            ((System.ComponentModel.ISupportInitialize)(this.qrpicbox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox qrpicbox;
        private System.Windows.Forms.TextBox info;
        private System.Windows.Forms.Button generate_qr;
        private System.Windows.Forms.Label generatedqrlabel;
    }
}