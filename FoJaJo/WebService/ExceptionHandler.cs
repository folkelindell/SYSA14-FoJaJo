using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Validation;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Services.Protocols;

namespace WebService
{
    public static class ExceptionHandler
    {
        public static Exception HandleEFException(Exception exception)
        {
            if (exception is DbUpdateConcurrencyException concurrencyEx)
            {
                return new SoapException("Database error", SoapException.ServerFaultCode);
            }
            else if (exception is DbUpdateException dbUpdateEx)
            {
                if (dbUpdateEx.InnerException != null
                        && dbUpdateEx.InnerException.InnerException != null)
                {
                    if (dbUpdateEx.InnerException.InnerException is SqlException sqlException)
                    {
                        switch (sqlException.Number)
                        {
                            case 2627:  // Unique constraint error
                            case 547:   // Constraint check violation
                            case 2601:  // Duplicated key row error
                                        // Constraint violation exception
                                        // A custom exception of yours for concurrency issues
                                return new SoapException("SQL ", SoapException.ServerFaultCode);
                            default:
                                // A custom exception of yours for other DB issues
                                return new SoapException("SQL ", SoapException.ServerFaultCode);
                        }
                    }

                    return new SoapException("SQL ", SoapException.ServerFaultCode);
                }
               
            }
            else if (exception is DbEntityValidationException)
            {
                return new SoapException("Validation error", SoapException.ServerFaultCode);
            }
            return new SoapException("Database error", SoapException.ServerFaultCode); 
        }
    }
}