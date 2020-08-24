using System;
using System.IO;
using System.Windows.Forms;


namespace C868
{
    public partial class LoginReport : Form
    {
        public LoginReport()
        {
            InitializeComponent();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ReportButton_Click(object sender, EventArgs e)
        {
            try
            {
                string line;

                using (StreamReader sr = new StreamReader("log.txt"))
                {

                    while ((line = sr.ReadLine()) != null)
                    {
                        richTextBox1.AppendText(line);
                        richTextBox1.AppendText("\r\n");
                        line = sr.ReadLine();

                    }
                    sr.Close();

                }
            }
            catch (Exception)
            {
                MessageBox.Show("The file could not be read or there is no data.");

            }
        }
    }
}
