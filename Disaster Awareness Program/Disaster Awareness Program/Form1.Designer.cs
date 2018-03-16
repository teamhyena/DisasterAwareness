namespace Disaster_Awareness_Program
{
    partial class Form1
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
            this.disasterType1 = new Disaster_Awareness_Program.DisasterType();
            this.alertType1 = new Disaster_Awareness_Program.AlertType();
            this.SuspendLayout();
            // 
            // disasterType1
            // 
            this.disasterType1.Location = new System.Drawing.Point(0, -2);
            this.disasterType1.Name = "disasterType1";
            this.disasterType1.Size = new System.Drawing.Size(644, 477);
            this.disasterType1.TabIndex = 1;
            // 
            // alertType1
            // 
            this.alertType1.Location = new System.Drawing.Point(592, 412);
            this.alertType1.Name = "alertType1";
            this.alertType1.Size = new System.Drawing.Size(640, 480);
            this.alertType1.TabIndex = 0;
            this.alertType1.Load += new System.EventHandler(this.alertType1_Load);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(615, 490);
            this.Controls.Add(this.disasterType1);
            this.Controls.Add(this.alertType1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form1";
            this.Text = " ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private AlertType alertType1;
        private DisasterType disasterType1;
    }
}

