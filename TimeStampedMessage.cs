using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MqqtTest.Classes
{
    public class TimeStampedMessage : Message
    {
        public DateTime Stamp { get; set; }

        #region Construction

        public TimeStampedMessage(DateTime dateTime)
        {
            Stamp = dateTime;
        }

        public TimeStampedMessage()
        {
            Stamp = DateTime.UtcNow; // Default to the current time
        }

        #endregion

        public void ToRos(out uint secs, out uint nsecs)
        {
            var unixEpoch = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc);
            TimeSpan timeSpan = Stamp - unixEpoch;
            double msecs = timeSpan.TotalMilliseconds;
            secs = (uint)(msecs / 1000);
            nsecs = (uint)((msecs / 1000 - secs) * 1e+9);
        }

        public static TimeStampedMessage Now()
        {
            return new TimeStampedMessage(DateTime.UtcNow);
        }

        public new string ToString()
        {
            return Stamp.ToString("HH:mm:ss dd-MM-yyyy", CultureInfo.InvariantCulture);
        }
    }
}
