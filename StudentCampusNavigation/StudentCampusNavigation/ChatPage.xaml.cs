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

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace StudentCampusNavigation
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class ChatPage : Page
    {
        public ObservableCollection<string> MessagesList { get; set; }
        public ChatPage()
        {
            MessagesList = new ObservableCollection<string>
            {
                "[Piotr] Where are the classes?",
                "[Piotr] I overslept and will be late 10 mins",
                "[Wiktoria] C-3, 299",
                "[Wiktoria] Don't worry, nobody's here yet",
                "[Piotr] Great. See you in a minute then"
            };
            this.InitializeComponent();
            OptionsBox.Items.Add("IT app.: Elect.media in Busi.");
            OptionsBox.SelectedIndex = 0;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
