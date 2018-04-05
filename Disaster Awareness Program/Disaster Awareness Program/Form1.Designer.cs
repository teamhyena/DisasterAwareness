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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.login1 = new Disaster_Awareness_Program.Login();
            this.islandType1 = new Disaster_Awareness_Program.IslandType();
            this.alertType1 = new Disaster_Awareness_Program.AlertType();
            this.disasterType1 = new Disaster_Awareness_Program.DisasterType();
            this.deliveryType1 = new Disaster_Awareness_Program.DeliveryType();
            this.contentSummary1 = new Disaster_Awareness_Program.ContentSummary();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(643, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // login1
            // 
            this.login1.Location = new System.Drawing.Point(0, 0);
            this.login1.Name = "login1";
            this.login1.Size = new System.Drawing.Size(640, 480);
            this.login1.TabIndex = 5;
            // 
            // islandType1
            // 
            this.islandType1.Location = new System.Drawing.Point(0, 0);
            this.islandType1.Name = "islandType1";
            this.islandType1.Size = new System.Drawing.Size(640, 480);
            this.islandType1.TabIndex = 4;
            // 
            // alertType1
            // 
            this.alertType1.Location = new System.Drawing.Point(0, 0);
            this.alertType1.Name = "alertType1";
            this.alertType1.Size = new System.Drawing.Size(640, 480);
            this.alertType1.TabIndex = 3;
            // 
            // disasterType1
            // 
            this.disasterType1.Enabled = false;
            this.disasterType1.Location = new System.Drawing.Point(3, 0);
            this.disasterType1.Name = "disasterType1";
            this.disasterType1.Size = new System.Drawing.Size(640, 480);
            this.disasterType1.TabIndex = 2;
            // 
            // deliveryType1
            // 
            this.deliveryType1.Enabled = false;
            this.deliveryType1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deliveryType1.Location = new System.Drawing.Point(0, 0);
            this.deliveryType1.Name = "deliveryType1";
            this.deliveryType1.Size = new System.Drawing.Size(640, 480);
            this.deliveryType1.TabIndex = 0;
            // 
            // contentSummary1
            // 
            this.contentSummary1.Location = new System.Drawing.Point(0, 0);
            this.contentSummary1.Name = "contentSummary1";
            this.contentSummary1.Size = new System.Drawing.Size(640, 480);
            this.contentSummary1.TabIndex = 6;
            this.contentSummary1.Load += new System.EventHandler(this.contentSummary1_Load);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(643, 477);
            this.Controls.Add(this.contentSummary1);
            this.Controls.Add(this.login1);
            this.Controls.Add(this.islandType1);
            this.Controls.Add(this.alertType1);
            this.Controls.Add(this.disasterType1);
            this.Controls.Add(this.deliveryType1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = " ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DeliveryType deliveryType1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private DisasterType disasterType1;
        private AlertType alertType1;
        private IslandType islandType1;
        private Login login1;
        private ContentSummary contentSummary1;

    }
}

