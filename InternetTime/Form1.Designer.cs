namespace InternetTime
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
            this.components = new System.ComponentModel.Container();
            this.ChangeButton = new System.Windows.Forms.Button();
            this.NormalTimeTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.InternetTimeTextBox = new System.Windows.Forms.TextBox();
            this.UpdateTime = new System.Windows.Forms.Timer(this.components);
            this.RealTimeUpdatingCheckBox = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.TestEndedTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ChangeButton
            // 
            this.ChangeButton.Location = new System.Drawing.Point(76, 251);
            this.ChangeButton.Name = "ChangeButton";
            this.ChangeButton.Size = new System.Drawing.Size(119, 23);
            this.ChangeButton.TabIndex = 0;
            this.ChangeButton.Text = "Change";
            this.ChangeButton.UseVisualStyleBackColor = true;
            this.ChangeButton.Click += new System.EventHandler(this.ChangeButton_Click);
            // 
            // NormalTimeTextBox
            // 
            this.NormalTimeTextBox.Location = new System.Drawing.Point(12, 35);
            this.NormalTimeTextBox.Name = "NormalTimeTextBox";
            this.NormalTimeTextBox.ReadOnly = true;
            this.NormalTimeTextBox.Size = new System.Drawing.Size(134, 20);
            this.NormalTimeTextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Normal time:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Internet time:";
            // 
            // InternetTimeTextBox
            // 
            this.InternetTimeTextBox.Location = new System.Drawing.Point(12, 96);
            this.InternetTimeTextBox.Name = "InternetTimeTextBox";
            this.InternetTimeTextBox.ReadOnly = true;
            this.InternetTimeTextBox.Size = new System.Drawing.Size(134, 20);
            this.InternetTimeTextBox.TabIndex = 3;
            // 
            // UpdateTime
            // 
            this.UpdateTime.Interval = 1000;
            this.UpdateTime.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // RealTimeUpdatingCheckBox
            // 
            this.RealTimeUpdatingCheckBox.AutoSize = true;
            this.RealTimeUpdatingCheckBox.Location = new System.Drawing.Point(12, 131);
            this.RealTimeUpdatingCheckBox.Name = "RealTimeUpdatingCheckBox";
            this.RealTimeUpdatingCheckBox.Size = new System.Drawing.Size(111, 17);
            this.RealTimeUpdatingCheckBox.TabIndex = 5;
            this.RealTimeUpdatingCheckBox.Text = "Realtime updating";
            this.RealTimeUpdatingCheckBox.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(336, 251);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Test perfomance";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(322, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Test ended in:";
            // 
            // TestEndedTextBox
            // 
            this.TestEndedTextBox.Location = new System.Drawing.Point(321, 35);
            this.TestEndedTextBox.Name = "TestEndedTextBox";
            this.TestEndedTextBox.ReadOnly = true;
            this.TestEndedTextBox.Size = new System.Drawing.Size(134, 20);
            this.TestEndedTextBox.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(501, 334);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TestEndedTextBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.RealTimeUpdatingCheckBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.InternetTimeTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NormalTimeTextBox);
            this.Controls.Add(this.ChangeButton);
            this.Name = "Form1";
            this.Text = "ZJIKO Lab4 Bodia";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ChangeButton;
        private System.Windows.Forms.TextBox NormalTimeTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox InternetTimeTextBox;
        private System.Windows.Forms.Timer UpdateTime;
        private System.Windows.Forms.CheckBox RealTimeUpdatingCheckBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TestEndedTextBox;
    }
}

