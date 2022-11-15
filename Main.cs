using AutomatedWorkplace.Components;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutomatedWorkplace
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            //SubmitTask submitTaskUI = new SubmitTask();
            // submitTaskUI.Hide();
            //mainPanel.Controls.Add(submitTaskUI);


        }

        private void btnLearn_Click(object sender, EventArgs e)
        {

        }

        private void btnTasks_Click(object sender, EventArgs e)
        {
            Tasks tasksUI = new Tasks();
            mainPanel.Controls.Add(tasksUI);
        }

        private void btnSchedule_Click(object sender, EventArgs e)
        {
            Schedule scheduleUI = new Schedule();
            mainPanel.Controls.Add(scheduleUI);
        }
    }
}
