using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication
{
    public static class Error_Logger
    {
        public static void SaveLog(string pageName, string methodName, string errorMessage, string stackTrace)
        {
            DataClasses1DataContext _context = new DataClasses1DataContext();
            tbl_Error_Log log = new tbl_Error_Log();
            log.Page_Name = pageName;
            log.Method_Name = methodName;
            log.Error_Message = errorMessage;
            log.Stack_Trace = stackTrace;
            log.Created_Datetime= DateTime.Now;
            _context.tbl_Error_Logs.InsertOnSubmit(log);
            _context.SubmitChanges();

        }
    }
}