using FinalProject.Services;

namespace FinalProject
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            MyDbContext db = new MyDbContext();

            MyServices services = new MyServices(db);

            Application.Run(new LoginForm());

        }
    }
}