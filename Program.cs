using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutomatedWorkplace
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            DB db = new DB();
            db.CreateDatabase(new SqlConnection("Server=localhost\\SQLEXPRESS;Trusted_Connection=True;"), "AutomatedWorkspace");
            Application.Run(new Main());
        }
    }
}
