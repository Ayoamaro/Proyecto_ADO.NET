using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_ADO.NET
{
    public partial class Main_Menu : Form
    {
        public Main_Menu()
        {
            InitializeComponent();
        }

        private void handleRecordBTN_Click(object sender, EventArgs e)
        {
            Tamper_Logs handleRecord = new Tamper_Logs();
            handleRecord.Show();
        }

        private void readRecordBTN_Click(object sender, EventArgs e)
        {
            Leer_Registros readRecord = new Leer_Registros();
            readRecord.Show();
        }

        private void comboDatagridBTN_Click(object sender, EventArgs e)
        {
            Combo_DataGrid comboDatagrid = new Combo_DataGrid();
            comboDatagrid.Show();
        }

        private void comboSelectBTN_Click(object sender, EventArgs e)
        {
            Combo_Seleccionar_DataGrid comboSelect = new Combo_Seleccionar_DataGrid();
            comboSelect.Show();
        }

        private void insertRecordBTN_Click(object sender, EventArgs e)
        {
            Insercion_Registro insertRecord = new Insercion_Registro();
            insertRecord.Show();
        }

        private void deleteRecordBTN_Click(object sender, EventArgs e)
        {
            Borrado_Registro deleteRecord = new Borrado_Registro();
            deleteRecord.Show();
        }

        private void updateRecordBTN_Click(object sender, EventArgs e)
        {
            Edicion_Registro updateRecord = new Edicion_Registro();
            updateRecord.Show();
        }

        private void twoDatagridBTN_Click(object sender, EventArgs e)
        {
            Dos_DataGrid_Relacionados twoDatagrid = new Dos_DataGrid_Relacionados();
            twoDatagrid.Show();
        }

        private void proceduresFunctionsBTN_Click(object sender, EventArgs e)
        {
            Ejecutar_PyF proceduresFunctions = new Ejecutar_PyF();
            proceduresFunctions.Show();
        }
    }
}
