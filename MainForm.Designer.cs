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
			components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			textBox = new TextBox();
			buttonSpeak = new Button();
			trackBarVolume = new TrackBar();
			labelVolume = new Label();
			labelSpeechRate = new Label();
			trackBarSpeechRate = new TrackBar();
			toolTip = new ToolTip(components);
			listBoxVoices = new ListBox();
			buttonPause = new Button();
			buttonStop = new Button();
			buttonShowVoiceInfo = new Button();
			labelComputerVoice = new Label();
			((System.ComponentModel.ISupportInitialize)trackBarVolume).BeginInit();
			((System.ComponentModel.ISupportInitialize)trackBarSpeechRate).BeginInit();
			SuspendLayout();
			// 
			// textBox
			// 
			textBox.AccessibleDescription = "Enter text to speak";
			textBox.AccessibleName = "text box to speak";
			textBox.AccessibleRole = AccessibleRole.Text;
			textBox.Location = new Point(12, 12);
			textBox.Multiline = true;
			textBox.Name = "textBox";
			textBox.PlaceholderText = "Please enter text to speak.";
			textBox.ScrollBars = ScrollBars.Vertical;
			textBox.Size = new Size(302, 166);
			textBox.TabIndex = 0;
			textBox.Text = "Text to speak";
			// 
			// buttonSpeak
			// 
			buttonSpeak.AccessibleDescription = "Speak the text";
			buttonSpeak.AccessibleName = "Speak button";
			buttonSpeak.AccessibleRole = AccessibleRole.PushButton;
			buttonSpeak.Image = Properties.Resources.control_play_blue;
			buttonSpeak.Location = new Point(20, 359);
			buttonSpeak.Name = "buttonSpeak";
			buttonSpeak.Size = new Size(85, 51);
			buttonSpeak.TabIndex = 8;
			buttonSpeak.Text = "Speak";
			buttonSpeak.TextImageRelation = TextImageRelation.ImageBeforeText;
			toolTip.SetToolTip(buttonSpeak, "Speak");
			buttonSpeak.UseVisualStyleBackColor = true;
			buttonSpeak.Click += ButtonSpeak_Click;
			// 
			// trackBarVolume
			// 
			trackBarVolume.AccessibleDescription = "Set the volume";
			trackBarVolume.AccessibleName = "volume";
			trackBarVolume.AccessibleRole = AccessibleRole.Slider;
			trackBarVolume.Location = new Point(189, 208);
			trackBarVolume.Maximum = 100;
			trackBarVolume.Name = "trackBarVolume";
			trackBarVolume.Size = new Size(125, 45);
			trackBarVolume.TabIndex = 5;
			trackBarVolume.TickFrequency = 5;
			trackBarVolume.TickStyle = TickStyle.Both;
			toolTip.SetToolTip(trackBarVolume, "volume");
			trackBarVolume.Scroll += TrackBarVolume_Scroll;
			// 
			// labelVolume
			// 
			labelVolume.AccessibleDescription = "label for the volume";
			labelVolume.AccessibleName = "volume";
			labelVolume.AccessibleRole = AccessibleRole.StaticText;
			labelVolume.AutoSize = true;
			labelVolume.Location = new Point(189, 190);
			labelVolume.Name = "labelVolume";
			labelVolume.Size = new Size(50, 15);
			labelVolume.TabIndex = 4;
			labelVolume.Text = "volume:";
			// 
			// labelSpeechRate
			// 
			labelSpeechRate.AccessibleDescription = "Label for the speech rate";
			labelSpeechRate.AccessibleName = "speech rate";
			labelSpeechRate.AccessibleRole = AccessibleRole.StaticText;
			labelSpeechRate.AutoSize = true;
			labelSpeechRate.Location = new Point(189, 256);
			labelSpeechRate.Name = "labelSpeechRate";
			labelSpeechRate.Size = new Size(70, 15);
			labelSpeechRate.TabIndex = 6;
			labelSpeechRate.Text = "speech rate:";
			// 
			// trackBarSpeechRate
			// 
			trackBarSpeechRate.AccessibleDescription = "Set the speech rate";
			trackBarSpeechRate.AccessibleName = "speech rate";
			trackBarSpeechRate.AccessibleRole = AccessibleRole.Slider;
			trackBarSpeechRate.LargeChange = 2;
			trackBarSpeechRate.Location = new Point(189, 274);
			trackBarSpeechRate.Minimum = -10;
			trackBarSpeechRate.Name = "trackBarSpeechRate";
			trackBarSpeechRate.Size = new Size(125, 45);
			trackBarSpeechRate.TabIndex = 7;
			trackBarSpeechRate.TickFrequency = 2;
			trackBarSpeechRate.TickStyle = TickStyle.Both;
			toolTip.SetToolTip(trackBarSpeechRate, "speech rate");
			trackBarSpeechRate.Scroll += TrackBarSpeechRate_Scroll;
			// 
			// listBoxVoices
			// 
			listBoxVoices.AccessibleDescription = "list with installed computer voices";
			listBoxVoices.AccessibleName = "computer voices";
			listBoxVoices.AccessibleRole = AccessibleRole.List;
			listBoxVoices.FormattingEnabled = true;
			listBoxVoices.Location = new Point(12, 214);
			listBoxVoices.Name = "listBoxVoices";
			listBoxVoices.Size = new Size(171, 139);
			listBoxVoices.TabIndex = 2;
			toolTip.SetToolTip(listBoxVoices, "List of installed comuter voices");
			// 
			// buttonPause
			// 
			buttonPause.AccessibleDescription = "Pause and resume the voice";
			buttonPause.AccessibleName = "Pause/resume button";
			buttonPause.AccessibleRole = AccessibleRole.PushButton;
			buttonPause.Image = Properties.Resources.control_pause_blue;
			buttonPause.Location = new Point(111, 359);
			buttonPause.Name = "buttonPause";
			buttonPause.Size = new Size(97, 51);
			buttonPause.TabIndex = 9;
			buttonPause.Text = "Pause";
			buttonPause.TextImageRelation = TextImageRelation.ImageBeforeText;
			toolTip.SetToolTip(buttonPause, "Pause/Resume");
			buttonPause.UseVisualStyleBackColor = true;
			buttonPause.Click += ButtonPause_Click;
			// 
			// buttonStop
			// 
			buttonStop.AccessibleDescription = "Stop the voice";
			buttonStop.AccessibleName = "Stop";
			buttonStop.AccessibleRole = AccessibleRole.PushButton;
			buttonStop.Image = Properties.Resources.control_stop_blue;
			buttonStop.Location = new Point(214, 359);
			buttonStop.Name = "buttonStop";
			buttonStop.Size = new Size(85, 51);
			buttonStop.TabIndex = 10;
			buttonStop.Text = "Stop";
			buttonStop.TextImageRelation = TextImageRelation.ImageBeforeText;
			toolTip.SetToolTip(buttonStop, "Stop");
			buttonStop.UseVisualStyleBackColor = true;
			buttonStop.Click += ButtonStop_Click;
			// 
			// buttonShowVoiceInfo
			// 
			buttonShowVoiceInfo.AccessibleDescription = "Show the voice info";
			buttonShowVoiceInfo.AccessibleName = "voice info";
			buttonShowVoiceInfo.AccessibleRole = AccessibleRole.PushButton;
			buttonShowVoiceInfo.Location = new Point(124, 184);
			buttonShowVoiceInfo.Name = "buttonShowVoiceInfo";
			buttonShowVoiceInfo.Size = new Size(59, 23);
			buttonShowVoiceInfo.TabIndex = 3;
			buttonShowVoiceInfo.Text = "info";
			toolTip.SetToolTip(buttonShowVoiceInfo, "voice info");
			buttonShowVoiceInfo.UseVisualStyleBackColor = true;
			buttonShowVoiceInfo.Click += ButtonShowVoiceInfo_Click;
			// 
			// labelComputerVoice
			// 
			labelComputerVoice.AccessibleDescription = "label for computer voices";
			labelComputerVoice.AccessibleName = "computer voices";
			labelComputerVoice.AccessibleRole = AccessibleRole.StaticText;
			labelComputerVoice.AutoSize = true;
			labelComputerVoice.Location = new Point(12, 190);
			labelComputerVoice.Name = "labelComputerVoice";
			labelComputerVoice.Size = new Size(106, 15);
			labelComputerVoice.TabIndex = 1;
			labelComputerVoice.Text = "computer voice(s):";
			// 
			// MainForm
			// 
			AccessibleDescription = "This is the application window.";
			AccessibleName = "application window";
			AccessibleRole = AccessibleRole.Window;
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(330, 422);
			Controls.Add(buttonShowVoiceInfo);
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
			Icon = (Icon)resources.GetObject("$this.Icon");
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
		private Button buttonShowVoiceInfo;
	}
}
