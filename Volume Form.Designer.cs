namespace MathsTutor
{
    partial class frmVolume
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
            this.lblVolume = new System.Windows.Forms.Label();
            this.btnQuiz = new System.Windows.Forms.Button();
            this.btnCuboid = new System.Windows.Forms.Button();
            this.btnSphere = new System.Windows.Forms.Button();
            this.btnCylinder = new System.Windows.Forms.Button();
            this.btnCube = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblVolume
            // 
            this.lblVolume.AutoSize = true;
            this.lblVolume.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVolume.ForeColor = System.Drawing.Color.Yellow;
            this.lblVolume.Location = new System.Drawing.Point(100, 30);
            this.lblVolume.Name = "lblVolume";
            this.lblVolume.Size = new System.Drawing.Size(187, 25);
            this.lblVolume.TabIndex = 17;
            this.lblVolume.Text = "Volume Calculator";
            // 
            // btnQuiz
            // 
            this.btnQuiz.BackColor = System.Drawing.Color.Gray;
            this.btnQuiz.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuiz.ForeColor = System.Drawing.Color.Lime;
            this.btnQuiz.Location = new System.Drawing.Point(44, 244);
            this.btnQuiz.Name = "btnQuiz";
            this.btnQuiz.Size = new System.Drawing.Size(85, 51);
            this.btnQuiz.TabIndex = 16;
            this.btnQuiz.Text = "Quiz";
            this.btnQuiz.UseVisualStyleBackColor = false;
            this.btnQuiz.Click += new System.EventHandler(this.btnQuiz_Click);
            // 
            // btnCuboid
            // 
            this.btnCuboid.BackColor = System.Drawing.Color.Gray;
            this.btnCuboid.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCuboid.ForeColor = System.Drawing.Color.Lime;
            this.btnCuboid.Location = new System.Drawing.Point(253, 169);
            this.btnCuboid.Name = "btnCuboid";
            this.btnCuboid.Size = new System.Drawing.Size(117, 51);
            this.btnCuboid.TabIndex = 15;
            this.btnCuboid.Text = "Cuboid";
            this.btnCuboid.UseVisualStyleBackColor = false;
            this.btnCuboid.Click += new System.EventHandler(this.btnCuboid_Click);
            // 
            // btnSphere
            // 
            this.btnSphere.BackColor = System.Drawing.Color.Gray;
            this.btnSphere.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSphere.ForeColor = System.Drawing.Color.Lime;
            this.btnSphere.Location = new System.Drawing.Point(44, 169);
            this.btnSphere.Name = "btnSphere";
            this.btnSphere.Size = new System.Drawing.Size(85, 51);
            this.btnSphere.TabIndex = 14;
            this.btnSphere.Text = "Sphere";
            this.btnSphere.UseVisualStyleBackColor = false;
            this.btnSphere.Click += new System.EventHandler(this.btnSphere_Click);
            // 
            // btnCylinder
            // 
            this.btnCylinder.BackColor = System.Drawing.Color.Gray;
            this.btnCylinder.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCylinder.ForeColor = System.Drawing.Color.Lime;
            this.btnCylinder.Location = new System.Drawing.Point(270, 88);
            this.btnCylinder.Name = "btnCylinder";
            this.btnCylinder.Size = new System.Drawing.Size(85, 46);
            this.btnCylinder.TabIndex = 13;
            this.btnCylinder.Text = "Cylinder";
            this.btnCylinder.UseVisualStyleBackColor = false;
            this.btnCylinder.Click += new System.EventHandler(this.btnCylinder_Click);
            // 
            // btnCube
            // 
            this.btnCube.BackColor = System.Drawing.Color.Gray;
            this.btnCube.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCube.ForeColor = System.Drawing.Color.Lime;
            this.btnCube.Location = new System.Drawing.Point(44, 88);
            this.btnCube.Name = "btnCube";
            this.btnCube.Size = new System.Drawing.Size(70, 63);
            this.btnCube.TabIndex = 12;
            this.btnCube.Text = "Cube";
            this.btnCube.UseVisualStyleBackColor = false;
            this.btnCube.Click += new System.EventHandler(this.btnCube_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Gray;
            this.btnExit.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.Lime;
            this.btnExit.Location = new System.Drawing.Point(270, 244);
            this.btnExit.Name = "btnExit";
            this.btnExit.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnExit.Size = new System.Drawing.Size(85, 51);
            this.btnExit.TabIndex = 18;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click_1);
            // 
            // frmVolume
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(417, 351);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblVolume);
            this.Controls.Add(this.btnQuiz);
            this.Controls.Add(this.btnCuboid);
            this.Controls.Add(this.btnSphere);
            this.Controls.Add(this.btnCylinder);
            this.Controls.Add(this.btnCube);
            this.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Lime;
            this.Name = "frmVolume";
            this.Text = "Volume Form";
            this.Load += new System.EventHandler(this.frmVolume_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblVolume;
        private System.Windows.Forms.Button btnQuiz;
        private System.Windows.Forms.Button btnCuboid;
        private System.Windows.Forms.Button btnSphere;
        private System.Windows.Forms.Button btnCylinder;
        private System.Windows.Forms.Button btnCube;
        private System.Windows.Forms.Button btnExit;
    }
}