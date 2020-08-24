using System;
using System.Data;
using System.Windows.Forms;

namespace C868
{
    public partial class MainSchedule : Form
    {
        public Login loginForm;

        public static string conString = SqlUpdater.GetconString();

        public MainSchedule()
        {
            InitializeComponent();
            MainSchedule_Load(WeekRadioButton.Checked = true);
            ReminderCheck(ScheduleCalendar);
        }

        public static string SetApptId = "";

        public static string SetCustName = "";

        public void MainSchedule_Load(bool week)
        {
            DateTime filter = week ? CalcDateFilter("week") : CalcDateFilter("month");
            DataTable dtRecord = SqlUpdater.FirstCal(SqlUpdater.DateSQLFormat(filter), week);
            ScheduleCalendar.DataSource = dtRecord;
        }


        public static DateTime CalcDateFilter(string type)
        {
            if (type == "week")
            {
                DateTime week = DateTime.Now.AddDays(7);
                return week;
            }
            else
            {
                DateTime month = DateTime.Now.AddMonths(1);
                return month;
            }
        }

        public static void ReminderCheck(DataGridView ScheduleCalendar)
        {
            foreach (DataGridViewRow row in ScheduleCalendar.Rows)
            {
                DateTime now = DateTime.UtcNow;
                DateTime start = DateTime.Parse(row.Cells[4].Value.ToString()).ToUniversalTime();
                TimeSpan nowUntilStartOfApp = now - start;
                if (nowUntilStartOfApp.TotalMinutes >= -15 && nowUntilStartOfApp.TotalMinutes < 1)
                {
                    MessageBox.Show($"Reminder: There is a Team Schedule Change within 15 minutes. ");
                }
            }

        }

        private void AddTeamButton_Click(object sender, EventArgs e)
        {
            AddTeam addTeam = new AddTeam();
            addTeam.Show();
        }

        private void EditTeamButton_Click(object sender, EventArgs e)
        {
            EditTeam editTeam = new EditTeam();
            editTeam.Show();
        }

        private void DeleteTeamButton_Click(object sender, EventArgs e)
        {
            DeleteTeam deleteTeam = new DeleteTeam();
            deleteTeam.Show();
        }

        private void AddScheduleButton_Click(object sender, EventArgs e)
        {
            AddSchedule addSchedule = new AddSchedule
            {
                mainScheduleObject = this
            };
            addSchedule.Show();
        }

        private void EditScheduleButton_Click(object sender, EventArgs e)
        {
            EditSchedule editSchedule = new EditSchedule
            {
                mainScheduleObject = this
            };
            editSchedule.Show();
        }

        private void DeleteScheduleButton_Click(object sender, EventArgs e)
        {
            DeleteSchedule deleteSchedule = new DeleteSchedule
            {
                mainScheduleObject = this
            };
            deleteSchedule.Show();
        }

        private void ScheduleTypeButton_Click(object sender, EventArgs e)
        {
            ScheduleType scheduleType = new ScheduleType();
            scheduleType.Show();
        }

        private void ScheduleUserButton_Click(object sender, EventArgs e)
        {
            ScheduleUser scheduleUser = new ScheduleUser();
            scheduleUser.Show();
        }

        private void LogInReportButton_Click(object sender, EventArgs e)
        {
            LoginReport loginReport = new LoginReport();
            loginReport.Show();
        }

        private void WeekRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            MainSchedule_Load(WeekRadioButton.Checked);
        }

        private void MonthRdioButton_CheckedChanged(object sender, EventArgs e)
        {

        }
        public void UpdateCalendar()
        {
            MainSchedule_Load(WeekRadioButton.Checked);
        }

        private void ScheduleCalendar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
