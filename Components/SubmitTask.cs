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

namespace AutomatedWorkplace.Components
{
    public partial class SubmitTask : UserControl
    {
        public SubmitTask()
        {
            InitializeComponent();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.ShowDialog();
            fileInput.Text = openFileDialog.FileName;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveFile(fileInput.Text);
            MessageBox.Show("Saved");
        }

        private void SaveFile(string filePath)
        {
            using (Stream stream = File.OpenRead(filePath))
            {
                byte[] buffer = new byte[stream.Length];
                stream.Read(buffer, 0, buffer.Length);
                string extn = new FileInfo(filePath).Extension;

                string query = "INSERT INTO Documents(Data,Extension) VALUES(@data, @extn)";

                using (SqlConnection connection = GetConnection())
                {
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.Add("@data", SqlDbType.VarBinary).Value = buffer;
                    command.Parameters.Add("@extn", SqlDbType.Char).Value = extn;
                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }

        private SqlConnection GetConnection()
        {
            return new SqlConnection("Server=localhost\\SQLEXPRESS;Trusted_Connection=True;Initial Catalog=AutomatedWorkspace;");
        }

        private void Start_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            using (SqlConnection connection = GetConnection())
            {
                string query = "SELECT Id, Data, Extension From Documents";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable table = new DataTable();
                adapter.Fill(table);

                if (table.Rows.Count > 0)
                {
                    dataGridView1.DataSource = table;
                }
            }
        }


    }
}
