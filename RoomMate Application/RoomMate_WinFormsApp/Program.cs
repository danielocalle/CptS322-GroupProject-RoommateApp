namespace RoomMate_WinFormsApp
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
<<<<<<< HEAD
            Application.Run(new login());
=======
           Application.Run(new login());
>>>>>>> 750755548165ca89d60c911423241bea5448968e
            Application.Run(new Form1());
            //Application.Run(new messageDash());
        }
    }
}