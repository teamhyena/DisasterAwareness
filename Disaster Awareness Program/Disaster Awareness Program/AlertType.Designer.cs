namespace Disaster_Awareness_Program
{
    partial class AlertType
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.sendTestAlertBtn = new System.Windows.Forms.Button();
            this.sendRealAlertBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.overrideCheckBox = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // sendTestAlertBtn
            // 
            this.sendTestAlertBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sendTestAlertBtn.Location = new System.Drawing.Point(57, 222);
            this.sendTestAlertBtn.Name = "sendTestAlertBtn";
            this.sendTestAlertBtn.Size = new System.Drawing.Size(200, 75);
            this.sendTestAlertBtn.TabIndex = 0;
            this.sendTestAlertBtn.Text = "Send TEST Alert";
            this.sendTestAlertBtn.UseVisualStyleBackColor = true;
            this.sendTestAlertBtn.Click += new System.EventHandler(this.sendTestAlertBtn_Click);
            // 
            // sendRealAlertBtn
            // 
            this.sendRealAlertBtn.Enabled = false;
            this.sendRealAlertBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sendRealAlertBtn.Location = new System.Drawing.Point(365, 222);
            this.sendRealAlertBtn.Name = "sendRealAlertBtn";
            this.sendRealAlertBtn.Size = new System.Drawing.Size(200, 75);
            this.sendRealAlertBtn.TabIndex = 1;
            this.sendRealAlertBtn.Text = "Send Real Alert";
            this.sendRealAlertBtn.UseVisualStyleBackColor = true;
            this.sendRealAlertBtn.Click += new System.EventHandler(this.sendRealAlertBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(296, 252);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Or";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(169, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(265, 31);
            this.label2.TabIndex = 3;
            this.label2.Text = "Choose Alert Type:";
            // 
            // overrideCheckBox
            // 
            this.overrideCheckBox.AutoSize = true;
            this.overrideCheckBox.Location = new System.Drawing.Point(365, 303);
            this.overrideCheckBox.Name = "overrideCheckBox";
            this.overrideCheckBox.Size = new System.Drawing.Size(66, 17);
            this.overrideCheckBox.TabIndex = 4;
            this.overrideCheckBox.Text = "Override";
            this.overrideCheckBox.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(226, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Current Emergency Status:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(368, 37);
            this.panel1.TabIndex = 6;
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Disaster_Awareness_Program.Properties.Resources.Stage_1_new;
            this.pictureBox1.Location = new System.Drawing.Point(73, 46);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(481, 98);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // AlertType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.overrideCheckBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sendRealAlertBtn);
            this.Controls.Add(this.sendTestAlertBtn);
            this.Name = "AlertType";
            this.Size = new System.Drawing.Size(640, 480);
            this.Load += new System.EventHandler(this.AlertType_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button sendTestAlertBtn;
        private System.Windows.Forms.Button sendRealAlertBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox overrideCheckBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ImageList imageList1;
    }
}
