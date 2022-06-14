using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test.jpos
{

    public abstract class PosEventArgs : EventArgs
    {
        protected PosEventArgs() { }
        public DateTime TimeStamp { get; protected set; }
        public int EventId { get; protected set; }
    }


    public class DataEventArgs : PosEventArgs
    {
        public DataEventArgs(int status, DateTime time, int eventId)
        {
            Status = status;
            TimeStamp = time;
            EventId = eventId;
        }
        public int Status { get; protected set; }

        public override string ToString()
        {
            return string.Format("{0} {1} {2}", EventId, TimeStamp, Status);
        }
    }


    public class OutputCompleteEventArgs : PosEventArgs
    {
        public int OutputId { get; protected set; }

        public OutputCompleteEventArgs(int outputId, DateTime time, int eventId)
        {
            OutputId = outputId;
            TimeStamp = time;
            EventId = eventId;            
        }

        public override string ToString()
        {
            return base.ToString() + ", OutputId: " + OutputId.ToString(System.Globalization.CultureInfo.InvariantCulture);
        }
    }

    [Serializable]
    public class StatusUpdateEventArgs : PosEventArgs
    {
        public StatusUpdateEventArgs(int status, DateTime time, int eventId)
        {
            Status = status;
            TimeStamp = time;
            EventId = eventId;
        }
        public int Status { get; protected set; }

        public override string ToString()
        {
            return string.Format("{0} {1} {2}", EventId, TimeStamp, Status);
        }

        /*
        public override string ToString()
        {
            return base.ToString() + ", Status: " + m_Status.ToString(System.Globalization.CultureInfo.InvariantCulture);
        }
        */
    }


    public class DeviceErrorEventArgs : PosEventArgs
    {
        //private PosResourceManager resourceManager;

        private ErrorCode errorcode;

        private int errorcodeextended;

        private ErrorLocus errorlocus;

        internal ErrorResponse errorresponse;

        public ErrorCode ErrorCode => errorcode;

        public int ErrorCodeExtended => errorcodeextended;

        public ErrorLocus ErrorLocus => errorlocus;

        public ErrorResponse ErrorResponse
        {
            get
            {
                return errorresponse;
            }
            set
            {
                ValidateErrorResponse(value);
                errorresponse = value;
            }
        }




        //
        // Summary:
        //     Creates an instance of the DeviceErrorEventArgs class with the specified data.
        //
        // Parameters:
        //   errorCodeExtended:
        //     The device extended error code. This value is device-specific.
        //
        //   errorLocus:
        //     The location of the error.
        //
        //   errorCode:
        //     The device error code.
        //
        //   errorResponse:
        //     The error response.
        public DeviceErrorEventArgs(ErrorCode errorCode, int errorCodeExtended, ErrorLocus errorLocus, ErrorResponse errorResponse, DateTime time, int eventId)
        {
            if (errorCode < ErrorCode.Closed || errorCode > ErrorCode.Extended)
            {
                ThrowPosException("IDS_ERR_INVALID_ERROR_CODE", ErrorCode.Illegal);
            }

            if (errorLocus != ErrorLocus.Input && errorLocus != ErrorLocus.InputData && errorLocus != ErrorLocus.Output)
            {
                ThrowPosException("IDS_ERR_INVALID_ERROR_LOCUS", ErrorCode.Illegal);
            }

            ValidateErrorResponse(errorResponse);
            errorcode = errorCode;
            errorcodeextended = errorCodeExtended;
            errorlocus = errorLocus;
            errorresponse = errorResponse;
            TimeStamp = time;
            EventId = eventId;            
        }

        private void ThrowPosException(string errorId, ErrorCode errorCode)
        {
            /*
            if (resourceManager == null)
            {
                resourceManager = new PosResourceManager(Assembly.GetExecutingAssembly());
            }
            */
            throw new PosControlException(errorId.ToString(), errorCode);
        }

        private void ValidateErrorResponse(ErrorResponse response)
        {
            if (response != ErrorResponse.Clear && response != ErrorResponse.ContinueInput && response != ErrorResponse.Retry)
            {
                ThrowPosException("IDS_ERR_INVALID_ERROR_RESPONSE", ErrorCode.Illegal);
            }
        }

        public override string ToString()
        {
            return base.ToString() + ", ErrorCode: " + errorcode.ToString() + ", ErrorCodeExtended: " + errorcodeextended.ToString(System.Globalization.CultureInfo.InvariantCulture) + ", ErrorLocus: " + errorlocus.ToString() + ", ErrorResponse: " + errorresponse;
        }
    }

}
