using PeriodicTable.Views;

namespace PeriodicTable.ViewModels
{
    public static class LoggerWindow
    {
        private static ErrorLoggerWindow elw = new ErrorLoggerWindow();
        public static bool WindowVisible = false;

        static LoggerWindow()
        {
            elw.WndClosing = WindowClosing;
        }

        public static void ShowWindow()
        {
            elw.Show();
            WindowVisible = true;
        }

        public static void HideWindow()
        {
            elw.Hide();
            WindowVisible = false;
        }

        public static void AddError(string errName, string description)
        {
            elw.AddError(errName, description);
        }

        public static void AddMessage(string message)
        {
            elw.AddMessage(message);
        }

        private static void WindowClosing()
        {
            HideWindow();
        }
    }
}
