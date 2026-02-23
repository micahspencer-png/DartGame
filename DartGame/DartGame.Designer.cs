namespace DartGame
{
    partial class DartGame
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
            this.DisplayPictureBox = new System.Windows.Forms.PictureBox();
            this.ExitButton = new System.Windows.Forms.Button();
            this.DisplayComboBox = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.PlayRadioButton = new System.Windows.Forms.RadioButton();
            this.ReviewRadioButton = new System.Windows.Forms.RadioButton();
            this.Displaylabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DisplayPictureBox)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DisplayPictureBox
            // 
            this.DisplayPictureBox.Location = new System.Drawing.Point(12, 12);
            this.DisplayPictureBox.Name = "DisplayPictureBox";
            this.DisplayPictureBox.Size = new System.Drawing.Size(550, 550);
            this.DisplayPictureBox.TabIndex = 0;
            this.DisplayPictureBox.TabStop = false;
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(668, 426);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(143, 71);
            this.ExitButton.TabIndex = 1;
            this.ExitButton.Text = "E&xit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // DisplayComboBox
            // 
            this.DisplayComboBox.FormattingEnabled = true;
            this.DisplayComboBox.Location = new System.Drawing.Point(629, 12);
            this.DisplayComboBox.Name = "DisplayComboBox";
            this.DisplayComboBox.Size = new System.Drawing.Size(174, 24);
            this.DisplayComboBox.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.PlayRadioButton);
            this.groupBox1.Controls.Add(this.ReviewRadioButton);
            this.groupBox1.Location = new System.Drawing.Point(607, 214);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(154, 145);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // PlayRadioButton
            // 
            this.PlayRadioButton.AutoSize = true;
            this.PlayRadioButton.Location = new System.Drawing.Point(26, 87);
            this.PlayRadioButton.Name = "PlayRadioButton";
            this.PlayRadioButton.Size = new System.Drawing.Size(55, 20);
            this.PlayRadioButton.TabIndex = 1;
            this.PlayRadioButton.TabStop = true;
            this.PlayRadioButton.Text = "Play";
            this.PlayRadioButton.UseVisualStyleBackColor = true;
            this.PlayRadioButton.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DartGame_KeyPress);
            // 
            // ReviewRadioButton
            // 
            this.ReviewRadioButton.AutoSize = true;
            this.ReviewRadioButton.Location = new System.Drawing.Point(26, 50);
            this.ReviewRadioButton.Name = "ReviewRadioButton";
            this.ReviewRadioButton.Size = new System.Drawing.Size(73, 20);
            this.ReviewRadioButton.TabIndex = 0;
            this.ReviewRadioButton.TabStop = true;
            this.ReviewRadioButton.Text = "Review";
            this.ReviewRadioButton.UseVisualStyleBackColor = true;
            this.ReviewRadioButton.CheckedChanged += new System.EventHandler(this.ReviewRadioButton_CheckedChanged);
            // 
            // Displaylabel
            // 
            this.Displaylabel.AutoSize = true;
            this.Displaylabel.Location = new System.Drawing.Point(604, 97);
            this.Displaylabel.Name = "Displaylabel";
            this.Displaylabel.Size = new System.Drawing.Size(119, 16);
            this.Displaylabel.TabIndex = 4;
            this.Displaylabel.Text = "Select Play to Start";
            // 
            // DartGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(823, 574);
            this.Controls.Add(this.Displaylabel);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.DisplayComboBox);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.DisplayPictureBox);
            this.MaximizeBox = false;
            this.Name = "DartGame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DartGame";
            this.Load += new System.EventHandler(this.DartGame_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DartGame_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.DisplayPictureBox)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox DisplayPictureBox;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.ComboBox DisplayComboBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton PlayRadioButton;
        private System.Windows.Forms.RadioButton ReviewRadioButton;
        private System.Windows.Forms.Label Displaylabel;
    }
}

