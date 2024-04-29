using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Asp.Net
{
    public partial class CalendarControl : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Calendar.Visible = false;
                Button.Text = "Show";
                CalDate.Text = "";

                Calendar.DayHeaderStyle.BackColor = Color.Black;
                Calendar.DayHeaderStyle.ForeColor = Color.White;

                Calendar.DayNameFormat = DayNameFormat.Full;
                Calendar.FirstDayOfWeek = FirstDayOfWeek.Friday;
                Calendar.NextMonthText = ">>";
                Calendar.PrevMonthText = "<<";

                Calendar.NextPrevFormat = NextPrevFormat.FullMonth;

                Calendar.SelectionMode = CalendarSelectionMode.DayWeekMonth;
                Calendar.SelectMonthText = "Month >";
                Calendar.SelectWeekText = "Week >";

            }
        }

        protected void Button_Click(object sender, EventArgs e)
        {
            Calendar.Visible = !Calendar.Visible;
            Button.Text = Calendar.Visible ? "Hide" : "Show";
        }

        protected void Calendar_SelectionChanged(object sender, EventArgs e)
        {
            StringBuilder DateText = new StringBuilder("Selected Dates: <br/>");
            foreach(DateTime SelectedDate in Calendar.SelectedDates)
            {
                DateText.Append(SelectedDate.ToLongDateString() + "<br/>");
            }
            CalDate.Text = DateText.ToString();
        }

        protected void Calendar_DayRender(object sender, DayRenderEventArgs e)
        {
            if (e.Day.IsOtherMonth || e.Day.IsWeekend)
            {
                e.Day.IsSelectable = false;
                e.Cell.ForeColor = Color.Red;
            }
            else if (e.Day.Date.Day % 2 == 0){
                e.Day.IsSelectable = false;
                e.Cell.BackColor = Color.White;
                e.Cell.ForeColor = Color.Red;
                e.Cell.Font.Bold = true;
                e.Cell.Text = "X";
                e.Cell.ToolTip = "Booked";
            }
        }

        protected void Calendar_VisibleMonthChanged(object sender, MonthChangedEventArgs e)
        {
            string OldMonth = GetMonthName(e.PreviousDate.Month);
            string NewMonth = GetMonthName(e.NewDate.Month);

            CalDate.Text = String.Format("Changed from {0} to {1}", OldMonth, NewMonth);
        }

        private string GetMonthName(int MonthNumber)
        {
            switch (MonthNumber)
            {
                case 1:
                    return "January";
                case 2:
                    return "February";
                case 3:
                    return "March";
                case 4:
                    return "April";
                case 5:
                    return "May";
                case 6:
                    return "June";
                case 7:
                    return "July";
                case 8:
                    return "August";
                case 9:
                    return "September";
                case 10:
                    return "October";
                case 11:
                    return "November";
                case 12:
                    return "December";
                default:
                    return "Invalid month number";
            }
        }
    }
}