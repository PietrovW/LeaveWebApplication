using System;

namespace Leave.DAL.Models.Base
{
    public class ResultCode
    {
        public ResultCode(Exception exception=null)
        {
            ExceptionAnalize(exception);
        }
        public Exception Exception { get; private set; }
        public bool IsError { get; private set; }
        public int RowsAffected { get; private set; }
        public ReturnCode ReturnCode { get; private set; }

        private void ExceptionAnalize(Exception exception = null)
        {
            IsError = true;
            ReturnCode = ReturnCode.SUCCEEDED;
           if ( exception!=null)
            {
                IsError = false;
                ReturnCode = ReturnCode.ERROR;
                Exception = exception;
            }
        }
    }


    public enum ReturnCode
    {
        ERROR = -1,
        SUCCEEDED = 0
    }
}