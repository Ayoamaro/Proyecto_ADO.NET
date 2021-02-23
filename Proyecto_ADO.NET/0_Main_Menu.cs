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
            Read_Logs readRecord = new Read_Logs();
            readRecord.Show();
        }

        private void comboDatagridBTN_Click(object sender, EventArgs e)
        {
            Combo_DataGrid comboDatagrid = new Combo_DataGrid();
            comboDatagrid.Show();
        }

        private void comboSelectBTN_Click(object sender, EventArgs e)
        {
            Combo_Selected_DataGrid comboSelect = new Combo_Selected_DataGrid();
            comboSelect.Show();
        }

        private void insertRecordBTN_Click(object sender, EventArgs e)
        {
            Create_Logs insertRecord = new Create_Logs();
            insertRecord.Show();
        }

        private void deleteRecordBTN_Click(object sender, EventArgs e)
        {
            Delete_Logs deleteRecord = new Delete_Logs();
            deleteRecord.Show();
        }

        private void updateRecordBTN_Click(object sender, EventArgs e)
        {
            Update_Logs updateRecord = new Update_Logs();
            updateRecord.Show();
        }

        private void twoDatagridBTN_Click(object sender, EventArgs e)
        {
            Two_DataGrid_Relation twoDatagrid = new Two_DataGrid_Relation();
            twoDatagrid.Show();
        }

        private void proceduresFunctionsBTN_Click(object sender, EventArgs e)
        {
            Execute_PyF proceduresFunctions = new Execute_PyF();
            proceduresFunctions.Show();
        }
    }
}
