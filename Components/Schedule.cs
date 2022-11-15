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
    public partial class Schedule : UserControl
    {
        public Schedule()
        {
            InitializeComponent();
            labels = new Label[][] {
                new Label[] { label10, label15, label20 },
                new Label[] { label9, label14, label19 },
                new Label[] { label8, label13, label18 },
                new Label[] { label7, label12, label17 },
                new Label[] { label6, label11, label16 },
            };
        }

        private Label[][] labels;
        private void Schedule_Load(object sender, EventArgs e)
        {
            using (SqlConnection connection = GetConnection())
            {
                string query = "SELECT Time,Date,Audience,StudentGroup,sb.SubjectTitle FROM Lectures as lc, Subjects as sb WHERE lc.SubjectId = sb.SubjectId";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable table = new DataTable();
                adapter.Fill(table);

                if (table.Rows.Count > 0)
                {
                    
                    for (int i = 0, j=0; i < table.Rows.Count && j<labels.Length; i += 3, j++)
                    {
                        var cells = table.Rows[i].ItemArray;
                        //var cells2 = table.Rows[i+1].ItemArray;
                        //var cells3 = table.Rows[i + 2].ItemArray;
                        //labels[j][0].Text = cells[4].ToString();
                        //labels[j][1].Text = cells2[4].ToString();
                        //labels[j][2].Text = cells3[4].ToString();

                    }

                       
                    }
            }
        }

        private SqlConnection GetConnection()
        {
            return new SqlConnection("Server=localhost\\SQLEXPRESS;Trusted_Connection=True;Initial Catalog=AutomatedWorkspace;");
        }
    }
}
