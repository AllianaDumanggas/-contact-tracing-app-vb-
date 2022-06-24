
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
            this.enterpassword = new System.Windows.Forms.TextBox();
            this.entername = new System.Windows.Forms.TextBox();
            this.Name = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.Label();
            this.submit = new System.Windows.Forms.Button();
            this.formanswer = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lable2 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // enterpassword
            // 
            this.enterpassword.Location = new System.Drawing.Point(175, 213);
            this.enterpassword.Name = "enterpassword";
            this.enterpassword.Size = new System.Drawing.Size(230, 20);
            this.enterpassword.TabIndex = 0;
            // 
            // entername
            // 
            this.entername.Location = new System.Drawing.Point(175, 176);
            this.entername.Name = "entername";
            this.entername.Size = new System.Drawing.Size(230, 20);
            this.entername.TabIndex = 1;
            // 
            // Name
            // 
            this.Name.AutoSize = true;
            this.Name.Location = new System.Drawing.Point(90, 179);
            this.Name.Name = "Name";
            this.Name.Size = new System.Drawing.Size(68, 13);
            this.Name.TabIndex = 2;
            this.Name.Text = "USERNAME";
            // 
            // password
            // 
            this.password.AutoSize = true;
            this.password.Location = new System.Drawing.Point(88, 220);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(70, 13);
            this.password.TabIndex = 3;
            this.password.Text = "PASSWORD";
            // 
            // submit
            // 
            this.submit.Location = new System.Drawing.Point(424, 195);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(75, 23);
            this.submit.TabIndex = 5;
            this.submit.Text = "SUBMIT";
            this.submit.UseVisualStyleBackColor = true;
            // 
            // formanswer
            // 
            this.formanswer.Location = new System.Drawing.Point(205, 97);
            this.formanswer.Name = "formanswer";
            this.formanswer.Size = new System.Drawing.Size(162, 23);
            this.formanswer.TabIndex = 6;
            this.formanswer.Text = "ANSWER FORM";
            this.formanswer.UseVisualStyleBackColor = true;
            this.formanswer.Click += new System.EventHandler(this.formanswer_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(211, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "WE ARE HOME TO CARE";
            // 
            // lable2
            // 
            this.lable2.AutoSize = true;
            this.lable2.Location = new System.Drawing.Point(277, 132);
            this.lable2.Name = "lable2";
            this.lable2.Size = new System.Drawing.Size(16, 13);
            this.lable2.TabIndex = 8;
            this.lable2.Text = "or";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(253, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "View Records";
            // 
            // RECORDS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(569, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lable2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.formanswer);
            this.Controls.Add(this.submit);
            this.Controls.Add(this.password);
            this.Controls.Add(this.Name);
            this.Controls.Add(this.entername);
            this.Controls.Add(this.enterpassword);
            this.DoubleBuffered = true;
            this.Name = "RECORDS";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox enterpassword;
        private System.Windows.Forms.TextBox entername;
        private System.Windows.Forms.Label Name;
        private System.Windows.Forms.Label password;
        private System.Windows.Forms.Button submit;
        private System.Windows.Forms.Button formanswer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lable2;
        private System.Windows.Forms.Label label2;
    }
}