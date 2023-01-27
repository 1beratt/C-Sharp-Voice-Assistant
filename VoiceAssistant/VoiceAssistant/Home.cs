using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech.Recognition;
using System.Speech.Synthesis;
using System.Threading;
using System.Runtime.InteropServices;
using System.Xml;
using System.Xml.Serialization;
using System.IO;
using System.Xml.Linq;
using System.Reflection;

namespace VoiceAssistant
{
    public partial class Home : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,     // x-coordinate of upper-left corner
            int nTopRect,      // y-coordinate of upper-left corner
            int nRightRect,    // x-coordinate of lower-right corner
            int nBottomRect,   // y-coordinate of lower-right corner
            int nWidthEllipse, // height of ellipse
            int nHeightEllipse // width of ellipse
        );
        public Home()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }

        SpeechRecognitionEngine reco = new SpeechRecognitionEngine();
        SpeechSynthesizer AssistantSpeak = new SpeechSynthesizer();

        private void mic1_Click(object sender, EventArgs e)
        {
            mic1.Visible = false;
            try
            {
                reco.RecognizeAsync();
            }
            catch (Exception)
            {
            }
            VoiceCommandBtn.Text = "I'm listening...";
        }

        private void mic2_Click(object sender, EventArgs e)
        {
            mic1.Visible = true;
            VoiceCommandBtn.Text = "Your Command";
        }
        string[] commands = XDocument.Load(@"AddCommand.xml").Descendants("Command").Select(element => element.Value).ToArray();
        string[] location = XDocument.Load(@"AddCommand.xml").Descendants("Location").Select(element => element.Value).ToArray();

        string[] DefaultCommands = XDocument.Load(@"DefaultCommand.xml").Descendants("Command").Select(element => element.Value).ToArray();
        void voice()
        {
            try
            {
                Choices options = new Choices(commands);
                Grammar grammar = new Grammar(new GrammarBuilder(options));

                Choices DefOptions = new Choices(DefaultCommands);
                Grammar DefGrammar = new Grammar(new GrammarBuilder(DefOptions));
                reco.LoadGrammar(grammar);
                reco.LoadGrammar(DefGrammar);
                reco.SetInputToDefaultAudioDevice();
                reco.SpeechRecognized += VoiceOkey;
            }
            catch
            {
                DialogResult dialogResult = MessageBox.Show("If your computer language is not English, please change it to English and try again.", "There is a problem", MessageBoxButtons.OKCancel);
                if (dialogResult == DialogResult.OK)
                {
                    Application.Exit();
                }
                else if(dialogResult == DialogResult.Cancel)
                {
                }
            }
        }
        
        private void VoiceOkey(object sender, SpeechRecognizedEventArgs e)
        {
            mic1.Visible = true;
            VoiceCommandBtn.Text = e.Result.Text;

            string[] whatsup = { "Thank you I am good.", "A boring day", "I'm a little sick" };
            if (e.Result.Text == "Hello")
            {
                AssistantSpeak.SpeakAsync("Hello, nice to see you.");
                VoiceCommandBtn.Text = "Hello, nice to see you.";
            }
            else if (e.Result.Text == "What's up")
            {
                Random random = new Random();
                int item = random.Next(0, whatsup.Length);
                AssistantSpeak.SpeakAsync(whatsup[item].ToString());
                VoiceCommandBtn.Text = whatsup[item].ToString();
            }
            else if (e.Result.Text == "What's your name")
            {
                AssistantSpeak.SpeakAsync("No steps yet. You can call it an assistant for short.");
                VoiceCommandBtn.Text = "No steps yet. You can call it an assistant for short.";
                Thread.Sleep(3000);
            }
            else if (e.Result.Text == "How old are you")
            {
                AssistantSpeak.SpeakAsync("My birthday is 21.01.2023");
                VoiceCommandBtn.Text = "My birthday is 21.01.2023";
                Thread.Sleep(2000);
            }
            else if (e.Result.Text == "Who created you")
            {
                AssistantSpeak.SpeakAsync("My developer name is Berat CELİK. He is a software developer.");
                VoiceCommandBtn.Text = "My developer name is Berat ÇELİK. He is a software developer.";
                Thread.Sleep(3000);
            }
            else if (e.Result.Text == "Minimize assistant")
            {
                AssistantSpeak.SpeakAsync("Okey");
                Thread.Sleep(1500);
                this.WindowState = FormWindowState.Minimized;
                
            }
            else if (e.Result.Text == "Show commands")
            {
                AssistantSpeak.SpeakAsync("Okey");
                Thread.Sleep(1500);
                OptionsPage form = new OptionsPage();
                form.Show();
            }
            else if (e.Result.Text == "What time is it?")
            {
                AssistantSpeak.SpeakAsync("Now it's "+DateTime.Now.ToShortTimeString());
                VoiceCommandBtn.Text = "Now it's "+DateTime.Now.ToShortTimeString();
            }
            else if (e.Result.Text == "Computer sleep mode")
            {
                AssistantSpeak.SpeakAsync("Okey, I'm sleep.");
                Thread.Sleep(2000);
                Application.SetSuspendState(PowerState.Suspend, true, true);
            }
            else if (e.Result.Text == "Hibernate Computer")
            {
                AssistantSpeak.SpeakAsync("Okey, I'm waiting for you.");
                Thread.Sleep(2000);
                Application.SetSuspendState(PowerState.Hibernate, true, true);
            }
            else if (e.Result.Text == "Sleep time")
            {
                AssistantSpeak.SpeakAsync("See you later.");
                Thread.Sleep(2000);
                Application.Exit();
            }
            for (int i = 0; i < commands.Length; i++)
            {
                if (e.Result.Text == commands[i].ToString())
                {
                    AssistantSpeak.SpeakAsync("Okey, please wait.");
                    VoiceCommandBtn.Text = "Okey, please wait.";
                    Thread.Sleep(2000);
                    System.Diagnostics.Process.Start(location[i].ToString());
                }
            }
        }

        private void Home_Load(object sender, EventArgs e)
        {
            voice();
        }

        private void OptionsBtn_Click(object sender, EventArgs e)
        {
            OptionsPage form = new OptionsPage();
            form.Show();
        }

        private void BeratClkBtn_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/1beratt");
        }       
    }
}
