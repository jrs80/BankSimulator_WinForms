using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankingApp
{
    internal static class Error
    {
        public static void ShowError(string msg="")
        {
            Console.WriteLine($"Error generated: {msg}");
            MessageBox.Show(msg, "Error!");
        }
    }
}
