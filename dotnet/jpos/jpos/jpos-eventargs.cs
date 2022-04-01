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

}
