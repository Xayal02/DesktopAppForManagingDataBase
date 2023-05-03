using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Speech.Recognition;
using System.Speech.Synthesis;
using System.Diagnostics;

namespace LogForm
{
    public partial class RusSpeechRecognizer : Form
    {
        static System.Globalization.CultureInfo ci = new System.Globalization.CultureInfo("ru-Ru");
        SpeechRecognitionEngine _recognizer = new SpeechRecognitionEngine(ci);
        SpeechSynthesizer Sarah = new SpeechSynthesizer();
        public RusSpeechRecognizer()
        {
            InitializeComponent();
        }

        private void RusSpeechRecognizer_Load(object sender, EventArgs e)
        {

            Choices words = new Choices();
            words.Add(new string[] { "покажи погоду", "открой вотсап" });

            _recognizer.SetInputToDefaultAudioDevice();
            _recognizer.SpeechRecognized += new EventHandler<SpeechRecognizedEventArgs>(Default_SpeechRecognized);

            GrammarBuilder grammarbuilder = new GrammarBuilder();
            grammarbuilder.Culture = ci;
            grammarbuilder.Append(words);

            _recognizer.LoadGrammarAsync(new Grammar(grammarbuilder));
            _recognizer.RecognizeAsync(RecognizeMode.Multiple);

            Sarah.SetOutputToDefaultAudioDevice();


        }

        private void Default_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
        {
            string speech = e.Result.Text;

            if (e.Result.Confidence > 0.70)
            {
                if (speech == "покажи погоду")
                {
                    Process.Start("msedge.exe", $"https://www.gismeteo.ru/weather-sumqayit-5295/");
                }
                if (speech == "открой вотсап")
                {
                    Process.Start("msedge.exe", $"https://wa.me");
                }
            }
        }

        private void sre_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
        {
            txtSpeech.Text = e.Result.Text;
        }
    }
}
