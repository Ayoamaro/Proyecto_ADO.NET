
namespace Proyecto_ADO.NET
{
    partial class Combo_Seleccionar_DataGrid
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.nameLeagueLBL = new System.Windows.Forms.Label();
            this.comboBoxLeague = new System.Windows.Forms.ComboBox();
            this.authorLBL = new System.Windows.Forms.Label();
            this.countLeagueLBL = new System.Windows.Forms.Label();
            this.dataGridTeam = new System.Windows.Forms.DataGridView();
            this.teamByLeagueLBL = new System.Windows.Forms.Label();
            this.countTeamLBL = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridTeam)).BeginInit();
            this.SuspendLayout();
            // 
            // nameLeagueLBL
            // 
            this.nameLeagueLBL.AutoSize = true;
            this.nameLeagueLBL.Font = new System.Drawing.Font("Assistant", 9.75F);
            this.nameLeagueLBL.Location = new System.Drawing.Point(22, 19);
            this.nameLeagueLBL.Name = "nameLeagueLBL";
            this.nameLeagueLBL.Size = new System.Drawing.Size(77, 17);
            this.nameLeagueLBL.TabIndex = 6;
            this.nameLeagueLBL.Text = "Nombre liga:";
            // 
            // comboBoxLeague
            // 
            this.comboBoxLeague.Font = new System.Drawing.Font("Assistant SemiBold", 8.249999F, System.Drawing.FontStyle.Bold);
            this.comboBoxLeague.FormattingEnabled = true;
            this.comboBoxLeague.Location = new System.Drawing.Point(105, 18);
            this.comboBoxLeague.Name = "comboBoxLeague";
            this.comboBoxLeague.Size = new System.Drawing.Size(542, 22);
            this.comboBoxLeague.TabIndex = 7;
            this.comboBoxLeague.SelectedIndexChanged += new System.EventHandler(this.comboBoxLeague_SelectedIndexChanged);
            // 
            // authorLBL
            // 
            this.authorLBL.AutoSize = true;
            this.authorLBL.Font = new System.Drawing.Font("Assistant", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.authorLBL.Location = new System.Drawing.Point(321, 383);
            this.authorLBL.Name = "authorLBL";
            this.authorLBL.Size = new System.Drawing.Size(136, 15);
            this.authorLBL.TabIndex = 13;
            this.authorLBL.Text = "Hecho por: Ayoze Amaro";
            this.authorLBL.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // countLeagueLBL
            // 
            this.countLeagueLBL.AutoSize = true;
            this.countLeagueLBL.Font = new System.Drawing.Font("Assistant", 9.75F);
            this.countLeagueLBL.Location = new System.Drawing.Point(653, 19);
            this.countLeagueLBL.Name = "countLeagueLBL";
            this.countLeagueLBL.Size = new System.Drawing.Size(98, 17);
            this.countLeagueLBL.TabIndex = 14;
            this.countLeagueLBL.Text = "Número de ligas:";
            // 
            // dataGridTeam
            // 
            this.dataGridTeam.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridTeam.Location = new System.Drawing.Point(25, 89);
            this.dataGridTeam.Name = "dataGridTeam";
            this.dataGridTeam.Size = new System.Drawing.Size(748, 250);
            this.dataGridTeam.TabIndex = 16;
            // 
            // teamByLeagueLBL
            // 
            this.teamByLeagueLBL.AutoSize = true;
            this.teamByLeagueLBL.Font = new System.Drawing.Font("Assistant", 9.75F, System.Drawing.FontStyle.Bold);
            this.teamByLeagueLBL.Location = new System.Drawing.Point(22, 69);
            this.teamByLeagueLBL.Name = "teamByLeagueLBL";
            this.teamByLeagueLBL.Size = new System.Drawing.Size(158, 17);
            this.teamByLeagueLBL.TabIndex = 15;
            this.teamByLeagueLBL.Text = "Equipos de la Liga elegida";
            // 
            // countTeamLBL
            // 
            this.countTeamLBL.AutoSize = true;
            this.countTeamLBL.Font = new System.Drawing.Font("Assistant", 9.75F);
            this.countTeamLBL.Location = new System.Drawing.Point(22, 352);
            this.countTeamLBL.Name = "countTeamLBL";
            this.countTeamLBL.Size = new System.Drawing.Size(115, 17);
            this.countTeamLBL.TabIndex = 17;
            this.countTeamLBL.Text = "Número de equipos:";
            // 
            // Combo_Seleccionar_DataGrid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(797, 410);
            this.Controls.Add(this.countTeamLBL);
            this.Controls.Add(this.dataGridTeam);
            this.Controls.Add(this.teamByLeagueLBL);
            this.Controls.Add(this.countLeagueLBL);
            this.Controls.Add(this.authorLBL);
            this.Controls.Add(this.comboBoxLeague);
            this.Controls.Add(this.nameLeagueLBL);
            this.Name = "Combo_Seleccionar_DataGrid";
            this.Text = "Combo para seleccionar un DataGrid";
            this.Load += new System.EventHandler(this.Combo_Seleccionar_DataGrid_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridTeam)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nameLeagueLBL;
        private System.Windows.Forms.ComboBox comboBoxLeague;
        private System.Windows.Forms.Label authorLBL;
        private System.Windows.Forms.Label countLeagueLBL;
        private System.Windows.Forms.DataGridView dataGridTeam;
        private System.Windows.Forms.Label teamByLeagueLBL;
        private System.Windows.Forms.Label countTeamLBL;
    }
}