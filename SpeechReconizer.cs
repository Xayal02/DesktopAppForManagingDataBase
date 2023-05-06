using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Speech.Recognition;
using System.Speech.Synthesis;
using System.Diagnostics;
using System;
using static LogForm.Program;
using System.IO;
using ColumnDeterminer;

namespace LogForm
{
    public class SpeechRecognizer
    {
        public static System.Globalization.CultureInfo ci = new System.Globalization.CultureInfo("ru-Ru");
        public static SpeechRecognitionEngine _recognizer = new SpeechRecognitionEngine(ci);
        public static SpeechSynthesizer Sarah = new SpeechSynthesizer();
        public static Choices words = new Choices();
        public static Choices commands = new Choices();


        public static void SpeechRecognizerOn()
        {
            commands.Add(File.ReadAllLines(pathToSpeechCommands));

            words.Add(new string[] { "покажи погоду", "открой вотсап", "Выйди" });
            _recognizer.SetInputToDefaultAudioDevice();
            _recognizer.SpeechRecognized += new EventHandler<SpeechRecognizedEventArgs>(Default_SpeechRecognized);

            GrammarBuilder grammarbuilder = new GrammarBuilder();
            grammarbuilder.Culture = ci;
            grammarbuilder.Append(commands);

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
                    if (speech == "открой вотсап")
                    {
                        Process.Start("msedge.exe", $"https://wa.me");
                    }

                    if (speech == "открой калькулятор")
                    {
                        Process.Start("msedge.exe", $"https://www.desmos.com/scientific?lang=ru");
                    }

                    if (speech == "открой файл список продуктов")
                    {
                        Process.Start("explorer.exe", $"D:\\VisualStudio\\Projects\\LogForm\\ProductList");
                    }
                    if (speech == "открой файл амбар")
                    {
                        Process.Start("explorer.exe", $"D:\\VisualStudio\\Projects\\LogForm\\WarehouseList");
                    }

                    if (speech == "выйди" || speech == "выйди из приложения")
                    {
                        Application.Exit();
                    }
                }
            }
        }

    }


        

   
}