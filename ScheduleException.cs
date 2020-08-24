using System;
using System.Windows.Forms;

namespace C868
{
    class ScheduleException : ApplicationException
    {
        public void BusinessHours()
        {
            MessageBox.Show("Exception occured. Please reschedule for normal business hours.");

        }

        public void AppOverlap()
        {
            MessageBox.Show("Exception occured. This schedule time has already been taken.");
        }

        public ScheduleException(string message) : base(message)
        {
        }

        public ScheduleException(string message, Exception innerException) : base(message, innerException)
        {
        }

        public ScheduleException()
        {
        }
    }
}
