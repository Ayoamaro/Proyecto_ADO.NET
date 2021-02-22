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
    public partial class Insercion_Registro : Form
    {
        DataSet ds = new DataSet();
        SqlDataAdapter da_Leagues, da_Teams;

        public Insercion_Registro()
        {
            InitializeComponent();
        }

        private void Insercion_Registro_Load(object sender, EventArgs e)
        {
            Connection cc = new Connection();
            try
            {
                cc.Con.Open();

                String query = "SELECT * FROM ligas";
                da_Leagues = new SqlDataAdapter(query, cc.Con);
                da_Leagues.Fill(ds, "Ligas");

                DataView dv_Leagues = new DataView(ds.Tables["Ligas"]);
                comboBoxLeague.DataSource = dv_Leagues;

                comboBoxLeague.DisplayMember = "nomLiga";
                comboBoxLeague.ValueMember = "codLiga";
                comboBoxLeague.DataSource = dv_Leagues;

                cc.Con.Close();

                comboBoxLeague.SelectedIndex = 0;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error: " + ex.Message);
            }
        }

        private void insertTeamBTN_Click(object sender, EventArgs e)
        {
            try
            {
                Connection cc = new Connection();
                cc.Con.Open();

                String query = "INSERT INTO equipos VALUES (@nomEquipo,@codLiga,@localidad,@internacional)";
                da_Teams = new SqlDataAdapter();
                da_Teams.InsertCommand = new SqlCommand(query, cc.Con);

                da_Teams.InsertCommand.Parameters.Add("@nomEquipo", SqlDbType.VarChar, 40).Value = nomTeamTXT.Text;
                da_Teams.InsertCommand.Parameters.Add("@codLiga", SqlDbType.Char, 5).Value = comboBoxLeague.SelectedValue;
                da_Teams.InsertCommand.Parameters.Add("@localidad", SqlDbType.VarChar, 60).Value = townTXT.Text;
                da_Teams.InsertCommand.Parameters.Add("@internacional", SqlDbType.TinyInt, 1).Value = internationalCHK.Checked;

                da_Teams.InsertCommand.ExecuteNonQuery();

                cc.Con.Close();

                MessageBox.Show("Equipo (" + nomTeamTXT.Text + ") insertado.");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error: " + ex.Message);
            }
        }
    }
}
