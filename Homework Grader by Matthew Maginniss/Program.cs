using System;
using System.Windows.Forms;

namespace HomeworkGrader
{
    internal static class Program
    {
        /// <summary>
        ///     The Main entry point for the application.
        /// </summary>
        [STAThread]
        public static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new HomeworkGraderForm());
        }
    }
}