using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Web;

namespace Asp.Net
{
    public class Logger
    {
        public static void Log(Exception Error)
        {
            Log(Error, EventLogEntryType.Error);
        }

        public static void Log(Exception Error, EventLogEntryType EventLogEntryType)
        {
            StringBuilder SBErrorMessage = new StringBuilder();
            do
            {
                SBErrorMessage.Append("Exception Type" + Environment.NewLine);
                SBErrorMessage.Append(Error.GetType().Name);
                SBErrorMessage.Append(Environment.NewLine + Environment.NewLine);
                SBErrorMessage.Append("Message" + Environment.NewLine);
                SBErrorMessage.Append(Error.Message + Environment.NewLine + Environment.NewLine);
                SBErrorMessage.Append("Stack Trace" + Environment.NewLine);
                SBErrorMessage.Append(Error.StackTrace + Environment.NewLine + Environment.NewLine);

                Error = Error.InnerException;

            } while (Error != null);

            string ErrorLog = SBErrorMessage.ToString();
            string LogProvider = ConfigurationManager.AppSettings["LogProvider"].ToUpper();
            
            if (LogProvider == "EMAIL")
            {
                SendEmail(ErrorLog);
            }
            else if (LogProvider == "DATABASE")
            {
                LogToDatabase(ErrorLog);
            }
            else if (LogProvider == "EVENTVIEWER")
            {
                LogToEventViewer(ErrorLog, EventLogEntryType);
            }
            else if(LogProvider == "BOTH")
            {
                LogToDatabase(ErrorLog);
                LogToEventViewer(ErrorLog, EventLogEntryType);
            }
            else
            {
                SendEmail(ErrorLog);
                LogToDatabase(ErrorLog);
                LogToEventViewer(ErrorLog, EventLogEntryType);
            }

        }

        private static void LogToEventViewer(string LogBody, EventLogEntryType EventLogEntryType)
        {
            if (!EventLog.SourceExists("thetahayaseen.com"))
            {
                EventLog.CreateEventSource("thetahayaseen.com", "TheTahaYaseen");
            }

            EventLog Log = new EventLog("TheTahaYaseen");
            Log.Source = "thetahayaseen.com";
            Log.WriteEntry(LogBody, EventLogEntryType);
        }

        private static void LogToDatabase(string LogBody)
        {
            string ConnectionString = "data source=DESKTOP-KMKAHQA\\SQLEXPRESS01; database=AdoStore; integrated security=SSPI; TrustServerCertificate=true;";
            SqlConnection Connection = new SqlConnection(ConnectionString);
            SqlCommand Command = new SqlCommand("SPInsertError", Connection);
            Command.CommandType = System.Data.CommandType.StoredProcedure;

            SqlParameter Parameter = new SqlParameter("@ExceptionMessage", LogBody);
            Command.Parameters.Add(Parameter);

            Connection.Open();
            Command.ExecuteNonQuery();
            Connection.Close();
        }

        public static void SendEmail(string EmailBody)
        {
            MailMessage MailMessage = new MailMessage("thetahayaseen@gmail.com", "thetahayaseen@gmail.com");
            MailMessage.Subject = "Error Log";
            MailMessage.Body = EmailBody;

            SmtpClient SmtpClient = new SmtpClient();
            // SmtpClient SmtpClient = new SmtpClient("smtp.google.com", 587);
            // SmtpClient.Credentials = new System.Net.NetworkCredential
            // {
            //     UserName = "thetahayaseen@gmail.com",
            //     Password = "********"
            // };
            // SmtpClient.EnableSsl = true;
            SmtpClient.Send(MailMessage);
        }

    }
}