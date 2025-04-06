using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChatApplication
{
    internal static class Program
    {
        public static ChatClient chatClient;
        private static string ip = "127.0.0.1";
        private static int port = 12345;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            chatClient = new ChatClient();
            try
            {
                chatClient.Connect(ip, port); // IP và port phải giống trong server
            }
            catch (Exception ex)
            {
                MessageBox.Show("Cannot connect to server: " + ex.Message);
                Environment.Exit(1);
            }
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}
