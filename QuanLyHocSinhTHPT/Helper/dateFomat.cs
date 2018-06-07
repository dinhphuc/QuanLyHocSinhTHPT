using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyHocSinhTHPT.Helper
{
    internal class dateFomat
    {
        public static void SetMyCustomFormat(DateTimePicker dt)
        {
            //Document
            #region
            /*
             d		The one- or two-digit day.
             dd		The two-digit day. Single-digit day values are preceded by a 0.
             ddd		The three-character day-of-week abbreviation.
             dddd	The full day-of-week name.
             h		The one- or two-digit hour in 12-hour format.
             hh		The two-digit hour in 12-hour format. Single digit values are preceded by a 0.
             H		The one- or two-digit hour in 24-hour format.
             HH		The two-digit hour in 24-hour format. Single digit values are preceded by a 0.
             m		The one- or two-digit minute.
             mm		The two-digit minute. Single digit values are preceded by a 0.
             M		The one- or two-digit month number.
             MM		The two-digit month number. Single digit values are preceded by a 0.
             MMM		The three-character month abbreviation.
             MMMM	The full month name.
             s		The one- or two-digit seconds.
             ss		The two-digit seconds. Single digit values are preceded by a 0.
             t		The one-letter A.M./P.M. abbreviation (A.M. is displayed as "A").
             tt		The two-letter A.M./P.M. abbreviation (A.M. is displayed as "AM").
             y		The one-digit year (2001 is displayed as "1").
             yy		The last two digits of the year (2001 is displayed as "01").
             yyyy	The full year (2001 is displayed as "2001").
             */
            #endregion
            // Set the Format type and the CustomFormat string.
            dt.Format = DateTimePickerFormat.Custom;
            dt.CustomFormat = "dd/MM/yyyy";
        }
    }
}