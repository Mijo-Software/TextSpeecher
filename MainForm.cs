using System.Speech.Synthesis;

// Import necessary namespaces
namespace TextSpeecher
{
	// MainForm class inherits from Form
	public partial class MainForm : Form
	{
		// Declare a SpeechSynthesizer instance
		private readonly SpeechSynthesizer synthesizer;

		// Constructor for the MainForm
		public MainForm()
		{
			// Initialize the form components and the speech synthesizer
			InitializeComponent();
			// Create a new instance of the SpeechSynthesizer
			synthesizer = new SpeechSynthesizer();
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

		// Event handler for the volume track bar scroll event
		private void TrackBarVolume_Scroll(object sender, EventArgs e)
		{
			// Update the synthesizer volume based on the track bar value
			synthesizer.Volume = trackBarVolume.Value;
			// Update the volume label to show the current volume
			labelVolume.Text = $"Volume: {synthesizer.Volume}";
		}

		private void TrackBarSpeechRate_Scroll(object sender, EventArgs e)
		{
			// Update the synthesizer speech rate based on the track bar value
			synthesizer.Rate = trackBarSpeechRate.Value;
			// Update the speech rate label to show the current rate
			labelSpeechRate.Text = $"Speech Rate: {synthesizer.Rate}";
		}
	}
}
