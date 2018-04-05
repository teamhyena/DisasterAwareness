namespace Disaster_Awareness_Program
{
    partial class InternalSystemTestForm
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
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTextMessageResult = new System.Windows.Forms.Label();
            this.lblEmailResult = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(18, 36);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(295, 31);
            this.button1.TabIndex = 0;
            this.button1.Text = "Test Delivery Methods";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblEmailResult);
            this.groupBox1.Controls.Add(this.lblTextMessageResult);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Location = new System.Drawing.Point(12, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(550, 183);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Delivery";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Text Message";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Email";
            // 
            // lblTextMessageResult
            // 
            this.lblTextMessageResult.AutoSize = true;
            this.lblTextMessageResult.Location = new System.Drawing.Point(215, 110);
            this.lblTextMessageResult.Name = "lblTextMessageResult";
            this.lblTextMessageResult.Size = new System.Drawing.Size(0, 20);
            this.lblTextMessageResult.TabIndex = 3;
            // 
            // lblEmailResult
            // 
            this.lblEmailResult.AutoSize = true;
            this.lblEmailResult.Location = new System.Drawing.Point(215, 151);
            this.lblEmailResult.Name = "lblEmailResult";
            this.lblEmailResult.Size = new System.Drawing.Size(0, 20);
            this.lblEmailResult.TabIndex = 4;
            // 
            // InternalSystemTestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(817, 513);
            this.Controls.Add(this.groupBox1);
            this.Name = "InternalSystemTestForm";
            this.Text = "InternalSystemTestForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblEmailResult;
        private System.Windows.Forms.Label lblTextMessageResult;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}