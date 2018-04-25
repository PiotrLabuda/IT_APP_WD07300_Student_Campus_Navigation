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

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace StudentCampusNavigation
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class HomePage : Page
    {
        public List<string> PagesList { get; set; }
        public List<Type> TypesList { get; set; }
        public HomePage()
        {
            PagesList = new List<string>
            {
                "Map",
                "Chat"
            };
            TypesList = new List<Type>
            {
                typeof(MapPage),
                typeof(ChatPage)
            };

            this.InitializeComponent();
            PageFrame.Navigate(TypesList[0]);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var index = PagesList.IndexOf(((sender as Button).Content as string));
                PageFrame.Navigate(TypesList[index]);
            }
            catch
            { }
        }
    }
}
