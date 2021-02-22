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

namespace Proyecto_ADO.NET
{
    public partial class Leer_Registros : Form
    {
        DataTable dt;

        public Leer_Registros()
        {
            InitializeComponent();
        }

        private void Leer_Registros_Load(object sender, EventArgs e)
        {
            Connection cc = new Connection();
            try
            {
                cc.Con.Open();

                String query = "SELECT * FROM ligas";
                SqlCommand command = new SqlCommand(query, cc.Con);

                SqlDataReader reader = command.ExecuteReader();
                dt = new DataTable();

                dt.Load(reader);

                dataGridLeague.DataSource = dt;

                dataGridLeague.Columns[0].HeaderText = "Código de Liga";
                dataGridLeague.Columns[1].HeaderText = "Nombre";

                countLeagueLBL.Text = "Número de Ligas: " + dt.Rows.Count.ToString();

                cc.Con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error: " + ex.Message);
            }
        }
    }
}
