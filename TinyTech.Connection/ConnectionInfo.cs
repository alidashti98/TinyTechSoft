using System.Data.Entity.Core.EntityClient;
using System.Drawing;
using System.Windows.Forms;

namespace TinyTech.Connection
{
    public class ConnectionInfo
    {
        public static string ServerName;
        public static string DatabaseName;
        public static string StaticUserName = "TinyTechAdmin";
        public static string StaticPassword = "TinyTech110";
        public static string Version = $"تايني تك سافت (T.T.S) نسخه {ConnectionClasses.CurrentVersion()} - تاريخ بروزرساني 1398/01/26";
        public static string LoggedInUserName;
        public static int LoggedInUserId;
        public static Color BackgroudColor = Color.FromArgb(3, 103, 135);

        public static string BuildConnectionString()
        {
            var connString = string.Concat("data source=", ServerName, ";initial catalog=", DatabaseName, ";persist security info=True;user id=", StaticUserName, ";password=", StaticPassword, ";multipleactiveresultsets=True;application name=EntityFramework&quot;");
            return new EntityConnectionStringBuilder
            {
                Metadata = "res://*/",
                Provider = "System.Data.SqlClient",
                ProviderConnectionString = connString
            }.ToString();
        }

        public static string BuildConnectionStringOld()
        {
            var connString = string.Concat("data source=", ServerName, ";initial catalog=", DatabaseName, ";persist security info=True;user id=", StaticUserName, ";password=", StaticPassword);
            return connString;
        }
    }
}