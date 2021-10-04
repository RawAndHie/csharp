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
using U41.Model;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace U41
{
    //private List<Icon> Icon ;
    
    
    public sealed partial class MainPage : Page
    {
        private List<Avatar> Avatars;
        public MainPage()
        {
            this.InitializeComponent();
            Avatars = ItemAvatar.GetAvatars();

        }
        private void NewContactButton_Click(object sender, RoutedEventArgs e)
        {
           
        }
    }
}
