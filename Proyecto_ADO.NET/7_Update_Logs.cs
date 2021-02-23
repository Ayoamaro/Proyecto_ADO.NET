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
    public partial class Update_Logs : Form
    {
        DataSet ds = new DataSet();
        SqlDataAdapter da_Leagues, da_Teams;

        public Update_Logs()
        {
            InitializeComponent();
        }

        private void loadRecordBTN_Click(object sender, EventArgs e)
        {
            Connection cc = new Connection();
            try
            {
                cc.Con.Open();

                ds.Clear();
                String query;

                query = "SELECT * FROM ligas";
                da_Leagues = new SqlDataAdapter(query, cc.Con);
                da_Leagues.Fill(ds, "Ligas");

                DataView dv_Leagues = new DataView(ds.Tables["Ligas"]);
                comboBoxLeague.DataSource = dv_Leagues;

                comboBoxLeague.DisplayMember = "nomLiga";
                comboBoxLeague.ValueMember = "codLiga";
                comboBoxLeague.DataSource = dv_Leagues;

                comboBoxLeague.SelectedIndex = 0;

                query = "SELECT * FROM equipos WHERE codEquipo=" + codTeamTXT.Text;
                da_Teams = new SqlDataAdapter(query, cc.Con);

                da_Teams.Fill(ds, "Equipos");

                nomTeamTXT.Text = ds.Tables["Equipos"].Rows[0]["nomEquipo"].ToString();
                comboBoxLeague.SelectedValue = ds.Tables["Equipos"].Rows[0]["codLiga"].ToString();
                townTXT.Text = ds.Tables["Equipos"].Rows[0]["localidad"].ToString();
                internationalCHK.Checked = Convert.ToBoolean(ds.Tables["Equipos"].Rows[0]["internacional"]);

                cc.Con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error: " + ex.Message);
            }
        }

        private void updateTeamBTN_Click(object sender, EventArgs e)
        {
            Connection cc = new Connection();
            try
            {
                cc.Con.Open();

                String query = "UPDATE equipos SET nomEquipo=@nomEquipo, codLiga=@codLiga, localidad=@localidad, internacional=@internacional " 
                             + "WHERE codEquipo=@codEquipo";
                da_Teams = new SqlDataAdapter();
                da_Teams.UpdateCommand = new SqlCommand(query, cc.Con);

                da_Teams.UpdateCommand.Parameters.Add("@codEquipo", SqlDbType.Int).Value = codTeamTXT.Text;

                da_Teams.UpdateCommand.Parameters.Add("@nomEquipo", SqlDbType.VarChar, 40).Value = nomTeamTXT.Text;
                da_Teams.UpdateCommand.Parameters.Add("@codLiga", SqlDbType.Char, 5).Value = comboBoxLeague.SelectedValue;
                da_Teams.UpdateCommand.Parameters.Add("@localidad", SqlDbType.VarChar, 60).Value = townTXT.Text;
                da_Teams.UpdateCommand.Parameters.Add("@internacional", SqlDbType.TinyInt, 1).Value = internationalCHK.Checked;

                da_Teams.UpdateCommand.ExecuteNonQuery();

                cc.Con.Close();

                MessageBox.Show("Equipo (" + nomTeamTXT.Text + ") modificado.");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error: " + ex.Message);
            }
        }
    }
}
