using System;
using System.IO;

namespace C868
{
    class Logger
    {
        private static DateTime? _time;
        public static void SetTime(DateTime? Time)
        {
            _time = Time;
        }
        public static DateTime? GetTime()
        {
            return _time;
        }

        public static void WriteUserLoginLog(string userName)
        {

            FileStream outp = new FileStream("log.txt", FileMode.Append, FileAccess.Write);
            using (StreamWriter sr = new StreamWriter(outp))
            {
                sr.WriteLine("User Name: " + userName + " Logged in at : " + DateTime.Now.ToString());
                sr.Close();

                //Alternate code:
                //using (StreamWriter streamWriter = new StreamWriter("log.txt", true))
                //{
                //    streamWriter.WriteLine("User Name: " + userName + " Logged in at : " + DateTime.Now.ToString();
                //}
            }
        }
    }
}
