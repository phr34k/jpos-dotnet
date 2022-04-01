using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test.jpos
{
    public class JavaException : Exception
    {
        public JavaException(string message) : base(message)
        {

        }
    }

    public class PosException : Exception
    {
        public PosException(string message) : base(message)
        {

        }

        public PosException(string message, Exception innerException) : base(message, innerException)
        {

        }
    }

    public class PosInvalidStateException : PosException
    {
        public PosInvalidStateException() : base("")
        {

        }
    }

    public class PosControlException : PosException
    {
        public PosControlException(string message) : base(message)
        {
            ErrorCode = 0;
            ErrorCodeExtended = 0;
        }
        public PosControlException(string message, ErrorCode errorCode) : base(message)
        {
            ErrorCode = errorCode;
            ErrorCodeExtended = 0;
        }
        public PosControlException(string message, ErrorCode errorCode, int extendedErrorCode) : base(message)
        {
            ErrorCode = errorCode;
            ErrorCodeExtended = extendedErrorCode;
        }

        public PosControlException(string message, ErrorCode errorCode, int extendedErrorCode, Exception innerException) : base(message, innerException)
        {
            ErrorCode = errorCode;
            ErrorCodeExtended = extendedErrorCode;
        }

        public ErrorCode ErrorCode { get; protected set; }
        public int ErrorCodeExtended { get; protected set; }
    }



}
