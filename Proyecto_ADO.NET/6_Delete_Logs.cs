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
    public partial class Borrado_Registro : Form
    {
        DataSet ds = new DataSet();
        SqlDataAdapter da_Teams;

        public Borrado_Registro()
        {
            InitializeComponent();
        }

        private void loadRecordBTN_Click(object sender, EventArgs e)
        {
            Connection cc = new Connection();
            try
            {
                cc.Con.Open();

                String query = "SELECT * FROM equipos WHERE codEquipo=" + codTeamTXT.Text;
                da_Teams = new SqlDataAdapter(query, cc.Con);

                da_Teams.Fill(ds, "Equipos");

                nomTeamTXT.Text = ds.Tables["Equipos"].Rows[0]["nomEquipo"].ToString();
                codLigaTXT.Text = ds.Tables["Equipos"].Rows[0]["codLiga"].ToString();
                townTXT.Text = ds.Tables["Equipos"].Rows[0]["localidad"].ToString();
                internationalCHK.Checked = Convert.ToBoolean(ds.Tables["Equipos"].Rows[0]["internacional"]);

                ds.Clear();

                cc.Con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error: " + ex.Message);
            }
        }

        private void deleteTeamBTN_Click(object sender, EventArgs e)
        {
            Connection cc = new Connection();
            try
            {
                cc.Con.Open();

                String query = "DELETE FROM equipos WHERE codEquipo=@codEquipo";
                da_Teams = new SqlDataAdapter();
                da_Teams.DeleteCommand = new SqlCommand(query, cc.Con);

                da_Teams.DeleteCommand.Parameters.Add("@codEquipo", SqlDbType.Int).Value = codTeamTXT.Text;
                da_Teams.DeleteCommand.ExecuteNonQuery();

                cc.Con.Close();
                MessageBox.Show("Registro (" + codTeamTXT.Text + ") borrado.");

                codTeamTXT.Text = "";
                nomTeamTXT.Text = "";
                codLigaTXT.Text = "";
                townTXT.Text = "";
                internationalCHK.Checked = false;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error: " + ex.Message);
            }
        }
    }
}
