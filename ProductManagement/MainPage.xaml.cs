﻿using System;
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
using ProductManagement.Model;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace ProductManagement
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        private ObservableCollection<Product> ListProduct;
        private List<ImageProduct> Images;


        public MainPage()
        {
            this.InitializeComponent();
            ListProduct = ProductManager.GetListProduct();
            Images = ItemImage.GetImages();
        }

        private void ClickButton_Click(object sender, RoutedEventArgs e)
        {
            ListProduct.Add(new Product { Count = ListProduct.Count + 1, Name = Name.Text, Description = Description.Text, Image = ((Image)ImageComboBox.SelectedValue).IconImage });

        }
    }
}
