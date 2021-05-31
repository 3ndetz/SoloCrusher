using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//using System.Threading.Tasks;
using WindowsInput;
using WindowsInput.Native;
using KeyboardHookManager;
using System.Windows.Forms;
using AutoTyper.View.ViewModel;
namespace AutoTyper
{
    public class CheckChars
    {
        // СТРОЧКА в СОЛО = 41 СИМВ. Оникс царь Опа Опа Ку бро ! !!!
        Random rnd = new Random();
        InputSimulator sim = new InputSimulator();
        public void TypeWord(char word, int typedelay, int rndtypeval)
        {
            

            //           if (word == 'й')
            //           {
            //               sim.Keyboard.KeyDown(VirtualKeyCode.VK_Q);
            //           }
            
            int rndsleep=rnd.Next(typedelay ^ (1 / 4) * 6, typedelay^(1/4)*9);
            const char V = '\\';
            int timeAfterShift = rndsleep;
            int timeBeforeShiftEnd = rndsleep / 2;
            void KeyType(VirtualKeyCode key, bool shifted=false)
            {
                if (shifted)
                {
                    sim.Keyboard.KeyDown(VirtualKeyCode.SHIFT);
                    sim.Keyboard.Sleep(timeAfterShift);
                    sim.Keyboard.KeyDown(key);
                    sim.Keyboard.Sleep(rndsleep);
                    sim.Keyboard.KeyUp(key);
                    sim.Keyboard.Sleep(timeBeforeShiftEnd);
                    sim.Keyboard.KeyUp(VirtualKeyCode.SHIFT);
                }
                else
                {
                    sim.Keyboard.KeyDown(key);
                    sim.Keyboard.Sleep(rndsleep);
                    sim.Keyboard.KeyUp(key);
                }
            }
            switch (word)
            {
                case ' ':
                    sim.Keyboard.Sleep(rndsleep/4);
                    sim.Keyboard.KeyDown(VirtualKeyCode.SPACE);
                    sim.Keyboard.Sleep(rndsleep);
                    sim.Keyboard.KeyUp(VirtualKeyCode.SPACE);

                    int _chance = rnd.Next(0, 4);
                    if (_chance == 2)
                    {
                        sim.Keyboard.Sleep(rndsleep*15);
                    }

                    break;
                case 'ё':
                    sim.Keyboard.Sleep(rndsleep*2);
                    sim.Keyboard.KeyDown(VirtualKeyCode.OEM_3);
                    sim.Keyboard.Sleep(rndsleep*2);
                    sim.Keyboard.KeyUp(VirtualKeyCode.OEM_3);
                    break;

                //йцукенгшщзхъфывапролджэячсмитьбю.\/,!"№;%:?*()-=+ЙЦУКЕНГШЩЗХЪФЫВАПРОЛДЖЭЯЧСМИТЬБЮ

                //йцукенгшщзхъ
                #region верхний ряд
                case 'й':
                    sim.Keyboard.KeyDown(VirtualKeyCode.VK_Q);
                    sim.Keyboard.Sleep(rndsleep);
                    sim.Keyboard.KeyUp(VirtualKeyCode.VK_Q);
                    break;
                case 'ц':
                    sim.Keyboard.KeyDown(VirtualKeyCode.VK_W);
                    sim.Keyboard.Sleep(rndsleep);
                    sim.Keyboard.KeyUp(VirtualKeyCode.VK_W);
                    break;
                case 'у':
                    sim.Keyboard.KeyDown(VirtualKeyCode.VK_E);
                    sim.Keyboard.Sleep(rndsleep);
                    sim.Keyboard.KeyUp(VirtualKeyCode.VK_E);
                    break;
                case 'к':
                    sim.Keyboard.KeyDown(VirtualKeyCode.VK_R);
                    sim.Keyboard.Sleep(rndsleep);
                    sim.Keyboard.KeyUp(VirtualKeyCode.VK_R);
                    break;
                case 'е':
                    sim.Keyboard.KeyDown(VirtualKeyCode.VK_T);
                    sim.Keyboard.Sleep(rndsleep);
                    sim.Keyboard.KeyUp(VirtualKeyCode.VK_T);
                    break;
                case 'н':
                    sim.Keyboard.KeyDown(VirtualKeyCode.VK_Y);
                    sim.Keyboard.Sleep(rndsleep);
                    sim.Keyboard.KeyUp(VirtualKeyCode.VK_Y);
                    break;
                case 'г':
                    sim.Keyboard.KeyDown(VirtualKeyCode.VK_U);
                    sim.Keyboard.Sleep(rndsleep);
                    sim.Keyboard.KeyUp(VirtualKeyCode.VK_U);
                    break;
                case 'ш':
                    sim.Keyboard.KeyDown(VirtualKeyCode.VK_I);
                    sim.Keyboard.Sleep(rndsleep);
                    sim.Keyboard.KeyUp(VirtualKeyCode.VK_I);
                    break;
                case 'щ':
                    sim.Keyboard.KeyDown(VirtualKeyCode.VK_O);
                    sim.Keyboard.Sleep(rndsleep);
                    sim.Keyboard.KeyUp(VirtualKeyCode.VK_O);
                    break;
                case 'з':
                    sim.Keyboard.KeyDown(VirtualKeyCode.VK_P);
                    sim.Keyboard.Sleep(rndsleep);
                    sim.Keyboard.KeyUp(VirtualKeyCode.VK_P);
                    break;
                case 'х':
                    sim.Keyboard.KeyDown(VirtualKeyCode.OEM_4);
                    sim.Keyboard.Sleep(rndsleep);
                    sim.Keyboard.KeyUp(VirtualKeyCode.OEM_4);
                    break;
                case 'ъ':
                    sim.Keyboard.KeyDown(VirtualKeyCode.OEM_6);
                    sim.Keyboard.Sleep(rndsleep);
                    sim.Keyboard.KeyUp(VirtualKeyCode.OEM_6);
                    break;
                #endregion
                //ЙЦУКЕНГШЩЗХЪ
                #region ВЕРХНИЙ РЯД (прописные)
                case 'Й':
                    sim.Keyboard.KeyDown(VirtualKeyCode.SHIFT);
                    sim.Keyboard.Sleep(timeAfterShift);
                    sim.Keyboard.KeyDown(VirtualKeyCode.VK_Q);
                    sim.Keyboard.Sleep(rndsleep);
                    sim.Keyboard.KeyUp(VirtualKeyCode.VK_Q);
                    sim.Keyboard.Sleep(timeBeforeShiftEnd);
                    sim.Keyboard.KeyUp(VirtualKeyCode.SHIFT);
                    break;
                case 'Ц':
                    sim.Keyboard.KeyDown(VirtualKeyCode.SHIFT);
                    sim.Keyboard.Sleep(timeAfterShift);
                    sim.Keyboard.KeyDown(VirtualKeyCode.VK_W);
                    sim.Keyboard.Sleep(rndsleep);
                    sim.Keyboard.KeyUp(VirtualKeyCode.VK_W);
                    sim.Keyboard.Sleep(timeBeforeShiftEnd);
                    sim.Keyboard.KeyUp(VirtualKeyCode.SHIFT);
                    break;
                case 'У':
                    sim.Keyboard.KeyDown(VirtualKeyCode.SHIFT);
                    sim.Keyboard.Sleep(timeAfterShift);
                    sim.Keyboard.KeyDown(VirtualKeyCode.VK_E);
                    sim.Keyboard.Sleep(rndsleep);
                    sim.Keyboard.KeyUp(VirtualKeyCode.VK_E);
                    sim.Keyboard.Sleep(timeBeforeShiftEnd);
                    sim.Keyboard.KeyUp(VirtualKeyCode.SHIFT);
                    break;
                case 'К':
                    sim.Keyboard.KeyDown(VirtualKeyCode.SHIFT);
                    sim.Keyboard.Sleep(timeAfterShift);
                    sim.Keyboard.KeyDown(VirtualKeyCode.VK_R);
                    sim.Keyboard.Sleep(rndsleep);
                    sim.Keyboard.KeyUp(VirtualKeyCode.VK_R);
                    sim.Keyboard.Sleep(timeBeforeShiftEnd);
                    sim.Keyboard.KeyUp(VirtualKeyCode.SHIFT);
                    break;
                case 'Е':
                    sim.Keyboard.KeyDown(VirtualKeyCode.SHIFT);
                    sim.Keyboard.Sleep(timeAfterShift);
                    sim.Keyboard.KeyDown(VirtualKeyCode.VK_T);
                    sim.Keyboard.Sleep(rndsleep);
                    sim.Keyboard.KeyUp(VirtualKeyCode.VK_T);
                    sim.Keyboard.Sleep(timeBeforeShiftEnd);
                    sim.Keyboard.KeyUp(VirtualKeyCode.SHIFT);
                    break;
                case 'Н':
                    sim.Keyboard.KeyDown(VirtualKeyCode.SHIFT);
                    sim.Keyboard.Sleep(timeAfterShift);
                    sim.Keyboard.KeyDown(VirtualKeyCode.VK_Y);
                    sim.Keyboard.Sleep(rndsleep);
                    sim.Keyboard.KeyUp(VirtualKeyCode.VK_Y);
                    sim.Keyboard.Sleep(timeBeforeShiftEnd);
                    sim.Keyboard.KeyUp(VirtualKeyCode.SHIFT);
                    break;
                case 'Г':
                    sim.Keyboard.KeyDown(VirtualKeyCode.SHIFT);
                    sim.Keyboard.Sleep(timeAfterShift);
                    sim.Keyboard.KeyDown(VirtualKeyCode.VK_U);
                    sim.Keyboard.Sleep(rndsleep);
                    sim.Keyboard.KeyUp(VirtualKeyCode.VK_U);
                    sim.Keyboard.Sleep(timeBeforeShiftEnd);
                    sim.Keyboard.KeyUp(VirtualKeyCode.SHIFT);
                    break;
                case 'Ш':
                    sim.Keyboard.KeyDown(VirtualKeyCode.SHIFT);
                    sim.Keyboard.Sleep(timeAfterShift);
                    sim.Keyboard.KeyDown(VirtualKeyCode.VK_I);
                    sim.Keyboard.Sleep(rndsleep);
                    sim.Keyboard.KeyUp(VirtualKeyCode.VK_I);
                    sim.Keyboard.Sleep(timeBeforeShiftEnd);
                    sim.Keyboard.KeyUp(VirtualKeyCode.SHIFT);
                    break;
                case 'Щ':
                    sim.Keyboard.KeyDown(VirtualKeyCode.SHIFT);
                    sim.Keyboard.Sleep(timeAfterShift);
                    sim.Keyboard.KeyDown(VirtualKeyCode.VK_O);
                    sim.Keyboard.Sleep(rndsleep);
                    sim.Keyboard.KeyUp(VirtualKeyCode.VK_O);
                    sim.Keyboard.Sleep(timeBeforeShiftEnd);
                    sim.Keyboard.KeyUp(VirtualKeyCode.SHIFT);
                    break;
                case 'З':
                    sim.Keyboard.KeyDown(VirtualKeyCode.SHIFT);
                    sim.Keyboard.Sleep(timeAfterShift);
                    sim.Keyboard.KeyDown(VirtualKeyCode.VK_P);
                    sim.Keyboard.Sleep(rndsleep);
                    sim.Keyboard.KeyUp(VirtualKeyCode.VK_P);
                    sim.Keyboard.Sleep(timeBeforeShiftEnd);
                    sim.Keyboard.KeyUp(VirtualKeyCode.SHIFT);
                    break;
                case 'Х':
                    sim.Keyboard.KeyDown(VirtualKeyCode.SHIFT);
                    sim.Keyboard.Sleep(timeAfterShift);
                    sim.Keyboard.KeyDown(VirtualKeyCode.OEM_4);
                    sim.Keyboard.Sleep(rndsleep);
                    sim.Keyboard.KeyUp(VirtualKeyCode.OEM_4);
                    sim.Keyboard.Sleep(timeBeforeShiftEnd);
                    sim.Keyboard.KeyUp(VirtualKeyCode.SHIFT);
                    break;
                case 'Ъ':
                    sim.Keyboard.KeyDown(VirtualKeyCode.SHIFT);
                    sim.Keyboard.Sleep(timeAfterShift);
                    sim.Keyboard.KeyDown(VirtualKeyCode.OEM_6);
                    sim.Keyboard.Sleep(rndsleep);
                    sim.Keyboard.KeyUp(VirtualKeyCode.OEM_6);
                    sim.Keyboard.Sleep(timeBeforeShiftEnd);
                    sim.Keyboard.KeyUp(VirtualKeyCode.SHIFT);
                    break;
                #endregion

                //фывапролджэ
                #region средний ряд
                case 'ф':
                    sim.Keyboard.KeyDown(VirtualKeyCode.VK_A);
                    sim.Keyboard.Sleep(rndsleep);
                    sim.Keyboard.KeyUp(VirtualKeyCode.VK_A);
                    break;
                case 'ы':
                    sim.Keyboard.KeyDown(VirtualKeyCode.VK_S);
                    sim.Keyboard.Sleep(rndsleep);
                    sim.Keyboard.KeyUp(VirtualKeyCode.VK_S);
                    break;
                case 'в':
                    sim.Keyboard.KeyDown(VirtualKeyCode.VK_D);
                    sim.Keyboard.Sleep(rndsleep);
                    sim.Keyboard.KeyUp(VirtualKeyCode.VK_D);
                    break;
                case 'а':
                    sim.Keyboard.KeyDown(VirtualKeyCode.VK_F);
                    sim.Keyboard.Sleep(rndsleep);
                    sim.Keyboard.KeyUp(VirtualKeyCode.VK_F);
                    break;
                case 'п':
                    sim.Keyboard.KeyDown(VirtualKeyCode.VK_G);
                    sim.Keyboard.Sleep(rndsleep);
                    sim.Keyboard.KeyUp(VirtualKeyCode.VK_G);
                    break;
                case 'р':
                    sim.Keyboard.KeyDown(VirtualKeyCode.VK_H);
                    sim.Keyboard.Sleep(rndsleep);
                    sim.Keyboard.KeyUp(VirtualKeyCode.VK_H);
                    break;
                case 'о':
                    sim.Keyboard.KeyDown(VirtualKeyCode.VK_J);
                    sim.Keyboard.Sleep(rndsleep);
                    sim.Keyboard.KeyUp(VirtualKeyCode.VK_J);
                    break;
                case 'л':
                    sim.Keyboard.KeyDown(VirtualKeyCode.VK_K);
                    sim.Keyboard.Sleep(rndsleep);
                    sim.Keyboard.KeyUp(VirtualKeyCode.VK_K);
                    break;
                case 'д':
                    sim.Keyboard.KeyDown(VirtualKeyCode.VK_L);
                    sim.Keyboard.Sleep(rndsleep);
                    sim.Keyboard.KeyUp(VirtualKeyCode.VK_L);
                    break;
                case 'ж':
                    sim.Keyboard.KeyDown(VirtualKeyCode.OEM_1);
                    sim.Keyboard.Sleep(rndsleep);
                    sim.Keyboard.KeyUp(VirtualKeyCode.OEM_1);
                    break;
                case 'э':
                    sim.Keyboard.KeyDown(VirtualKeyCode.OEM_7);
                    sim.Keyboard.Sleep(rndsleep);
                    sim.Keyboard.KeyUp(VirtualKeyCode.OEM_7);
                    break;
                #endregion
                //ФЫВАПРОЛДЖЭ
                #region СРЕДНИЙ РЯД (ПРОПИСНЫЕ)
                case 'Ф':
                    KeyType(VirtualKeyCode.VK_A, true);
                    break;
                case 'Ы':
                    KeyType(VirtualKeyCode.VK_S, true);
                    break;
                case 'В':
                    KeyType(VirtualKeyCode.VK_D, true);
                    break;
                case 'А':
                    KeyType(VirtualKeyCode.VK_F, true);
                    break;
                case 'П':
                    KeyType(VirtualKeyCode.VK_G, true);
                    break;
                case 'Р':
                    KeyType(VirtualKeyCode.VK_H, true);
                    break;
                case 'О':
                    KeyType(VirtualKeyCode.VK_J, true);
                    break;
                case 'Л':
                    KeyType(VirtualKeyCode.VK_K, true);
                    break;
                case 'Д':
                    KeyType(VirtualKeyCode.VK_L, true);
                    break;
                case 'Ж':
                    KeyType(VirtualKeyCode.OEM_1, true);
                    break;
                case 'Э':
                    KeyType(VirtualKeyCode.OEM_7, true);
                    break;
                #endregion


                //ячсмитьбю
                #region нижний ряд
                case 'я':
                    sim.Keyboard.KeyDown(VirtualKeyCode.VK_Z);
                    sim.Keyboard.Sleep(rndsleep);
                    sim.Keyboard.KeyUp(VirtualKeyCode.VK_Z);
                    break;
                case 'ч':
                    sim.Keyboard.KeyDown(VirtualKeyCode.VK_X);
                    sim.Keyboard.Sleep(rndsleep);
                    sim.Keyboard.KeyUp(VirtualKeyCode.VK_X);
                    break;
                case 'с':
                    sim.Keyboard.KeyDown(VirtualKeyCode.VK_C);
                    sim.Keyboard.Sleep(rndsleep);
                    sim.Keyboard.KeyUp(VirtualKeyCode.VK_C);
                    break;
                case 'м':
                    sim.Keyboard.KeyDown(VirtualKeyCode.VK_V);
                    sim.Keyboard.Sleep(rndsleep);
                    sim.Keyboard.KeyUp(VirtualKeyCode.VK_V);
                    break;
                case 'и':
                    sim.Keyboard.KeyDown(VirtualKeyCode.VK_B);
                    sim.Keyboard.Sleep(rndsleep);
                    sim.Keyboard.KeyUp(VirtualKeyCode.VK_B);
                    break;
                case 'т':
                    sim.Keyboard.KeyDown(VirtualKeyCode.VK_N);
                    sim.Keyboard.Sleep(rndsleep);
                    sim.Keyboard.KeyUp(VirtualKeyCode.VK_N);
                    break;
                case 'ь':
                    sim.Keyboard.KeyDown(VirtualKeyCode.VK_M);
                    sim.Keyboard.Sleep(rndsleep);
                    sim.Keyboard.KeyUp(VirtualKeyCode.VK_M);
                    break;
                case 'б':
                    sim.Keyboard.KeyDown(VirtualKeyCode.OEM_COMMA);
                    sim.Keyboard.Sleep(rndsleep);
                    sim.Keyboard.KeyUp(VirtualKeyCode.OEM_COMMA);
                    break;
                case 'ю':
                    sim.Keyboard.KeyDown(VirtualKeyCode.OEM_PERIOD);
                    sim.Keyboard.Sleep(rndsleep);
                    sim.Keyboard.KeyUp(VirtualKeyCode.OEM_PERIOD);
                    break;
                #endregion
                //ЯЧСМИТЬБЮ
                #region НИЖНИЙ РЯД (ПРОПИСНЫЕ)
                case 'Я':
                    KeyType(VirtualKeyCode.VK_Z, true);
                    break;
                case 'Ч':
                    KeyType(VirtualKeyCode.VK_X, true);
                    break;
                case 'С':
                    KeyType(VirtualKeyCode.VK_C, true);
                    break;
                case 'М':
                    KeyType(VirtualKeyCode.VK_V, true);
                    break;
                case 'И':
                    KeyType(VirtualKeyCode.VK_B, true);
                    break;
                case 'Т':
                    KeyType(VirtualKeyCode.VK_N, true);
                    break;
                case 'Ь':
                    KeyType(VirtualKeyCode.VK_M, true);
                    break;
                case 'Б':
                    KeyType(VirtualKeyCode.OEM_COMMA, true);
                    break;
                case 'Ю':
                    KeyType(VirtualKeyCode.OEM_PERIOD, true);
                    break;
                #endregion

                #region \/,.
                case V: //V = "\"
                    sim.Keyboard.KeyDown(VirtualKeyCode.OEM_5);
                    sim.Keyboard.Sleep(rndsleep);
                    sim.Keyboard.KeyUp(VirtualKeyCode.OEM_5);
                    break;
                case '/':
                    sim.Keyboard.KeyDown(VirtualKeyCode.SHIFT);
                    sim.Keyboard.Sleep(timeAfterShift);
                    sim.Keyboard.KeyDown(VirtualKeyCode.OEM_5);
                    sim.Keyboard.Sleep(rndsleep);
                    sim.Keyboard.KeyUp(VirtualKeyCode.OEM_5);
                    sim.Keyboard.Sleep(timeBeforeShiftEnd);
                    sim.Keyboard.KeyUp(VirtualKeyCode.SHIFT);
                    break;
                case ',':
                    sim.Keyboard.KeyDown(VirtualKeyCode.SHIFT);
                    sim.Keyboard.Sleep(timeAfterShift);
                    sim.Keyboard.KeyDown(VirtualKeyCode.OEM_2);
                    sim.Keyboard.Sleep(rndsleep);
                    sim.Keyboard.KeyUp(VirtualKeyCode.OEM_2);
                    sim.Keyboard.Sleep(timeBeforeShiftEnd);
                    sim.Keyboard.KeyUp(VirtualKeyCode.SHIFT);
                    break;
                case '.':
                    sim.Keyboard.KeyDown(VirtualKeyCode.OEM_2);
                    sim.Keyboard.Sleep(rndsleep);
                    sim.Keyboard.KeyUp(VirtualKeyCode.OEM_2);
                    break;
                #endregion

                //!"№;%:?*()-=+

                #region !"№;%:?*()-=+
                case '!':
                    sim.Keyboard.KeyDown(VirtualKeyCode.SHIFT);
                    sim.Keyboard.Sleep(timeAfterShift);
                    sim.Keyboard.KeyDown(VirtualKeyCode.VK_1);
                    sim.Keyboard.Sleep(rndsleep);
                    sim.Keyboard.KeyUp(VirtualKeyCode.VK_1);
                    sim.Keyboard.Sleep(timeBeforeShiftEnd);
                    sim.Keyboard.KeyUp(VirtualKeyCode.SHIFT);
                    break;
                case '"':
                    sim.Keyboard.KeyDown(VirtualKeyCode.SHIFT);
                    sim.Keyboard.Sleep(timeAfterShift);
                    sim.Keyboard.KeyDown(VirtualKeyCode.VK_2);
                    sim.Keyboard.Sleep(rndsleep);
                    sim.Keyboard.KeyUp(VirtualKeyCode.VK_2);
                    sim.Keyboard.Sleep(timeBeforeShiftEnd);
                    sim.Keyboard.KeyUp(VirtualKeyCode.SHIFT);
                    break;
                case '№':
                    sim.Keyboard.KeyDown(VirtualKeyCode.SHIFT);
                    sim.Keyboard.Sleep(timeAfterShift);
                    sim.Keyboard.KeyDown(VirtualKeyCode.VK_3);
                    sim.Keyboard.Sleep(rndsleep);
                    sim.Keyboard.KeyUp(VirtualKeyCode.VK_3);
                    sim.Keyboard.Sleep(timeBeforeShiftEnd);
                    sim.Keyboard.KeyUp(VirtualKeyCode.SHIFT);
                    break;
                case ';':
                    sim.Keyboard.KeyDown(VirtualKeyCode.SHIFT);
                    sim.Keyboard.Sleep(timeAfterShift);
                    sim.Keyboard.KeyDown(VirtualKeyCode.VK_4);
                    sim.Keyboard.Sleep(rndsleep);
                    sim.Keyboard.KeyUp(VirtualKeyCode.VK_4);
                    sim.Keyboard.Sleep(timeBeforeShiftEnd);
                    sim.Keyboard.KeyUp(VirtualKeyCode.SHIFT);
                    break;
                case '%':
                    sim.Keyboard.KeyDown(VirtualKeyCode.SHIFT);
                    sim.Keyboard.Sleep(timeAfterShift);
                    sim.Keyboard.KeyDown(VirtualKeyCode.VK_5);
                    sim.Keyboard.Sleep(rndsleep);
                    sim.Keyboard.KeyUp(VirtualKeyCode.VK_5);
                    sim.Keyboard.Sleep(timeBeforeShiftEnd);
                    sim.Keyboard.KeyUp(VirtualKeyCode.SHIFT);
                    break;
                case ':':
                    sim.Keyboard.KeyDown(VirtualKeyCode.SHIFT);
                    sim.Keyboard.Sleep(timeAfterShift);
                    sim.Keyboard.KeyDown(VirtualKeyCode.VK_6);
                    sim.Keyboard.Sleep(rndsleep);
                    sim.Keyboard.KeyUp(VirtualKeyCode.VK_6);
                    sim.Keyboard.Sleep(timeBeforeShiftEnd);
                    sim.Keyboard.KeyUp(VirtualKeyCode.SHIFT);
                    break;  
                case '?':
                    sim.Keyboard.KeyDown(VirtualKeyCode.SHIFT);
                    sim.Keyboard.Sleep(timeAfterShift);
                    sim.Keyboard.KeyDown(VirtualKeyCode.VK_7);
                    sim.Keyboard.Sleep(rndsleep);
                    sim.Keyboard.KeyUp(VirtualKeyCode.VK_7);
                    sim.Keyboard.Sleep(timeBeforeShiftEnd);
                    sim.Keyboard.KeyUp(VirtualKeyCode.SHIFT);
                    break;
                case '*':
                    sim.Keyboard.KeyDown(VirtualKeyCode.SHIFT);
                    sim.Keyboard.Sleep(timeAfterShift);
                    sim.Keyboard.KeyDown(VirtualKeyCode.VK_8);
                    sim.Keyboard.Sleep(rndsleep);
                    sim.Keyboard.KeyUp(VirtualKeyCode.VK_8);
                    sim.Keyboard.Sleep(timeBeforeShiftEnd);
                    sim.Keyboard.KeyUp(VirtualKeyCode.SHIFT);
                    break;
                case '(':
                    sim.Keyboard.KeyDown(VirtualKeyCode.SHIFT);
                    sim.Keyboard.Sleep(timeAfterShift);
                    sim.Keyboard.KeyDown(VirtualKeyCode.VK_9);
                    sim.Keyboard.Sleep(rndsleep);
                    sim.Keyboard.KeyUp(VirtualKeyCode.VK_9);
                    sim.Keyboard.Sleep(timeBeforeShiftEnd);
                    sim.Keyboard.KeyUp(VirtualKeyCode.SHIFT);
                    break;
                case ')':
                    sim.Keyboard.KeyDown(VirtualKeyCode.SHIFT);
                    sim.Keyboard.Sleep(timeAfterShift);
                    sim.Keyboard.KeyDown(VirtualKeyCode.VK_0);
                    sim.Keyboard.Sleep(rndsleep);
                    sim.Keyboard.KeyUp(VirtualKeyCode.VK_0);
                    sim.Keyboard.Sleep(timeBeforeShiftEnd);
                    sim.Keyboard.KeyUp(VirtualKeyCode.SHIFT);
                    break;
                case '-':
                    sim.Keyboard.KeyDown(VirtualKeyCode.OEM_MINUS);
                    sim.Keyboard.Sleep(rndsleep);
                    sim.Keyboard.KeyUp(VirtualKeyCode.OEM_MINUS);
                    break;

                case '=':
                    sim.Keyboard.KeyDown(VirtualKeyCode.OEM_PLUS);
                    sim.Keyboard.Sleep(rndsleep);
                    sim.Keyboard.KeyUp(VirtualKeyCode.OEM_PLUS);
                    break;
                case '+':
                    sim.Keyboard.KeyDown(VirtualKeyCode.SHIFT);
                    sim.Keyboard.Sleep(timeAfterShift);
                    sim.Keyboard.KeyDown(VirtualKeyCode.OEM_PLUS);
                    sim.Keyboard.Sleep(rndsleep);
                    sim.Keyboard.KeyUp(VirtualKeyCode.OEM_PLUS);
                    sim.Keyboard.Sleep(timeBeforeShiftEnd);
                    sim.Keyboard.KeyUp(VirtualKeyCode.SHIFT);
                    break;

                #endregion

                //1234567890

                #region 1234567890
                case '1':
                    KeyType(VirtualKeyCode.VK_1);
                    break;
                case '2':
                    KeyType(VirtualKeyCode.VK_2);
                    break;
                case '3':
                    KeyType(VirtualKeyCode.VK_3);
                    break;
                case '4':
                    KeyType(VirtualKeyCode.VK_4);
                    break;
                case '5':
                    KeyType(VirtualKeyCode.VK_5);
                    break;
                case '6':
                    KeyType(VirtualKeyCode.VK_6);
                    break;
                case '7':
                    KeyType(VirtualKeyCode.VK_7);
                    break;
                case '8':
                    KeyType(VirtualKeyCode.VK_8);
                    break;
                case '9':
                    KeyType(VirtualKeyCode.VK_9);
                    break;
                case '0':
                    KeyType(VirtualKeyCode.VK_0);
                    break;

                #endregion


                default:
                    KeyType(VirtualKeyCode.VK_G);
                    break;
            }
        }
        
        /*
        public void AssistTypeWordUnRegister(bool shift = false)
        {
            HookManager.KeyDown += (s, e) =>
            {
                switch (e.KeyCode)
                {
                    case Keys.Space:
                        e.Handled = false;
                        break;
                    case Keys.Oem3: //ё, `
                        e.Handled = false;
                        break;
                }

            };
            HookManager.KeyUp += (s, e) =>
            {
                switch (e.KeyCode)
                {
                    case Keys.Space:
                        e.Handled = false;
                        break;
                    case Keys.Oem3:
                        e.Handled = false;
                        break;
                }

            };
        }
        */
        public void AssistTypeWordRegister(bool shift = false)
        {
            if (!VM.AssistTypeRegistered)
            {
                VM.AssistTypeRegistered = true;
                HookManager.KeyDown += (s, e) =>
                {
                    switch (e.KeyCode)
                    {
                        case Keys.Space:
                            e.Handled = VM.EHandled;
                            VM.ViewModel_OnTypeEvent();
                            break;
                        case Keys.Oem3:
                            e.Handled = VM.EHandled;
                            VM.ViewModel_OnTypeEvent();
                            break;

                        //йцукенгшщзхъфывапролджэячсмитьбю.\/,!"№;%:?*()-=+ЙЦУКЕНГШЩЗХЪФЫВАПРОЛДЖЭЯЧСМИТЬБЮ

                        //йцукенгшщзхъ
                        #region верхний ряд
                        case Keys.Q:
                            e.Handled = VM.EHandled;
                            VM.ViewModel_OnTypeEvent();
                            break;
                        case Keys.W:
                            e.Handled = VM.EHandled;
                            VM.ViewModel_OnTypeEvent();
                            break;
                        case Keys.E:
                            e.Handled = VM.EHandled;
                            VM.ViewModel_OnTypeEvent();
                            break;
                        case Keys.R:
                            e.Handled = VM.EHandled;
                            VM.ViewModel_OnTypeEvent();
                            break;
                        case Keys.T:
                            e.Handled = VM.EHandled;
                            VM.ViewModel_OnTypeEvent();
                            break;
                        case Keys.Y:
                            e.Handled = VM.EHandled;
                            VM.ViewModel_OnTypeEvent();
                            break;
                        case Keys.U:
                            e.Handled = VM.EHandled;
                            VM.ViewModel_OnTypeEvent();
                            break;
                        case Keys.I:
                            e.Handled = VM.EHandled;
                            VM.ViewModel_OnTypeEvent();
                            break;
                        case Keys.O:
                            e.Handled = VM.EHandled;
                            VM.ViewModel_OnTypeEvent();
                            break;
                        case Keys.P:
                            e.Handled = VM.EHandled;
                            VM.ViewModel_OnTypeEvent();
                            break;
                        case Keys.Oem4:
                            e.Handled = VM.EHandled;
                            VM.ViewModel_OnTypeEvent();
                            break;
                        case Keys.Oem6:
                            e.Handled = VM.EHandled;
                            VM.ViewModel_OnTypeEvent();
                            break;
                        #endregion
                        //фывапролджэ
                        #region средний ряд
                        case Keys.A:
                            e.Handled = VM.EHandled;
                            VM.ViewModel_OnTypeEvent();
                            break;
                        case Keys.S:
                            e.Handled = VM.EHandled;
                            VM.ViewModel_OnTypeEvent();
                            break;
                        case Keys.D:
                            e.Handled = VM.EHandled;
                            VM.ViewModel_OnTypeEvent();
                            break;
                        case Keys.F:
                            e.Handled = VM.EHandled;
                            VM.ViewModel_OnTypeEvent();
                            break;
                        case Keys.G:
                            e.Handled = VM.EHandled;
                            VM.ViewModel_OnTypeEvent();
                            break;
                        case Keys.H:
                            e.Handled = VM.EHandled;
                            VM.ViewModel_OnTypeEvent();
                            break;
                        case Keys.J:
                            e.Handled = VM.EHandled;
                            VM.ViewModel_OnTypeEvent();
                            break;
                        case Keys.K:
                            e.Handled = VM.EHandled;
                            VM.ViewModel_OnTypeEvent();
                            break;
                        case Keys.L:
                            e.Handled = VM.EHandled;
                            VM.ViewModel_OnTypeEvent();
                            break;
                        case Keys.Oem1:
                            e.Handled = VM.EHandled;
                            VM.ViewModel_OnTypeEvent();
                            break;
                        case Keys.Oem7:
                            e.Handled = VM.EHandled;
                            VM.ViewModel_OnTypeEvent();
                            break;
                        #endregion
                        //ФЫВАПРОЛДЖЭ

                        //ячсмитьбю
                        #region нижний ряд
                        case Keys.Z:
                            e.Handled = VM.EHandled;
                            VM.ViewModel_OnTypeEvent();
                            break;
                        case Keys.X:
                            e.Handled = VM.EHandled;
                            VM.ViewModel_OnTypeEvent();
                            break;
                        case Keys.C:
                            e.Handled = VM.EHandled;
                            VM.ViewModel_OnTypeEvent();
                            break;
                        case Keys.V:
                            e.Handled = VM.EHandled;
                            VM.ViewModel_OnTypeEvent();
                            break;
                        case Keys.B:
                            e.Handled = VM.EHandled;
                            VM.ViewModel_OnTypeEvent();
                            break;
                        case Keys.N:
                            e.Handled = VM.EHandled;
                            VM.ViewModel_OnTypeEvent();
                            break;
                        case Keys.M:
                            e.Handled = VM.EHandled;
                            VM.ViewModel_OnTypeEvent();
                            break;
                        case Keys.Oemcomma:
                            e.Handled = VM.EHandled;
                            VM.ViewModel_OnTypeEvent();
                            break;
                        case Keys.OemPeriod:
                            e.Handled = VM.EHandled;
                            VM.ViewModel_OnTypeEvent();
                            break;
                        #endregion

                        #region \/,.

                        case Keys.Oem5:
                            e.Handled = VM.EHandled;
                            VM.ViewModel_OnTypeEvent();
                            break;
                        case Keys.Oem2:
                            e.Handled = VM.EHandled;
                            VM.ViewModel_OnTypeEvent();
                            break;
                        #endregion

                        //!"№;%:?*()-=+

                        #region !"№;%:?*()-=+
                        case Keys.D1:
                            e.Handled = VM.EHandled;
                            VM.ViewModel_OnTypeEvent();
                            break;
                        case Keys.D2:
                            e.Handled = VM.EHandled;
                            VM.ViewModel_OnTypeEvent();
                            break;
                        case Keys.D3:
                            e.Handled = VM.EHandled;
                            VM.ViewModel_OnTypeEvent();
                            break;
                        case Keys.D4:
						    e.Handled = VM.EHandled;
                            VM.ViewModel_OnTypeEvent();
                            break;
                        case Keys.D5:
                            e.Handled = VM.EHandled;
                            VM.ViewModel_OnTypeEvent();
                            break;
                        case Keys.D6:
                            e.Handled = VM.EHandled;
                            VM.ViewModel_OnTypeEvent();
                            break;
                        case Keys.D7:
                            e.Handled = VM.EHandled;
                            VM.ViewModel_OnTypeEvent();
                            break;
                        case Keys.D8:
                            e.Handled = VM.EHandled;
                            VM.ViewModel_OnTypeEvent();
                            break;
                        case Keys.D9:
                            e.Handled = VM.EHandled;
                            VM.ViewModel_OnTypeEvent();
                            break;
                        case Keys.D0:
                            e.Handled = VM.EHandled;
                            VM.ViewModel_OnTypeEvent();
                            break;
                        case Keys.OemMinus:
                            e.Handled = VM.EHandled;
                            VM.ViewModel_OnTypeEvent();
                            break;
                        case Keys.Oemplus:
                            e.Handled = VM.EHandled;
                            VM.ViewModel_OnTypeEvent();
                            break;
                            #endregion
                    }

                };
                HookManager.KeyUp += (s, e) =>
                {
                    switch (e.KeyCode)
                    {
                        case Keys.Space:
                            e.Handled = VM.EHandledUp;
                            TypeNextWordUp();
                            break;
                        case Keys.Oem3:
                            e.Handled = VM.EHandledUp;
                            TypeNextWordUp();
                            break;

                        //йцукенгшщзхъфывапролджэячсмитьбю.\/,!"№;%:?*()-=+ЙЦУКЕНГШЩЗХЪФЫВАПРОЛДЖЭЯЧСМИТЬБЮ

                        //йцукенгшщзхъ
                        #region верхний ряд
                        case Keys.Q:
                            e.Handled = VM.EHandledUp;
                            TypeNextWordUp();
                            break;
                        case Keys.W:
                            e.Handled = VM.EHandledUp;
                            TypeNextWordUp();
                            break;
                        case Keys.E:
                            e.Handled = VM.EHandledUp;
                            TypeNextWordUp();
                            break;
                        case Keys.R:
                            e.Handled = VM.EHandledUp;
                            TypeNextWordUp();
                            break;
                        case Keys.T:
                            e.Handled = VM.EHandledUp;
                            TypeNextWordUp();
                            break;
                        case Keys.Y:
                            e.Handled = VM.EHandledUp;
                            TypeNextWordUp();
                            break;
                        case Keys.U:
                            e.Handled = VM.EHandledUp;
                            TypeNextWordUp();
                            break;
                        case Keys.I:
                            e.Handled = VM.EHandledUp;
                            TypeNextWordUp();
                            break;
                        case Keys.O:
                            e.Handled = VM.EHandledUp;
                            TypeNextWordUp();
                            break;
                        case Keys.P:
                            e.Handled = VM.EHandledUp;
                            TypeNextWordUp();
                            break;
                        case Keys.Oem4:
                            e.Handled = VM.EHandledUp;
                            TypeNextWordUp();
                            break;
                        case Keys.Oem6:
                            e.Handled = VM.EHandledUp;
                            TypeNextWordUp();
                            break;
                        #endregion
                        //фывапролджэ
                        #region средний ряд
                        case Keys.A:
                            e.Handled = VM.EHandledUp;
                            TypeNextWordUp();
                            break;
                        case Keys.S:
                            e.Handled = VM.EHandledUp;
                            TypeNextWordUp();
                            break;
                        case Keys.D:
                            e.Handled = VM.EHandledUp;
                            TypeNextWordUp();
                            break;
                        case Keys.F:
                            e.Handled = VM.EHandledUp;
                            TypeNextWordUp();
                            break;
                        case Keys.G:
                            e.Handled = VM.EHandledUp;
                            TypeNextWordUp();
                            break;
                        case Keys.H:
                            e.Handled = VM.EHandledUp;
                            TypeNextWordUp();
                            break;
                        case Keys.J:
                            e.Handled = VM.EHandledUp;
                            TypeNextWordUp();
                            break;
                        case Keys.K:
                            e.Handled = VM.EHandledUp;
                            TypeNextWordUp();
                            break;
                        case Keys.L:
                            e.Handled = VM.EHandledUp;
                            TypeNextWordUp();
                            break;
                        case Keys.Oem1:
                            e.Handled = VM.EHandledUp;
                            TypeNextWordUp();
                            break;
                        case Keys.Oem7:
                            e.Handled = VM.EHandledUp;
                            TypeNextWordUp();
                            break;
                        #endregion
                        //ФЫВАПРОЛДЖЭ

                        //ячсмитьбю
                        #region нижний ряд
                        case Keys.Z:
                            e.Handled = VM.EHandledUp;
                            TypeNextWordUp();
                            break;
                        case Keys.X:
                            e.Handled = VM.EHandledUp;
                            TypeNextWordUp();
                            break;
                        case Keys.C:
                            e.Handled = VM.EHandledUp;
                            TypeNextWordUp();
                            break;
                        case Keys.V:
                            e.Handled = VM.EHandledUp;
                            TypeNextWordUp();
                            break;
                        case Keys.B:
                            e.Handled = VM.EHandledUp;
                            TypeNextWordUp();
                            break;
                        case Keys.N:
                            e.Handled = VM.EHandledUp;
                            TypeNextWordUp();
                            break;
                        case Keys.M:
                            e.Handled = VM.EHandledUp;
                            TypeNextWordUp();
                            break;
                        case Keys.Oemcomma:
                            e.Handled = VM.EHandledUp;
                            TypeNextWordUp();
                            break;
                        case Keys.OemPeriod:
                            e.Handled = VM.EHandledUp;
                            TypeNextWordUp();
                            break;
                        #endregion

                        #region \/,.

                        case Keys.Oem5:
                            e.Handled = VM.EHandledUp;
                            TypeNextWordUp();
                            break;
                        case Keys.Oem2:
                            e.Handled = VM.EHandledUp;
                            TypeNextWordUp();
                            break;
                        #endregion

                        //!"№;%:?*()-=+

                        #region !"№;%:?*()-=+
                        case Keys.D1:
                            e.Handled = VM.EHandledUp;
                            TypeNextWordUp();
                            break;
                        case Keys.D2:
                            e.Handled = VM.EHandledUp;
                            TypeNextWordUp();
                            break;
                        case Keys.D3:
                            e.Handled = VM.EHandledUp;
                            TypeNextWordUp();
                            break;
                        case Keys.D4:
                            e.Handled = VM.EHandledUp;
                            TypeNextWordUp();
                            break;
                        case Keys.D5:
                            e.Handled = VM.EHandledUp;
                            TypeNextWordUp();
                            break;
                        case Keys.D6:
                            e.Handled = VM.EHandledUp;
                            TypeNextWordUp();
                            break;
                        case Keys.D7:
                            e.Handled = VM.EHandledUp;
                            TypeNextWordUp();
                            break;
                        case Keys.D8:
                            e.Handled = VM.EHandledUp;
                            TypeNextWordUp();
                            break;
                        case Keys.D9:
                            e.Handled = VM.EHandledUp;
                            TypeNextWordUp();
                            break;
                        case Keys.D0:
                            e.Handled = VM.EHandledUp;
                            TypeNextWordUp();
                            break;
                        case Keys.OemMinus:
                            e.Handled = VM.EHandledUp;
                            TypeNextWordUp();
                            break;
                        case Keys.Oemplus:
                            e.Handled = VM.EHandledUp;
                            TypeNextWordUp();
                            break;
                            #endregion
                    }


                };
            }
        }
        public void TypeNextWord(bool shift = false, int rndval = 150, bool waiting = false)
        {
            int rndsleep = rnd.Next(100 ^ (1 / 4) * 6, 100 ^ (1 / 4) * 9);
            const char V = '\\';
            int timeAfterShift = rndsleep/2;
            int timeBeforeShiftEnd = rndsleep / 4;
            WordKeyTypeDown();
            void WordKeyTypeDown()
            {
                VM.NextWordNumber++;
                VM.EHandled = false;
                switch (VM.NextWord)
                {
                    case ' ':
                        KeyTypeDown(VirtualKeyCode.SPACE);
                        break;
                    case 'ё':
                        KeyTypeDown(VirtualKeyCode.OEM_3);
                        break;

                    //йцукенгшщзхъфывапролджэячсмитьбю.\/,!"№;%:?*()-=+ЙЦУКЕНГШЩЗХЪФЫВАПРОЛДЖЭЯЧСМИТЬБЮ

                    //йцукенгшщзхъ
                    #region верхний ряд
                    case 'й':
                        KeyTypeDown(VirtualKeyCode.VK_Q);
                        break;
                    case 'ц':
                        KeyTypeDown(VirtualKeyCode.VK_W);
                        break;
                    case 'у':
                        KeyTypeDown(VirtualKeyCode.VK_E);
                        break;
                    case 'к':
                        KeyTypeDown(VirtualKeyCode.VK_R);
                        break;
                    case 'е':
                        KeyTypeDown(VirtualKeyCode.VK_T);
                        break;
                    case 'н':
                        KeyTypeDown(VirtualKeyCode.VK_Y);
                        break;
                    case 'г':
                        KeyTypeDown(VirtualKeyCode.VK_U);
                        break;
                    case 'ш':
                        KeyTypeDown(VirtualKeyCode.VK_I);
                        break;
                    case 'щ':
                        KeyTypeDown(VirtualKeyCode.VK_O);
                        break;
                    case 'з':
                        KeyTypeDown(VirtualKeyCode.VK_P);
                        break;
                    case 'х':
                        KeyTypeDown(VirtualKeyCode.OEM_4);
                        break;
                    case 'ъ':
                        KeyTypeDown(VirtualKeyCode.OEM_6);
                        break;
                    #endregion
                    //ЙЦУКЕНГШЩЗХЪ
                    #region ВЕРХНИЙ РЯД (прописные)
                    case 'Й':
                        KeyTypeDown(VirtualKeyCode.VK_Q,true);
                        break;
                    case 'Ц':
                        KeyTypeDown(VirtualKeyCode.VK_W, true);
                        break;
                    case 'У':
                        KeyTypeDown(VirtualKeyCode.VK_E, true);
                        break;
                    case 'К':
                        KeyTypeDown(VirtualKeyCode.VK_R, true);
                        break;
                    case 'Е':
                        KeyTypeDown(VirtualKeyCode.VK_T, true);
                        break;
                    case 'Н':
                        KeyTypeDown(VirtualKeyCode.VK_Y, true);
                        break;
                    case 'Г':
                        KeyTypeDown(VirtualKeyCode.VK_U, true);
                        break;
                    case 'Ш':
                        KeyTypeDown(VirtualKeyCode.VK_I, true);
                        break;
                    case 'Щ':
                        KeyTypeDown(VirtualKeyCode.VK_O, true);
                        break;
                    case 'З':
                        KeyTypeDown(VirtualKeyCode.VK_P, true);
                        break;
                    case 'Х':
                        KeyTypeDown(VirtualKeyCode.OEM_4, true);
                        break;
                    case 'Ъ':
                        KeyTypeDown(VirtualKeyCode.OEM_6, true);
                        break;
                    #endregion

                    //фывапролджэ
                    #region средний ряд
                    case 'ф':
                        KeyTypeDown(VirtualKeyCode.VK_A);
                        break;
                    case 'ы':
                        KeyTypeDown(VirtualKeyCode.VK_S);
                        break;
                    case 'в':
                        KeyTypeDown(VirtualKeyCode.VK_D);
                        break;
                    case 'а':
                        KeyTypeDown(VirtualKeyCode.VK_F);
                        break;
                    case 'п':
                        KeyTypeDown(VirtualKeyCode.VK_G);
                        break;
                    case 'р':
                        KeyTypeDown(VirtualKeyCode.VK_H);
                        break;
                    case 'о':
                        KeyTypeDown(VirtualKeyCode.VK_J);
                        break;
                    case 'л':
                        KeyTypeDown(VirtualKeyCode.VK_K);
                        break;
                    case 'д':
                        KeyTypeDown(VirtualKeyCode.VK_L);
                        break;
                    case 'ж':
                        KeyTypeDown(VirtualKeyCode.OEM_1);
                        break;
                    case 'э':
                        KeyTypeDown(VirtualKeyCode.OEM_7);
                        break;
                    #endregion
                    //ФЫВАПРОЛДЖЭ
                    #region СРЕДНИЙ РЯД (ПРОПИСНЫЕ)
                    case 'Ф':
                        KeyTypeDown(VirtualKeyCode.VK_A, true);
                        break;
                    case 'Ы':
                        KeyTypeDown(VirtualKeyCode.VK_S, true);
                        break;
                    case 'В':
                        KeyTypeDown(VirtualKeyCode.VK_D, true);
                        break;
                    case 'А':
                        KeyTypeDown(VirtualKeyCode.VK_F, true);
                        break;
                    case 'П':
                        KeyTypeDown(VirtualKeyCode.VK_G, true);
                        break;
                    case 'Р':
                        KeyTypeDown(VirtualKeyCode.VK_H, true);
                        break;
                    case 'О':
                        KeyTypeDown(VirtualKeyCode.VK_J, true);
                        break;
                    case 'Л':
                        KeyTypeDown(VirtualKeyCode.VK_K, true);
                        break;
                    case 'Д':
                        KeyTypeDown(VirtualKeyCode.VK_L, true);
                        break;
                    case 'Ж':
                        KeyTypeDown(VirtualKeyCode.OEM_1, true);
                        break;
                    case 'Э':
                        KeyTypeDown(VirtualKeyCode.OEM_7, true);
                        break;
                    #endregion


                    //ячсмитьбю
                    #region нижний ряд
                    case 'я':
                        KeyTypeDown(VirtualKeyCode.VK_Z);
                        break;
                    case 'ч':
                        KeyTypeDown(VirtualKeyCode.VK_X);
                        break;
                    case 'с':
                        KeyTypeDown(VirtualKeyCode.VK_C);
                        break;
                    case 'м':
                        KeyTypeDown(VirtualKeyCode.VK_V);
                        break;
                    case 'и':
                        KeyTypeDown(VirtualKeyCode.VK_B);
                        break;
                    case 'т':
                        KeyTypeDown(VirtualKeyCode.VK_N);
                        break;
                    case 'ь':
                        KeyTypeDown(VirtualKeyCode.VK_M);
                        break;
                    case 'б':
                        KeyTypeDown(VirtualKeyCode.OEM_COMMA);
                        break;
                    case 'ю':
                        KeyTypeDown(VirtualKeyCode.OEM_PERIOD);
                        break;
                    #endregion
                    //ЯЧСМИТЬБЮ
                    #region НИЖНИЙ РЯД (ПРОПИСНЫЕ)
                    case 'Я':
                        KeyTypeDown(VirtualKeyCode.VK_Z, true);
                        break;
                    case 'Ч':
                        KeyTypeDown(VirtualKeyCode.VK_X, true);
                        break;
                    case 'С':
                        KeyTypeDown(VirtualKeyCode.VK_C, true);
                        break;
                    case 'М':
                        KeyTypeDown(VirtualKeyCode.VK_V, true);
                        break;
                    case 'И':
                        KeyTypeDown(VirtualKeyCode.VK_B, true);
                        break;
                    case 'Т':
                        KeyTypeDown(VirtualKeyCode.VK_N, true);
                        break;
                    case 'Ь':
                        KeyTypeDown(VirtualKeyCode.VK_M, true);
                        break;
                    case 'Б':
                        KeyTypeDown(VirtualKeyCode.OEM_COMMA, true);
                        break;
                    case 'Ю':
                        KeyTypeDown(VirtualKeyCode.OEM_PERIOD, true);
                        break;
                    #endregion

                    #region \/,.
                    case V: //V = "\"
                        KeyTypeDown(VirtualKeyCode.OEM_5);
                        break;
                    case '/':
                        KeyTypeDown(VirtualKeyCode.OEM_5, true);
                        break;
                    case ',':
                        KeyTypeDown(VirtualKeyCode.OEM_2,true);
                        break;
                    case '.':
                        KeyTypeDown(VirtualKeyCode.OEM_2);
                        break;
                    #endregion

                    //!"№;%:?*()-=+

                    #region !"№;%:?*()-=+
                    case '!':
                        KeyTypeDown(VirtualKeyCode.VK_1, true);
                        break;
                    case '"':
                        KeyTypeDown(VirtualKeyCode.VK_2, true);
                        break;
                    case '№':
                        KeyTypeDown(VirtualKeyCode.VK_3, true);
                        break;
                    case ';':
                        KeyTypeDown(VirtualKeyCode.VK_4, true);
                        break;
                    case '%':
                        KeyTypeDown(VirtualKeyCode.VK_5, true);
                        break;
                    case ':':
                        KeyTypeDown(VirtualKeyCode.VK_6, true);
                        break;
                    case '?':
                        KeyTypeDown(VirtualKeyCode.VK_7, true);
                        break;
                    case '*':
                        KeyTypeDown(VirtualKeyCode.VK_8, true);
                        break;
                    case '(':
                        KeyTypeDown(VirtualKeyCode.VK_9, true);
                        break;
                    case ')':
                        KeyTypeDown(VirtualKeyCode.VK_0, true);
                        break;
                    case '-':
                        KeyTypeDown(VirtualKeyCode.OEM_MINUS);
                        break;
                    case '=':
                        KeyTypeDown(VirtualKeyCode.OEM_PLUS);
                        break;
                    case '+':
                        KeyTypeDown(VirtualKeyCode.OEM_PLUS, true);
                        break;

                    #endregion

                    //1234567890

                    #region 1234567890
                    case '1':
                        KeyTypeDown(VirtualKeyCode.VK_1);
                        break;
                    case '2':
                        KeyTypeDown(VirtualKeyCode.VK_2);
                        break;
                    case '3':
                        KeyTypeDown(VirtualKeyCode.VK_3);
                        break;
                    case '4':
                        KeyTypeDown(VirtualKeyCode.VK_4);
                        break;
                    case '5':
                        KeyTypeDown(VirtualKeyCode.VK_5);
                        break;
                    case '6':
                        KeyTypeDown(VirtualKeyCode.VK_6);
                        break;
                    case '7':
                        KeyTypeDown(VirtualKeyCode.VK_7);
                        break;
                    case '8':
                        KeyTypeDown(VirtualKeyCode.VK_8);
                        break;
                    case '9':
                        KeyTypeDown(VirtualKeyCode.VK_9);
                        break;
                    case '0':
                        KeyTypeDown(VirtualKeyCode.VK_0);
                        break;

                    #endregion

                    default:
                        KeyTypeDown(VirtualKeyCode.VK_G);
                        break;
                }
            }
            void KeyTypeDown(VirtualKeyCode key, bool shifted = false)
            {
                if (shifted&&VM.Shifted)
                {
                    sim.Keyboard.KeyDown(VirtualKeyCode.SHIFT);
                    sim.Keyboard.Sleep(timeAfterShift);
                    sim.Keyboard.KeyDown(key);
                    VM.EHandledUp = false;
                    sim.Keyboard.Sleep(rndsleep);

                    sim.Keyboard.KeyUp(key);
                    
                    sim.Keyboard.Sleep(timeBeforeShiftEnd);  
                    sim.Keyboard.KeyUp(VirtualKeyCode.SHIFT);
                    VM.EHandledUp = true;
                    VM.EHandled = true;


                }
                else
                {
                    sim.Keyboard.KeyDown(key);
                    sim.Keyboard.Sleep(rndsleep);
                    VM.EHandledUp = false;
                    sim.Keyboard.KeyUp(key);
                    VM.EHandled = true; VM.EHandledUp = true;
                }
                
            }

        }
        public void TypeNextWordUp()
        {
            //VM.EHandled = false;

            if(false)
            if (!VM.AssistFinished)
            {
                VM.TypeAllowedChangeUp();
                if (VM.TypeAllowed)
                {
                    
                    const char V = '\\';
                    WordKeyTypeUp();
                    void WordKeyTypeUp()
                    {
                        VM.EHandledUp = false;
                        switch (VM.NextWord)
                        {
                            case ' ':
                                KeyTypeUp(VirtualKeyCode.SPACE);
                                break;
                            case 'ё':
                                KeyTypeUp(VirtualKeyCode.OEM_3);
                                break;

                            //йцукенгшщзхъфывапролджэячсмитьбю.\/,!"№;%:?*()-=+ЙЦУКЕНГШЩЗХЪФЫВАПРОЛДЖЭЯЧСМИТЬБЮ

                            //йцукенгшщзхъ
                            #region верхний ряд
                            case 'й':
                                KeyTypeUp(VirtualKeyCode.VK_Q);
                                break;
                            case 'ц':
                                KeyTypeUp(VirtualKeyCode.VK_W);
                                break;
                            case 'у':
                                KeyTypeUp(VirtualKeyCode.VK_E);
                                break;
                            case 'к':
                                KeyTypeUp(VirtualKeyCode.VK_R);
                                break;
                            case 'е':
                                KeyTypeUp(VirtualKeyCode.VK_T);
                                break;
                            case 'н':
                                KeyTypeUp(VirtualKeyCode.VK_Y);
                                break;
                            case 'г':
                                KeyTypeUp(VirtualKeyCode.VK_U);
                                break;
                            case 'ш':
                                KeyTypeUp(VirtualKeyCode.VK_I);
                                break;
                            case 'щ':
                                KeyTypeUp(VirtualKeyCode.VK_O);
                                break;
                            case 'з':
                                KeyTypeUp(VirtualKeyCode.VK_P);
                                break;
                            case 'х':
                                KeyTypeUp(VirtualKeyCode.OEM_4);
                                break;
                            case 'ъ':
                                KeyTypeUp(VirtualKeyCode.OEM_6);
                                break;
                            #endregion
                            //ЙЦУКЕНГШЩЗХЪ
                            #region ВЕРХНИЙ РЯД (прописные)
                            case 'Й':
                                KeyTypeUp(VirtualKeyCode.VK_Q);
                                break;
                            case 'Ц':
                                KeyTypeUp(VirtualKeyCode.VK_W);
                                break;
                            case 'У':
                                KeyTypeUp(VirtualKeyCode.VK_E);
                                break;
                            case 'К':
                                KeyTypeUp(VirtualKeyCode.VK_R);
                                break;
                            case 'Е':
                                KeyTypeUp(VirtualKeyCode.VK_T);
                                break;
                            case 'Н':
                                KeyTypeUp(VirtualKeyCode.VK_Y);
                                break;
                            case 'Г':
                                KeyTypeUp(VirtualKeyCode.VK_U);
                                break;
                            case 'Ш':
                                KeyTypeUp(VirtualKeyCode.VK_I);
                                break;
                            case 'Щ':
                                KeyTypeUp(VirtualKeyCode.VK_O);
                                break;
                            case 'З':
                                KeyTypeUp(VirtualKeyCode.VK_P);
                                break;
                            case 'Х':
                                KeyTypeUp(VirtualKeyCode.OEM_4);
                                break;
                            case 'Ъ':
                                KeyTypeUp(VirtualKeyCode.OEM_6);
                                break;
                                #endregion
                        }
                        VM.EHandledUp = true;
                    }
                    void KeyTypeUp(VirtualKeyCode key)
                    {
                        sim.Keyboard.KeyUp(key);
                    }
                }
            }
        }
        public ViewModel VM;
        public CheckChars(ViewModel _vm) { VM = _vm; }
    }
}
