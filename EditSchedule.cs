using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace C868
{
    public partial class EditSchedule : Form
    {
        public EditSchedule()
        {
            InitializeComponent();
        }

        public MainSchedule mainScheduleObject;

        public static Dictionary<string, string> form = new Dictionary<string, string>();

        public static bool AppHasConflict(DateTime startTime, DateTime endTime)
        {

            foreach (var app in SqlUpdater.GetAppointments().Values)
            {

                if (startTime < DateTime.Parse(app["end"].ToString()) && DateTime.Parse(app["start"].ToString()) < endTime)
                    return true;
            }
            return false;
        }

        public static bool OutsideBusinessHours(DateTime startTime, DateTime endTime)
        {
            startTime = startTime.ToLocalTime();
            endTime = endTime.ToLocalTime();
            DateTime businessStart = DateTime.Today.AddHours(8);
            DateTime businessEnd = DateTime.Today.AddHours(17);
            if (startTime.TimeOfDay > businessStart.TimeOfDay && startTime.TimeOfDay < businessEnd.TimeOfDay &&
                endTime.TimeOfDay > businessStart.TimeOfDay && endTime.TimeOfDay < businessEnd.TimeOfDay)
                return false;
            return true;
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private bool Validator()
        {

            if (EmptyCheck() == false)
            {
                MessageBox.Show("Please complete all Schedule Information fields.");
                return false;
            }
            if (System.Text.RegularExpressions.Regex.IsMatch(TeamIdBox.Text, "[^0-9]+$"))
            {
                ShowError(TeamIdLabel.Text);
                return false;
            }
            if (System.Text.RegularExpressions.Regex.IsMatch(TypeBox.Text, "[^a-zA-Z]+$"))
            {
                ShowError(TypeLabel.Text);
                return false;
            }
            if (System.Text.RegularExpressions.Regex.IsMatch(StartTimeBox.Text, "[^0-9:/]+$"))
            {
                ShowError(StartLabel.Text);
                return false;
            }
            if (System.Text.RegularExpressions.Regex.IsMatch(EndTimeBox.Text, "[^0-9:/]+$"))
            {
                ShowError(EndLabel.Text);
                return false;
            }
            return true;
        }

        private void ShowError(string item)
        {
            MessageBox.Show("Please enter valid information for " + item);
        }

        private bool EmptyCheck()
        {
            foreach (Control c in this.Controls)
            {
                if (c is TextBox)
                {
                    TextBox textBox = c as TextBox;
                    if (string.IsNullOrEmpty(textBox.Text))
                    {
                        return false;
                    }
                }
                if (c is ComboBox)
                {
                    ComboBox combo = c as ComboBox;
                    if (combo.SelectedIndex == -1)
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            string appointmentId = SearchBar.Text;
            form = SqlUpdater.GetAppointmentDetails(appointmentId);
            TeamIdBox.Text = form["customerId"];
            TypeBox.Text = form["type"];
            StartTimeBox.Text = SqlUpdater.ConvertToTimezone(form["start"]);
            EndTimeBox.Text = (SqlUpdater.ConvertToTimezone(form["end"]));
        }

        private void TeamIdBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            string timestamp = SqlUpdater.CreateTimestamp();
            int userId = SqlUpdater.GetCurrentUserID();
            string username = SqlUpdater.GetCurrentUserName();
            int appointmentId = Convert.ToInt32(SearchBar.Text);
            int customerId = Convert.ToInt32(TeamIdBox.Text);
            string type = TypeBox.Text;
            DateTime startTime = DateTime.Parse(StartTimeBox.Text).ToUniversalTime();
            DateTime endTime = DateTime.Parse(EndTimeBox.Text).ToUniversalTime();
            //String st = DateTime.Parse(StartTimeBox.Text).ToUniversalTime().ToString("u");
            //String et = DateTime.Parse(EndTimeBox.Text).ToUniversalTime().ToString("u");
            String st = DateTime.Parse(StartTimeBox.Text).ToUniversalTime().ToString("yyyy-MM-dd hh:mm:ss");
            String et = DateTime.Parse(EndTimeBox.Text).ToUniversalTime().ToString("yyyy-MM-dd hh:mm:ss");

            bool pass = Validator();
            if (pass)

                try
                {
                    if (AppHasConflict(startTime, endTime))
                        throw new ScheduleException();
                    else
                    {
                        try
                        {
                            if (OutsideBusinessHours(startTime, endTime))
                                throw new ScheduleException();
                            else
                            {

                                SqlUpdater.UpdateAppt(customerId, userId, st, et, type, timestamp, username, appointmentId);

                                mainScheduleObject.UpdateCalendar();
                                MessageBox.Show("Update Sucessfull.");
                                Close();

                            }
                        }
                        catch (ScheduleException ex) { ex.BusinessHours(); }

                    }
                }
                catch (ScheduleException ex) { ex.AppOverlap(); }

            else
            {

                MessageBox.Show("Add Schedule Error.");
            }
        }


        private void CancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
