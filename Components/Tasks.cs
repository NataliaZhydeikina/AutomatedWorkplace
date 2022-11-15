using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutomatedWorkplace.Components
{
    public partial class Tasks : UserControl
    {
        public Tasks()
        {
            InitializeComponent();
        }

        private void Tasks_Load(object sender, EventArgs e)
        {
            using (SqlConnection connection = GetConnection())
            {
                string query = "SELECT ts.Title,ts.Description,ts.link,sb.SubjectTitle,tch.Name,tch.Surname, tch.Email FROM Tasks as ts, Subjects as sb, Teachers as tch WHERE ts.SubjectId = sb.SubjectId AND ts.TeacherId = tch.TeacherId";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable table = new DataTable();
                adapter.Fill(table);

                if (table.Rows.Count > 0)
                {
                    var cells =  table.Rows[0].ItemArray;
                    title.Text = cells[0].ToString();
                    description.Text = cells[1].ToString();
                    link.Text = "https://docs.google.com/document/d/"+ cells[2].ToString()+"/edit?usp=sharing";

                    subject.Text = cells[3].ToString();
                    teacher.Text = cells[4].ToString()+" "+ cells[5].ToString()+" ("+cells[6].ToString()+ "@stud.nau.edu.ua)";
                }
            }
        }

        private SqlConnection GetConnection()
        {
            return new SqlConnection("Server=localhost\\SQLEXPRESS;Trusted_Connection=True;Initial Catalog=AutomatedWorkspace;");
        }


    }
}
