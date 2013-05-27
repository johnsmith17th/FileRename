using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace FileRename
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            MainForm form = new MainForm();
            if (args != null && args.Length > 0)
            {
                form.Source = args[0];
            }
            Application.Run(form);
        }
    }
}
