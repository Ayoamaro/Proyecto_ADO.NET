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
    public partial class Tamper_Logs : Form
    {
        DataSet ds = new DataSet();
        SqlDataAdapter da_Leagues, da_Teams, da_Agreements, da_Players;

        public Tamper_Logs()
        {
            InitializeComponent();
        }

        private void Manipular_Registros_Load(object sender, EventArgs e)
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

                dataGridTeam.Columns[0].HeaderText = "Código de Equipo";
                dataGridTeam.Columns[1].HeaderText = "Nombre";
                dataGridTeam.Columns[2].HeaderText = "Código de Liga";
                dataGridTeam.Columns[3].HeaderText = "Localidad";
                dataGridTeam.Columns[4].HeaderText = "Internacional";

                countTeamLBL.Text = "Número de Equipos: " + ds.Tables["Equipos"].Rows.Count.ToString();

                /* Contratos */
                query = "SELECT * FROM contratos";
                da_Agreements = new SqlDataAdapter(query, cc.Con);
                da_Agreements.Fill(ds, "Contratos");

                DataView dv_Agreements = new DataView(ds.Tables["Contratos"]);
                dataGridAgreement.DataSource = dv_Agreements;

                dataGridAgreement.Columns[0].HeaderText = "Código de Contrato";
                dataGridAgreement.Columns[1].HeaderText = "DNI/NIE";
                dataGridAgreement.Columns[2].HeaderText = "Código de Equipo";
                dataGridAgreement.Columns[3].HeaderText = "Fecha de Inicio";
                dataGridAgreement.Columns[4].HeaderText = "Fecha de Fin";
                dataGridAgreement.Columns[5].HeaderText = "Precio Anual";
                dataGridAgreement.Columns[6].HeaderText = "Precio Recisión";

                countAgreementLBL.Text = "Número de Contratos: " + ds.Tables["Contratos"].Rows.Count.ToString();

                /* Futbolistas */
                query = "SELECT * FROM futbolistas";
                da_Players = new SqlDataAdapter(query, cc.Con);
                da_Players.Fill(ds, "Futbolistas");

                DataView dv_Players = new DataView(ds.Tables["Futbolistas"]);
                dataGridPlayer.DataSource = dv_Players;

                dataGridPlayer.Columns[0].HeaderText = "DNI/NIE";
                dataGridPlayer.Columns[1].HeaderText = "Nombre";
                dataGridPlayer.Columns[2].HeaderText = "Nacionalidad";

                countPlayerLBL.Text = "Número de Futbolistas: " + ds.Tables["Futbolistas"].Rows.Count.ToString();

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
                SqlCommandBuilder commandBuilder = new SqlCommandBuilder(da_Leagues);
                da_Leagues.Update(ds.Tables["Ligas"]);

                countLeagueLBL.Text = "Número de Ligas: " + ds.Tables["Ligas"].Rows.Count.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error: " + ex.Message);
            }
        }

        private void saveTeamBTN_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommandBuilder commandBuilder = new SqlCommandBuilder(da_Teams);
                da_Teams.Update(ds.Tables["Equipos"]);

                countTeamLBL.Text = "Número de Equipos: " + ds.Tables["Equipos"].Rows.Count.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error: " + ex.Message);
            }
        }

        private void saveAgreementBTN_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommandBuilder commandBuilder = new SqlCommandBuilder(da_Agreements);
                da_Agreements.Update(ds.Tables["Contratos"]);

                countAgreementLBL.Text = "Número de Contratos: " + ds.Tables["Contratos"].Rows.Count.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error: " + ex.Message);
            }
        }

        private void savePlayerBTN_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommandBuilder commandBuilder = new SqlCommandBuilder(da_Players);
                da_Players.Update(ds.Tables["Futbolistas"]);

                countPlayerLBL.Text = "Número de Futbolistas: " + ds.Tables["Futbolistas"].Rows.Count.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error: " + ex.Message);
            }
        }
    }
}
