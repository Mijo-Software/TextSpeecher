namespace TextSpeecher
{
    partial class MainForm
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
			textBox = new TextBox();
			buttonSpeak = new Button();
			SuspendLayout();
			// 
			// textBox
			// 
			textBox.Location = new Point(12, 12);
			textBox.Multiline = true;
			textBox.Name = "textBox";
			textBox.PlaceholderText = "Please enter text to speak.";
			textBox.Size = new Size(449, 166);
			textBox.TabIndex = 0;
			// 
			// buttonSpeak
			// 
			buttonSpeak.Location = new Point(199, 184);
			buttonSpeak.Name = "buttonSpeak";
			buttonSpeak.Size = new Size(75, 38);
			buttonSpeak.TabIndex = 1;
			buttonSpeak.Text = "Sprechen";
			buttonSpeak.UseVisualStyleBackColor = true;
			buttonSpeak.Click += ButtonSpeak_Click;
			// 
			// MainForm
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(473, 232);
			Controls.Add(buttonSpeak);
			Controls.Add(textBox);
			FormBorderStyle = FormBorderStyle.FixedSingle;
			MaximizeBox = false;
			Name = "MainForm";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "TextSpeecher";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private TextBox textBox;
		private Button buttonSpeak;
	}
}
