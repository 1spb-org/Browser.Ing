using Microsoft.AspNetCore.Components.WebView.WindowsForms;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Web.WebView2.Core;
using Microsoft.Win32;
using Newtonsoft.Json;
using System.Collections.Concurrent;
using System.ComponentModel;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace BrowserIng.MainGUI
{
    public partial class FMain : Form, IBrowserIngForm
    {
        static string? _exeDir = Path.GetDirectoryName(
            Assembly.GetEntryAssembly()?.Location ??
            Assembly.GetExecutingAssembly()?.Location ??
            Directory.GetCurrentDirectory());

        internal string DirDataDef;
        internal ConcurrentDictionary<UInt64, Nav> _dic = new ConcurrentDictionary<ulong, Nav>();

        internal NotifyIcon _icon;
        private string[] _args;
        internal IBrowserIngListener _lsnr;
        internal Arg _cmdLine;
        internal Cfg _cfg = new Cfg();
        private string _cfgPath;

        public FMain(string[] args, IBrowserIngListener lsnr = null)
        {
            _args = args;
            this._lsnr = lsnr;

            TuneBlazor();

            ParseCmdLine();

            InitializeComponent();

            SetupDataDir(); 

            LoadSettings();

            AdjustToolbar();

            _icon = new NotifyIcon();
            _icon.Icon = Icon;
            _icon.Visible = true;
        }

        BlazorWebView? BWV =>
            ((BTabPage)tabControl1.SelectedTab!)?.WV;

        private void ParseCmdLine()
        {
            //*
            CommandLine.Parser p = new CommandLine.Parser(x => { x.EnableDashDash = true; });

            var e = p.ParseArguments<Arg>(_args);
            //*/
            _cmdLine = e?.Value ?? new Arg { };
            // MessageBox.Show(JsonConvert.SerializeObject(_cmdLine, Formatting.Indented));
        }

        private void SetupDataDir()
        {
            var dir = _cmdLine?.UserDataDir;
            DirDataDef = dir ?? Path.Combine(_exeDir, "DefaultProfile");


            Directory.CreateDirectory(DirDataDef);
            _cfgPath = Path.Combine(DirDataDef, "BrowserIng.settings.json");
        }

        private void LoadSettings()
        {
            try
            {
                _cfg = JsonConvert.DeserializeObject<Cfg>(File.ReadAllText(_cfgPath));
            }
            catch
            {
            }
        }
        internal void SaveSettings()
        {
            try
            {
                File.WriteAllText(_cfgPath, JsonConvert.SerializeObject(_cfg, Formatting.Indented));
            }
            catch
            {
            }
        }

        private void AdjustToolbar()
        {
            if (_cfg.BigToolbar)
            {
                toolStrip2.ImageList = imageList2;
                toolStrip2.ImageScalingSize = new Size(32, 32);
                _urlBarTextBox.Font = new Font(_urlBarTextBox.Font.FontFamily, 14f);
            }
            else
            {
                toolStrip2.ImageList = imageList1;
                toolStrip2.ImageScalingSize = new Size(16, 16);
            }


            toolStripButton7.ImageIndex = 69;
            toolStripButton7.DisplayStyle = ToolStripItemDisplayStyle.Image;

            toolStripButton6.ImageIndex = 65;
            toolStripButton6.DisplayStyle = ToolStripItemDisplayStyle.Image;

            toolStripButton1.ImageIndex = 80;
            toolStripButton1.DisplayStyle = ToolStripItemDisplayStyle.Image;

            toolStripButton2.ImageIndex = 121;
            toolStripButton2.DisplayStyle = ToolStripItemDisplayStyle.Image;

            toolStripButton3.ImageIndex = 132;
            toolStripButton3.DisplayStyle = ToolStripItemDisplayStyle.Image;

            toolStripButton4.ImageIndex = 144;
            toolStripButton4.DisplayStyle = ToolStripItemDisplayStyle.Image;

            toolStripButton5.ImageIndex = 1;
            toolStripButton5.DisplayStyle = ToolStripItemDisplayStyle.Image;

            toolStripButton8.ImageIndex = 108;
            toolStripButton8.DisplayStyle = ToolStripItemDisplayStyle.Image;

            toolStripButton9.ImageIndex = 40;
            toolStripButton9.DisplayStyle = ToolStripItemDisplayStyle.Image;

            toolStripButton10.ImageIndex = 98;
            toolStripButton10.DisplayStyle = ToolStripItemDisplayStyle.Image;
        }

        public void SetListener(IBrowserIngListener lsnr)
        {
            this._lsnr = lsnr;
        }



        private void FMain_Load(object sender, EventArgs e)
        {
            NewTab(_cmdLine.URI);
        }


        private void TuneBlazor()
        {
            _services = new ServiceCollection();
            _services.AddWindowsFormsBlazorWebView();
        }

        private void NewTab(string? url = null)
        {
            var uri = DefUrlGet(url);
            BTabPage bTabPage = new BTabPage(this, uri);
            tabControl1.TabPages.Add(bTabPage);
            tabControl1.SelectedTab = bTabPage;
        }

        internal void NewTabFromSrc(CoreWebView2NewWindowRequestedEventArgs e)
        {
            BTabPage bTabPage = new BTabPage(this, e.Uri);
            tabControl1.TabPages.Add(bTabPage);
            tabControl1.SelectedTab = bTabPage;
        }

        private string DefUrlGet(string? url)
        {
            var uri = url ?? _cfg.DefaultUri ?? "https://google.ie/";
            _urlBarTextBox.Text = uri;
            return uri;
        }

        private void FMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            _icon.Dispose();
            SaveSettings();
        }



        private void GoToAddressBarValue()
        {
            var webview = BWV.WebView;
            var uri = _urlBarTextBox.Text;
            if (string.IsNullOrEmpty(uri))
                return;
            BWV.HostPage = null;
            webview.Source = uri.GetUri(_cfg.SearchUri);
        }

        private void toolStripButton7_Click(object sender, EventArgs e)
        {
            var webview = BWV.WebView;
            var uri = (_cfg.DefaultUri ?? "google.ie").GetUri(_cfg.SearchUri);
            BWV.HostPage = null;
            webview.Source = uri;
        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            GoToAddressBarValue();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            var webview = BWV.WebView;
            webview.GoBack();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            var webview = BWV.WebView;
            webview.GoForward();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            var webview = BWV.WebView;
            webview.Stop();
        }



        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            BWV.WebView.Reload();
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            bool oldToolbar = _cfg.BigToolbar;
            Form form = new Form();
            form.Width = 600;
            form.Height = 400;

            form.StartPosition = FormStartPosition.CenterParent;
            form.Text = "Setup";
            form.Icon = Icon;
            form.Controls.Add(new PropertyGrid { SelectedObject = _cfg, Dock = DockStyle.Fill });
            form.ShowDialog(this);

            if (oldToolbar != _cfg.BigToolbar)
                AdjustToolbar();

        }

        private void toolStripButtonNEW_Click(object sender, EventArgs e)
        {
            NewTab();
        }

        private void tabControl1_Selected(object sender, TabControlEventArgs e)
        {
            _urlBarTextBox.Text = BWV.WebView.Source?.ToString() ?? "";
        }

        private void _urlBarTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
                GoToAddressBarValue();
        }

        private Point _dragStartPoint;
        internal ServiceCollection _services;
        // private ServiceProvider _serviceProvider;

        private void tabControl1_MouseDown(object sender, MouseEventArgs e)
        {
            _dragStartPoint = e.Location;
        }

        private void tabControl1_MouseMove_1(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (Math.Abs(e.X - _dragStartPoint.X) > SystemInformation.DragSize.Width ||
                    Math.Abs(e.Y - _dragStartPoint.Y) > SystemInformation.DragSize.Height)
                {

                    TabPage tab = GetTabAt(e.Location);
                    if (tab != null)
                    {
                        tabControl1.DoDragDrop(tab, DragDropEffects.Move);
                    }
                }
            }
        }

        private TabPage GetTabAt(Point pt)
        {
            for (int i = 0; i < tabControl1.TabCount; i++)
            {
                if (tabControl1.GetTabRect(i).Contains(pt)) return tabControl1.TabPages[i];
            }
            return null;
        }

        private void tabControl1_DragOver(object sender, DragEventArgs e)
        {
            var draggedTab = e.Data.GetData(typeof(BTabPage)) as BTabPage;


            if (draggedTab != null)
            {
                e.Effect = DragDropEffects.Move;
            }
            else
            {
                e.Effect = DragDropEffects.None;
                return;
            }

            Point pt = tabControl1.PointToClient(new Point(e.X, e.Y));

            for (int i = 0; i < tabControl1.TabCount; i++)
            {
                if (tabControl1.GetTabRect(i).Contains(pt))
                {
                    TabPage targetTab = tabControl1.TabPages[i];
                    if (draggedTab != targetTab)
                    {
                        int targetIndex = tabControl1.TabPages.IndexOf(targetTab);
                        tabControl1.TabPages.Remove(draggedTab);
                        tabControl1.TabPages.Insert(targetIndex, draggedTab);
                        tabControl1.SelectedTab = draggedTab;
                    }
                    break;
                }
            }
        }

        private void toolStripButton9_Click(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab != null && tabControl1.TabPages.Count > 1)
                tabControl1.TabPages.Remove(tabControl1.SelectedTab);
        }

        private void toolStripButton10_Click(object sender, EventArgs e)
        {
            // Проверяем, что WebView уже готов
            if (BWV?.WebView?.CoreWebView2 != null)
            {
                BWV.WebView.CoreWebView2.OpenDevToolsWindow();
            }
        }
    }

    public class Cfg
    {
        public string DefaultUri { set; get; } = "https://google.ie/search?q=1spb.org";
        public string SearchUri { set; get; } = "https://google.ie/search?q={q}";
        public bool BigToolbar { get; set; } = false;

        [JsonIgnore]
        public string FrameworkDescription => RuntimeInformation.FrameworkDescription;

        public List<Auth> AuthList { get; set; } = [];
        public List<Visit> History { get; set; } = [];
        public bool UseBlazor { get; set; } = true;
    }

    public class Visit
    {
        public DateTime When { set; get; } = DateTime.Now;
        public string URI { set; get; }
        public string Title { set; get; }

        public override string ToString()
        {
            return When + ": " +  Title + " " + URI;
        }
    }

    public class Auth
    {
        public string UrlStartsWith { get; set; }
        public string User { get; set; }

        [PasswordPropertyText(true)]
        public string Password { get; set; }
    }

    public class Nav
    {
        public DateTime FirstVisiting { get; set; }
        public DateTime LastVisiting { get; set; }
        public DateTime LastVisited { get; set; }
        public ulong NavId { get; set; }
        internal Uri URI { set; get; }
    }

    public static class _EXT_
    {
        public static Uri? GetUri(this string s, string search = null)
        {
            try
            {
                return new UriBuilder(s).Uri;
            }
            catch 
            {
                if(search != null)
                try 
                {
                        return new Uri(search.Replace("{q}", s));
                } 
                catch 
                { 
                }
                return null;
            }
        }
    }
}
