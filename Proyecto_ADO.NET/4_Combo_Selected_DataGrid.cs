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
    public partial class Combo_Selected_DataGrid : Form
    {
        DataSet ds = new DataSet();
        SqlDataAdapter da_Leagues, da_Teams;

        public Combo_Selected_DataGrid()
        {
            InitializeComponent();
        }

        private void comboBoxLeague_SelectedIndexChanged(object sender, EventArgs e)
        {
            Connection cc = new Connection();
            try
            {
                cc.Con.Open();

                if (ds.Tables["Equipos"] != null) {
                    ds.Tables["Equipos"].Clear();
                }

                /* Equipos */
                String query = "SELECT * FROM equipos";
                da_Teams = new SqlDataAdapter(query, cc.Con);
                da_Teams.Fill(ds, "Equipos");

                DataView dv_Teams = new DataView(ds.Tables["Equipos"]);
                dv_Teams.RowFilter = "codLiga = '" + comboBoxLeague.SelectedValue + "'";
                dataGridTeam.DataSource = dv_Teams;

                dataGridTeam.Columns[0].HeaderText = "Código de Equipo";
                dataGridTeam.Columns[1].HeaderText = "Nombre Equipo";
                dataGridTeam.Columns[2].HeaderText = "Código de Liga";
                dataGridTeam.Columns[3].HeaderText = "Localidad";
                dataGridTeam.Columns[4].HeaderText = "Internacional";

                countTeamLBL.Text = "Número de Equipos: " + dv_Teams.Count.ToString();

                cc.Con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error: " + ex.Message);
            }
        }

        private void Combo_Selected_DataGrid_Load(object sender, EventArgs e)
        {
            Connection cc = new Connection();
            try
            {
                cc.Con.Open();

                /* Ligas */
                String query = "SELECT * FROM ligas";
                da_Leagues = new SqlDataAdapter(query, cc.Con);
                da_Leagues.Fill(ds, "Ligas");

                DataView dv_Leagues = new DataView(ds.Tables["Ligas"]);
                comboBoxLeague.DataSource = dv_Leagues;

                comboBoxLeague.DisplayMember = "nomLiga";
                comboBoxLeague.ValueMember = "codLiga";
                comboBoxLeague.DataSource = dv_Leagues;

                countLeagueLBL.Text = "Número de Ligas: " + ds.Tables["Ligas"].Rows.Count.ToString();

                cc.Con.Close();

                comboBoxLeague.SelectedIndex = 0;
                comboBoxLeague_SelectedIndexChanged(null, null);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error: " + ex.Message);
            }
        }
    }
}
