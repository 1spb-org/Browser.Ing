using BrowserIng.MainGUI;
using Microsoft.Win32;
using Newtonsoft.Json;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace WAF
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
     

        [STAThread]
        static void Main(string[] args)
        {
            try
            {
                string exePath = Process.GetCurrentProcess()!.MainModule!.FileName;
                RegisterProtocol("browsering", exePath);
            }
            catch 
            { 
            }

            if (args.FirstOrDefault() == "-console")
            {
                args = args.Skip(1).ToArray(); 
                ConsoleBrowserListener lsnr = new ConsoleBrowserListener();
                Helper.AllocConsole();
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new FMain(args, lsnr));
                Helper.FreeConsole();
                return;
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FMain(args));
        
        }


        public static void RegisterProtocol(string scheme, string executablePath)
        {
            // Путь в реестре для текущего пользователя (не требует прав админа)
            string root = $@"Software\Classes\{scheme}";

            using (var key = Registry.CurrentUser.CreateSubKey(root))
            {
                key.SetValue("", $"URL:{scheme} Protocol");
                key.SetValue("URL Protocol", "");

                using (var shellKey = key.CreateSubKey(@"shell\open\command"))
                {
                    // %1 передает URI целиком в аргументы командной строки
                    shellKey.SetValue("", $"\"{executablePath}\" \"%1\"");
                }
            }
        }

        public static class Helper
        {

            [DllImport("kernel32.dll")]
            public static extern Boolean AllocConsole();

            [DllImport("kernel32.dll")]
            public static extern Boolean FreeConsole();
        }
    }

    internal class ConsoleBrowserListener: IBrowserIngListener
    { 
        public void Receive(BrowserIngMessage obj)
        { 
            Console.WriteLine( JsonConvert.SerializeObject(obj));
        }
    }
}