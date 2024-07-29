namespace ChatApp
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        public static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            int port = args.Length > 0 ? int.Parse(args[0]) : 11000; // Usar puerto 11000 por defecto si no se especifica

            Application.Run(new Form1(port));
        }
    }
}