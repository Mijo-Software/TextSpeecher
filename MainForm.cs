using System.Speech.Synthesis;

// Import necessary namespaces
namespace TextSpeecher
{
	// MainForm class inherits from Form
	public partial class MainForm : Form
	{
		// Declare a SpeechSynthesizer instance
		private readonly SpeechSynthesizer synthesizer;

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

		// Event handler for the form load event
		private void MainForm_Load(object sender, EventArgs e)
		{
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
	}
}
