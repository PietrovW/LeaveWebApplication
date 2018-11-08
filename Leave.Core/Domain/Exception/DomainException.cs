using Leave.Core.Exception;
using System;
using System.Collections.Generic;
using System.Text;

namespace Leave.Core.Domain.Exception
{
    public class DomainException : LeaveException
    {
        public DomainException()
        {
        }

        public DomainException(string code) : base(code)
        {
        }

        public DomainException(string message, params object[] args) : base(string.Empty, message, args)
        {
        }

        public DomainException(string code, string message, params object[] args) : base(null, code, message, args)
        {
        }

        public DomainException(System.Exception innerException, string message, params object[] args)
            : base(innerException, string.Empty, message, args)
        {
        }

        public DomainException(System.Exception innerException, string code, string message, params object[] args)
            : base(string.Format(message, args), innerException)
        {
        }
    }
}
