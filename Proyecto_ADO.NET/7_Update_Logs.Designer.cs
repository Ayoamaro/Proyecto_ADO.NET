﻿
namespace Proyecto_ADO.NET
{
    partial class Update_Logs
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
            this.loadRecordBTN = new System.Windows.Forms.Button();
            this.codTeamTXT = new System.Windows.Forms.TextBox();
            this.codTeamLBL = new System.Windows.Forms.Label();
            this.groupInsert = new System.Windows.Forms.GroupBox();
            this.comboBoxLeague = new System.Windows.Forms.ComboBox();
            this.updateTeamBTN = new System.Windows.Forms.Button();
            this.internationalCHK = new System.Windows.Forms.CheckBox();
            this.townTXT = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.nomTeamTXT = new System.Windows.Forms.TextBox();
            this.nameTeamLBL = new System.Windows.Forms.Label();
            this.authorLBL = new System.Windows.Forms.Label();
            this.groupInsert.SuspendLayout();
            this.SuspendLayout();
            // 
            // loadRecordBTN
            // 
            this.loadRecordBTN.Font = new System.Drawing.Font("Assistant", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadRecordBTN.Location = new System.Drawing.Point(275, 19);
            this.loadRecordBTN.Name = "loadRecordBTN";
            this.loadRecordBTN.Size = new System.Drawing.Size(140, 30);
            this.loadRecordBTN.TabIndex = 38;
            this.loadRecordBTN.Text = "Cargar registro";
            this.loadRecordBTN.UseVisualStyleBackColor = true;
            this.loadRecordBTN.Click += new System.EventHandler(this.loadRecordBTN_Click);
            // 
            // codTeamTXT
            // 
            this.codTeamTXT.Font = new System.Drawing.Font("Assistant SemiBold", 8.249999F, System.Drawing.FontStyle.Bold);
            this.codTeamTXT.Location = new System.Drawing.Point(70, 23);
            this.codTeamTXT.Name = "codTeamTXT";
            this.codTeamTXT.Size = new System.Drawing.Size(184, 22);
            this.codTeamTXT.TabIndex = 37;
            // 
            // codTeamLBL
            // 
            this.codTeamLBL.AutoSize = true;
            this.codTeamLBL.Font = new System.Drawing.Font("Assistant", 9.75F);
            this.codTeamLBL.Location = new System.Drawing.Point(15, 26);
            this.codTeamLBL.Name = "codTeamLBL";
            this.codTeamLBL.Size = new System.Drawing.Size(49, 17);
            this.codTeamLBL.TabIndex = 36;
            this.codTeamLBL.Text = "Código:";
            // 
            // groupInsert
            // 
            this.groupInsert.Controls.Add(this.comboBoxLeague);
            this.groupInsert.Controls.Add(this.updateTeamBTN);
            this.groupInsert.Controls.Add(this.internationalCHK);
            this.groupInsert.Controls.Add(this.townTXT);
            this.groupInsert.Controls.Add(this.label2);
            this.groupInsert.Controls.Add(this.label1);
            this.groupInsert.Controls.Add(this.nomTeamTXT);
            this.groupInsert.Controls.Add(this.nameTeamLBL);
            this.groupInsert.Location = new System.Drawing.Point(18, 55);
            this.groupInsert.Name = "groupInsert";
            this.groupInsert.Size = new System.Drawing.Size(397, 175);
            this.groupInsert.TabIndex = 35;
            this.groupInsert.TabStop = false;
            // 
            // comboBoxLeague
            // 
            this.comboBoxLeague.Font = new System.Drawing.Font("Assistant SemiBold", 8.249999F, System.Drawing.FontStyle.Bold);
            this.comboBoxLeague.FormattingEnabled = true;
            this.comboBoxLeague.Location = new System.Drawing.Point(106, 43);
            this.comboBoxLeague.Name = "comboBoxLeague";
            this.comboBoxLeague.Size = new System.Drawing.Size(155, 22);
            this.comboBoxLeague.TabIndex = 34;
            // 
            // updateTeamBTN
            // 
            this.updateTeamBTN.Font = new System.Drawing.Font("Assistant", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateTeamBTN.Location = new System.Drawing.Point(12, 125);
            this.updateTeamBTN.Name = "updateTeamBTN";
            this.updateTeamBTN.Size = new System.Drawing.Size(375, 40);
            this.updateTeamBTN.TabIndex = 32;
            this.updateTeamBTN.Text = "Guardar Cambios";
            this.updateTeamBTN.UseVisualStyleBackColor = true;
            this.updateTeamBTN.Click += new System.EventHandler(this.updateTeamBTN_Click);
            // 
            // internationalCHK
            // 
            this.internationalCHK.AutoSize = true;
            this.internationalCHK.Font = new System.Drawing.Font("Assistant", 9.75F);
            this.internationalCHK.Location = new System.Drawing.Point(12, 98);
            this.internationalCHK.Name = "internationalCHK";
            this.internationalCHK.Size = new System.Drawing.Size(98, 21);
            this.internationalCHK.TabIndex = 31;
            this.internationalCHK.Text = "Internacional";
            this.internationalCHK.UseVisualStyleBackColor = true;
            // 
            // townTXT
            // 
            this.townTXT.Font = new System.Drawing.Font("Assistant SemiBold", 8.249999F, System.Drawing.FontStyle.Bold);
            this.townTXT.Location = new System.Drawing.Point(79, 70);
            this.townTXT.Name = "townTXT";
            this.townTXT.Size = new System.Drawing.Size(218, 22);
            this.townTXT.TabIndex = 30;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Assistant", 9.75F);
            this.label2.Location = new System.Drawing.Point(9, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 17);
            this.label2.TabIndex = 29;
            this.label2.Text = "Localidad:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Assistant", 9.75F);
            this.label1.Location = new System.Drawing.Point(9, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 17);
            this.label1.TabIndex = 27;
            this.label1.Text = "Código de Liga:";
            // 
            // nomTeamTXT
            // 
            this.nomTeamTXT.Font = new System.Drawing.Font("Assistant SemiBold", 8.249999F, System.Drawing.FontStyle.Bold);
            this.nomTeamTXT.Location = new System.Drawing.Point(109, 16);
            this.nomTeamTXT.Name = "nomTeamTXT";
            this.nomTeamTXT.Size = new System.Drawing.Size(237, 22);
            this.nomTeamTXT.TabIndex = 26;
            // 
            // nameTeamLBL
            // 
            this.nameTeamLBL.AutoSize = true;
            this.nameTeamLBL.Font = new System.Drawing.Font("Assistant", 9.75F);
            this.nameTeamLBL.Location = new System.Drawing.Point(9, 17);
            this.nameTeamLBL.Name = "nameTeamLBL";
            this.nameTeamLBL.Size = new System.Drawing.Size(94, 17);
            this.nameTeamLBL.TabIndex = 25;
            this.nameTeamLBL.Text = "Nombre equipo:";
            // 
            // authorLBL
            // 
            this.authorLBL.AutoSize = true;
            this.authorLBL.Font = new System.Drawing.Font("Assistant", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.authorLBL.Location = new System.Drawing.Point(149, 242);
            this.authorLBL.Name = "authorLBL";
            this.authorLBL.Size = new System.Drawing.Size(136, 15);
            this.authorLBL.TabIndex = 34;
            this.authorLBL.Text = "Hecho por: Ayoze Amaro";
            this.authorLBL.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // Edicion_Registro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 273);
            this.Controls.Add(this.loadRecordBTN);
            this.Controls.Add(this.codTeamTXT);
            this.Controls.Add(this.codTeamLBL);
            this.Controls.Add(this.groupInsert);
            this.Controls.Add(this.authorLBL);
            this.Name = "Edicion_Registro";
            this.Text = "Edición de registro";
            this.groupInsert.ResumeLayout(false);
            this.groupInsert.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button loadRecordBTN;
        private System.Windows.Forms.TextBox codTeamTXT;
        private System.Windows.Forms.Label codTeamLBL;
        private System.Windows.Forms.GroupBox groupInsert;
        private System.Windows.Forms.Button updateTeamBTN;
        private System.Windows.Forms.CheckBox internationalCHK;
        private System.Windows.Forms.TextBox townTXT;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nomTeamTXT;
        private System.Windows.Forms.Label nameTeamLBL;
        private System.Windows.Forms.Label authorLBL;
        private System.Windows.Forms.ComboBox comboBoxLeague;
    }
}