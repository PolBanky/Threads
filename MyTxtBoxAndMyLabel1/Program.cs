using System;
using System.Windows.Forms;

namespace Threads
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        /// 
        static public char divide_true = ' ', divide_false = ' ';

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Program.divider();
            Application.Run(new Form1());
        }   // завершение Main()

  // divider
        static void divider()
        {
            string a;
            a = Application.CurrentCulture.NumberFormat.NumberDecimalSeparator;
            //label1.Text = a[0] + ";";
            if(a[0]==',')
            { divide_true = ','; divide_false = '.'; }
            else
            { divide_true = '.'; divide_false = ','; }
        }	// завершение divider()

    }       // завершение class Program
}           // завершение namespace MyTxtBoxAndMyLabel1
