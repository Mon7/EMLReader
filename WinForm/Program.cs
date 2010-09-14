using System;
using System.Linq;
using System.Windows.Forms;

namespace EmlReader.WinForm
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            var emlViewer = new EmlViewer();
            if (args.Any())
                emlViewer.OpenEml(args.First());
            Application.Run(emlViewer);
        }
    }
}
