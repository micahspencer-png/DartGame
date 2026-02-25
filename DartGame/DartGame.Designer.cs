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
            this.RoundTextBox = new System.Windows.Forms.TextBox();
            this.Dart1TextBox = new System.Windows.Forms.TextBox();
            this.Dart2TextBox = new System.Windows.Forms.TextBox();
            this.Dart3TextBox = new System.Windows.Forms.TextBox();
            this.RoundLabel = new System.Windows.Forms.Label();
            this.Dart1Label = new System.Windows.Forms.Label();
            this.Dart2Label = new System.Windows.Forms.Label();
            this.Dart3Label = new System.Windows.Forms.Label();
            this.ReviewGroupBox = new System.Windows.Forms.GroupBox();
            this.RoundGroupBox = new System.Windows.Forms.GroupBox();
            this.PlayRoundTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.DartCountabel = new System.Windows.Forms.Label();
            this.DartCountTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DisplayPictureBox)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.ReviewGroupBox.SuspendLayout();
            this.RoundGroupBox.SuspendLayout();
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
            this.ExitButton.Location = new System.Drawing.Point(669, 482);
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
            this.DisplayComboBox.SelectedIndexChanged += new System.EventHandler(this.DisplayComboBox_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.PlayRadioButton);
            this.groupBox1.Controls.Add(this.ReviewRadioButton);
            this.groupBox1.Location = new System.Drawing.Point(607, 127);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(98, 85);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // PlayRadioButton
            // 
            this.PlayRadioButton.AutoSize = true;
            this.PlayRadioButton.Location = new System.Drawing.Point(6, 47);
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
            this.ReviewRadioButton.Location = new System.Drawing.Point(6, 21);
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
            this.Displaylabel.Location = new System.Drawing.Point(577, 53);
            this.Displaylabel.Name = "Displaylabel";
            this.Displaylabel.Size = new System.Drawing.Size(119, 16);
            this.Displaylabel.TabIndex = 4;
            this.Displaylabel.Text = "Select Play to Start";
            // 
            // RoundTextBox
            // 
            this.RoundTextBox.Location = new System.Drawing.Point(89, 13);
            this.RoundTextBox.Name = "RoundTextBox";
            this.RoundTextBox.ReadOnly = true;
            this.RoundTextBox.Size = new System.Drawing.Size(122, 22);
            this.RoundTextBox.TabIndex = 5;
            // 
            // Dart1TextBox
            // 
            this.Dart1TextBox.Location = new System.Drawing.Point(89, 41);
            this.Dart1TextBox.Name = "Dart1TextBox";
            this.Dart1TextBox.ReadOnly = true;
            this.Dart1TextBox.Size = new System.Drawing.Size(122, 22);
            this.Dart1TextBox.TabIndex = 5;
            // 
            // Dart2TextBox
            // 
            this.Dart2TextBox.Location = new System.Drawing.Point(89, 69);
            this.Dart2TextBox.Name = "Dart2TextBox";
            this.Dart2TextBox.ReadOnly = true;
            this.Dart2TextBox.Size = new System.Drawing.Size(122, 22);
            this.Dart2TextBox.TabIndex = 5;
            // 
            // Dart3TextBox
            // 
            this.Dart3TextBox.Location = new System.Drawing.Point(89, 97);
            this.Dart3TextBox.Name = "Dart3TextBox";
            this.Dart3TextBox.ReadOnly = true;
            this.Dart3TextBox.Size = new System.Drawing.Size(122, 22);
            this.Dart3TextBox.TabIndex = 5;
            // 
            // RoundLabel
            // 
            this.RoundLabel.AutoSize = true;
            this.RoundLabel.Location = new System.Drawing.Point(3, 16);
            this.RoundLabel.Name = "RoundLabel";
            this.RoundLabel.Size = new System.Drawing.Size(47, 16);
            this.RoundLabel.TabIndex = 6;
            this.RoundLabel.Text = "Round";
            // 
            // Dart1Label
            // 
            this.Dart1Label.AutoSize = true;
            this.Dart1Label.Location = new System.Drawing.Point(3, 44);
            this.Dart1Label.Name = "Dart1Label";
            this.Dart1Label.Size = new System.Drawing.Size(39, 16);
            this.Dart1Label.TabIndex = 6;
            this.Dart1Label.Text = "Dart1";
            // 
            // Dart2Label
            // 
            this.Dart2Label.AutoSize = true;
            this.Dart2Label.Location = new System.Drawing.Point(3, 72);
            this.Dart2Label.Name = "Dart2Label";
            this.Dart2Label.Size = new System.Drawing.Size(39, 16);
            this.Dart2Label.TabIndex = 6;
            this.Dart2Label.Text = "Dart2";
            // 
            // Dart3Label
            // 
            this.Dart3Label.AutoSize = true;
            this.Dart3Label.Location = new System.Drawing.Point(3, 100);
            this.Dart3Label.Name = "Dart3Label";
            this.Dart3Label.Size = new System.Drawing.Size(39, 16);
            this.Dart3Label.TabIndex = 6;
            this.Dart3Label.Text = "Dart3";
            // 
            // ReviewGroupBox
            // 
            this.ReviewGroupBox.Controls.Add(this.Dart3Label);
            this.ReviewGroupBox.Controls.Add(this.Dart2Label);
            this.ReviewGroupBox.Controls.Add(this.Dart1Label);
            this.ReviewGroupBox.Controls.Add(this.RoundLabel);
            this.ReviewGroupBox.Controls.Add(this.Dart3TextBox);
            this.ReviewGroupBox.Controls.Add(this.Dart2TextBox);
            this.ReviewGroupBox.Controls.Add(this.Dart1TextBox);
            this.ReviewGroupBox.Controls.Add(this.RoundTextBox);
            this.ReviewGroupBox.Location = new System.Drawing.Point(580, 218);
            this.ReviewGroupBox.Name = "ReviewGroupBox";
            this.ReviewGroupBox.Size = new System.Drawing.Size(231, 148);
            this.ReviewGroupBox.TabIndex = 7;
            this.ReviewGroupBox.TabStop = false;
            // 
            // RoundGroupBox
            // 
            this.RoundGroupBox.Controls.Add(this.DartCountTextBox);
            this.RoundGroupBox.Controls.Add(this.DartCountabel);
            this.RoundGroupBox.Controls.Add(this.PlayRoundTextBox);
            this.RoundGroupBox.Controls.Add(this.label1);
            this.RoundGroupBox.Location = new System.Drawing.Point(586, 372);
            this.RoundGroupBox.Name = "RoundGroupBox";
            this.RoundGroupBox.Size = new System.Drawing.Size(205, 104);
            this.RoundGroupBox.TabIndex = 8;
            this.RoundGroupBox.TabStop = false;
            // 
            // PlayRoundTextBox
            // 
            this.PlayRoundTextBox.Location = new System.Drawing.Point(77, 21);
            this.PlayRoundTextBox.Name = "PlayRoundTextBox";
            this.PlayRoundTextBox.ReadOnly = true;
            this.PlayRoundTextBox.Size = new System.Drawing.Size(122, 22);
            this.PlayRoundTextBox.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Round";
            // 
            // DartCountabel
            // 
            this.DartCountabel.AutoSize = true;
            this.DartCountabel.Location = new System.Drawing.Point(6, 52);
            this.DartCountabel.Name = "DartCountabel";
            this.DartCountabel.Size = new System.Drawing.Size(69, 16);
            this.DartCountabel.TabIndex = 6;
            this.DartCountabel.Text = "Dart Count";
            // 
            // DartCountTextBox
            // 
            this.DartCountTextBox.Location = new System.Drawing.Point(77, 49);
            this.DartCountTextBox.Name = "DartCountTextBox";
            this.DartCountTextBox.ReadOnly = true;
            this.DartCountTextBox.Size = new System.Drawing.Size(122, 22);
            this.DartCountTextBox.TabIndex = 5;
            // 
            // DartGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(823, 574);
            this.Controls.Add(this.RoundGroupBox);
            this.Controls.Add(this.ReviewGroupBox);
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
            this.ReviewGroupBox.ResumeLayout(false);
            this.ReviewGroupBox.PerformLayout();
            this.RoundGroupBox.ResumeLayout(false);
            this.RoundGroupBox.PerformLayout();
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
        private System.Windows.Forms.TextBox RoundTextBox;
        private System.Windows.Forms.TextBox Dart1TextBox;
        private System.Windows.Forms.TextBox Dart2TextBox;
        private System.Windows.Forms.TextBox Dart3TextBox;
        private System.Windows.Forms.Label RoundLabel;
        private System.Windows.Forms.Label Dart1Label;
        private System.Windows.Forms.Label Dart2Label;
        private System.Windows.Forms.Label Dart3Label;
        private System.Windows.Forms.GroupBox ReviewGroupBox;
        private System.Windows.Forms.GroupBox RoundGroupBox;
        private System.Windows.Forms.TextBox PlayRoundTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox DartCountTextBox;
        private System.Windows.Forms.Label DartCountabel;
    }
}

