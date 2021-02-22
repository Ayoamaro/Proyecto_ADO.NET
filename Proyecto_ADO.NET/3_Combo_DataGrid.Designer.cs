
namespace Proyecto_ADO.NET
{
    partial class Combo_DataGrid
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
            this.countLeagueLBL = new System.Windows.Forms.Label();
            this.dataGridLeague = new System.Windows.Forms.DataGridView();
            this.leagueLBL = new System.Windows.Forms.Label();
            this.countTeamLBL = new System.Windows.Forms.Label();
            this.dataGridTeam = new System.Windows.Forms.DataGridView();
            this.teamLBL = new System.Windows.Forms.Label();
            this.saveLeagueBTN = new System.Windows.Forms.Button();
            this.authorLBL = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridLeague)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridTeam)).BeginInit();
            this.SuspendLayout();
            // 
            // countLeagueLBL
            // 
            this.countLeagueLBL.AutoSize = true;
            this.countLeagueLBL.Font = new System.Drawing.Font("Assistant", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.countLeagueLBL.Location = new System.Drawing.Point(21, 289);
            this.countLeagueLBL.Name = "countLeagueLBL";
            this.countLeagueLBL.Size = new System.Drawing.Size(101, 17);
            this.countLeagueLBL.TabIndex = 5;
            this.countLeagueLBL.Text = "Número de Ligas:";
            // 
            // dataGridLeague
            // 
            this.dataGridLeague.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridLeague.Location = new System.Drawing.Point(21, 31);
            this.dataGridLeague.Name = "dataGridLeague";
            this.dataGridLeague.Size = new System.Drawing.Size(330, 245);
            this.dataGridLeague.TabIndex = 4;
            // 
            // leagueLBL
            // 
            this.leagueLBL.AutoSize = true;
            this.leagueLBL.Font = new System.Drawing.Font("Assistant", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.leagueLBL.Location = new System.Drawing.Point(173, 11);
            this.leagueLBL.Name = "leagueLBL";
            this.leagueLBL.Size = new System.Drawing.Size(39, 17);
            this.leagueLBL.TabIndex = 3;
            this.leagueLBL.Text = "Ligas";
            this.leagueLBL.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // countTeamLBL
            // 
            this.countTeamLBL.AutoSize = true;
            this.countTeamLBL.Font = new System.Drawing.Font("Assistant", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.countTeamLBL.Location = new System.Drawing.Point(372, 289);
            this.countTeamLBL.Name = "countTeamLBL";
            this.countTeamLBL.Size = new System.Drawing.Size(116, 17);
            this.countTeamLBL.TabIndex = 8;
            this.countTeamLBL.Text = "Número de Equipos:";
            // 
            // dataGridTeam
            // 
            this.dataGridTeam.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridTeam.Location = new System.Drawing.Point(372, 31);
            this.dataGridTeam.Name = "dataGridTeam";
            this.dataGridTeam.Size = new System.Drawing.Size(680, 245);
            this.dataGridTeam.TabIndex = 7;
            // 
            // teamLBL
            // 
            this.teamLBL.AutoSize = true;
            this.teamLBL.Font = new System.Drawing.Font("Assistant", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teamLBL.Location = new System.Drawing.Point(703, 11);
            this.teamLBL.Name = "teamLBL";
            this.teamLBL.Size = new System.Drawing.Size(53, 17);
            this.teamLBL.TabIndex = 6;
            this.teamLBL.Text = "Equipos";
            this.teamLBL.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // saveLeagueBTN
            // 
            this.saveLeagueBTN.Font = new System.Drawing.Font("Assistant", 9.75F);
            this.saveLeagueBTN.Location = new System.Drawing.Point(109, 323);
            this.saveLeagueBTN.Name = "saveLeagueBTN";
            this.saveLeagueBTN.Size = new System.Drawing.Size(400, 45);
            this.saveLeagueBTN.TabIndex = 9;
            this.saveLeagueBTN.Text = "Guardar Datos";
            this.saveLeagueBTN.UseVisualStyleBackColor = true;
            this.saveLeagueBTN.Click += new System.EventHandler(this.saveLeagueBTN_Click);
            // 
            // authorLBL
            // 
            this.authorLBL.AutoSize = true;
            this.authorLBL.Font = new System.Drawing.Font("Assistant", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.authorLBL.Location = new System.Drawing.Point(548, 338);
            this.authorLBL.Name = "authorLBL";
            this.authorLBL.Size = new System.Drawing.Size(136, 15);
            this.authorLBL.TabIndex = 12;
            this.authorLBL.Text = "Hecho por: Ayoze Amaro";
            this.authorLBL.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // Combo_DataGrid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1076, 384);
            this.Controls.Add(this.authorLBL);
            this.Controls.Add(this.saveLeagueBTN);
            this.Controls.Add(this.countTeamLBL);
            this.Controls.Add(this.dataGridTeam);
            this.Controls.Add(this.teamLBL);
            this.Controls.Add(this.countLeagueLBL);
            this.Controls.Add(this.dataGridLeague);
            this.Controls.Add(this.leagueLBL);
            this.Name = "Combo_DataGrid";
            this.Text = "Combo dentro de un DataGrid";
            this.Load += new System.EventHandler(this.Combo_DataGrid_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridLeague)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridTeam)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label countLeagueLBL;
        private System.Windows.Forms.DataGridView dataGridLeague;
        private System.Windows.Forms.Label leagueLBL;
        private System.Windows.Forms.Label countTeamLBL;
        private System.Windows.Forms.DataGridView dataGridTeam;
        private System.Windows.Forms.Label teamLBL;
        private System.Windows.Forms.Button saveLeagueBTN;
        private System.Windows.Forms.Label authorLBL;
    }
}