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
    public partial class Dos_DataGrid_Relacionados : Form
    {
        DataSet ds = new DataSet();
        SqlDataAdapter da_Leagues, da_Teams;
        
        DataView dv_Leagues = new DataView();
        DataRowView currentRowView;

        public Dos_DataGrid_Relacionados()
        {
            InitializeComponent();
        }

        private void Dos_DataGrid_Relacionados_Load(object sender, EventArgs e)
        {
            Connection cc = new Connection();
            try
            {
                cc.Con.Open();

                String query;

                /* Ligas */
                query = "SELECT * FROM ligas";
                da_Leagues = new SqlDataAdapter(query, cc.Con);
                da_Leagues.Fill(ds, "Ligas");

                /* Equipos */
                query = "SELECT * FROM equipos";
                da_Teams = new SqlDataAdapter(query, cc.Con);
                da_Teams.Fill(ds, "Equipos");

                DataColumn parentColumn = ds.Tables["Ligas"].Columns["codLiga"];
                DataColumn childColumn = ds.Tables["Equipos"].Columns["codLiga"];
                DataRelation relCustOrder;
                relCustOrder = new DataRelation("LigasEquipos", parentColumn, childColumn);
                ds.Relations.Add(relCustOrder);

                /* Ligas */
                dv_Leagues = new DataView(ds.Tables["Ligas"]);
                dataGridLeague.DataSource = dv_Leagues;

                currentRowView = dv_Leagues[dataGridLeague.CurrentRow.Index];

                dataGridLeague.Columns[0].HeaderText = "Código de Liga";
                dataGridLeague.Columns[1].HeaderText = "Nombre";

                countLeagueLBL.Text = "Número de Ligas: " + ds.Tables["Ligas"].Rows.Count.ToString();

                /* Equipos */
                dataGridTeam.DataSource = currentRowView.CreateChildView("LigasEquipos");

                dataGridTeam.Columns[0].HeaderText = "Código de Equipo";
                dataGridTeam.Columns[1].HeaderText = "Nombre Equipo";
                dataGridTeam.Columns[2].HeaderText = "Código de Liga";
                dataGridTeam.Columns[3].HeaderText = "Localidad";
                dataGridTeam.Columns[4].HeaderText = "Internacional";

                countTeamLBL.Text = "Número de Equipos: " + currentRowView.CreateChildView("LigasEquipos").Count.ToString();

                cc.Con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error: " + ex.Message);
            }
        }

        private void dataGridLeague_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Connection cc = new Connection();
            try
            {
                cc.Con.Open();

                currentRowView = dv_Leagues[dataGridLeague.CurrentRow.Index];
                dataGridTeam.DataSource = currentRowView.CreateChildView("LigasEquipos");

                countTeamLBL.Text = "Número de Equipos: " + (dataGridTeam.RowCount-1).ToString();

                cc.Con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error: " + ex.Message);
            }
        }
    }
}
