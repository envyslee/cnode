using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using System.Net.Http;
using System.Collections.ObjectModel;
using cnode.Entity;
using Newtonsoft.Json;
using System.Text.RegularExpressions;

namespace cnode.Page
{
    public partial class subjectDetailPage : PhoneApplicationPage
    {
        private string id = string.Empty;


        private ObservableCollection<reply> bindReply = new ObservableCollection<reply>();
        public ObservableCollection<reply> BindReply
        {
            get { return bindReply; }
            set { bindReply = value; }
        }
        public subjectDetailPage()
        {
            InitializeComponent();
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            if (NavigationContext.QueryString.ContainsKey("id"))
            {
                id = NavigationContext.QueryString["id"];
            }
            base.OnNavigatedTo(e);
        }

        private async void subDetail_Loaded(object sender, RoutedEventArgs e)
        {
            string url = "https://cnodejs.org/api/v1/topic/" + id;
            HttpClient hc = new HttpClient();
            var content = await hc.GetStringAsync(url);
            var res = JsonConvert.DeserializeObject<content>(content);
            res.data.replies.ForEach(a =>
            {
                bindReply.Add(a);
            });
            //string js = "<script type=\"text/javascript\"> window.onload = function () { var elem = document.getElementById('subid');window.external.Notify(elem.scrollHeight + '');}</script>";
            bindReply.ToList().ForEach(a =>
            {
                //a.content = a.content.Replace("<div class=\"markdown-text\">", "<div id=\"subid\" class=\"markdown-text\">");
                //a.content += js;
                a.content = System.Text.RegularExpressions.Regex.Replace(a.content, @"[^(\u4e00-\u9fa5)]", "");
            });
            var con = res.data;
            titletb.Text = con.title;
            authortb.Text = con.author.loginname;
            timetb.Text = con.create_at;
            contentwb.NavigateToString(con.content);

        }

        private string GetCz(string s)
        {
            string res = string.Empty;
            Regex reg = new Regex("[\u4e00-\u9fa5]+");
            foreach (Match v in reg.Matches(s))
            {
                res += v;
            }
            return res;

        }


        private void WebBrowser_ScriptNotify(object sender, NotifyEventArgs e)
        {
            WebBrowser thisBrowser = (WebBrowser)sender;
            int height = Convert.ToInt32(e.Value);
            double newHeight = height * 1.5;
            thisBrowser.Height = newHeight;
        }

        protected override void OnBackKeyPress(System.ComponentModel.CancelEventArgs e)
        {
            if (contentwb.CanGoBack)
            {
                contentwb.GoBack();
                e.Cancel = true;
            }
            else
            {
                base.OnBackKeyPress(e);
            }
           
        }

    }
}