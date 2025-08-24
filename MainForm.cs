using System.Speech.Synthesis;

// Import necessary namespaces
namespace TextSpeecher
{
	// MainForm class inherits from Form
	public partial class MainForm : Form
	{
		// Declare a SpeechSynthesizer instance
		private readonly SpeechSynthesizer? synthesizer;

		// Method to load installed voices into the ListBox
		private void LoadInstalledVoicesToListBox()
		{
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
				}
				else
				{
					// Show a message box if no voices are found
					_ = MessageBox.Show(text: "No installed voices were found.", caption: "Error", buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Error);
				}
				// Attach an event handler for when the selected index changes
				listBoxVoices.SelectedIndexChanged += (s, e) =>
				{
					// Get the selected voice name
					string selectedVoice = listBoxVoices.SelectedItem.ToString() ?? string.Empty;
					// Set the synthesizer to use the selected voice
					synthesizer.SelectVoice(name: selectedVoice);
				};
			}
			else
			{
				// Show a message box if the ListBox control is not found
				_ = MessageBox.Show(text: "The ListBox control was not found.", caption: "Error", buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Error);
			}
		}

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

		private void Synthesizer_SpeakStarted(object? sender, SpeakStartedEventArgs e)
		{
		}

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
					listBoxVoices.Enabled = true;
					trackBarVolume.Enabled = true;
					trackBarSpeechRate.Enabled = true;
					break;
				case SynthesizerState.Speaking:
					// When speaking, disable Speak button and enable Pause and Stop buttons
					// Also disable voice selection and track bars
					buttonSpeak.Enabled = false;
					buttonPause.Enabled = true;
					buttonStop.Enabled = true;
					listBoxVoices.Enabled = false;
					trackBarVolume.Enabled = false;
					trackBarSpeechRate.Enabled = false;
					break;
				case SynthesizerState.Paused:
					// When paused, disable Speak button, enable Pause button, and disable Stop button
					buttonSpeak.Enabled = false;
					buttonPause.Enabled = true;
					buttonStop.Enabled = false;
					break;
				default:
					// For any other state, enable Speak button and disable Pause and Stop buttons
					// Also enable voice selection and track bars
					buttonSpeak.Enabled = true;
					buttonPause.Enabled = false;
					buttonStop.Enabled = false;
					listBoxVoices.Enabled = true;
					trackBarVolume.Enabled = true;
					trackBarSpeechRate.Enabled = true;
					break;
			}
		}

		private void Synthesizer_SpeakProgress(object? sender, SpeakProgressEventArgs e)
		{
			// Optionally, you can update a status label or log the progress
			// For example, you could display the current word being spoken
			// labelStatus.Text = $"Speaking: {e.Text}";
		}

		private void Synthesizer_SpeakCompleted(object? sender, SpeakCompletedEventArgs e)
		{
		}

		// Event handler for the form load event
		private void MainForm_Load(object sender, EventArgs e)
		{
			// Disable the Pause and Stop buttons initially
			buttonPause.Enabled = false;
			buttonStop.Enabled = false;

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

		// Event handler for the Speak button click event
		private void ButtonSpeak_Click(object sender, EventArgs e)
		{
			// Get the text from the TextBox and speak it
			string textToSpeak = textBox.Text;
			// Check if the text is not empty
			if (!string.IsNullOrEmpty(value: textToSpeak))
			{
				// Speak the text asynchronously
				_ = synthesizer.SpeakAsync(textToSpeak: textToSpeak);
			}
			else
			{
				// Show a message box if the text is empty
				_ = MessageBox.Show(text: "Please enter text to speak.", caption: "Error", buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Error);
				// Set focus back to the TextBox
				_ = textBox.Focus();
			}
		}

		// Event handler for the volume track bar scroll event
		private void TrackBarVolume_Scroll(object sender, EventArgs e)
		{
			// Update the synthesizer volume based on the track bar value
			synthesizer.Volume = trackBarVolume.Value;
			// Update the volume label to show the current volume
			labelVolume.Text = $"Volume: {synthesizer.Volume}";
		}

		// Event handler for the speech rate track bar scroll event
		private void TrackBarSpeechRate_Scroll(object sender, EventArgs e)
		{
			// Update the synthesizer speech rate based on the track bar value
			synthesizer.Rate = trackBarSpeechRate.Value;
			// Update the speech rate label to show the current rate
			labelSpeechRate.Text = $"Speech Rate: {synthesizer.Rate}";
		}

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

		private void ButtonStop_Click(object sender, EventArgs e)
		{
			// Stop the speech synthesis
			synthesizer.SpeakAsyncCancelAll();
			buttonSpeak.Enabled = true;
			buttonPause.Enabled = false;
			buttonStop.Enabled = false;
		}
	}
}