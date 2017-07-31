using System.Reflection;
using Windows.UI;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace Reloj_Control
{
    public sealed partial class ButtonSettingPage : Page
    {
        public ButtonSettingPage()
        {
            this.InitializeComponent();

            //rellena los combobox de color
            foreach(PropertyInfo item in typeof(Colors).GetTypeInfo().DeclaredProperties)
            {
                if (item.PropertyType == typeof(Color))
                {
                    ColorButtonComboBox.Items.Add(item.GetValue(typeof(Colors)).ToString());
                    ColorMessageComboBox.Items.Add(item.GetValue(typeof(Colors)).ToString());
                }
            }
        }

        public ButtonSettingPage(ButtonSetting bs) 
            : this()
        {

        }

        private void ButtonSetting_Changed(object sender, RoutedEventArgs e)
        {
            if (SaveButton != null)
                SaveButton.IsEnabled = !string.IsNullOrEmpty(LabelButtonTextBox.Text);
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            ButtonsCollection.Items.Add(new ButtonSetting()
            {
                ButtonLabel = LabelButtonTextBox.Text
            });

            Frame.GoBack();
        }

        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            Frame.GoBack();
        }
    }
}
