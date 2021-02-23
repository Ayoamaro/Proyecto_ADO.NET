
namespace Proyecto_ADO.NET
{
    partial class Create_Logs
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
            this.nameTeamLBL = new System.Windows.Forms.Label();
            this.nomTeamTXT = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxLeague = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.townTXT = new System.Windows.Forms.TextBox();
            this.internationalCHK = new System.Windows.Forms.CheckBox();
            this.authorLBL = new System.Windows.Forms.Label();
            this.insertTeamBTN = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nameTeamLBL
            // 
            this.nameTeamLBL.AutoSize = true;
            this.nameTeamLBL.Font = new System.Drawing.Font("Assistant", 9.75F);
            this.nameTeamLBL.Location = new System.Drawing.Point(21, 18);
            this.nameTeamLBL.Name = "nameTeamLBL";
            this.nameTeamLBL.Size = new System.Drawing.Size(94, 17);
            this.nameTeamLBL.TabIndex = 7;
            this.nameTeamLBL.Text = "Nombre equipo:";
            // 
            // nomTeamTXT
            // 
            this.nomTeamTXT.Font = new System.Drawing.Font("Assistant SemiBold", 8.249999F, System.Drawing.FontStyle.Bold);
            this.nomTeamTXT.Location = new System.Drawing.Point(121, 17);
            this.nomTeamTXT.Name = "nomTeamTXT";
            this.nomTeamTXT.Size = new System.Drawing.Size(184, 22);
            this.nomTeamTXT.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Assistant", 9.75F);
            this.label1.Location = new System.Drawing.Point(21, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "Liga:";
            // 
            // comboBoxLeague
            // 
            this.comboBoxLeague.Font = new System.Drawing.Font("Assistant SemiBold", 8.249999F, System.Drawing.FontStyle.Bold);
            this.comboBoxLeague.FormattingEnabled = true;
            this.comboBoxLeague.Location = new System.Drawing.Point(61, 45);
            this.comboBoxLeague.Name = "comboBoxLeague";
            this.comboBoxLeague.Size = new System.Drawing.Size(155, 22);
            this.comboBoxLeague.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Assistant", 9.75F);
            this.label2.Location = new System.Drawing.Point(21, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "Localidad:";
            // 
            // townTXT
            // 
            this.townTXT.Font = new System.Drawing.Font("Assistant SemiBold", 8.249999F, System.Drawing.FontStyle.Bold);
            this.townTXT.Location = new System.Drawing.Point(91, 73);
            this.townTXT.Name = "townTXT";
            this.townTXT.Size = new System.Drawing.Size(177, 22);
            this.townTXT.TabIndex = 12;
            // 
            // internationalCHK
            // 
            this.internationalCHK.AutoSize = true;
            this.internationalCHK.Font = new System.Drawing.Font("Assistant", 9.75F);
            this.internationalCHK.Location = new System.Drawing.Point(24, 99);
            this.internationalCHK.Name = "internationalCHK";
            this.internationalCHK.Size = new System.Drawing.Size(98, 21);
            this.internationalCHK.TabIndex = 13;
            this.internationalCHK.Text = "Internacional";
            this.internationalCHK.UseVisualStyleBackColor = true;
            // 
            // authorLBL
            // 
            this.authorLBL.AutoSize = true;
            this.authorLBL.Font = new System.Drawing.Font("Assistant", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.authorLBL.Location = new System.Drawing.Point(97, 175);
            this.authorLBL.Name = "authorLBL";
            this.authorLBL.Size = new System.Drawing.Size(136, 15);
            this.authorLBL.TabIndex = 14;
            this.authorLBL.Text = "Hecho por: Ayoze Amaro";
            this.authorLBL.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // insertTeamBTN
            // 
            this.insertTeamBTN.Font = new System.Drawing.Font("Assistant", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.insertTeamBTN.Location = new System.Drawing.Point(24, 126);
            this.insertTeamBTN.Name = "insertTeamBTN";
            this.insertTeamBTN.Size = new System.Drawing.Size(281, 40);
            this.insertTeamBTN.TabIndex = 15;
            this.insertTeamBTN.Text = "Insertar equipo";
            this.insertTeamBTN.UseVisualStyleBackColor = true;
            this.insertTeamBTN.Click += new System.EventHandler(this.insertTeamBTN_Click);
            // 
            // Insercion_Registro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 199);
            this.Controls.Add(this.insertTeamBTN);
            this.Controls.Add(this.authorLBL);
            this.Controls.Add(this.internationalCHK);
            this.Controls.Add(this.townTXT);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxLeague);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nomTeamTXT);
            this.Controls.Add(this.nameTeamLBL);
            this.Name = "Insercion_Registro";
            this.Text = "Inserción de un registro";
            this.Load += new System.EventHandler(this.Create_Logs_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nameTeamLBL;
        private System.Windows.Forms.TextBox nomTeamTXT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxLeague;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox townTXT;
        private System.Windows.Forms.CheckBox internationalCHK;
        private System.Windows.Forms.Label authorLBL;
        private System.Windows.Forms.Button insertTeamBTN;
    }
}