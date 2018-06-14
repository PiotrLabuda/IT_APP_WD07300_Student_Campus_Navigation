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
    public sealed partial class CalendarPage : Page
    {

        private Dictionary<string, List<string>> eventlist;
        public ObservableCollection<string> Events { get; set; }
        public CalendarPage()
        {
            eventlist = new Dictionary<string, List<string>>
            {
                [(new DateTimeOffset(new DateTime(2018, 6, 14)).ToString())] = new List<string> {"[7:30] IT app.: Elect. media in Busi.",
                "[9:15] Comp. Proj. Management"},
                [(new DateTimeOffset(new DateTime(2018, 6, 15)).ToString())] = new List<string> {"[11:15] Discrete mathematics"}
            };
            Events = new ObservableCollection<string>();
            this.InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void CalendarView_SelectedDatesChanged(CalendarView sender, CalendarViewSelectedDatesChangedEventArgs args)
        {
            Events.Clear();
            try
            {

                var selected = args.AddedDates.FirstOrDefault();
                selected = selected.DateTime.Date;
                if (selected != null && eventlist.ContainsKey(selected.ToString()))
                {
                    Events.Clear();
                    var k = (eventlist[selected.ToString()]);
                    foreach (var l in k)
                    {
                        Events.Add(l);
                    }
                }

            }
            catch
            { }
        }
    }
}
