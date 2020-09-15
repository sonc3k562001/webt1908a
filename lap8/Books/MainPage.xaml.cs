using Books.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace Books
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        private ObservableCollection<BooksItem> BooksItems;
        public MainPage()
        {
            this.InitializeComponent();
            BooksItems = new ObservableCollection<BooksItem>();
        }

        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (Coder.IsSelected)
            {
                BooksManager.GetBooks("Coder", BooksItems);
                TitleTextBlock.Text = "Coder";
            }
            else if(Developer.IsSelected)
            {
                BooksManager.GetBooks("Developer", BooksItems);
                TitleTextBlock.Text = "Developer";
            }
        }

        private void CoderButton_Click(object sender, RoutedEventArgs e)
        {
            MySplitView.IsPaneOpen = !MySplitView.IsPaneOpen;
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            Coder.IsSelected = true;
        }
    }
}
