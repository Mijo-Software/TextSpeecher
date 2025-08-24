﻿namespace TextSpeecher
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
			components = new System.ComponentModel.Container();
			textBox = new TextBox();
			buttonSpeak = new Button();
			trackBarVolume = new TrackBar();
			labelVolume = new Label();
			labelSpeechRate = new Label();
			trackBarSpeechRate = new TrackBar();
			toolTip = new ToolTip(components);
			listBoxVoices = new ListBox();
			labelComputerVoice = new Label();
			buttonPause = new Button();
			buttonStop = new Button();
			((System.ComponentModel.ISupportInitialize)trackBarVolume).BeginInit();
			((System.ComponentModel.ISupportInitialize)trackBarSpeechRate).BeginInit();
			SuspendLayout();
			// 
			// textBox
			// 
			textBox.Location = new Point(12, 12);
			textBox.Multiline = true;
			textBox.Name = "textBox";
			textBox.PlaceholderText = "Please enter text to speak.";
			textBox.ScrollBars = ScrollBars.Vertical;
			textBox.Size = new Size(302, 166);
			textBox.TabIndex = 0;
			// 
			// buttonSpeak
			// 
			buttonSpeak.Location = new Point(20, 369);
			buttonSpeak.Name = "buttonSpeak";
			buttonSpeak.Size = new Size(85, 38);
			buttonSpeak.TabIndex = 5;
			buttonSpeak.Text = "Speak";
			buttonSpeak.UseVisualStyleBackColor = true;
			buttonSpeak.Click += ButtonSpeak_Click;
			// 
			// trackBarVolume
			// 
			trackBarVolume.Location = new Point(189, 208);
			trackBarVolume.Maximum = 100;
			trackBarVolume.Name = "trackBarVolume";
			trackBarVolume.Size = new Size(125, 45);
			trackBarVolume.TabIndex = 2;
			trackBarVolume.TickFrequency = 5;
			trackBarVolume.TickStyle = TickStyle.Both;
			trackBarVolume.Scroll += TrackBarVolume_Scroll;
			// 
			// labelVolume
			// 
			labelVolume.AutoSize = true;
			labelVolume.Location = new Point(189, 190);
			labelVolume.Name = "labelVolume";
			labelVolume.Size = new Size(50, 15);
			labelVolume.TabIndex = 1;
			labelVolume.Text = "volume:";
			// 
			// labelSpeechRate
			// 
			labelSpeechRate.AutoSize = true;
			labelSpeechRate.Location = new Point(189, 256);
			labelSpeechRate.Name = "labelSpeechRate";
			labelSpeechRate.Size = new Size(70, 15);
			labelSpeechRate.TabIndex = 3;
			labelSpeechRate.Text = "speech rate:";
			// 
			// trackBarSpeechRate
			// 
			trackBarSpeechRate.LargeChange = 2;
			trackBarSpeechRate.Location = new Point(189, 274);
			trackBarSpeechRate.Minimum = -10;
			trackBarSpeechRate.Name = "trackBarSpeechRate";
			trackBarSpeechRate.Size = new Size(125, 45);
			trackBarSpeechRate.TabIndex = 4;
			trackBarSpeechRate.TickFrequency = 2;
			trackBarSpeechRate.TickStyle = TickStyle.Both;
			trackBarSpeechRate.Scroll += TrackBarSpeechRate_Scroll;
			// 
			// listBoxVoices
			// 
			listBoxVoices.FormattingEnabled = true;
			listBoxVoices.Location = new Point(12, 214);
			listBoxVoices.Name = "listBoxVoices";
			listBoxVoices.Size = new Size(171, 139);
			listBoxVoices.TabIndex = 6;
			// 
			// labelComputerVoice
			// 
			labelComputerVoice.AutoSize = true;
			labelComputerVoice.Location = new Point(12, 190);
			labelComputerVoice.Name = "labelComputerVoice";
			labelComputerVoice.Size = new Size(106, 15);
			labelComputerVoice.TabIndex = 7;
			labelComputerVoice.Text = "computer voice(s):";
			// 
			// buttonPause
			// 
			buttonPause.Location = new Point(111, 369);
			buttonPause.Name = "buttonPause";
			buttonPause.Size = new Size(85, 38);
			buttonPause.TabIndex = 8;
			buttonPause.Text = "Pause";
			buttonPause.UseVisualStyleBackColor = true;
			buttonPause.Click += ButtonPause_Click;
			// 
			// buttonStop
			// 
			buttonStop.Location = new Point(202, 369);
			buttonStop.Name = "buttonStop";
			buttonStop.Size = new Size(85, 38);
			buttonStop.TabIndex = 9;
			buttonStop.Text = "Stop";
			buttonStop.UseVisualStyleBackColor = true;
			buttonStop.Click += ButtonStop_Click;
			// 
			// MainForm
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(330, 422);
			Controls.Add(buttonStop);
			Controls.Add(buttonPause);
			Controls.Add(labelComputerVoice);
			Controls.Add(listBoxVoices);
			Controls.Add(labelSpeechRate);
			Controls.Add(trackBarSpeechRate);
			Controls.Add(labelVolume);
			Controls.Add(trackBarVolume);
			Controls.Add(buttonSpeak);
			Controls.Add(textBox);
			FormBorderStyle = FormBorderStyle.FixedSingle;
			MaximizeBox = false;
			Name = "MainForm";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "TextSpeecher";
			Load += MainForm_Load;
			((System.ComponentModel.ISupportInitialize)trackBarVolume).EndInit();
			((System.ComponentModel.ISupportInitialize)trackBarSpeechRate).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private TextBox textBox;
		private Button buttonSpeak;
		private TrackBar trackBarVolume;
		private Label labelVolume;
		private Label labelSpeechRate;
		private TrackBar trackBarSpeechRate;
		private ToolTip toolTip;
		private ListBox listBoxVoices;
		private Label labelComputerVoice;
		private Button buttonPause;
		private Button buttonStop;
	}
}
