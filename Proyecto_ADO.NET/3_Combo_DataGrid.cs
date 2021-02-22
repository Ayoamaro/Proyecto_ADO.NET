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
    public partial class Combo_DataGrid : Form
    {
        DataSet ds = new DataSet();
        SqlDataAdapter da_Leagues, da_Teams;

        public Combo_DataGrid()
        {
            InitializeComponent();
        }

        private void Combo_DataGrid_Load(object sender, EventArgs e)
        {
            try
            {
                Connection cc = new Connection();
                cc.Con.Open();

                String query;

                /* Ligas */
                query = "SELECT * FROM ligas";
                da_Leagues = new SqlDataAdapter(query, cc.Con);
                da_Leagues.Fill(ds, "Ligas");

                /*2 opciones para el DataSource del DataGridView (1º opción) DataView o (2º opción) DataTable */
                DataView dv_Leagues = new DataView(ds.Tables["Ligas"]);
                dataGridLeague.DataSource = dv_Leagues;

                dataGridLeague.Columns[0].HeaderText = "Código de Liga";
                dataGridLeague.Columns[1].HeaderText = "Nombre";

                countLeagueLBL.Text = "Número de Ligas: " + ds.Tables["Ligas"].Rows.Count.ToString();

                /* Equipos */
                query = "SELECT * FROM equipos";
                da_Teams = new SqlDataAdapter(query, cc.Con);
                da_Teams.Fill(ds, "Equipos");

                DataView dv_Teams = new DataView(ds.Tables["Equipos"]);
                dataGridTeam.DataSource = dv_Teams;

                DataGridViewComboBoxColumn cmb = new DataGridViewComboBoxColumn();
                cmb.DataPropertyName = "codLiga";
                cmb.DisplayMember = "nomLiga";
                cmb.ValueMember = "codLiga";
                cmb.DataSource = dv_Leagues;
                dataGridTeam.Columns.Add(cmb);

                dataGridTeam.Columns[0].HeaderText = "Código de Equipo";
                dataGridTeam.Columns[1].HeaderText = "Nombre Equipo";
                dataGridTeam.Columns[2].HeaderText = "Código de Liga";
                dataGridTeam.Columns[3].HeaderText = "Localidad";
                dataGridTeam.Columns[4].HeaderText = "Internacional";
                dataGridTeam.Columns[5].HeaderText = "Nombre Liga";

                dataGridTeam.Columns[2].Visible = false;

                countTeamLBL.Text = "Número de Equipos: " + ds.Tables["Equipos"].Rows.Count.ToString();

                cc.Con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error: " + ex.Message);
            }
        }

        private void saveLeagueBTN_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommandBuilder commandBuilderLeague = new SqlCommandBuilder(da_Leagues);
                da_Leagues.Update(ds.Tables["Ligas"]);

                countLeagueLBL.Text = "Número de Ligas: " + ds.Tables["Ligas"].Rows.Count.ToString();

                SqlCommandBuilder commandBuilderTeam = new SqlCommandBuilder(da_Teams);
                da_Teams.Update(ds.Tables["Equipos"]);

                countTeamLBL.Text = "Número de Equipos: " + ds.Tables["Equipos"].Rows.Count.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error: " + ex.Message);
            }
        }
    }
}
