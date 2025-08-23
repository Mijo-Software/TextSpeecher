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
	}
}
