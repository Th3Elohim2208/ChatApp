using System;
using System.Windows.Forms;

namespace ChatApp
{
    static class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            int port = 11000; // Default port
            if (args.Length > 0 && int.TryParse(args[0], out int parsedPort))
            {
                port = parsedPort;
            }

            Application.Run(new Form1(port));
        }
    }
}
