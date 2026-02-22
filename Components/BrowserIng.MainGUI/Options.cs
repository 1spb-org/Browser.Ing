using CommandLine.Text;
using CommandLine;
using System.Diagnostics;

namespace BrowserIng
{
    public class Arg 
    {
        [Option('b', "blazor",
            HelpText = "Uses Blazor", Default = false, Required = false)]
       public bool Blazor { get; set; }


        [Option('d', "user-data-dir",
            HelpText = "User data directory", Required = false )]
       public string? UserDataDir { get; set; }


        [Value(0, MetaName = "input URI",
            HelpText = "Input URI to be processed.",
            Required = false)]
        public string? URI { get; set; }
    }

     
  

}
