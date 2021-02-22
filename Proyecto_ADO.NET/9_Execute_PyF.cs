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
    public partial class Ejecutar_PyF : Form
    {
        DataSet ds = new DataSet();
        SqlDataAdapter da_Agreements;

        public Ejecutar_PyF()
        {
            InitializeComponent();
        }

        private void listAgreementBTN_Click(object sender, EventArgs e)
        {
            Connection cc = new Connection();
            try
            {
                cc.Con.Open();

                String query = "EXEC dbo.ejerc_1 @codDnionie= '" + dniAgreementTXT.Text + "'";
                da_Agreements = new SqlDataAdapter(query, cc.Con);
                da_Agreements.Fill(ds, "Contratos");

                DataView dv_Agreements = new DataView(ds.Tables["Contratos"]);
                dataGridProcedure.DataSource = dv_Agreements;

                dataGridProcedure.Columns[0].HeaderText = "Código de Contrato";
                dataGridProcedure.Columns[1].HeaderText = "DNI/NIE";
                dataGridProcedure.Columns[2].HeaderText = "Código de Equipo";
                dataGridProcedure.Columns[3].HeaderText = "Fecha de Inicio";
                dataGridProcedure.Columns[4].HeaderText = "Fecha de Fin";
                dataGridProcedure.Columns[5].HeaderText = "Precio Anual";
                dataGridProcedure.Columns[6].HeaderText = "Precio Recisión";

                cc.Con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error: " + ex.Message);
            }
        }

        private void insertTeamBTN_Click(object sender, EventArgs e)
        {
            Connection cc = new Connection();
            try
            {
                cc.Con.Open();

                SqlCommand cmd = new SqlCommand("dbo.ejerc_2", cc.Con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@nomEquipo", nomTeamTXT.Text);
                cmd.Parameters.AddWithValue("@codLiga", codLeagueTXT.Text);
                cmd.Parameters.AddWithValue("@localidad", townTXT.Text);
                cmd.Parameters.AddWithValue("@internacional", internationalCHK.Checked);

                SqlParameter outPut1 = new SqlParameter();
                outPut1.ParameterName = "@Salida1";
                outPut1.Direction = ParameterDirection.Output;
                outPut1.SqlDbType = SqlDbType.Int;
                cmd.Parameters.Add(outPut1);

                SqlParameter outPut2 = new SqlParameter();
                outPut2.ParameterName = "@Salida2";
                outPut2.Direction = ParameterDirection.Output;
                outPut2.SqlDbType = SqlDbType.Int;
                cmd.Parameters.Add(outPut2);

                cmd.ExecuteNonQuery();

                string Out1 = outPut1.Value.ToString();
                string Out2 = outPut2.Value.ToString();

                existLeagueLBL.Text = "Existe Liga: " + Out1;
                insertLeagueLBL.Text = "Inserción: " + Out2;

                cc.Con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error: " + ex.Message);
            }
        }

        private void activePlayersBTN_Click(object sender, EventArgs e)
        {
            Connection cc = new Connection();
            try
            {
                cc.Con.Open();

                SqlCommand cmd = new SqlCommand("dbo.ejerc_3", cc.Con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@codEquipo", codTeamTXT.Text);
                cmd.Parameters.AddWithValue("@precioAnual", priceYearTXT.Text);
                cmd.Parameters.AddWithValue("@precioResicion", priceTerminationTXT.Text);

                SqlParameter outPut1 = new SqlParameter();
                outPut1.ParameterName = "@Salida1";
                outPut1.Direction = ParameterDirection.Output;
                outPut1.SqlDbType = SqlDbType.Int;
                cmd.Parameters.Add(outPut1);

                SqlParameter outPut2 = new SqlParameter();
                outPut2.ParameterName = "@Salida2";
                outPut2.Direction = ParameterDirection.Output;
                outPut2.SqlDbType = SqlDbType.Int;
                cmd.Parameters.Add(outPut2);

                cmd.ExecuteNonQuery();

                string Out1 = outPut1.Value.ToString();
                string Out2 = outPut2.Value.ToString();

                activeAgreementLBL.Text = "Contratos activos: " + Out1;
                lowerPricesLBL.Text = "Precios menores: " + Out2;

                cc.Con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error: " + ex.Message);
            }
        }

        private void showMonthsBTN_Click(object sender, EventArgs e)
        {
            Connection cc = new Connection();
            try
            {
                cc.Con.Open();

                String query = "SELECT dbo.ejerc_4 ('" + dniPlayerTXT.Text + "')";
                SqlCommand command = new SqlCommand(query, cc.Con);

                monthsPlayedLBL.Text = "Mese(s) jugados: " + command.ExecuteScalar();

                cc.Con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error: " + ex.Message);
            }
        }   
    }
}
