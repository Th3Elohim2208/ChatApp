using System;
using System.Linq;
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

            int port = 11000; // Puerto predeterminado
            // Busca el argumento "-port" y trata de obtener el valor después de este
            int portIndex = Array.IndexOf(args, "-port");
            if (portIndex >= 0 && portIndex < args.Length - 1 && int.TryParse(args[portIndex + 1], out int parsedPort))
            {
                port = parsedPort;
            }

            Application.Run(new Form1(port));
        }
    }
}
