using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GraphExperiment
{
    static class Program
    {
        public static Dashboard Dashboard;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Dashboard = new Dashboard();
            Application.Run(Dashboard);
        }
    }
}
