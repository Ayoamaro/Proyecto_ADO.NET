
namespace Proyecto_ADO.NET
{
    partial class Read_Logs
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
            this.leagueLBL = new System.Windows.Forms.Label();
            this.dataGridLeague = new System.Windows.Forms.DataGridView();
            this.countLeagueLBL = new System.Windows.Forms.Label();
            this.authorLBL = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridLeague)).BeginInit();
            this.SuspendLayout();
            // 
            // leagueLBL
            // 
            this.leagueLBL.AutoSize = true;
            this.leagueLBL.Font = new System.Drawing.Font("Assistant", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.leagueLBL.Location = new System.Drawing.Point(168, 18);
            this.leagueLBL.Name = "leagueLBL";
            this.leagueLBL.Size = new System.Drawing.Size(39, 17);
            this.leagueLBL.TabIndex = 0;
            this.leagueLBL.Text = "Ligas";
            this.leagueLBL.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dataGridLeague
            // 
            this.dataGridLeague.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridLeague.Location = new System.Drawing.Point(16, 38);
            this.dataGridLeague.Name = "dataGridLeague";
            this.dataGridLeague.Size = new System.Drawing.Size(330, 245);
            this.dataGridLeague.TabIndex = 1;
            // 
            // countLeagueLBL
            // 
            this.countLeagueLBL.AutoSize = true;
            this.countLeagueLBL.Font = new System.Drawing.Font("Assistant", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.countLeagueLBL.Location = new System.Drawing.Point(16, 296);
            this.countLeagueLBL.Name = "countLeagueLBL";
            this.countLeagueLBL.Size = new System.Drawing.Size(101, 17);
            this.countLeagueLBL.TabIndex = 2;
            this.countLeagueLBL.Text = "Número de Ligas:";
            // 
            // authorLBL
            // 
            this.authorLBL.AutoSize = true;
            this.authorLBL.Font = new System.Drawing.Font("Assistant", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.authorLBL.Location = new System.Drawing.Point(114, 325);
            this.authorLBL.Name = "authorLBL";
            this.authorLBL.Size = new System.Drawing.Size(136, 15);
            this.authorLBL.TabIndex = 11;
            this.authorLBL.Text = "Hecho por: Ayoze Amaro";
            this.authorLBL.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // Leer_Registros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 349);
            this.Controls.Add(this.authorLBL);
            this.Controls.Add(this.countLeagueLBL);
            this.Controls.Add(this.dataGridLeague);
            this.Controls.Add(this.leagueLBL);
            this.Name = "Leer_Registros";
            this.Text = "Leer registros de diferentes tablas";
            this.Load += new System.EventHandler(this.Read_Logs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridLeague)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label leagueLBL;
        private System.Windows.Forms.DataGridView dataGridLeague;
        private System.Windows.Forms.Label countLeagueLBL;
        private System.Windows.Forms.Label authorLBL;
    }
}