namespace Disaster_Awareness_Program
{
    partial class ContentSummary
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
            this.label3 = new System.Windows.Forms.Label();
            this.nextButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.userDataBase1 = new Disaster_Awareness_Program.userDataBase();
            this.islandGroupBox = new System.Windows.Forms.GroupBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.islandTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.alertTypeTextBox = new System.Windows.Forms.TextBox();
            this.disasterTypeLabel = new System.Windows.Forms.Label();
            this.disasterLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userDataBase1)).BeginInit();
            this.islandGroupBox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
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
            // nextButton
            // 
            this.nextButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nextButton.Location = new System.Drawing.Point(346, 346);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(190, 59);
            this.nextButton.TabIndex = 61;
            this.nextButton.Text = "Send Alert";
            this.nextButton.UseVisualStyleBackColor = true;
            this.nextButton.Click += new System.EventHandler(this.nextButton_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(429, 37);
            this.panel1.TabIndex = 52;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(110, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(426, 31);
            this.label2.TabIndex = 51;
            this.label2.Text = "Please Confirm Your Selections";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(90, 346);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(190, 59);
            this.button1.TabIndex = 63;
            this.button1.Text = "Cancel and Reset Form";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Disaster_Awareness_Program.Properties.Resources.Stage_5;
            this.pictureBox1.Location = new System.Drawing.Point(45, 46);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(561, 98);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 53;
            this.pictureBox1.TabStop = false;
            // 
            // userDataBase1
            // 
            this.userDataBase1.DataSetName = "userDataBase";
            this.userDataBase1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // islandGroupBox
            // 
            this.islandGroupBox.Controls.Add(this.islandTextBox);
            this.islandGroupBox.Location = new System.Drawing.Point(427, 192);
            this.islandGroupBox.Name = "islandGroupBox";
            this.islandGroupBox.Size = new System.Drawing.Size(200, 148);
            this.islandGroupBox.TabIndex = 64;
            this.islandGroupBox.TabStop = false;
            this.islandGroupBox.Text = "Islands ";
            this.islandGroupBox.Enter += new System.EventHandler(this.iconGroupBox_Enter);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // islandTextBox
            // 
            this.islandTextBox.AcceptsReturn = true;
            this.islandTextBox.Location = new System.Drawing.Point(13, 20);
            this.islandTextBox.Multiline = true;
            this.islandTextBox.Name = "islandTextBox";
            this.islandTextBox.ReadOnly = true;
            this.islandTextBox.Size = new System.Drawing.Size(181, 122);
            this.islandTextBox.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.alertTypeTextBox);
            this.groupBox1.Location = new System.Drawing.Point(221, 192);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 148);
            this.groupBox1.TabIndex = 65;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Alert Types";
            // 
            // alertTypeTextBox
            // 
            this.alertTypeTextBox.AcceptsReturn = true;
            this.alertTypeTextBox.Location = new System.Drawing.Point(13, 20);
            this.alertTypeTextBox.Multiline = true;
            this.alertTypeTextBox.Name = "alertTypeTextBox";
            this.alertTypeTextBox.ReadOnly = true;
            this.alertTypeTextBox.Size = new System.Drawing.Size(181, 122);
            this.alertTypeTextBox.TabIndex = 0;
            // 
            // disasterTypeLabel
            // 
            this.disasterTypeLabel.AutoSize = true;
            this.disasterTypeLabel.Location = new System.Drawing.Point(24, 192);
            this.disasterTypeLabel.Name = "disasterTypeLabel";
            this.disasterTypeLabel.Size = new System.Drawing.Size(72, 13);
            this.disasterTypeLabel.TabIndex = 68;
            this.disasterTypeLabel.Text = "Disaster Type";
            // 
            // disasterLabel
            // 
            this.disasterLabel.AutoSize = true;
            this.disasterLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.disasterLabel.Location = new System.Drawing.Point(60, 242);
            this.disasterLabel.Name = "disasterLabel";
            this.disasterLabel.Size = new System.Drawing.Size(99, 33);
            this.disasterLabel.TabIndex = 69;
            this.disasterLabel.Text = "label1";
            // 
            // ContentSummary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.disasterLabel);
            this.Controls.Add(this.disasterTypeLabel);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.islandGroupBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.nextButton);
            this.Controls.Add(this.panel1);
            this.Name = "ContentSummary";
            this.Size = new System.Drawing.Size(640, 480);
            this.Load += new System.EventHandler(this.ContentSummary_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userDataBase1)).EndInit();
            this.islandGroupBox.ResumeLayout(false);
            this.islandGroupBox.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button nextButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private userDataBase userDataBase1;
        private System.Windows.Forms.GroupBox islandGroupBox;
        private System.Windows.Forms.TextBox islandTextBox;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox alertTypeTextBox;
        private System.Windows.Forms.Label disasterTypeLabel;
        private System.Windows.Forms.Label disasterLabel;
    }
}
