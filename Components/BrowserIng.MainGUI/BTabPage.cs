using Microsoft.AspNetCore.Components.WebView;
using Microsoft.AspNetCore.Components.WebView.WindowsForms;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Web.WebView2.Core;
using Microsoft.Win32;

namespace BrowserIng.MainGUI
{
    internal class BTabPage: TabPage
    {

        private BlazorWebView blazorWebView1;
        FMain _f;
        public BlazorWebView WV => blazorWebView1;

        public BTabPage(FMain f, string uri)
        {
            _f = f;

            blazorWebView1 = new BlazorWebView();

            blazorWebView1.Dock = DockStyle.Fill;
            blazorWebView1.Location = new Point(3, 3);
            blazorWebView1.Name = "blazorWebView1";
            blazorWebView1.Size = new Size(1220, 700);
            blazorWebView1.TabIndex = 2;
            blazorWebView1.Text = "blazorWebView1";

            Controls.Add(blazorWebView1);


            blazorWebView1.WebView.NavigationCompleted += WebView_NavigationCompleted;
            blazorWebView1.WebView.NavigationStarting += WebView_NavigationStarting;
                      
            if (_f._cfg.UseBlazor || (_f._cmdLine.Blazor ?? false))
                TuneHomeBlazor();
            else 
                SetWebBrowserEnvironment();

            if (!string.IsNullOrEmpty(uri))
            {
                try
                {
                    blazorWebView1.WebView.Source = uri.GetUri(_f._cfg.SearchUri);
                }
                catch
                {
                }
            }
            else
            {
             blazorWebView1.HostPage = ".\\wwwroot\\index.html";
             blazorWebView1.RootComponents.Add<Main>("#app"); // Main.razor 
            }

        }


       private void TuneHomeBlazor()
       {
             blazorWebView1.BlazorWebViewInitializing += WebView2Initializing;
             blazorWebView1.WebView.CoreWebView2InitializationCompleted += Webview_CoreWebView2InitializationCompleted;

            //  SetWebBrowserEnvironment();

            // var services = new ServiceCollection();
            // services.AddWindowsFormsBlazorWebView();

            blazorWebView1.Services = _f._services.BuildServiceProvider();  // services.BuildServiceProvider();
        }

        private void WebView2Initializing(object? sender, BlazorWebViewInitializingEventArgs e)
        {

            if(!string.IsNullOrEmpty(_f.DirDataDef))
                e.UserDataFolder = _f.DirDataDef;

            blazorWebView1.UrlLoading += (sender, e) =>
            {               
                e.UrlLoadingStrategy = UrlLoadingStrategy.OpenInWebView;               
            };
        }

        private void Webview_CoreWebView2InitializationCompleted(object? sender, 
            CoreWebView2InitializationCompletedEventArgs e)
        {
            UseAuthAuto();
            UseHistory();

            blazorWebView1.WebView.CoreWebView2.NewWindowRequested += CoreWebView2_NewWindowRequested; ;
            blazorWebView1.WebView.CoreWebView2.Settings.AreDevToolsEnabled = true;
            blazorWebView1.WebView.CoreWebView2.Settings.AreDefaultContextMenusEnabled = true;

            blazorWebView1.WebView.CoreWebView2.DocumentTitleChanged += CoreWebView2_DocumentTitleChanged;
        }

        private void CoreWebView2_DocumentTitleChanged(object? sender, object e)
        {
            Text = blazorWebView1.WebView.CoreWebView2.DocumentTitle;
        }

        private void CoreWebView2_NewWindowRequested(object? sender, CoreWebView2NewWindowRequestedEventArgs e)
        {
            _f.NewTabFromSrc(e);
            e.Handled = true;
        }

        void UseAuthAuto()
        {
            var webview = blazorWebView1.WebView;

            webview.CoreWebView2.BasicAuthenticationRequested
                += delegate (object? sender, CoreWebView2BasicAuthenticationRequestedEventArgs args)
                {
                    var g = _f._cfg.AuthList.Where(x => args.Uri.StartsWith(x.UrlStartsWith)).FirstOrDefault();
                    if (g != null)
                    {
                        args.Response.UserName = g.User;
                        args.Response.Password = g.Password;
                    }
                    else
                    {

                    }
                };
        }

        private void WebView_NavigationStarting(object? sender, CoreWebView2NavigationStartingEventArgs e)
        {
            Nav x;
            if (_f._dic.ContainsKey(e.NavigationId))
            {
                x = _f._dic[e.NavigationId];
                x.LastVisiting = DateTime.Now;
            }
            else
                x = _f._dic[e.NavigationId] = new Nav { URI = new Uri(e.Uri), FirstVisiting = DateTime.Now, LastVisiting = DateTime.Now, NavId = e.NavigationId };

           _f._lsnr?.Receive(new BrowserIngMessage { Uri = e.Uri, Time = DateTime.Now, Message = $"NavigationStarting", Source = x });
        }

        private async void WebView_NavigationCompleted(object? sender, CoreWebView2NavigationCompletedEventArgs e)
        {
            var o = _f._dic[e.NavigationId];

            if (e.IsSuccess)
            {
                o.LastVisited = DateTime.Now;
                var rr  = o.URI.ToString();

                _f._urlBarTextBox.Text = rr;
                _f._lsnr?.Receive(new BrowserIngMessage { Uri = rr, Time = DateTime.Now, 
                    Message = $"NavigationCompleted success {e.HttpStatusCode}", Source = o });

                Text = blazorWebView1.WebView.CoreWebView2.DocumentTitle;
                if (string.IsNullOrEmpty(Text))
                {
                    Text = rr;
                }

                // TODO:// execute script on completion
                // var s = await BWV.WebView.CoreWebView2.ExecuteScriptAsync("JSON.stringify(document.body)");          
                //  MessageBox.Show(s);
                return;
            }

            _f._lsnr?.Receive(new BrowserIngMessage { Uri = o.URI.ToString(), Time = DateTime.Now,
                Message = $"NavigationCompleted failure {e.HttpStatusCode}", Source = o });
        }


        void UseHistory()
        {
            var webview = blazorWebView1.WebView;
            webview.CoreWebView2.HistoryChanged += CoreWebView2_HistoryChanged;
        }

        private void CoreWebView2_HistoryChanged(object? sender, object e)
        {
            switch (sender)
            {
                case CoreWebView2 cwv:

                    if (_f._cfg.History.LastOrDefault()?.URI != cwv.Source)
                    {
                        _f._cfg.History.Add(new Visit { URI = cwv.Source, When = DateTime.Now, Title = cwv.DocumentTitle });
                        _f.SaveSettings();
                    }

                    break;
            }
        }

        async void SetWebBrowserEnvironment()
        {
            try
            {
                blazorWebView1.BlazorWebViewInitializing += WebView2Initializing;

                // Retrieve the webview 2 path
                string edgeWebView2Path = GetEdgeWebView2Path();

                var webview = blazorWebView1.WebView;
                webview.CoreWebView2InitializationCompleted += Webview_CoreWebView2InitializationCompleted;


                var env = await CoreWebView2Environment.CreateAsync(edgeWebView2Path,  _f.DirDataDef);
                //, new CoreWebView2EnvironmentOptions { /* Language = */ });           
                await webview.EnsureCoreWebView2Async(env);
            }
            catch (Exception ex)
            {
                _f._icon.ShowBalloonTip(5000, "Error", ex.Message, ToolTipIcon.Error);
            }

        }

        public string GetEdgeWebView2Path()
        {
            string keyPath = @"SOFTWARE\WOW6432Node\Microsoft\EdgeUpdate\Clients\{2CD8A007-E189-409D-A2C8-9AF4EF3C72AA}";
            using (RegistryKey key = Registry.LocalMachine.OpenSubKey(keyPath))
            {
                if (key != null)
                {
                    object pathObject = key.GetValue("pv");
                    if (pathObject != null)
                    {
                        return pathObject.ToString();
                    }
                }
            }
            return null;
        }

    }
}
