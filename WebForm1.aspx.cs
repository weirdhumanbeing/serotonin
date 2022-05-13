using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CountDownToSerotonin
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DateTime dt = new DateTime(2022, 06, 24);
            //DateTime test = new DateTime(2022, 05, 9);
            TimeSpan dt2 = dt - DateTime.Now;
            int weeksResidue = dt2.Days % 7;
            int days = dt2.Days - weeksResidue;
            int weeks = (dt2.Days - weeksResidue) / 7;
            Time2.Text = weeks.ToString() + " savaitės";
            Time1.Text = dt2.Days.ToString() + " dienos, " + dt2.Hours.ToString() + " valandos, " + dt2.Minutes.ToString() + " minutės, " + dt2.Seconds.ToString() + " sekundės";

        }

        /*public string CalculateTimeDifference(DateTime startDate, DateTime endDate)
        {
            int days = 0; int hours = 0; int mins = 0; int secs = 0;
            string final = string.Empty;
            if (endDate > startDate)
            {
                days = (endDate - startDate).Days;
                hours = (endDate - startDate).Hours;
                mins = (endDate - startDate).Minutes;
                secs = (endDate - startDate).Seconds;
                final = string.Format("{0} days {1} hours {2} mins {3} secs", days, hours, mins, secs);
            }
            return final;
        }*/

    }

}