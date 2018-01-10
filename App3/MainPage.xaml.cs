using System;
using Windows.ApplicationModel.Email;
using Windows.UI;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// Документацию по шаблону элемента "Пустая страница" см. по адресу http://go.microsoft.com/fwlink/?LinkId=391641

namespace App3
{
    /// <summary>
    ///     Пустая страница, которую можно использовать саму по себе или для перехода внутри фрейма.
    /// </summary>
    public sealed partial class MainPage
    {
        public MainPage()
        {
            InitializeComponent();
            NavigationCacheMode = NavigationCacheMode.Required;
        }

        /// <summary>
        ///     Вызывается перед отображением этой страницы во фрейме.
        /// </summary>
        /// <param name="e">
        ///     Данные события, описывающие, каким образом была достигнута эта страница.
        ///     Этот параметр обычно используется для настройки страницы.
        /// </param>
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            // TODO: Подготовьте здесь страницу для отображения.

            // TODO: Если приложение содержит несколько страниц, обеспечьте
            // обработку нажатия аппаратной кнопки "Назад", выполнив регистрацию на
            // событие Windows.Phone.UI.Input.HardwareButtons.BackPressed.
            // Если вы используете NavigationHelper, предоставляемый некоторыми шаблонами,
            // данное событие обрабатывается для вас.
        }

        public void Detect()
        {
            switch (textBox.Text)
            {
                default:
                    textBlock_Red.Visibility = Visibility.Visible;
                    textBlock_Red.Foreground = new SolidColorBrush(Colors.Red);
                    textBlock_Red.Text = "Такого кода не существует";
                    textBox.BorderThickness = new Thickness(2);
                    textBlock.Text = "";

                    break;
                case "AK":
                case "KK":
                    textBlock_Red.Visibility = Visibility.Collapsed;
                    textBox.BorderThickness = new Thickness(0);
                    textBlock.Text = "АР Крым";
                    break;
                case "AB":
                case "KB":
                    textBlock_Red.Visibility = Visibility.Collapsed;
                    textBox.BorderThickness = new Thickness(0);
                    textBlock.Text = "Винницкая область";
                    break;
                case "AC":
                case "KC":
                    textBlock_Red.Visibility = Visibility.Collapsed;
                    textBox.BorderThickness = new Thickness(0);
                    textBlock.Text = "Волынская область";
                    break;
                case "AE":
                case "KE":
                    textBlock_Red.Visibility = Visibility.Collapsed;
                    textBox.BorderThickness = new Thickness(0);
                    textBlock.Text = "Днепровская область";
                    break;
                case "AH":
                case "KH":
                    textBlock_Red.Visibility = Visibility.Collapsed;
                    textBox.BorderThickness = new Thickness(0);
                    textBlock.Text = "Донецкая область";
                    break;
                case "AM":
                case "KM":
                    textBlock_Red.Visibility = Visibility.Collapsed;
                    textBox.BorderThickness = new Thickness(0);
                    textBlock.Text = "Житомирская область";
                    break;
                case "AO":
                case "KO":
                    textBlock_Red.Visibility = Visibility.Collapsed;
                    textBox.BorderThickness = new Thickness(0);
                    textBlock.Text = "Закарпатская область";
                    break;
                case "AP":
                case "KP":
                    textBlock_Red.Visibility = Visibility.Collapsed;
                    textBox.BorderThickness = new Thickness(0);
                    textBlock.Text = "Запорожская область";
                    break;
                case "AT":
                case "KT":
                    textBlock_Red.Visibility = Visibility.Collapsed;
                    textBox.BorderThickness = new Thickness(0);
                    textBlock.Text = "Ивано-Франковская область";
                    break;
                case "AI":
                case "KI":
                    textBlock_Red.Visibility = Visibility.Collapsed;
                    textBox.BorderThickness = new Thickness(0);
                    textBlock.Text = "Киевская область";
                    break;
                case "KA":
                case "AA":
                    textBlock_Red.Visibility = Visibility.Collapsed;
                    textBox.BorderThickness = new Thickness(0);
                    textBlock.Text = "Город Киев";
                    break;
                case "BA":
                case "HA":
                    textBlock_Red.Visibility = Visibility.Collapsed;
                    textBox.BorderThickness = new Thickness(0);
                    textBlock.Text = "Кировоградская область";
                    break;
                case "BB":
                case "HB":
                    textBlock_Red.Visibility = Visibility.Collapsed;
                    textBox.BorderThickness = new Thickness(0);
                    textBlock.Text = "Луганская область";
                    break;
                case "BC":
                case "HC":
                    textBlock_Red.Visibility = Visibility.Collapsed;
                    textBox.BorderThickness = new Thickness(0);
                    textBlock.Text = "Львовская область";
                    break;
                case "BE":
                case "HE":
                    textBlock_Red.Visibility = Visibility.Collapsed;
                    textBox.BorderThickness = new Thickness(0);
                    textBlock.Text = "Николаевская область";
                    break;
                case "BH":
                case "HH":
                    textBlock_Red.Visibility = Visibility.Collapsed;
                    textBox.BorderThickness = new Thickness(0);
                    textBlock.Text = "Одесская область";
                    break;
                case "BI":
                case "HI":
                    textBlock_Red.Visibility = Visibility.Collapsed;
                    textBox.BorderThickness = new Thickness(0);
                    textBlock.Text = "Полтавская область";
                    break;
                case "BK":
                case "HK":
                    textBlock_Red.Visibility = Visibility.Collapsed;
                    textBox.BorderThickness = new Thickness(0);
                    textBlock.Text = "Ровенская область";
                    break;
                case "BM":
                case "HM":
                    textBlock_Red.Visibility = Visibility.Collapsed;
                    textBox.BorderThickness = new Thickness(0);
                    textBlock.Text = "Сумская область";
                    break;
                case "BO":
                case "HO":
                    textBlock_Red.Visibility = Visibility.Collapsed;
                    textBox.BorderThickness = new Thickness(0);
                    textBlock.Text = "Тернопольская область";
                    break;
                case "AX":
                case "KX":
                    textBlock_Red.Visibility = Visibility.Collapsed;
                    textBox.BorderThickness = new Thickness(0);
                    textBlock.Text = "Харьковская область";
                    break;
                case "BT":
                case "HT":
                    textBlock_Red.Visibility = Visibility.Collapsed;
                    textBox.BorderThickness = new Thickness(0);
                    textBlock.Text = "Херсонская область";
                    break;
                case "BX":
                case "HX":
                    textBlock_Red.Visibility = Visibility.Collapsed;
                    textBox.BorderThickness = new Thickness(0);
                    textBlock.Text = "Хмельницькая область";
                    break;
                case "IA":
                case "CA":
                    textBlock_Red.Visibility = Visibility.Collapsed;
                    textBox.BorderThickness = new Thickness(0);
                    textBlock.Text = "Черкасская область";
                    break;
                case "IB":
                case "CB":
                    textBlock_Red.Visibility = Visibility.Collapsed;
                    textBox.BorderThickness = new Thickness(0);
                    textBlock.Text = "Черниговская область";
                    break;
                case "IE":
                case "CE":
                    textBlock_Red.Visibility = Visibility.Collapsed;
                    textBox.BorderThickness = new Thickness(0);
                    textBlock.Text = "Черновецкая область";
                    break;
                case "IH":
                case "CH":
                    textBlock_Red.Visibility = Visibility.Collapsed;
                    textBox.BorderThickness = new Thickness(0);
                    textBlock.Text = "Город Севастополь";
                    break;
                case "II":
                    textBlock_Red.Visibility = Visibility.Collapsed;
                    textBox.BorderThickness = new Thickness(0);
                    textBlock.Text = "Общегосударственный";
                    break;
            }
        }

        private void but_1_Click(object sender, RoutedEventArgs e)
        {
            if (textBox.Text.Length < 2)
            {
                textBox.Text = textBox.Text + "A";
                textBox.BorderThickness = new Thickness(2);
            }
            else
            {
                textBox.Text = "A";
                textBox.BorderThickness = new Thickness(2);
                textBlock_Red.Visibility = Visibility.Collapsed;
                textBlock.Text = "Введите код региона";
            }
            if (textBox.Text.Length == 2)
            Detect();
        }

        private void but_2_Click(object sender, RoutedEventArgs e)
        {
            if (textBox.Text.Length < 2)
            {
                textBox.Text = textBox.Text + "B";
                textBox.BorderThickness = new Thickness(2);
            }
            else
            {
                textBox.Text = "B";
                textBox.BorderThickness = new Thickness(2);
                textBlock_Red.Visibility = Visibility.Collapsed;
                textBlock.Text = "Введите код региона";
            }
            if (textBox.Text.Length == 2)
                Detect();
        }

        private void but_3_Click(object sender, RoutedEventArgs e)
        {
            if (textBox.Text.Length < 2)
            {
                textBox.Text = textBox.Text + "C";
                textBox.BorderThickness = new Thickness(2);
            }
            else
            {
                textBox.Text = "C";
                textBox.BorderThickness = new Thickness(2);
                textBlock_Red.Visibility = Visibility.Collapsed;
                textBlock.Text = "Введите код региона";
            }
            if (textBox.Text.Length == 2)
                Detect();
        }

        private void but_4_Click(object sender, RoutedEventArgs e)
        {
            if (textBox.Text.Length < 2)
            {
                textBox.Text = textBox.Text + "E";
                textBox.BorderThickness = new Thickness(2);
            }
            else
            {
                textBox.Text = "E";
                textBox.BorderThickness = new Thickness(2);
                textBlock_Red.Visibility = Visibility.Collapsed;
                textBlock.Text = "Введите код региона";
            }
            if (textBox.Text.Length == 2)
                Detect();
        }

        private void but_5_Click(object sender, RoutedEventArgs e)
        {
            if (textBox.Text.Length < 2)
            {
                textBox.Text = textBox.Text + "H";
                textBox.BorderThickness = new Thickness(2);
            }
            else
            {
                textBox.Text = "H";
                textBox.BorderThickness = new Thickness(2);
                textBlock_Red.Visibility = Visibility.Collapsed;
                textBlock.Text = "Введите код региона";
            }
            if (textBox.Text.Length == 2)
                Detect();
        }

        private void but_6_Click(object sender, RoutedEventArgs e)
        {
            if (textBox.Text.Length < 2)
            {
                textBox.Text = textBox.Text + "I";
                textBox.BorderThickness = new Thickness(2);
            }
            else
            {
                textBox.Text = "I";
                textBox.BorderThickness = new Thickness(2);
                textBlock_Red.Visibility = Visibility.Collapsed;
                textBlock.Text = "Введите код региона";
            }
            if (textBox.Text.Length == 2)
                Detect();
        }

        private void but_7_Click(object sender, RoutedEventArgs e)
        {
            if (textBox.Text.Length < 2)
            {
                textBox.BorderThickness = new Thickness(2);
                textBox.Text = textBox.Text + "K";
            }
            else
            {
                textBox.Text = "K";
                textBox.BorderThickness = new Thickness(2);
                textBlock_Red.Visibility = Visibility.Collapsed;
                textBlock.Text = "Введите код региона";
            }
            if (textBox.Text.Length == 2)
                Detect();
        }

        private void but_8_Click(object sender, RoutedEventArgs e)
        {
            if (textBox.Text.Length < 2)
            {
                textBox.Text = textBox.Text + "M";
                textBox.BorderThickness = new Thickness(2);
            }
            else
            {
                textBox.Text = "M";
                textBox.BorderThickness = new Thickness(2);
                textBlock_Red.Visibility = Visibility.Collapsed;
                textBlock.Text = "Введите код региона";
            }
            if (textBox.Text.Length == 2)
                Detect();
        }

        private void but_9_Click(object sender, RoutedEventArgs e)
        {
            if (textBox.Text.Length < 2)
            {
                textBox.BorderThickness = new Thickness(2);
                textBox.Text = textBox.Text + "O";
            }
            else
            {
                textBox.Text = "O";
                textBox.BorderThickness = new Thickness(2);
                textBlock_Red.Visibility = Visibility.Collapsed;
                textBlock.Text = "Введите код региона";
            }
            if (textBox.Text.Length == 2)
                Detect();
        }

        private void but_10_Click(object sender, RoutedEventArgs e)
        {
            if (textBox.Text.Length < 2)
            {
                textBox.BorderThickness = new Thickness(2);
                textBox.Text = textBox.Text + "P";
            }
            else
            {
                textBox.Text = "P";
                textBox.BorderThickness = new Thickness(2);
                textBlock_Red.Visibility = Visibility.Collapsed;
                textBlock.Text = "Введите код региона";
            }
            if (textBox.Text.Length == 2)
                Detect();
        }

        private void but_11_Click(object sender, RoutedEventArgs e)
        {
            if (textBox.Text.Length < 2)
            {
                textBox.BorderThickness = new Thickness(2);
                textBox.Text = textBox.Text + "T";
            }
            else
            {
                textBox.Text = "T";
                textBox.BorderThickness = new Thickness(2);
                textBlock_Red.Visibility = Visibility.Collapsed;
                textBlock.Text = "Введите код региона";
            }
            if (textBox.Text.Length == 2)
                Detect();
        }

        private void but_12_Click(object sender, RoutedEventArgs e)
        {
            if (textBox.Text.Length < 2)
            {
                textBox.Text = textBox.Text + "X";
                textBox.BorderThickness = new Thickness(2);
            }
            else
            {
                textBox.Text = "X";
                textBox.BorderThickness = new Thickness(2);
                textBlock_Red.Visibility = Visibility.Collapsed;
                textBlock.Text = "Введите код региона";
            }
            if (textBox.Text.Length == 2)
                Detect();
        }

        private void but_13_Click(object sender, RoutedEventArgs e)
        {
            textBox.Text = "";
            textBox.BorderThickness = new Thickness(2);
            textBlock_Red.Visibility = Visibility.Collapsed;
            textBlock.Text = "Введите код региона";
        }

        private void but_14_Click(object sender, RoutedEventArgs e)
        {
            if (textBox.Text.Length != 0)
            {
                textBox.Text = textBox.Text.Substring(0, textBox.Text.Length - 1);
                textBox.BorderThickness = new Thickness(2);
            }
            textBlock_Red.Visibility = Visibility.Collapsed;
            textBox.BorderThickness = new Thickness(2);
            textBlock.Text = "Введите код региона";
        }

        private async void ListViewItem_Tapped(object sender, TappedRoutedEventArgs e)
        {
            var dialog = new MessageDialog("CH - с 2004 года\nIH - после 2014 года\nЦифровой код - 27",
                "Коды региона для Севастополя:");
            dialog.Commands.Add(new UICommand("ОК"));
            await dialog.ShowAsync();
        }

        private async void ListViewItem_Tapped_1(object sender, TappedRoutedEventArgs e)
        {
            var dialog = new MessageDialog("AA - с 2004 года\nKA - после 2014 года\nЦифровой код - 11",
                "Коды региона для Киева:");
            dialog.Commands.Add(new UICommand("ОК"));
            await dialog.ShowAsync();
        }

        private async void ListViewItem_Tapped_2(object sender, TappedRoutedEventArgs e)
        {
            var dialog = new MessageDialog("AK - с 2004 года\nKK - после 2014 года\nЦифровой код - 01",
                "Коды региона для Крыма:");
            dialog.Commands.Add(new UICommand("ОК"));
            await dialog.ShowAsync();
        }


        private async void ListViewItem_Tapped_3(object sender, TappedRoutedEventArgs e)
        {
            var dialog = new MessageDialog("AB - с 2004 года\nKB - после 2014 года\nКод области - 02",
                "Коды региона для Винницкой области:");
            dialog.Commands.Add(new UICommand("ОК"));
            await dialog.ShowAsync();
        }

        private async void ListViewItem_Tapped_4(object sender, TappedRoutedEventArgs e)
        {
            var dialog = new MessageDialog("AC - с 2004 года\nKC - после 2014 года\nКод области - 03",
                "Коды региона для Волынской области:");
            dialog.Commands.Add(new UICommand("ОК"));
            await dialog.ShowAsync();
        }

        private async void ListViewItem_Tapped_5(object sender, TappedRoutedEventArgs e)
        {
            var dialog = new MessageDialog("AE - с 2004 года\nKE - после 2014 года\nКод области - 04",
                "Коды региона для Днепровской области:");
            dialog.Commands.Add(new UICommand("ОК"));
            await dialog.ShowAsync();
        }

        private async void ListViewItem_Tapped_6(object sender, TappedRoutedEventArgs e)
        {
            var dialog = new MessageDialog("AH - с 2004 года\nKH - после 2014 года\nКод области - 05",
                "Коды региона для Донецкой области:");
            dialog.Commands.Add(new UICommand("ОК"));
            await dialog.ShowAsync();
        }

        private async void ListViewItem_Tapped_7(object sender, TappedRoutedEventArgs e)
        {
            var dialog = new MessageDialog("AM - с 2004 года\nKM - после 2014 года\nКод области - 06",
                "Коды региона для Житомирской области:");
            dialog.Commands.Add(new UICommand("ОК"));
            await dialog.ShowAsync();
        }

        private async void ListViewItem_Tapped_8(object sender, TappedRoutedEventArgs e)
        {
            var dialog = new MessageDialog("AO - с 2004 года\nKO - после 2014 года\nКод области - 07",
                "Коды региона для Закарпатской области:");
            dialog.Commands.Add(new UICommand("ОК"));
            await dialog.ShowAsync();
        }

        private async void ListViewItem_Tapped_9(object sender, TappedRoutedEventArgs e)
        {
            var dialog = new MessageDialog("AP - с 2004 года\nKP - после 2014 года\nКод области - 08",
                "Коды региона для Запорожской области:");
            dialog.Commands.Add(new UICommand("ОК"));
            await dialog.ShowAsync();
        }

        private async void ListViewItem_Tapped_10(object sender, TappedRoutedEventArgs e)
        {
            var dialog = new MessageDialog("AT - с 2004 года\nKT - после 2014 года\nКод области - 09",
                "Коды региона для Ивано-Франковской области:");
            dialog.Commands.Add(new UICommand("ОК"));
            await dialog.ShowAsync();
        }

        private async void ListViewItem_Tapped_11(object sender, TappedRoutedEventArgs e)
        {
            var dialog = new MessageDialog("AI - с 2004 года\nKI - после 2014 года\nКод области - 10",
                "Коды региона для Киевской области:");
            dialog.Commands.Add(new UICommand("ОК"));
            await dialog.ShowAsync();
        }

        private async void ListViewItem_Tapped_12(object sender, TappedRoutedEventArgs e)
        {
            var dialog = new MessageDialog("BA - с 2004 года\nHA - после 2014 года\nКод области - 12",
                "Коды региона для Кировоградской области:");
            dialog.Commands.Add(new UICommand("ОК"));
            await dialog.ShowAsync();
        }

        private async void ListViewItem_Tapped_13(object sender, TappedRoutedEventArgs e)
        {
            var dialog = new MessageDialog("BB - с 2004 года\nHB - после 2014 года\nКод области - 13",
                "Коды региона для Луганаской области:");
            dialog.Commands.Add(new UICommand("ОК"));
            await dialog.ShowAsync();
        }

        private async void ListViewItem_Tapped_14(object sender, TappedRoutedEventArgs e)
        {
            var dialog = new MessageDialog("BC - с 2004 года\nHC - после 2014 года\nКод области - 14",
                "Коды региона для Львовской области:");
            dialog.Commands.Add(new UICommand("ОК"));
            await dialog.ShowAsync();
        }

        private async void ListViewItem_Tapped_15(object sender, TappedRoutedEventArgs e)
        {
            var dialog = new MessageDialog("BE - с 2004 года\nHE - после 2014 года\nКод области - 15",
                "Коды региона для Николаевской области:");
            dialog.Commands.Add(new UICommand("ОК"));
            await dialog.ShowAsync();
        }

        private async void ListViewItem_Tapped_16(object sender, TappedRoutedEventArgs e)
        {
            var dialog = new MessageDialog("BH - с 2004 года\nHH - после 2014 года\nКод области - 16",
                "Коды региона для Одесской области:");
            dialog.Commands.Add(new UICommand("ОК"));
            await dialog.ShowAsync();
        }

        private async void ListViewItem_Tapped_17(object sender, TappedRoutedEventArgs e)
        {
            var dialog = new MessageDialog("BI - с 2004 года\nHI - после 2014 года\nКод области - 17",
                "Коды региона для Полтавской области:");
            dialog.Commands.Add(new UICommand("ОК"));
            await dialog.ShowAsync();
        }

        private async void ListViewItem_Tapped_18(object sender, TappedRoutedEventArgs e)
        {
            var dialog = new MessageDialog("BK - с 2004 года\nHK - после 2014 года\nКод области - 18",
                "Коды региона для Ровенской области:");
            dialog.Commands.Add(new UICommand("ОК"));
            await dialog.ShowAsync();
        }

        private async void ListViewItem_Tapped_19(object sender, TappedRoutedEventArgs e)
        {
            var dialog = new MessageDialog("BM - с 2004 года\nHM - после 2014 года\nКод области - 19",
                "Коды региона для Сумской области:");
            dialog.Commands.Add(new UICommand("ОК"));
            await dialog.ShowAsync();
        }

        private async void ListViewItem_Tapped_20(object sender, TappedRoutedEventArgs e)
        {
            var dialog = new MessageDialog("BO - с 2004 года\nHO - после 2014 года\nКод области - 20",
                "Коды региона для Тернопольской области:");
            dialog.Commands.Add(new UICommand("ОК"));
            await dialog.ShowAsync();
        }

        private async void ListViewItem_Tapped_21(object sender, TappedRoutedEventArgs e)
        {
            var dialog = new MessageDialog("AX - с 2004 года\nKX - после 2014 года\nКод области - 21",
                "Коды региона для Харьковской области:");
            dialog.Commands.Add(new UICommand("ОК"));
            await dialog.ShowAsync();
        }

        private async void ListViewItem_Tapped_22(object sender, TappedRoutedEventArgs e)
        {
            var dialog = new MessageDialog("BT - с 2004 года\nHT - после 2014 года\nКод области - 22",
                "Коды региона для Херсонской области:");
            dialog.Commands.Add(new UICommand("ОК"));
            await dialog.ShowAsync();
        }

        private async void ListViewItem_Tapped_23(object sender, TappedRoutedEventArgs e)
        {
            var dialog = new MessageDialog("BX - с 2004 года\nHX - после 2014 года\nКод области - 23",
                "Коды региона для Хмельницкой области:");
            dialog.Commands.Add(new UICommand("ОК"));
            await dialog.ShowAsync();
        }

        private async void ListViewItem_Tapped_24(object sender, TappedRoutedEventArgs e)
        {
            var dialog = new MessageDialog("CA - с 2004 года\nIA - после 2014 года\nКод области - 24",
                "Коды региона для Черкасской области:");
            dialog.Commands.Add(new UICommand("ОК"));
            await dialog.ShowAsync();
        }

        private async void ListViewItem_Tapped_25(object sender, TappedRoutedEventArgs e)
        {
            var dialog = new MessageDialog("CB - с 2004 года\nIB - после 2014 года\nКод области - 25",
                "Коды региона для Черниговской области:");
            dialog.Commands.Add(new UICommand("ОК"));
            await dialog.ShowAsync();
        }

        private async void ListViewItem_Tapped_26(object sender, TappedRoutedEventArgs e)
        {
            var dialog = new MessageDialog("CE - с 2004 года\nIE - после 2014 года\nКод области - 26",
                "Коды региона для Черновицкой области:");
            dialog.Commands.Add(new UICommand("ОК"));
            await dialog.ShowAsync();
        }
        private async void Hyperlink_OnClick(object sender, RoutedEventArgs e)
        {
            EmailRecipient sendTo = new EmailRecipient()
            {
                Address = "alex-under@mail.ua"
            };

            //generate mail object
            EmailMessage mail = new EmailMessage();
            mail.Subject = "Feedback";

            //add recipients to the mail object
            mail.To.Add(sendTo);
            //mail.Bcc.Add(sendTo);
            //mail.CC.Add(sendTo);

            await EmailManager.ShowComposeNewEmailAsync(mail);
        }
    }
}