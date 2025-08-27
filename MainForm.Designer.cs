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
			buttonSaveAsWavFile = new Button();
			checkBoxEnableSsmlMode = new CheckBox();
			buttonImport = new Button();
			contextMenuStripImportSource = new ContextMenuStrip(components);
			toolStripMenuItemImportFromClipboard = new ToolStripMenuItem();
			toolStripMenuItemImportTextFile = new ToolStripMenuItem();
			toolStripMenuItemImportSsmlFile = new ToolStripMenuItem();
			labelComputerVoice = new Label();
			statusStrip = new StatusStrip();
			labelStatus = new ToolStripStatusLabel();
			buttonClearText = new Button();
			saveFileDialogWaveFile = new SaveFileDialog();
			openFileDialogTextFile = new OpenFileDialog();
			openFileDialogSsmlFile = new OpenFileDialog();
			((System.ComponentModel.ISupportInitialize)trackBarVolume).BeginInit();
			((System.ComponentModel.ISupportInitialize)trackBarSpeechRate).BeginInit();
			contextMenuStripImportSource.SuspendLayout();
			statusStrip.SuspendLayout();
			SuspendLayout();
			// 
			// textBox
			// 
			textBox.AccessibleDescription = "Enter text to speak";
			textBox.AccessibleName = "text box to speak";
			textBox.AccessibleRole = AccessibleRole.Text;
			textBox.AllowDrop = true;
			textBox.Location = new Point(12, 45);
			textBox.Multiline = true;
			textBox.Name = "textBox";
			textBox.PlaceholderText = "Please enter text to speak.";
			textBox.ScrollBars = ScrollBars.Vertical;
			textBox.Size = new Size(335, 122);
			textBox.TabIndex = 2;
			textBox.Text = "Text to speak";
			textBox.TextChanged += TextBox_TextChanged;
			textBox.Enter += TextBox_Enter;
			textBox.Leave += ClearStatusBar_Leave;
			textBox.MouseEnter += TextBox_Enter;
			textBox.MouseLeave += ClearStatusBar_Leave;
			// 
			// buttonSpeak
			// 
			buttonSpeak.AccessibleDescription = "Speak the text";
			buttonSpeak.AccessibleName = "Speak button";
			buttonSpeak.AccessibleRole = AccessibleRole.PushButton;
			buttonSpeak.AutoEllipsis = true;
			buttonSpeak.Image = Properties.Resources.control_play_blue;
			buttonSpeak.ImageAlign = ContentAlignment.MiddleRight;
			buttonSpeak.Location = new Point(12, 357);
			buttonSpeak.Name = "buttonSpeak";
			buttonSpeak.Size = new Size(67, 27);
			buttonSpeak.TabIndex = 11;
			buttonSpeak.Text = "Speak";
			buttonSpeak.TextImageRelation = TextImageRelation.ImageBeforeText;
			toolTip.SetToolTip(buttonSpeak, "Speak");
			buttonSpeak.UseVisualStyleBackColor = true;
			buttonSpeak.Click += ButtonSpeak_Click;
			buttonSpeak.Enter += ButtonSpeak_Enter;
			buttonSpeak.Leave += ClearStatusBar_Leave;
			buttonSpeak.MouseEnter += ButtonSpeak_Enter;
			buttonSpeak.MouseLeave += ClearStatusBar_Leave;
			// 
			// trackBarVolume
			// 
			trackBarVolume.AccessibleDescription = "Set the volume";
			trackBarVolume.AccessibleName = "volume";
			trackBarVolume.AccessibleRole = AccessibleRole.Slider;
			trackBarVolume.Location = new Point(189, 208);
			trackBarVolume.Maximum = 100;
			trackBarVolume.Name = "trackBarVolume";
			trackBarVolume.Size = new Size(158, 45);
			trackBarVolume.TabIndex = 8;
			trackBarVolume.TickFrequency = 5;
			trackBarVolume.TickStyle = TickStyle.Both;
			toolTip.SetToolTip(trackBarVolume, "volume");
			trackBarVolume.Scroll += TrackBarVolume_Scroll;
			trackBarVolume.Enter += TrackBarVolume_Enter;
			trackBarVolume.Leave += ClearStatusBar_Leave;
			trackBarVolume.MouseEnter += TrackBarVolume_Enter;
			trackBarVolume.MouseLeave += ClearStatusBar_Leave;
			// 
			// labelVolume
			// 
			labelVolume.AccessibleDescription = "label for the volume";
			labelVolume.AccessibleName = "volume";
			labelVolume.AccessibleRole = AccessibleRole.StaticText;
			labelVolume.AutoEllipsis = true;
			labelVolume.AutoSize = true;
			labelVolume.Location = new Point(189, 190);
			labelVolume.Name = "labelVolume";
			labelVolume.Size = new Size(50, 15);
			labelVolume.TabIndex = 7;
			labelVolume.Text = "volume:";
			labelVolume.Enter += LabelVolume_Enter;
			labelVolume.Leave += ClearStatusBar_Leave;
			labelVolume.MouseEnter += LabelVolume_Enter;
			labelVolume.MouseLeave += ClearStatusBar_Leave;
			// 
			// labelSpeechRate
			// 
			labelSpeechRate.AccessibleDescription = "Label for the speech rate";
			labelSpeechRate.AccessibleName = "speech rate";
			labelSpeechRate.AccessibleRole = AccessibleRole.StaticText;
			labelSpeechRate.AutoEllipsis = true;
			labelSpeechRate.AutoSize = true;
			labelSpeechRate.Location = new Point(189, 256);
			labelSpeechRate.Name = "labelSpeechRate";
			labelSpeechRate.Size = new Size(70, 15);
			labelSpeechRate.TabIndex = 9;
			labelSpeechRate.Text = "speech rate:";
			labelSpeechRate.Enter += LabelSpeechRate_Enter;
			labelSpeechRate.Leave += ClearStatusBar_Leave;
			labelSpeechRate.MouseEnter += LabelSpeechRate_Enter;
			labelSpeechRate.MouseLeave += ClearStatusBar_Leave;
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
			trackBarSpeechRate.Size = new Size(158, 45);
			trackBarSpeechRate.TabIndex = 10;
			trackBarSpeechRate.TickFrequency = 2;
			trackBarSpeechRate.TickStyle = TickStyle.Both;
			toolTip.SetToolTip(trackBarSpeechRate, "speech rate");
			trackBarSpeechRate.Scroll += TrackBarSpeechRate_Scroll;
			trackBarSpeechRate.Enter += TrackBarSpeechRate_Enter;
			trackBarSpeechRate.Leave += ClearStatusBar_Leave;
			trackBarSpeechRate.MouseEnter += TrackBarSpeechRate_Enter;
			trackBarSpeechRate.MouseLeave += ClearStatusBar_Leave;
			// 
			// listBoxVoices
			// 
			listBoxVoices.AccessibleDescription = "list with installed computer voices";
			listBoxVoices.AccessibleName = "computer voices";
			listBoxVoices.AccessibleRole = AccessibleRole.List;
			listBoxVoices.FormattingEnabled = true;
			listBoxVoices.Location = new Point(12, 214);
			listBoxVoices.Name = "listBoxVoices";
			listBoxVoices.Size = new Size(171, 94);
			listBoxVoices.TabIndex = 5;
			toolTip.SetToolTip(listBoxVoices, "List of installed comuter voices");
			listBoxVoices.Enter += ListBoxVoices_Enter;
			listBoxVoices.Leave += ClearStatusBar_Leave;
			listBoxVoices.MouseEnter += ListBoxVoices_Enter;
			listBoxVoices.MouseLeave += ClearStatusBar_Leave;
			// 
			// buttonPause
			// 
			buttonPause.AccessibleDescription = "Pause and resume the voice";
			buttonPause.AccessibleName = "Pause/resume button";
			buttonPause.AccessibleRole = AccessibleRole.PushButton;
			buttonPause.AutoEllipsis = true;
			buttonPause.Image = Properties.Resources.control_pause_blue;
			buttonPause.ImageAlign = ContentAlignment.MiddleRight;
			buttonPause.Location = new Point(85, 357);
			buttonPause.Name = "buttonPause";
			buttonPause.Size = new Size(76, 27);
			buttonPause.TabIndex = 12;
			buttonPause.Text = "Pause";
			buttonPause.TextImageRelation = TextImageRelation.ImageBeforeText;
			toolTip.SetToolTip(buttonPause, "Pause/Resume");
			buttonPause.UseVisualStyleBackColor = true;
			buttonPause.Click += ButtonPause_Click;
			buttonPause.Enter += ButtonPause_Enter;
			buttonPause.Leave += ClearStatusBar_Leave;
			buttonPause.MouseEnter += ButtonPause_Enter;
			buttonPause.MouseLeave += ClearStatusBar_Leave;
			// 
			// buttonStop
			// 
			buttonStop.AccessibleDescription = "Stop the voice";
			buttonStop.AccessibleName = "Stop";
			buttonStop.AccessibleRole = AccessibleRole.PushButton;
			buttonStop.AutoEllipsis = true;
			buttonStop.Image = Properties.Resources.control_stop_blue;
			buttonStop.ImageAlign = ContentAlignment.MiddleRight;
			buttonStop.Location = new Point(167, 357);
			buttonStop.Name = "buttonStop";
			buttonStop.Size = new Size(67, 27);
			buttonStop.TabIndex = 13;
			buttonStop.Text = "Stop";
			buttonStop.TextImageRelation = TextImageRelation.ImageBeforeText;
			toolTip.SetToolTip(buttonStop, "Stop");
			buttonStop.UseVisualStyleBackColor = true;
			buttonStop.Click += ButtonStop_Click;
			buttonStop.Enter += ButtonStop_Enter;
			buttonStop.Leave += ClearStatusBar_Leave;
			buttonStop.MouseEnter += ButtonStop_Enter;
			buttonStop.MouseLeave += ClearStatusBar_Leave;
			// 
			// buttonShowVoiceInfo
			// 
			buttonShowVoiceInfo.AccessibleDescription = "Show the voice info";
			buttonShowVoiceInfo.AccessibleName = "voice info";
			buttonShowVoiceInfo.AccessibleRole = AccessibleRole.PushButton;
			buttonShowVoiceInfo.AutoEllipsis = true;
			buttonShowVoiceInfo.Image = Properties.Resources.information;
			buttonShowVoiceInfo.ImageAlign = ContentAlignment.MiddleRight;
			buttonShowVoiceInfo.Location = new Point(12, 314);
			buttonShowVoiceInfo.Name = "buttonShowVoiceInfo";
			buttonShowVoiceInfo.Size = new Size(171, 27);
			buttonShowVoiceInfo.TabIndex = 6;
			buttonShowVoiceInfo.Text = "Voice Info";
			buttonShowVoiceInfo.TextImageRelation = TextImageRelation.ImageBeforeText;
			toolTip.SetToolTip(buttonShowVoiceInfo, "voice info");
			buttonShowVoiceInfo.UseVisualStyleBackColor = true;
			buttonShowVoiceInfo.Click += ButtonShowVoiceInfo_Click;
			buttonShowVoiceInfo.Enter += ButtonShowVoiceInfo_Enter;
			buttonShowVoiceInfo.Leave += ClearStatusBar_Leave;
			buttonShowVoiceInfo.MouseEnter += ButtonShowVoiceInfo_Enter;
			buttonShowVoiceInfo.MouseLeave += ClearStatusBar_Leave;
			// 
			// buttonSaveAsWavFile
			// 
			buttonSaveAsWavFile.AccessibleDescription = "Save the speech into a WAV file";
			buttonSaveAsWavFile.AccessibleName = "Save as WAV file";
			buttonSaveAsWavFile.AccessibleRole = AccessibleRole.PushButton;
			buttonSaveAsWavFile.AutoEllipsis = true;
			buttonSaveAsWavFile.Image = Properties.Resources.diskette;
			buttonSaveAsWavFile.ImageAlign = ContentAlignment.MiddleRight;
			buttonSaveAsWavFile.Location = new Point(240, 357);
			buttonSaveAsWavFile.Name = "buttonSaveAsWavFile";
			buttonSaveAsWavFile.Size = new Size(78, 27);
			buttonSaveAsWavFile.TabIndex = 14;
			buttonSaveAsWavFile.Text = "Wav File";
			buttonSaveAsWavFile.TextImageRelation = TextImageRelation.ImageBeforeText;
			toolTip.SetToolTip(buttonSaveAsWavFile, "Save as WAV file");
			buttonSaveAsWavFile.UseVisualStyleBackColor = true;
			buttonSaveAsWavFile.Click += ButtonSaveAsWavFile_Click;
			buttonSaveAsWavFile.Enter += ButtonSaveAsWavFile_Enter;
			buttonSaveAsWavFile.Leave += ClearStatusBar_Leave;
			buttonSaveAsWavFile.MouseEnter += ButtonSaveAsWavFile_Enter;
			buttonSaveAsWavFile.MouseLeave += ClearStatusBar_Leave;
			// 
			// checkBoxEnableSsmlMode
			// 
			checkBoxEnableSsmlMode.AccessibleDescription = "Enable the SSML mode";
			checkBoxEnableSsmlMode.AccessibleName = "Enable SSML mode";
			checkBoxEnableSsmlMode.AccessibleRole = AccessibleRole.CheckButton;
			checkBoxEnableSsmlMode.AutoSize = true;
			checkBoxEnableSsmlMode.Location = new Point(12, 168);
			checkBoxEnableSsmlMode.Name = "checkBoxEnableSsmlMode";
			checkBoxEnableSsmlMode.Size = new Size(127, 19);
			checkBoxEnableSsmlMode.TabIndex = 3;
			checkBoxEnableSsmlMode.Text = "Enable SSML mode";
			toolTip.SetToolTip(checkBoxEnableSsmlMode, "Enable SSML mode");
			checkBoxEnableSsmlMode.UseVisualStyleBackColor = true;
			checkBoxEnableSsmlMode.Enter += CheckBoxEnableSsmlMode_Enter;
			checkBoxEnableSsmlMode.Leave += ClearStatusBar_Leave;
			checkBoxEnableSsmlMode.MouseEnter += CheckBoxEnableSsmlMode_Enter;
			checkBoxEnableSsmlMode.MouseLeave += ClearStatusBar_Leave;
			// 
			// buttonImport
			// 
			buttonImport.AccessibleDescription = "Import a text source";
			buttonImport.AccessibleName = "Import source";
			buttonImport.AccessibleRole = AccessibleRole.PushButton;
			buttonImport.AutoEllipsis = true;
			buttonImport.ContextMenuStrip = contextMenuStripImportSource;
			buttonImport.Image = Properties.Resources.document_import;
			buttonImport.ImageAlign = ContentAlignment.MiddleRight;
			buttonImport.Location = new Point(12, 12);
			buttonImport.Name = "buttonImport";
			buttonImport.Size = new Size(117, 27);
			buttonImport.TabIndex = 0;
			buttonImport.Text = "Import source";
			buttonImport.TextImageRelation = TextImageRelation.ImageBeforeText;
			toolTip.SetToolTip(buttonImport, "Import source");
			buttonImport.UseVisualStyleBackColor = true;
			buttonImport.Click += ButtonImport_Click;
			buttonImport.Enter += ButtonImport_Enter;
			buttonImport.Leave += ClearStatusBar_Leave;
			buttonImport.MouseEnter += ButtonImport_Enter;
			buttonImport.MouseLeave += ClearStatusBar_Leave;
			// 
			// contextMenuStripImportSource
			// 
			contextMenuStripImportSource.AccessibleDescription = "Import a source";
			contextMenuStripImportSource.AccessibleName = "Import Source";
			contextMenuStripImportSource.AccessibleRole = AccessibleRole.MenuPopup;
			contextMenuStripImportSource.AllowClickThrough = true;
			contextMenuStripImportSource.AllowDrop = true;
			contextMenuStripImportSource.Items.AddRange(new ToolStripItem[] { toolStripMenuItemImportFromClipboard, toolStripMenuItemImportTextFile, toolStripMenuItemImportSsmlFile });
			contextMenuStripImportSource.Name = "contextMenuStripImportSource";
			contextMenuStripImportSource.Size = new Size(193, 70);
			contextMenuStripImportSource.TabStop = true;
			contextMenuStripImportSource.Text = "Import souce";
			toolTip.SetToolTip(contextMenuStripImportSource, "Import source");
			// 
			// toolStripMenuItemImportFromClipboard
			// 
			toolStripMenuItemImportFromClipboard.AccessibleDescription = "Import from clipboard";
			toolStripMenuItemImportFromClipboard.AccessibleName = "Import from clipboard";
			toolStripMenuItemImportFromClipboard.AccessibleRole = AccessibleRole.MenuItem;
			toolStripMenuItemImportFromClipboard.AutoToolTip = true;
			toolStripMenuItemImportFromClipboard.Image = Properties.Resources.paste_plain;
			toolStripMenuItemImportFromClipboard.Name = "toolStripMenuItemImportFromClipboard";
			toolStripMenuItemImportFromClipboard.Size = new Size(192, 22);
			toolStripMenuItemImportFromClipboard.Text = "Import from clipboard";
			toolStripMenuItemImportFromClipboard.Click += ToolStripMenuItemImportFromClipboard_Click;
			toolStripMenuItemImportFromClipboard.MouseEnter += ToolStripMenuItemImportFromClipboard_MouseEnter;
			toolStripMenuItemImportFromClipboard.MouseLeave += ClearStatusBar_Leave;
			// 
			// toolStripMenuItemImportTextFile
			// 
			toolStripMenuItemImportTextFile.AccessibleDescription = "Open a text file";
			toolStripMenuItemImportTextFile.AccessibleName = "Open text file";
			toolStripMenuItemImportTextFile.AccessibleRole = AccessibleRole.MenuItem;
			toolStripMenuItemImportTextFile.AutoToolTip = true;
			toolStripMenuItemImportTextFile.Image = Properties.Resources.page_white_text;
			toolStripMenuItemImportTextFile.Name = "toolStripMenuItemImportTextFile";
			toolStripMenuItemImportTextFile.Size = new Size(192, 22);
			toolStripMenuItemImportTextFile.Text = "Import text file";
			toolStripMenuItemImportTextFile.Click += ToolStripMenuItemImportTextFile_Click;
			toolStripMenuItemImportTextFile.MouseEnter += ToolStripMenuItemImportTextFile_MouseEnter;
			toolStripMenuItemImportTextFile.MouseLeave += ClearStatusBar_Leave;
			// 
			// toolStripMenuItemImportSsmlFile
			// 
			toolStripMenuItemImportSsmlFile.AccessibleDescription = "Open a SSML file";
			toolStripMenuItemImportSsmlFile.AccessibleName = "Open a SSML file";
			toolStripMenuItemImportSsmlFile.AccessibleRole = AccessibleRole.MenuItem;
			toolStripMenuItemImportSsmlFile.AutoToolTip = true;
			toolStripMenuItemImportSsmlFile.Image = Properties.Resources.page_white_code;
			toolStripMenuItemImportSsmlFile.Name = "toolStripMenuItemImportSsmlFile";
			toolStripMenuItemImportSsmlFile.Size = new Size(192, 22);
			toolStripMenuItemImportSsmlFile.Text = "Import SSML file";
			toolStripMenuItemImportSsmlFile.Click += ToolStripMenuItemImportSsmlFile_Click;
			toolStripMenuItemImportSsmlFile.MouseEnter += ToolStripMenuItemImportSsmlFile_MouseEnter;
			toolStripMenuItemImportSsmlFile.MouseLeave += ClearStatusBar_Leave;
			// 
			// labelComputerVoice
			// 
			labelComputerVoice.AccessibleDescription = "label for computer voices";
			labelComputerVoice.AccessibleName = "computer voices";
			labelComputerVoice.AccessibleRole = AccessibleRole.StaticText;
			labelComputerVoice.AutoSize = true;
			labelComputerVoice.Location = new Point(12, 190);
			labelComputerVoice.Name = "labelComputerVoice";
			labelComputerVoice.Size = new Size(157, 15);
			labelComputerVoice.TabIndex = 4;
			labelComputerVoice.Text = "Installed Computer Coice(s):";
			labelComputerVoice.Enter += LabelComputerVoice_Enter;
			labelComputerVoice.Leave += ClearStatusBar_Leave;
			labelComputerVoice.MouseEnter += LabelComputerVoice_Enter;
			labelComputerVoice.MouseLeave += ClearStatusBar_Leave;
			// 
			// statusStrip
			// 
			statusStrip.AccessibleRole = AccessibleRole.StatusBar;
			statusStrip.AllowClickThrough = true;
			statusStrip.AllowItemReorder = true;
			statusStrip.Items.AddRange(new ToolStripItem[] { labelStatus });
			statusStrip.Location = new Point(0, 395);
			statusStrip.Name = "statusStrip";
			statusStrip.RenderMode = ToolStripRenderMode.ManagerRenderMode;
			statusStrip.ShowItemToolTips = true;
			statusStrip.Size = new Size(359, 22);
			statusStrip.SizingGrip = false;
			statusStrip.TabIndex = 15;
			statusStrip.TabStop = true;
			statusStrip.Text = "statusStrip";
			// 
			// labelStatus
			// 
			labelStatus.AccessibleDescription = "Show some information";
			labelStatus.AccessibleName = "information";
			labelStatus.AccessibleRole = AccessibleRole.StaticText;
			labelStatus.AutoToolTip = true;
			labelStatus.Name = "labelStatus";
			labelStatus.Size = new Size(38, 17);
			labelStatus.Text = "status";
			labelStatus.ToolTipText = "Some information";
			labelStatus.MouseEnter += LabelStatus_MouseEnter;
			labelStatus.MouseLeave += ClearStatusBar_Leave;
			// 
			// buttonClearText
			// 
			buttonClearText.Image = Properties.Resources.delete;
			buttonClearText.ImageAlign = ContentAlignment.MiddleRight;
			buttonClearText.Location = new Point(231, 12);
			buttonClearText.Name = "buttonClearText";
			buttonClearText.Size = new Size(116, 27);
			buttonClearText.TabIndex = 1;
			buttonClearText.Text = "Clear text";
			buttonClearText.TextImageRelation = TextImageRelation.ImageBeforeText;
			buttonClearText.UseVisualStyleBackColor = true;
			buttonClearText.Click += ButtonClearText_Click;
			buttonClearText.Enter += ButtonClearText_Enter;
			buttonClearText.Leave += ClearStatusBar_Leave;
			buttonClearText.MouseEnter += ButtonClearText_Enter;
			buttonClearText.MouseLeave += ClearStatusBar_Leave;
			// 
			// saveFileDialogWaveFile
			// 
			saveFileDialogWaveFile.DefaultExt = "wav";
			saveFileDialogWaveFile.Filter = "WAV file|*.wav";
			// 
			// openFileDialogTextFile
			// 
			openFileDialogTextFile.DefaultExt = "ssml";
			openFileDialogTextFile.Filter = "text file|*.txt;*.text";
			// 
			// openFileDialogSsmlFile
			// 
			openFileDialogSsmlFile.DefaultExt = "ssml";
			openFileDialogSsmlFile.Filter = "SSML file|*.ssml;*.xml";
			// 
			// MainForm
			// 
			AccessibleDescription = "This is the application window.";
			AccessibleName = "application window";
			AccessibleRole = AccessibleRole.Window;
			AllowDrop = true;
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(359, 417);
			Controls.Add(buttonImport);
			Controls.Add(checkBoxEnableSsmlMode);
			Controls.Add(buttonSaveAsWavFile);
			Controls.Add(buttonClearText);
			Controls.Add(statusStrip);
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
			DragDrop += MainForm_DragDrop;
			((System.ComponentModel.ISupportInitialize)trackBarVolume).EndInit();
			((System.ComponentModel.ISupportInitialize)trackBarSpeechRate).EndInit();
			contextMenuStripImportSource.ResumeLayout(false);
			statusStrip.ResumeLayout(false);
			statusStrip.PerformLayout();
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
		private StatusStrip statusStrip;
		private ToolStripStatusLabel labelStatus;
		private Button buttonClearText;
		private Button buttonSaveAsWavFile;
		private SaveFileDialog saveFileDialogWaveFile;
        private OpenFileDialog openFileDialogTextFile;
		private OpenFileDialog openFileDialogSsmlFile;
		private CheckBox checkBoxEnableSsmlMode;
		private Button buttonImport;
		private ContextMenuStrip contextMenuStripImportSource;
		private ToolStripMenuItem toolStripMenuItemImportFromClipboard;
		private ToolStripMenuItem toolStripMenuItemImportTextFile;
		private ToolStripMenuItem toolStripMenuItemImportSsmlFile;
	}
}
