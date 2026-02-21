using CommandLine.Text;
using CommandLine; 

namespace BrowserIng
{
    interface IOptions
    {

        [Option('d', "user-data-dir",
            SetName = "user-data-dir",
            HelpText = "User data directory")]
        string? UserDataDir { get; set; }

        [Option('b', "blazor",
            SetName = "blazor",
            HelpText = "Uses Blazor")]
        bool? Blazor { get; set; }


        [Value(0, MetaName = "input URI",
            HelpText = "Input URI to be processed.",
            Required = false)]
        string URI { get; set; }
    }

     
    class Arg : IOptions
    {
        public string? UserDataDir { get; set; }
        public string URI { get; set; }
        public bool? Blazor { get; set; }
    }

}
