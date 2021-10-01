using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace U20
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void Checkbox_tap(Object sender, TappedRoutedEventArgs e)
        {
            TextBlock.Text = MyCheckBox.IsChecked.ToString();
        }

        private void Radio_checked(Object sender, RoutedEventArgs e)
        {
            TextRadio.Text = (bool)YesButton.IsChecked ? "Yes" : "No";
        }

        private void Combobox_changed(object sender, SelectionChangedEventArgs e)
        {
            if (TextCombobox == null)
            {
                return;
            }
            var combo = (ComboBox)sender;
            var item = (ComboBoxItem)combo.SelectedItem;
            TextCombobox.Text = item.Content.ToString();
        }

        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var selectedItem = ListBox.Items.Cast<ListBoxItem>().Where(p => p.IsSelected).Select(t => t.Content.ToString()).ToArray();
            TextListBox.Text = string.Join(",", selectedItem);
        }

        private void ToggleButton_Click(object sender, RoutedEventArgs e)
        {
            TextToggleButton.Text = ToggleButton.IsChecked.ToString();
        }
    }
}
