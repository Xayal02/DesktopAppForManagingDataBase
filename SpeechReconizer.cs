using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Speech.Recognition;
using System.Speech.Synthesis;
using System.Diagnostics;
using System;

namespace LogForm
{
    public class SpeechRecognizer
    {
        public static System.Globalization.CultureInfo ci = new System.Globalization.CultureInfo("ru-Ru");
        public static SpeechRecognitionEngine _recognizer = new SpeechRecognitionEngine(ci);
        public static SpeechSynthesizer Sarah = new SpeechSynthesizer();
        public static Choices words = new Choices();

        public static void SpeechRecognizerOn()
        {
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

        public static void SpeechRecognizerOf()
        {
            _recognizer.SpeechRecognized -= new EventHandler<SpeechRecognizedEventArgs>(Default_SpeechRecognized);
        }


        public static void Default_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
        {
            if (e != null)
            {
                string speech = e.Result.Text;

                if (e.Result.Confidence > 0.70)
                {
                    if (speech == "покажи погоду")
                    {
                        Process.Start("msedge.exe", $"https://www.gismeteo.ru/weather-sumqayit-5295/");
                    }
                    //if (speech == "открой вотсап")
                    //{
                    //    Process.Start("msedge.exe", $"https://wa.me");
                    //}
                }
            }
        }

    }


        

   
}