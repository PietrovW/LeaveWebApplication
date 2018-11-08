
namespace Leave.Core.Exception
{
   public class LeaveException : System.Exception
    {
        public string Code { get; }

        protected LeaveException()
        {
        }

        protected LeaveException(string code)
        {
            Code = code;
        }

        protected LeaveException(string message, params object[] args) : this(string.Empty, message, args)
        {
        }

        protected LeaveException(string code, string message, params object[] args) : this(null, code, message, args)
        {
        }


        protected LeaveException(System.Exception innerException, string message, params object[] args)
            : this(innerException, string.Empty, message, args)
        {
        }

        protected LeaveException(System.Exception innerException, string code, string message, params object[] args)
            : base(string.Format(message, args), innerException)
        {
            Code = code;
        }
    }
}
