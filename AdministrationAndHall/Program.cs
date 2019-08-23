using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using AdministrationAndHall.UI;

namespace AdministrationAndHall
{
    static class Program
    {
           [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new BasicForm());
            
        }
    }
}
