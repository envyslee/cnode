using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using cnode.Resources;
using System.Net.Http;
using Newtonsoft.Json;
using cnode.Entity;
using System.Collections.ObjectModel;

namespace cnode
{
    public partial class MainPage : PhoneApplicationPage
    {
        private ObservableCollection<subjectDetial> bindNewest = new ObservableCollection<subjectDetial>();
        public ObservableCollection<subjectDetial> BindNewest
        {
            get { return bindNewest; }
            set { bindNewest = value; }
        }


        // 构造函数
        public MainPage()
        {
            InitializeComponent();

        }

        private async void homepage_Loaded(object sender, RoutedEventArgs e)
        {
            string url="https://cnodejs.org/api/v1/topics";
            HttpClient hc = new HttpClient();
            var content = await hc.GetStringAsync(url);
            var res = JsonConvert.DeserializeObject<subject>(content);
            res.data.ForEach(a => { bindNewest.Add(a); });
            bindNewest.ToList().ForEach(z => {
                if (z.top)
                {
                    z.tab = "top";
                }
            });
            loadingpage.Visibility = Visibility.Collapsed;
        }

        private void Pivot_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void newestgrid_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            Grid g = sender as Grid;
            NavigationService.Navigate(new Uri("/Page/subjectDetailPage.xaml?id="+g.Tag.ToString(), UriKind.Relative));
        }

      
    }
}