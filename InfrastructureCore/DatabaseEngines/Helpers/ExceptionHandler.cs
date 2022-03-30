using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfrastructureCore.DatabaseEngines.Helpers
{
    public class ExceptionHandler
    {
        public static void Publish(System.Exception innerException, bool raiseException)
        {
            // write to all trace listeners
            Trace.WriteLineIf(true, Format(innerException));
            if (raiseException)
            {
                throw innerException;
            }
        }

        public static void Publish(string traceMessage)
        {
            // write to all trace listeners
            Trace.WriteLineIf(true, traceMessage);
        }

        static public string Format(System.Exception exception)
        {
            string tmp = string.Empty;
            StringBuilder msg = null;
            DateTime dateTime = DateTime.Now;
            try
            {
                msg = new StringBuilder();
                msg.AppendLine();
                msg.AppendLine("==============[System Error Tracing]==============");
                msg.AppendLine("[CallStackTrace]");
                msg.AppendLine(exception.StackTrace);

               
                msg.AppendLine("\r\n[DateTime] : " + dateTime.ToString("yyyy-MM-dd HH:mm:ss"));

               
                if (exception.GetType() == typeof(System.Data.SqlClient.SqlException))
                {
                    SqlException sqlErr = (SqlException)exception;
                    msg.Append("\r\n[SqlException] ");
                    msg.Append("\r\nException Type: ").Append(sqlErr.GetType());
                    msg.Append("\r\nErrors: ").Append(sqlErr.ErrorCode);
                    msg.Append("\r\nMessage: ").Append("{" + sqlErr.Message + "}");
                }
               
                else
                {
                    msg.Append("\r\n[Exception] ");
                    msg.Append("\r\n" + "DetailMsg: {" + exception.Message + "}");
                }
            }
            catch
            {
                //throw ex;
            }

            return msg.ToString();
        }
    }
}
