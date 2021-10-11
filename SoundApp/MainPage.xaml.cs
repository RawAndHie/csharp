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
using System.Collections.ObjectModel;
using SoundApp.Model;
using Windows.ApplicationModel.DataTransfer;
using Windows.Storage;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace SoundApp
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {

        private ObservableCollection<Music> Music;
        private List<Item> Singer;
        public List<string> Suggestions;
        public MainPage()
        {
            this.InitializeComponent();
            Music = new ObservableCollection<Music>();
            MusicManager.GetAllMusic(Music);
            Singer = new List<Item>();

            Singer.Add(new Item { Category = MusicCategory.Den });
            Singer.Add(new Item { Category = MusicCategory.Vu });
            Singer.Add(new Item { Category = MusicCategory.Andiez });
        }

        private void MenuItemsListView_ItemClick(object sender, ItemClickEventArgs e)
        {
            var menuItem = (Item)e.ClickedItem;

            CategoryTextBlock.Text = menuItem.Category.ToString();
            MusicManager.GetMusicByCategory(Music, menuItem.Category);
            BackButton.Visibility = Visibility.Visible;
        }

        private void HumburgerButton_Click(object sender, RoutedEventArgs e)
        {
            MySplitView.IsPaneOpen = !MySplitView.IsPaneOpen;
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            goBack();
        }
        private void goBack()
        {
            MusicManager.GetAllMusic(Music);
            CategoryTextBlock.Text = "All Music";
            MenuItemsListView.SelectedItem = null;
            BackButton.Visibility = Visibility.Collapsed;
        }
        private void SearchAutoSuggestBox_TextChanged(AutoSuggestBox sender, AutoSuggestBoxTextChangedEventArgs args)
        {
            if (String.IsNullOrEmpty(sender.Text)) goBack();

            MusicManager.GetAllMusic(Music);
            Suggestions = Music
                .Where(p => p.Name.StartsWith(sender.Text))
                .Select(p => p.Name)
                .ToList();
            SearchAutoSuggestBox.ItemsSource = Suggestions;
        }

        private void SearchAutoSuggestBox_QuerySubmitted(AutoSuggestBox sender, AutoSuggestBoxQuerySubmittedEventArgs args)
        {
            MusicManager.GetMusicByName(Music, sender.Text);
            CategoryTextBlock.Text = sender.Text;
            MenuItemsListView.SelectedItem = null;
            BackButton.Visibility = Visibility.Visible;
        }

        private void SoundGridView_ItemClick(object sender, ItemClickEventArgs e)
        {
            var music = (Music)e.ClickedItem;
            MyMediaElement.Source = new Uri(this.BaseUri, music.AudioFile);
        }

        
    }
}
