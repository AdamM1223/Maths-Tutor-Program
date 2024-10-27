namespace MathsTutor
{
    partial class frmPast
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
            this.lblAreaResults = new System.Windows.Forms.Label();
            this.lblVolumeResults = new System.Windows.Forms.Label();
            this.btnResults = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblDesc = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblAreaResults
            // 
            this.lblAreaResults.AutoSize = true;
            this.lblAreaResults.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAreaResults.ForeColor = System.Drawing.Color.Yellow;
            this.lblAreaResults.Location = new System.Drawing.Point(131, 101);
            this.lblAreaResults.Name = "lblAreaResults";
            this.lblAreaResults.Size = new System.Drawing.Size(90, 13);
            this.lblAreaResults.TabIndex = 1;
            this.lblAreaResults.Text = "Area Results - N/A";
            // 
            // lblVolumeResults
            // 
            this.lblVolumeResults.AutoSize = true;
            this.lblVolumeResults.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVolumeResults.ForeColor = System.Drawing.Color.Yellow;
            this.lblVolumeResults.Location = new System.Drawing.Point(131, 133);
            this.lblVolumeResults.Name = "lblVolumeResults";
            this.lblVolumeResults.Size = new System.Drawing.Size(104, 13);
            this.lblVolumeResults.TabIndex = 2;
            this.lblVolumeResults.Text = "Volume Results - N/A";
            // 
            // btnResults
            // 
            this.btnResults.BackColor = System.Drawing.Color.Gray;
            this.btnResults.ForeColor = System.Drawing.Color.Lime;
            this.btnResults.Location = new System.Drawing.Point(83, 166);
            this.btnResults.Name = "btnResults";
            this.btnResults.Size = new System.Drawing.Size(152, 66);
            this.btnResults.TabIndex = 3;
            this.btnResults.Text = "Click to View Results!";
            this.btnResults.UseVisualStyleBackColor = false;
            this.btnResults.Click += new System.EventHandler(this.btnResults_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Yellow;
            this.lblTitle.Location = new System.Drawing.Point(172, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(102, 23);
            this.lblTitle.TabIndex = 54;
            this.lblTitle.Text = "Past Results";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDesc
            // 
            this.lblDesc.AutoSize = true;
            this.lblDesc.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDesc.ForeColor = System.Drawing.Color.Yellow;
            this.lblDesc.Location = new System.Drawing.Point(2, 61);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(469, 13);
            this.lblDesc.TabIndex = 64;
            this.lblDesc.Text = "When the button is pressed, if there are stored results, these will be displayed " +
    "in the labels below!";
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Gray;
            this.btnExit.ForeColor = System.Drawing.Color.Lime;
            this.btnExit.Location = new System.Drawing.Point(290, 166);
            this.btnExit.Name = "btnExit";
            this.btnExit.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnExit.Size = new System.Drawing.Size(98, 66);
            this.btnExit.TabIndex = 65;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmPast
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(482, 265);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblDesc);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnResults);
            this.Controls.Add(this.lblVolumeResults);
            this.Controls.Add(this.lblAreaResults);
            this.Name = "frmPast";
            this.Text = "Past Quizzes";
            this.Load += new System.EventHandler(this.frmPast_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblAreaResults;
        private System.Windows.Forms.Label lblVolumeResults;
        private System.Windows.Forms.Button btnResults;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblDesc;
        private System.Windows.Forms.Button btnExit;
    }
}