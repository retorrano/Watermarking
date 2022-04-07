namespace WM
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.SSFButton = new System.Windows.Forms.Button();
            this.SFTextBox = new System.Windows.Forms.TextBox();
            this.TFTextBox = new System.Windows.Forms.TextBox();
            this.STFButton = new System.Windows.Forms.Button();
            this.ProcessButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.WITextBox = new System.Windows.Forms.TextBox();
            this.IconTextBox = new System.Windows.Forms.TextBox();
            this.SIButton = new System.Windows.Forms.Button();
            this.ATextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.RTextBox = new System.Windows.Forms.TextBox();
            this.GTextBox = new System.Windows.Forms.TextBox();
            this.BTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.FontTextBox = new System.Windows.Forms.TextBox();
            this.AboutButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SSFButton
            // 
            this.SSFButton.Location = new System.Drawing.Point(20, 17);
            this.SSFButton.Name = "SSFButton";
            this.SSFButton.Size = new System.Drawing.Size(168, 23);
            this.SSFButton.TabIndex = 0;
            this.SSFButton.Text = "Select Source Folder";
            this.SSFButton.UseVisualStyleBackColor = true;
            this.SSFButton.Click += new System.EventHandler(this.SSFButton_Click);
            // 
            // SFTextBox
            // 
            this.SFTextBox.Location = new System.Drawing.Point(216, 17);
            this.SFTextBox.Name = "SFTextBox";
            this.SFTextBox.Size = new System.Drawing.Size(487, 23);
            this.SFTextBox.TabIndex = 1;
            // 
            // TFTextBox
            // 
            this.TFTextBox.Location = new System.Drawing.Point(216, 46);
            this.TFTextBox.Name = "TFTextBox";
            this.TFTextBox.Size = new System.Drawing.Size(487, 23);
            this.TFTextBox.TabIndex = 3;
            // 
            // STFButton
            // 
            this.STFButton.Location = new System.Drawing.Point(20, 46);
            this.STFButton.Name = "STFButton";
            this.STFButton.Size = new System.Drawing.Size(168, 23);
            this.STFButton.TabIndex = 2;
            this.STFButton.Text = "Select Target Folder";
            this.STFButton.UseVisualStyleBackColor = true;
            this.STFButton.Click += new System.EventHandler(this.STFButton_Click);
            // 
            // ProcessButton
            // 
            this.ProcessButton.Location = new System.Drawing.Point(20, 238);
            this.ProcessButton.Name = "ProcessButton";
            this.ProcessButton.Size = new System.Drawing.Size(75, 23);
            this.ProcessButton.TabIndex = 5;
            this.ProcessButton.Text = "Process";
            this.ProcessButton.UseVisualStyleBackColor = true;
            this.ProcessButton.Click += new System.EventHandler(this.ProcessButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(20, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 21);
            this.label1.TabIndex = 6;
            this.label1.Text = "Watermark Text";
            // 
            // WITextBox
            // 
            this.WITextBox.Location = new System.Drawing.Point(216, 110);
            this.WITextBox.Name = "WITextBox";
            this.WITextBox.Size = new System.Drawing.Size(487, 23);
            this.WITextBox.TabIndex = 7;
            // 
            // IconTextBox
            // 
            this.IconTextBox.Location = new System.Drawing.Point(216, 75);
            this.IconTextBox.Name = "IconTextBox";
            this.IconTextBox.Size = new System.Drawing.Size(487, 23);
            this.IconTextBox.TabIndex = 9;
            // 
            // SIButton
            // 
            this.SIButton.Location = new System.Drawing.Point(20, 75);
            this.SIButton.Name = "SIButton";
            this.SIButton.Size = new System.Drawing.Size(168, 23);
            this.SIButton.TabIndex = 8;
            this.SIButton.Text = "Select Icon";
            this.SIButton.UseVisualStyleBackColor = true;
            this.SIButton.Click += new System.EventHandler(this.SIButton_Click);
            // 
            // ATextBox
            // 
            this.ATextBox.Location = new System.Drawing.Point(216, 181);
            this.ATextBox.Name = "ATextBox";
            this.ATextBox.Size = new System.Drawing.Size(52, 23);
            this.ATextBox.TabIndex = 11;
            this.ATextBox.Text = "255";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(20, 179);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 21);
            this.label2.TabIndex = 10;
            this.label2.Text = "Text Color (ARGB)";
            // 
            // RTextBox
            // 
            this.RTextBox.Location = new System.Drawing.Point(274, 181);
            this.RTextBox.Name = "RTextBox";
            this.RTextBox.Size = new System.Drawing.Size(52, 23);
            this.RTextBox.TabIndex = 12;
            this.RTextBox.Text = "255";
            // 
            // GTextBox
            // 
            this.GTextBox.Location = new System.Drawing.Point(332, 181);
            this.GTextBox.Name = "GTextBox";
            this.GTextBox.Size = new System.Drawing.Size(52, 23);
            this.GTextBox.TabIndex = 13;
            this.GTextBox.Text = "255";
            // 
            // BTextBox
            // 
            this.BTextBox.Location = new System.Drawing.Point(390, 181);
            this.BTextBox.Name = "BTextBox";
            this.BTextBox.Size = new System.Drawing.Size(52, 23);
            this.BTextBox.TabIndex = 14;
            this.BTextBox.Text = "255";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(20, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 21);
            this.label3.TabIndex = 15;
            this.label3.Text = "Font";
            // 
            // FontTextBox
            // 
            this.FontTextBox.Location = new System.Drawing.Point(216, 148);
            this.FontTextBox.Name = "FontTextBox";
            this.FontTextBox.Size = new System.Drawing.Size(190, 23);
            this.FontTextBox.TabIndex = 16;
            // 
            // AboutButton
            // 
            this.AboutButton.Location = new System.Drawing.Point(713, 415);
            this.AboutButton.Name = "AboutButton";
            this.AboutButton.Size = new System.Drawing.Size(75, 23);
            this.AboutButton.TabIndex = 17;
            this.AboutButton.Text = "About";
            this.AboutButton.UseVisualStyleBackColor = true;
            this.AboutButton.Click += new System.EventHandler(this.AboutButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.AboutButton);
            this.Controls.Add(this.FontTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BTextBox);
            this.Controls.Add(this.GTextBox);
            this.Controls.Add(this.RTextBox);
            this.Controls.Add(this.ATextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.IconTextBox);
            this.Controls.Add(this.SIButton);
            this.Controls.Add(this.WITextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ProcessButton);
            this.Controls.Add(this.TFTextBox);
            this.Controls.Add(this.STFButton);
            this.Controls.Add(this.SFTextBox);
            this.Controls.Add(this.SSFButton);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Watermarking";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button SSFButton;
        private TextBox SFTextBox;
        private TextBox TFTextBox;
        private Button STFButton;
        private Button ProcessButton;
        private Label label1;
        private TextBox WITextBox;
        private TextBox IconTextBox;
        private Button SIButton;
        private TextBox ATextBox;
        private Label label2;
        private TextBox RTextBox;
        private TextBox GTextBox;
        private TextBox BTextBox;
        private Label label3;
        private TextBox FontTextBox;
        private Button AboutButton;
    }
}