using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrowserIng.MainGUI
{
    public class BrowserIngMessage
    {
        public DateTime Time { get; set; }
        public string? Message { get; set; }
        public string? Uri { get; set; }
        public object? Source { get; set; }

    }

    public interface IBrowserIngListener
    {
        void Receive(BrowserIngMessage obj);
    }

    public interface IBrowserIngForm
    {
        void SetListener(IBrowserIngListener lsnr);
    }

}
