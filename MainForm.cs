using System.Speech.AudioFormat;
using System.Speech.Synthesis;

// Import necessary namespaces
namespace TextSpeecher
{
	// MainForm class inherits from Form
	public partial class MainForm : Form
	{
		// Declare a SpeechSynthesizer instance
		private readonly SpeechSynthesizer? synthesizer;

		#region Helpers

		/// <summary>
		/// Sets the status bar text.
		/// </summary>
		/// <param name="text">The main text to be displayed on the status bar.</param>
		/// <param name="additionalInfo">Additional information to be displayed alongside the main text.</param>
		private void SetStatusBar(string text, string additionalInfo = "")
		{
			// Check if the text is not null or whitespace
			if (string.IsNullOrWhiteSpace(value: text))
			{
				return;
			}
			// Set the status bar text
			labelStatus.Text = string.IsNullOrWhiteSpace(value: additionalInfo) ? text : $"{text} - {additionalInfo}";
		}

		/// <summary>
		/// Clears the status bar text.
		/// </summary>
		private void ClearStatusBar()
		{
			// Clear the status bar text
			labelStatus.Text = string.Empty;
		}

		// Method to count words in a given string
		private static int CountWords(string text)
		{
			// Check if the input text is null or empty.
			if (string.IsNullOrEmpty(value: text))
			{
				return 0;
			}

			// Define a set of delimiters (spaces, new lines, tabs)
			char[] delimiters = [' ', '\r', '\n', '\t'];

			// Split the string into an array of words using the delimiters
			// and remove any empty entries that might result from multiple delimiters.
			string[] words = text.Split(separator: delimiters, options: StringSplitOptions.RemoveEmptyEntries);

			// Return the number of words, which is the length of the array.
			return words.Length;
		}

		// Method to count installed voices
		private int CountInstalledVoice()
		{
			// Check if the ListBox control is null
			if (listBoxVoices == null)
			{
				// Show a message box if the ListBox control is not found
				_ = MessageBox.Show(text: "The ListBox control was not found.", caption: "Error", buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Error);
				return 0;
			}
			// Return the count of items in the ListBox
			if (listBoxVoices.Items.Count > 0)
			{
				// Return the count of installed voices
				return listBoxVoices.Items.Count;
			}
			else
			{
				// Show a message box if no voices are found
				_ = MessageBox.Show(text: "No installed voices were found.", caption: "Error", buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Error);
				return 0;
			}
		}

		// Method to load installed voices into the ListBox
		private void LoadInstalledVoicesToListBox()
		{
			// Disable the Show Voice Info button initially
			buttonShowVoiceInfo.Enabled = false;
			// Find the ListBox control by its name
			if (listBoxVoices != null)
			{
				// Create a new instance of SpeechSynthesizer to get installed voices
				using SpeechSynthesizer synth = new();
				// Clear existing items in the ListBox
				listBoxVoices.Items.Clear();
				// Loop through each installed voice and add its name to the ListBox
				foreach (InstalledVoice voice in synth.GetInstalledVoices())
				{
					// Add the voice name to the ListBox
					_ = listBoxVoices.Items.Add(item: voice.VoiceInfo.Name);
				}
				// Optionally, select the first voice in the ListBox
				if (listBoxVoices.Items.Count > 0)
				{
					// Select the first item in the ListBox
					listBoxVoices.SelectedIndex = 0;
					// Attach an event handler for when the selected index changes
					listBoxVoices.SelectedIndexChanged += (s, e) =>
					{
						// Get the selected voice name
						string selectedVoice = listBoxVoices.SelectedItem.ToString() ?? string.Empty;
						// Set the synthesizer to use the selected voice
						synthesizer.SelectVoice(name: selectedVoice);
					};
					// Enable the Show Voice Info button when a voice is selected
					buttonShowVoiceInfo.Enabled = true;
				}
				else
				{
					// Show a message box if no voices are found
					_ = MessageBox.Show(text: "No installed voices were found.", caption: "Error", buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Error);
				}
			}
			else
			{
				// Show a message box if the ListBox control is not found
				_ = MessageBox.Show(text: "The ListBox control was not found.", caption: "Error", buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Error);
			}
		}

		/// <summary>
		/// Checks whether text is present in the clipboard and returns it.
		/// </summary>
		/// <returns>The text from the clipboard or null if none exists.</returns>
		private static string? GetClipboardText()
		{
			try
			{
                if (Clipboard.ContainsText())
                {
                    return (string?)Clipboard.GetText();
                }
                else
                {
                    _ = MessageBox.Show(text: "No text in clipboard.", caption: "Warning", buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Warning);
                    return null;
                }
            }
			catch (Exception ex)
			{
				// If the clipboard is not accessible
				_ = MessageBox.Show(text: $"Fehler beim Zugriff auf die Zwischenablage:\n{ex.Message}", caption: "Fehler", buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Error);
				return null;
			}
		}


		#endregion

		#region Constructor

		// Constructor for the MainForm
		public MainForm()
		{
			// Initialize the form components and the speech synthesizer
			InitializeComponent();
			// Create a new instance of the SpeechSynthesizer
			synthesizer = new SpeechSynthesizer();

			// Attach event handlers for the synthesizer events
			synthesizer.SpeakStarted += Synthesizer_SpeakStarted;
			synthesizer.StateChanged += Synthesizer_StateChanged;
			synthesizer.SpeakProgress += Synthesizer_SpeakProgress;
			synthesizer.SpeakCompleted += Synthesizer_SpeakCompleted;

			// Load installed voices into the ListBox
			LoadInstalledVoicesToListBox();
			// Set the initial voice to the first one in the list if available
			if (listBoxVoices.Items.Count > 0)
			{
				// Get the name of the first voice in the ListBox
				string initialVoice = listBoxVoices.Items[index: 0].ToString() ?? string.Empty;
				// Select the initial voice in the synthesizer
				synthesizer.SelectVoice(name: initialVoice);
				// Set the selected index of the ListBox to the first item
				listBoxVoices.SelectedIndex = 0;
			}
			else
			{
				// Show a message box if no voices are available
				_ = MessageBox.Show(text: "No voices are available to select.", caption: "Error", buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Error);
			}
		}

		#endregion

		#region SpeechSynthesizer event handlers

		// Event handler for the SpeakStarted event
		private void Synthesizer_SpeakStarted(object? sender, SpeakStartedEventArgs e)
		{
		}

		// Event handler for the StateChanged event
		private void Synthesizer_StateChanged(object? sender, StateChangedEventArgs e)
		{
			// Check if the synthesizer instance is null
			if (synthesizer == null)
			{
				// Show a message box if the synthesizer instance is null
				_ = MessageBox.Show(text: "The SpeechSynthesizer instance is not initialized.", caption: "Error", buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Error);
				return;
			}
			// Update button states based on the current state of the synthesizer
			switch (e.State)
			{
				// Handle different states of the synthesizer
				case SynthesizerState.Ready:
					// When ready, enable Speak button and disable Pause and Stop buttons
					// Also enable voice selection and track bars
					buttonSpeak.Enabled = true;
					buttonPause.Enabled = false;
					buttonStop.Enabled = false;
					contextMenuStripImportSource.Enabled = true;
					buttonClearText.Enabled = true;
					buttonSaveAsWavFile.Enabled = true;
					listBoxVoices.Enabled = true;
					trackBarVolume.Enabled = true;
					trackBarSpeechRate.Enabled = true;
					trackBarSpeechRate.Enabled = true;
					checkBoxEnableSsmlMode.Enabled = true;
					labelStatus.Text = string.Empty;
					break;
				case SynthesizerState.Speaking:
					// When speaking, disable Speak button, enable Pause and Stop buttons
					// Also disable voice selection and track bars
					buttonSpeak.Enabled = false;
					buttonPause.Enabled = true;
					buttonStop.Enabled = true;
					contextMenuStripImportSource.Enabled = false;
					buttonClearText.Enabled = false;
					buttonSaveAsWavFile.Enabled = false;
					listBoxVoices.Enabled = false;
					trackBarVolume.Enabled = false;
					trackBarSpeechRate.Enabled = false;
					checkBoxEnableSsmlMode.Enabled = false;
					break;
				case SynthesizerState.Paused:
					// When paused, disable Speak button, enable Pause button, and disable Stop button
					buttonSpeak.Enabled = false;
					buttonPause.Enabled = true;
					buttonStop.Enabled = false;
					buttonSaveAsWavFile.Enabled = false;
					break;
				default:
					// For any other state, enable Speak button and disable Pause and Stop buttons
					// Also enable voice selection and track bars
					buttonSpeak.Enabled = true;
					buttonPause.Enabled = false;
					buttonStop.Enabled = false;
					contextMenuStripImportSource.Enabled = true;
					buttonClearText.Enabled = true;
					buttonSaveAsWavFile.Enabled = true;
					listBoxVoices.Enabled = true;
					trackBarVolume.Enabled = true;
					trackBarSpeechRate.Enabled = true;
					checkBoxEnableSsmlMode.Enabled = true;
					labelStatus.Text = string.Empty;
					break;
			}
		}

		// Event handler for the SpeakProgress event
		private void Synthesizer_SpeakProgress(object? sender, SpeakProgressEventArgs e)
		{
			// Update the status label with the current speaking text and character info
			labelStatus.Text = $"Speaking: {e.Text}, Char Count: {e.CharacterCount}, Char Position: {e.CharacterPosition}";
			// Set focus to the TextBox and select the current character position
			_ = textBox.Focus();
			textBox.Select(start: e.CharacterPosition, length: e.Text.Length);
		}

		// Event handler for the SpeakCompleted event
		private void Synthesizer_SpeakCompleted(object? sender, SpeakCompletedEventArgs e)
		{
			// Reset the output to the default audio device after saving
			synthesizer.SetOutputToDefaultAudioDevice();
		}

		#endregion

		#region Form event handlers

		// Event handler for the form load event
		private void MainForm_Load(object sender, EventArgs e)
		{
			synthesizer.SetOutputToDefaultAudioDevice();

			// Disable the Pause and Stop buttons initially
			buttonPause.Enabled = false;
			buttonStop.Enabled = false;

			// Clear any status messages
			labelStatus.Text = string.Empty;

			// Set focus to the TextBox when the form loads
			_ = textBox.Focus();
			// Set the initial volume of the synthesizer and the track bar
			trackBarVolume.Value = synthesizer.Volume;
			// Update the volume label to show the current volume
			labelVolume.Text = $"Volume: {synthesizer.Volume}";
			// Set the initial speech rate of the synthesizer and the track bar
			trackBarSpeechRate.Value = synthesizer.Rate;
			// Update the speech rate label to show the current rate
			labelSpeechRate.Text = $"Speech Rate: {synthesizer.Rate}";
		}

		#endregion

		#region Enter and MouseEnter event handlers

		// Event handler for the ListBox enter event
		private void ListBoxVoices_Enter(object sender, EventArgs e)
		{
			// Show status bar message when ListBox gains focus or mouse enters the ListBox
			SetStatusBar(text: "Select a voice from the list.", additionalInfo: $"Total Voices: {CountInstalledVoice()}");
		}

		// Event handler for the TextBox enter event
		private void TextBox_Enter(object sender, EventArgs e)
		{
			// Show status bar message when TextBox gains focus or mouse enters the TextBox
			SetStatusBar(text: "Enter text to be spoken.", additionalInfo: $"Current Text Length: {textBox.TextLength}. Total words: {CountWords(text: textBox.Text)}");
		}

		// Event handler for the Volume track bar enter event
		private void TrackBarVolume_Enter(object sender, EventArgs e)
		{
			// Show status bar message when volume track bar gains focus or mouse enters the volume track bar
			SetStatusBar(text: "Adjust the volume of the speech.", additionalInfo: $"Current Volume: {synthesizer.Volume}");
		}

		// Event handler for the Volume track bar enter event
		private void LabelVolume_Enter(object sender, EventArgs e)
		{
			// Show status bar message when volume track bar gains focus or mouse enters the volume track bar
			SetStatusBar(text: "Adjust the volume of the speech.", additionalInfo: $"Current Volume: {synthesizer.Volume}");
		}

		// Event handler for the Volume label enter event
		private void TrackBarSpeechRate_Enter(object sender, EventArgs e)
		{
			// Show status bar message when speech rate track bar gains focus or mouse enters the speech rate track bar
			SetStatusBar(text: "Adjust the speech rate.", additionalInfo: $"Current Speech Rate: {synthesizer.Rate}");
		}

		// Event handler for the Speech Rate label enter event
		private void LabelSpeechRate_Enter(object sender, EventArgs e)
		{
			// Show status bar message when speech rate label gains focus or mouse enters the speech rate label
			SetStatusBar(text: "Adjust the speech rate.", additionalInfo: $"Current Speech Rate: {synthesizer.Rate}");
		}

		// Event handler for the Volume label enter event
		private void LabelComputerVoice_Enter(object sender, EventArgs e)
		{
			// Show status bar message when computer voice label gains focus or mouse enters the computer voice label
			SetStatusBar(text: "List of installed computer voices.", additionalInfo: $"Total Voices: {CountInstalledVoice()}");
		}

		// Event handler for the Show Voice Info button enter event
		private void ButtonShowVoiceInfo_Enter(object sender, EventArgs e)
		{
			// Show status bar message when Show Voice Info button gains focus or mouse enters the Show Voice Info button
			SetStatusBar(text: "Show information about the selected voice.", additionalInfo: "");
		}

		// Event handler for the Speak button enter event
		private void ButtonClearText_Enter(object sender, EventArgs e)
		{
			// Show status bar message when Clear Text button gains focus or mouse enters the Clear Text button
			SetStatusBar(text: "Clear the text box.", additionalInfo: "");
		}

		// Event handler for the Speak button enter event
		private void ButtonPause_Enter(object sender, EventArgs e)
		{
			// Show status bar message when Pause button gains focus or mouse enters the Pause button
			SetStatusBar(text: "Pause or resume the speech.", additionalInfo: "");
		}

		// Event handler for the Stop button enter event
		private void ButtonStop_Enter(object sender, EventArgs e)
		{
			// Show status bar message when Stop button gains focus or mouse enters the Stop button
			SetStatusBar(text: "Stop the speech.", additionalInfo: "");
		}

		// Event handler for the Speak button enter event
		private void ButtonSaveAsWavFile_Enter(object sender, EventArgs e)
		{
			// Show status bar message when Save As WAV File button gains focus or mouse enters the Save As WAV File button
			SetStatusBar(text: "Save the spoken text as a WAV file.", additionalInfo: "");
		}

		// Event handler for the Speak button enter event
		private void LabelStatus_MouseEnter(object sender, EventArgs e)
		{
			// Show status bar message when mouse enters the status label
			SetStatusBar(text: "Status bar showing current status and information.", additionalInfo: "");
		}

		// Event handler for the Speak button mouse enter event
		private void ButtonSpeak_Enter(object sender, EventArgs e)
		{
			// Show status bar message when mouse enters the Speak button or mouse enters the Speak button
			SetStatusBar(text: "Speak the entered text.", additionalInfo: "");
		}

		private void CheckBoxEnableSsmlMode_Enter(object sender, EventArgs e)
		{
			SetStatusBar(text: "Enable the SSML mode", additionalInfo: "");
		}

		private void ButtonImport_Enter(object sender, EventArgs e)
		{
			SetStatusBar(text: "Import a text source", additionalInfo: "");
		}

		private void ToolStripMenuItemImportFromClipboard_MouseEnter(object sender, EventArgs e)
		{
			SetStatusBar(text: "Import from clipboard", additionalInfo: "");
		}

		private void ToolStripMenuItemImportTextFile_MouseEnter(object sender, EventArgs e)
		{
			SetStatusBar(text: "Import text file", additionalInfo: "");
		}

		private void ToolStripMenuItemImportSsmlFile_MouseEnter(object sender, EventArgs e)
		{
			SetStatusBar(text: "Import SSML file", additionalInfo: "");
		}

		#endregion

		#region Leave event handlers

		/// <summary>
		/// Called when the mouse pointer leaves a control.
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance that contains the event data.</param>
		private void ClearStatusBar_Leave(object sender, EventArgs e)
		{
			// Check if the sender is null
			ArgumentNullException.ThrowIfNull(argument: sender);
			// Check if the event arguments are null
			ArgumentNullException.ThrowIfNull(argument: e);
			// Clear the status bar text when the mouse leaves the control
			ClearStatusBar();
		}

		#endregion

		#region Scroll event handlers

		// Event handler for the volume track bar scroll event
		private void TrackBarVolume_Scroll(object sender, EventArgs e)
		{
			// Update the synthesizer volume based on the track bar value
			synthesizer.Volume = trackBarVolume.Value;
			// Update the volume label to show the current volume
			labelVolume.Text = $"Volume: {synthesizer.Volume}";
			// Show status bar message with the current volume
			SetStatusBar(text: "Adjust the volume of the speech.", additionalInfo: $"Current Volume: {synthesizer.Volume}");
		}

		// Event handler for the speech rate track bar scroll event
		private void TrackBarSpeechRate_Scroll(object sender, EventArgs e)
		{
			// Update the synthesizer speech rate based on the track bar value
			synthesizer.Rate = trackBarSpeechRate.Value;
			// Update the speech rate label to show the current rate
			labelSpeechRate.Text = $"Speech Rate: {synthesizer.Rate}";
			// Show status bar message with the current speech rate
			SetStatusBar(text: "Adjust the speech rate.", additionalInfo: $"Current Speech Rate: {synthesizer.Rate}");
		}

		#endregion

		#region TextChanged event handlers

		// Event handler for the TextBox text changed event
		private void TextBox_TextChanged(object sender, EventArgs e)
		{
			// Enable or disable buttons based on whether there is text in the TextBox
			if (textBox.TextLength > 0)
			{
				// Enable buttons if there is text
				buttonClearText.Enabled = true;
				buttonSpeak.Enabled = true;
				buttonSaveAsWavFile.Enabled = true;
				SetStatusBar(text: "Enter text to be spoken.", additionalInfo: $"Current Text Length: {textBox.TextLength}. Total words: {CountWords(text: textBox.Text)}");
			}
			else
			{
				// Disable buttons if there is no text
				buttonClearText.Enabled = false;
				buttonSpeak.Enabled = false;
				buttonSaveAsWavFile.Enabled = false;
			}
		}

		#endregion

		#region Click event handlers

		// Event handler for the Speak button click event
		private void ButtonSpeak_Click(object sender, EventArgs e)
		{
			// Get the text from the TextBox and speak it
			string textToSpeak = textBox.Text;
			// Check if the text is not empty
			if (!string.IsNullOrEmpty(value: textToSpeak))
			{
				if (checkBoxEnableSsmlMode.Checked)
				{
					_ = synthesizer.SpeakSsmlAsync(textToSpeak: textToSpeak);
				}
				else
				{
					// Speak the text asynchronously
					_ = synthesizer.SpeakAsync(textToSpeak: textToSpeak);
				}
			}
			else
			{
				// Show a message box if the text is empty
				_ = MessageBox.Show(text: "Please enter text to speak.", caption: "Error", buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Error);
				// Set focus back to the TextBox
				_ = textBox.Focus();
			}
		}

		// Event handler for the Pause button click event
		private void ButtonPause_Click(object sender, EventArgs e)
		{
			// Check the current state of the synthesizer
			// and toggle between pause and resume
			// based on the current state
			if (synthesizer.State == SynthesizerState.Speaking)
			{
				// Pause the speech synthesis
				synthesizer.Pause();
				buttonPause.Text = "Resume";
			}
			else if (synthesizer.State == SynthesizerState.Paused)
			{
				// Resume the speech synthesis
				synthesizer.Resume();
				buttonPause.Text = "Pause";
			}
		}

		// Event handler for the Stop button click event
		private void ButtonStop_Click(object sender, EventArgs e)
		{
			// Stop the speech synthesis
			synthesizer.SpeakAsyncCancelAll();
		}

		// Event handler for the Show Voice Info button click event
		private void ButtonShowVoiceInfo_Click(object sender, EventArgs e)
		{
			// Get the currently selected voice information
			VoiceInfo? selectedVoiceInfo = synthesizer.Voice;
			// Display the voice information in a message box
			if (selectedVoiceInfo != null)
			{
				// Prepare the voice details string
				string AudioFormats = "";
				// List all supported audio formats
				foreach (SpeechAudioFormatInfo fmt in selectedVoiceInfo.SupportedAudioFormats)
				{
					// Append each audio format to the AudioFormats string
					AudioFormats += $"{fmt.EncodingFormat}\n";
				}
				// Prepare additional info string
				string AdditionalInfo = "";
				// List all additional info key-value pairs
				foreach (string key in selectedVoiceInfo.AdditionalInfo.Keys)
				{
					// Append each key-value pair to the AdditionalInfo string
					AdditionalInfo += string.Format(format: $"  {{0}}: {{1}}\n", arg0: key, arg1: selectedVoiceInfo.AdditionalInfo[key: key]);
				}
				// Combine all voice details into a single string
				string voiceDetails = $"Name: {selectedVoiceInfo.Name}\nID: {selectedVoiceInfo.Id}\nCulture: {selectedVoiceInfo.Culture}\nAge: {selectedVoiceInfo.Age}\nGender: {selectedVoiceInfo.Gender}\nDescription: {selectedVoiceInfo.Description}\nAdditionalInfo: \n{AdditionalInfo}\n";
				// Check if there are supported audio formats and append accordingly
				if (selectedVoiceInfo.SupportedAudioFormats.Count != 0)
				{
					// Append the audio formats to the voice details
					voiceDetails += $"Audio Formats:\n{AudioFormats}";
				}
				else
				{
					// Indicate that there are no audio formats available
					voiceDetails += "Audio Formats: None\n";
				}
				// Show the voice details in a message box
				_ = MessageBox.Show(text: voiceDetails, caption: "Voice Info", buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Information);
			}
			else
			{
				// Show a message box if no voice is currently selected
				_ = MessageBox.Show(text: "No voice is currently selected.", caption: "Voice Info", buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Information);
			}
		}

		// Event handler for the Clear Text button click event
		private void ButtonClearText_Click(object sender, EventArgs e)
		{
			// Clear the text in the TextBox
			textBox.Clear();
		}

		// Event handler for the Save As WAV File button click event
		private void ButtonSaveAsWavFile_Click(object sender, EventArgs e)
		{
			// Check if the synthesizer instance is null
			if (synthesizer == null)
			{
				// Show a message box if the synthesizer instance is null
				_ = MessageBox.Show(text: "The SpeechSynthesizer instance is not initialized.", caption: "Error", buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Error);
				return;
			}
			// Validate input before saving to WAV file
			if (string.IsNullOrEmpty(value: textBox.Text))
			{
				// Show a message box if the text is empty
				_ = MessageBox.Show(text: "Please enter text to speak.", caption: "Error", buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Error);
				// Set focus back to the TextBox
				_ = textBox.Focus();
				return;
			}
			// Check if the synthesizer is currently speaking
			if (synthesizer.State == SynthesizerState.Speaking)
			{
				// Show a message box if the synthesizer is currently speaking
				_ = MessageBox.Show(text: "The synthesizer is currently speaking. Please stop it before saving to a file.", caption: "Error", buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Error);
				return;
			}
			// Check if the synthesizer is currently paused
			if (synthesizer.State == SynthesizerState.Paused)
			{
				// Show a message box if the synthesizer is currently paused
				_ = MessageBox.Show(text: "The synthesizer is currently paused. Please resume or stop it before saving to a file.", caption: "Error", buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Error);
				return;
			}
			// Check if a voice is selected in the ListBox
			if (listBoxVoices.SelectedItem == null)
			{
				// Show a message box if no voice is selected
				_ = MessageBox.Show(text: "Please select a voice before saving to a file.", caption: "Error", buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Error);
				return;
			}
			// Check if the selected voice is valid
			if (string.IsNullOrEmpty(value: listBoxVoices.SelectedItem.ToString()))
			{
				// Show a message box if the selected voice is invalid
				_ = MessageBox.Show(text: "The selected voice is invalid. Please select a valid voice before saving to a file.", caption: "Error", buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Error);
				return;
			}
			// Set the synthesizer to use the selected voice
			if (saveFileDialogWaveFile.ShowDialog() == DialogResult.OK)
			{
				// Get the selected file path from the SaveFileDialog
				string selectedFilePath = saveFileDialogWaveFile.FileName;
				// Set the output of the synthesizer to the selected WAV file
				synthesizer.SetOutputToWaveFile(path: selectedFilePath);
				// Speak the text asynchronously and save it to the WAV file
				_ = synthesizer.SpeakAsync(textToSpeak: textBox.Text);
				// Show a message box indicating that the file has been saved
				_ = MessageBox.Show(text: $"The speech has been saved to {selectedFilePath}", caption: "Success", buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Information);
			}
			else
			{
				// Show a message box if the user cancels the SaveFileDialog
				_ = MessageBox.Show(text: "The save operation was canceled.", caption: "Canceled", buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Information);
			}
		}

		private void ButtonImport_Click(object sender, EventArgs e)
		{
			if (sender is Button button && contextMenuStripImportSource != null)
			{
				// Calculate position directly below the button
				Point point = button.PointToScreen(p: new Point(x: 0, y: button.Height));
				// Show context menu at the calculated position
				contextMenuStripImportSource.Show(screenLocation: point);
			}
		}

		private void ToolStripMenuItemImportTextFile_Click(object sender, EventArgs e)
		{
			if (openFileDialogTextFile.ShowDialog() == DialogResult.OK)
			{
				try
				{
					textBox.Text = File.ReadAllText(path: openFileDialogTextFile.FileName);
					synthesizer.SpeakAsyncCancelAll();
					_ = synthesizer.SpeakAsync(textToSpeak: textBox.Text);
				}
				catch (Exception ex)
				{
					_ = MessageBox.Show(text: $"Error while reading:\n{ex.Message}", caption: "error", buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Error);
				}
			}
		}

		private void ToolStripMenuItemImportSsmlFile_Click(object sender, EventArgs e)
		{
			if (openFileDialogSsmlFile.ShowDialog() == DialogResult.OK)
			{
				try
				{
					string ssmlIssue = File.ReadAllText(path: openFileDialogSsmlFile.FileName);
					textBox.Text = ssmlIssue;
					synthesizer.SpeakAsyncCancelAll();
					_ = synthesizer.SpeakSsmlAsync(textToSpeak: ssmlIssue);
				}
				catch (Exception ex)
				{
					_ = MessageBox.Show(text: $"Error while reading:\n{ex.Message}", caption: "error", buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Error);
				}
			}
		}

		private void ToolStripMenuItemImportFromClipboard_Click(object sender, EventArgs e)
		{
			string clipboardText = GetClipboardText();
			if (string.IsNullOrEmpty(value: clipboardText))
			{
				return;
			}
			synthesizer.SpeakAsyncCancelAll();
			textBox.Text = clipboardText;
			_ = synthesizer.SpeakAsync(textToSpeak: clipboardText);
		}

		private void MainForm_DragDrop(object sender, DragEventArgs e)
		{
			try
			{
				// Retrieve files
				string[]? files = e.Data.GetData(format: DataFormats.FileDrop) as string[];

				if (files.Length > 0)
				{
					string filePath = files[0];

					// Check if the file exists
					if (File.Exists(path: filePath))
					{
						// Load text content and display it in TextBox
						string content = File.ReadAllText(path: filePath);
						textBox.Text = content;
					}
					else
					{
						_ = MessageBox.Show(text: "The selected file no longer exists.", caption: "Error", buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Error);
					}
				}
			}
			catch (Exception ex)
			{
				_ = MessageBox.Show(text: $"Error loading file:\n{ex.Message}", caption: "Error", buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Error);
			}
		}

		private void MainForm_DragEnter(object sender, DragEventArgs e)
		{
			// Check if a file is being dragged
			e.Effect = e.Data.GetDataPresent(format: DataFormats.FileDrop) ? DragDropEffects.Copy : DragDropEffects.None;
		}
	}

	#endregion
}