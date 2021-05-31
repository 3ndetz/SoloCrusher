using AutoTyper.View.ViewModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Input;
using WindowsInput;
using WindowsInput.Native;
using KeyboardHookManager;
using System.Windows.Forms;

namespace AutoTyper
{

    public class ViewModel : INotifyPropertyChanged
    {
        //Thread myThread = new Thread(new ThreadStart(FIRSЕ_DOWNLOAD));
        //myThread.Start();

        //KeyboardHook kb = new KeyboardHook();
        public CheckChars check { get; set; }
        public ViewModel()
        {

            //HookManager.KeyDown += (s, e) => { 
            //    if (e.KeyCode == System.Windows.Forms.Keys.B) {
            //        e.Handled = true;
            //        OutputRnd = "Привет Даун"; 
            //    } ; };
        }

        public RelayCommand Button1ClcCmd
        {
            get { return new RelayCommand(_ => Button1Clc()); }
        }
        public RelayCommand MyCommandCmd
        {
            get { return new RelayCommand(_ => MyCommand()); }
        }
        public RelayCommand StopCommandCmd
        {
            get { return new RelayCommand(_ => StopCommand()); }
        }
        public bool StopCommand()
        {
            //System.Diagnostics.Process.Start("https://www.minecraft.net/ru-ru/download");

            if (_stopTyping == true) _stopTyping = false;
            else
                _stopTyping = true;
            EHandled = false; EHandledUp = false;
            ViewModel_OnAssistEnd();
            AssistFinished = true;
            return true;
        }
        public void Button1Clc()
        {
            if (string.IsNullOrEmpty(InputText)) return;
            //sim.Keyboard.ModifiedKeyStroke(VirtualKeyCode.MENU, VirtualKeyCode.TAB);
            //System.Threading.Thread.Sleep(1000);
            if (!ManualMode)
            {
                Task.Run(() =>
                {
                    if (string.IsNullOrEmpty(InputTypeSpeed) && string.IsNullOrEmpty(InputTypeRand))
                        simulateTypingText(InputText);
                    else
                    {
                        simulateTypingText(InputText, int.Parse(InputTypeSpeed), 1500, int.Parse(InputTypeRand));
                    };
                });
                //if (StopCommand()) return;
            }
            else
            {
                check.AssistTypeWordRegister(true);
                Task.Run(() =>
                {
                    
                    assistTypingText(InputText, Shifted);
                });
            }
            //sim.Keyboard.ModifiedKeyStroke(VirtualKeyCode.SHIFT, VirtualKeyCode.VK_G);
            //OutputText2 = "Ты пидор.2";
        }

        InputSimulator sim = new InputSimulator();
        public void MyCommand()
        {

            //System.Threading.Thread.Sleep(1000);
            Task.Run(() =>
            {
                simulateTypingText(InputText, 100, 1500, 300);
            });
            // Wait a second to start typing

            //sim.Keyboard.Sleep(1000)
            //// Type Hello World
            //.TextEntry("Hello World !")
            //// Wait another second
            //.Sleep(1000)
            //// Type More text
            //.TextEntry("Type another thing")
            //;

            // Press 0 key
            //sim.Keyboard.KeyPress(VirtualKeyCode.VK_0);
            //// Press 1
            //sim.Keyboard.KeyPress(VirtualKeyCode.VK_1);
            //// Press b
            //sim.Keyboard.KeyPress(VirtualKeyCode.VK_B);
            //// Press v
            //sim.Keyboard.KeyPress(VirtualKeyCode.VK_V);
            //// Press enter
            //sim.Keyboard.KeyPress(VirtualKeyCode.RETURN);
            //// Press Left CTRL button
            //sim.Keyboard.KeyPress(VirtualKeyCode.LCONTROL);
            ////InputText = "Ты пидор.";
        }
        public string InputText { get; set; }
        public string InputTypeRand { get; set; }

        float _progressValue = 0;
        public float ProgressValue
        {
            get { return _progressValue; }
            set
            {
                _progressValue = value; OnPropertyChanged("ProgressValue");
            }
        }
        string _colorGreen = "PaleGreen";
        string _colorDarkGreen = "LimeGreen";
        string _colorYellow = "Yellow";
        string _colorRed = "Red";
        string _colorBlue = "DodgerBlue";
        string _colorOrange = "#FFFF7400";
        bool _stopTyping = false;


        bool _shifted = false;
        public bool Shifted
        {
            get { return _shifted; }
            set
            {
                _shifted = value; OnPropertyChanged("Shifted");
            }
        }

        bool _manualMode = false;
        public bool ManualMode
        {
            get { return _manualMode; }
            set
            {
                _manualMode = value; OnPropertyChanged("ManualMode");
            }
        }
        public bool AssistFinished { get; set; } = false;
        char[] _loadedAssistText;

        string _progressBarColor = "#FF11B42F";
        public string ProgressBarColor
        {
            get { return _progressBarColor; }
            set
            {
                _progressBarColor = value; OnPropertyChanged("ProgressBarColor");
            }
        }

        string _outputInfo = "HelloDebil";
        public string OutputInfo
        {
            get { return _outputInfo; }
            set
            {
                _outputInfo = value; OnPropertyChanged("OutputInfo");
            }
        }

        public string InputTypeSpeed { get; set; }
        string _outputRnd = "HelloDebil";
        public string OutputRnd
        {
            get { return _outputRnd; }
            set
            {
                _outputRnd = value; OnPropertyChanged("OutputRnd");
            }
        }

        int _nextWordNumber = 0;
        public int NextWordNumber
        {
            get { return _nextWordNumber; }
            set
            {
                _nextWordNumber = value; OutputRnd = _nextWordNumber.ToString(); OnPropertyChanged("NextWordNumber");
            }
        }


        char _nextWord = 'S';

        public char NextWord
        {
            get { return _nextWord; }
            set
            {
                _nextWord = value; OnPropertyChanged("NextWord");
            }
        }

        public bool AssistTypeRegistered { get; set; } = false;
        public bool EHandled { get; set; } = true;
        public bool EHandledUp { get; set; } = true;
        public bool TypeAllowed { get; set; } = false;
        public bool TypeAllowedUp { get; set; } = false;


        #region INotifyPropertyChanged
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion


        //if ((Keyboard.Modifiers & ModifierKeys.Control) == ModifierKeys.Control && e.Key == Key.R)
        //    protected override void OnKeyDown(KeyEventArgs e)
        //{
        //    base.OnKeyDown(e);
        //    if (e.KeyCode == Keys.F4 && e.Alt)
        //    {
        //        MessageBox.Show("Тест");
        //        e.Handled = true;
        //    }
        //}
        //CheckChars check = new CheckChars();
        private void simulateTypingText(string _text, int typingDelay = 100, int startDelay = 1500, int MaxRnd = 250)
        {
            Random rnd = new Random();
            // Wait the start delay time
            sim.Keyboard.Sleep(startDelay);
            // Split the text in lines in case it has
            string[] lines = _text.Split(new string[] { "\r\n", "\n" }, StringSplitOptions.None);
            // Some flags to calculate the percentage
            int allLines = lines.Length;
            int current = 0;
            int rndval = 0;
            int ii = 0;
            ProgressValue = 0;
            float percentage = 0;
            int _chance = 0;
            int typingDelayOld = typingDelay;
            ProgressBarColor = _colorDarkGreen;
            foreach (string line in lines)
            {
                // Split line into characters
                char[] words = line.ToCharArray();
                int allWords = words.Length;

                foreach (char word in words)
                {
                    
                    rndval = rnd.Next(0, MaxRnd);
                    #region Статистика
                    percentage = (float)((float)current / (float)allWords) * (float)100;
                    current++;

                    //ProgressValue = percentage;
                    sim.Keyboard.Sleep(typingDelay + rndval);
                    OutputInfo = current.ToString() + " / " + allWords.ToString();

                    var timer = new System.Timers.Timer(25);
                    timer.Elapsed += (s, a) =>
                    {
                        
                        if (ProgressValue >= (float)percentage)
                        {
                            timer.Stop();
                        } else { ProgressValue += 1; }
                    };
                    timer.Start();

                    #endregion
                    
                    OutputRnd = rndval.ToString();
                    if (_stopTyping) { _stopTyping = false; return; }

                    //                    if (ii > 0) OutputRnd += "\t TURBO ON" + typingDelay.ToString();
                    check.TypeWord(word, typingDelay, rndval);
                    //sim.Keyboard.TextEntry(word).Sleep(typingDelay+rndval);
                    #region РежимТурбо
                    _chance = rnd.Next(0, 10);
                    if (_chance == 2&&ii==0)
                    {
                        sim.Keyboard.Sleep(typingDelay + rndval*5);

                        if (typingDelay > 20)
                        {
                            
                            typingDelay = typingDelayOld / 2;
                            ii++;
                        }

                    }
                    if (ii > 0) { ii++; OutputRnd += "\t TURBO ON" + typingDelay.ToString(); ProgressBarColor = _colorBlue; }
                    if (ii == 10)
                    {
                        typingDelay = typingDelayOld;
                        ii = 0;
                        ProgressBarColor = _colorDarkGreen;
                    }
                    #endregion
                    
                }


                // Add a new line by pressing ENTER
                // Return to start of the line in your editor with HOME
                //sim.Keyboard.KeyPress(VirtualKeyCode.RETURN);
                //sim.Keyboard.KeyPress(VirtualKeyCode.HOME);
                // Show the percentage in the console
                //Console.WriteLine("Percent : {0}", percentage.ToString());
            }
            ProgressBarColor = _colorGreen;
            ProgressValue = 100;
        }

        //public delegate void OnType();
        //public event OnType OnTypeEvent;
        private void assistTypingText(string _text, bool shift)
        {
            Random rnd = new Random();
            AssistFinished = false;
            string[] lines = _text.Split(new string[] { "\r\n", "\n" }, StringSplitOptions.None);
            _loadedAssistText = _text.ToCharArray();
            EHandled = true; EHandledUp = true;
            TypeAllowed = false;
            NextWord = _loadedAssistText[NextWordNumber];
            int allLines = lines.Length;
            int current = 0;
            int rndval = 0;
            int ii = 0;
            ProgressValue = 0;
            float percentage = 0;
            int _chance = 0;
            ProgressBarColor = _colorDarkGreen;
            
            #region comment
            /*
            foreach (string line in lines)
            {
                char[] words = line.ToCharArray();
                int allWords = words.Length;


                
                foreach (char word in words)
                {

                    #region Статистика
                    percentage = ((float)current / (float)allWords) * 100;
                    current++;

                    //ProgressValue = percentage;
                    OutputInfo = current.ToString() + " / " + allWords.ToString();

                    var timer = new System.Timers.Timer(50);
                    timer.Elapsed += (s, a) =>
                    {
                        ProgressValue += (float)2;
                        if (ProgressValue >= (float)percentage)
                        {
                            timer.Stop();
                        }
                    };
                    timer.Start();

                    #endregion
                    WaitingForUser = true;
                    OutputRnd = rndval.ToString();
                    if (_stopTyping) { _stopTyping = false; break; }
                    //object e = null;
                    //                    if (ii > 0) OutputRnd += "\t TURBO ON" + typingDelay.ToString();
                    //OnTypeEvent += ViewModel_OnTypeEvent(e); check.TypeNextWord();
                    //OnTypeEvent();
                    //check.AssistTypeWord(word, shift, rndval, WaitingForUser);
                    //check.AssistTypeWord(word, shift, rndval, WaitingForUser);
                    do
                    {

                    } while (!WaitingForUser);
                    do
                    {

                    } while (!WaitingForUser);
                    //sim.Keyboard.TextEntry(word).Sleep(typingDelay+rndval);
                }


                // Add a new line by pressing ENTER
                // Return to start of the line in your editor with HOME
                //sim.Keyboard.KeyPress(VirtualKeyCode.RETURN);
                //sim.Keyboard.KeyPress(VirtualKeyCode.HOME);
                // Show the percentage in the console
                //Console.WriteLine("Percent : {0}", percentage.ToString());
            }*/
            #endregion
        }

        internal void ViewModel_OnTypeEvent()
        {
            Task.Run(() =>
            {

                if (!AssistFinished)
                    if ((_loadedAssistText.Length) > NextWordNumber)
                    {
                        TypeAllowedChange();
                        if (TypeAllowed)
                        {
                            if (NextWordNumber == 0) { AssistFinished = false; }
                            //                sim.Keyboard.Sleep(500);
                            NextWord = _loadedAssistText[NextWordNumber];
                            check.TypeNextWord();
                            //NextWordNumber += 1;
                            OutputInfo = NextWordNumber.ToString() + " / " + _loadedAssistText.Length.ToString();
                            ProgressValue = (float)((float)NextWordNumber / (float)_loadedAssistText.Length)*100;
                        }

                    }
                    else
                    {
                        ViewModel_OnAssistEnd(); EHandled = false; EHandledUp = false;
                    }
            });
            //Thread.Sleep(1000);
            //e.Handled = false;
        }
        
        public void ViewModel_OnAssistEnd()
        {
            EHandled = false; EHandledUp = false;
            //check.AssistTypeWordUnRegister();
            ProgressBarColor = _colorGreen;
            ProgressValue = 100;

            sim.Keyboard.Sleep(200);
            AssistFinished = true;
            EHandled = false; NextWordNumber = 0;
        }
        public void TypeAllowedChange()
        {
            if (TypeAllowed) { TypeAllowed = false; }
            else { TypeAllowed = true; }
        }
        public void TypeAllowedChangeUp()
        {
            if (TypeAllowedUp) { TypeAllowedUp = false; }
            if (!TypeAllowedUp) { TypeAllowedUp = true; }
        }
    }
}
