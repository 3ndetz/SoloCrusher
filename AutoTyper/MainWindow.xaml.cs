using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Microsoft.Win32;
//using TaskBarTasks;

namespace AutoTyper
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
			CompId.Text = "ID вашего компьютера: "+GetUniqueId.UniqueHardwaeId;
			if (GetUniqueId.CheckIdActivation(GetUniqueId.UniqueHardwaeId))
			{
				TextActivateR2.Text = "Приложение зарегистрировано!";
				TextActivateR3.Text = "Больше ничего делать не надо," +
					" можешь использовать БРОООООООО (спс за 100$ БРОО я их конечно" +
					" же отправлю на благотварительнасть)";
				ActivateToolTip.Background = Brushes.LimeGreen;
				CompId.Background = Brushes.LimeGreen;
				ViewModel VM = new ViewModel();
				CheckChars check = new CheckChars(VM);
				VM.check = check;
				DataContext = VM;
            }
            else
            {
				TextActivateR1.Text = "здорова тцпица!!!!";
				TextActivateR2.Text = "Приложение не зарегистрировано!!!!!";
				TextActivateR3.Text = "пшол уййй отсюда мы закрыты" +
					" ладно шучу плати автору 100к" +
					" потом отдавай свою машину квартиру ЖЕНУ " + "и может быть я ради тебя исключительно ПО ДОБРОТЕ ДУШЕВНОЙ" + 
					"активирую приложуху =) По делу: Если че, этот id свой ты должен мне отправить, после чего я " +
					"зарегистрирую тебя в нашей НОВЕЙШЕЙ как твой новый батя системе.";
				ActivateToolTip.Background = Brushes.Red;
				CompId.Background = Brushes.Red;
			}
			cmbFontFamily.ItemsSource = Fonts.SystemFontFamilies.OrderBy(f => f.Source);
			cmbFontSize.ItemsSource = new List<double>() { 8, 9, 10, 11, 12, 14, 16, 18, 20, 22, 24, 26, 28, 36, 48, 72 };
		}
		//void OnPreviewKeyDown(object sender, KeyEventArgs e)
		//{
		//    var key = e.Key;
		//    if (key == Key.A)
		//        e.Handled = true;
		//}

		private void rtbEditor_SelectionChanged(object sender, RoutedEventArgs e)
		{
			object temp = rtbEditor.Selection.GetPropertyValue(Inline.FontWeightProperty);
			btnBold.IsChecked = (temp != DependencyProperty.UnsetValue) && (temp.Equals(FontWeights.Bold));
			temp = rtbEditor.Selection.GetPropertyValue(Inline.FontStyleProperty);
			btnItalic.IsChecked = (temp != DependencyProperty.UnsetValue) && (temp.Equals(FontStyles.Italic));
			temp = rtbEditor.Selection.GetPropertyValue(Inline.TextDecorationsProperty);
			btnUnderline.IsChecked = (temp != DependencyProperty.UnsetValue) && (temp.Equals(TextDecorations.Underline));

			temp = rtbEditor.Selection.GetPropertyValue(Inline.FontFamilyProperty);
			cmbFontFamily.SelectedItem = temp;
			temp = rtbEditor.Selection.GetPropertyValue(Inline.FontSizeProperty);
			cmbFontSize.Text = temp.ToString();
		}

		private void Open_Executed(object sender, ExecutedRoutedEventArgs e)
		{
			OpenFileDialog dlg = new OpenFileDialog();
			dlg.Filter = "Rich Text Format (*.rtf)|*.rtf|All files (*.*)|*.*";
			if (dlg.ShowDialog() == true)
			{
				FileStream fileStream = new FileStream(dlg.FileName, FileMode.Open);
				TextRange range = new TextRange(rtbEditor.Document.ContentStart, rtbEditor.Document.ContentEnd);
				range.Load(fileStream, DataFormats.Rtf);
			}
		}
		private void textSendBtn_TextSend(object sender, RoutedEventArgs e)
		{
			TextRange range = new TextRange(rtbEditor.Document.ContentStart, rtbEditor.Document.ContentEnd);
			string _text = range.Text;
			int k = -1;int _i = 0;
			bool divideByLine = false;
			if (divideByLine)
			{
				while (_i <= _text.Length - 1)
				{
					k++;
					if ((_text[_i] == '\n') || ((_text[_i] == '\r') && (_text[_i + 1] == '\n')))
					{
						k = -1;
						if ((_text[_i] == '\r') && (_text[_i + 1] == '\n'))
						{
							_text = _text.Remove(_i, 1); _i--;
						}
					}
					if (k > 39)
					{
						_text = _text.Insert(_i, "\n"); k = -1; _i--;
					}
					_i++;

				}
			}
			//TaskbarProgress
			//_text = _text.Replace('\n', ' ');
			_text = _text.Remove(_text.Length - 2, 1);
			TextInputBox.Text = _text;
			TextInputBox.Focus();
		}

		private void Save_Executed(object sender, ExecutedRoutedEventArgs e)
		{
			SaveFileDialog dlg = new SaveFileDialog();
			dlg.Filter = "Rich Text Format (*.rtf)|*.rtf|All files (*.*)|*.*";
			if (dlg.ShowDialog() == true)
			{
				FileStream fileStream = new FileStream(dlg.FileName, FileMode.Create);
				TextRange range = new TextRange(rtbEditor.Document.ContentStart, rtbEditor.Document.ContentEnd);
				range.Save(fileStream, DataFormats.Rtf);
			}
		}

		private void cmbFontFamily_SelectionChanged(object sender, SelectionChangedEventArgs e)
		{
			if (cmbFontFamily.SelectedItem != null)
				rtbEditor.Selection.ApplyPropertyValue(Inline.FontFamilyProperty, cmbFontFamily.SelectedItem);
		}

		private void cmbFontSize_TextChanged(object sender, TextChangedEventArgs e)
		{
			rtbEditor.Selection.ApplyPropertyValue(Inline.FontSizeProperty, cmbFontSize.Text);
		}
	}
}
