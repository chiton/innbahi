using System.Configuration;

namespace INNBAHI.Helpers
{
    public static class AppAettingsReader
    {
        public static string MailServer
        { get { return ConfigurationManager.AppSettings["MailServer"].ToString(); } }
        public static string MailUser
        { get { return ConfigurationManager.AppSettings["MailUser"].ToString(); } }
        public static string MailPassword
        { get { return ConfigurationManager.AppSettings["MailPassword"].ToString(); } }
        public static string EmailTo
        { get { return ConfigurationManager.AppSettings["EmailTo"].ToString(); } }
    }
}