
namespace Proyecto_ADO.NET
{
    partial class Ejecutar_PyF
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
            this.firstProcedure = new System.Windows.Forms.GroupBox();
            this.dataGridProcedure = new System.Windows.Forms.DataGridView();
            this.leagueLBL = new System.Windows.Forms.Label();
            this.listAgreementBTN = new System.Windows.Forms.Button();
            this.dniAgreementTXT = new System.Windows.Forms.TextBox();
            this.firstDniLBL = new System.Windows.Forms.Label();
            this.secondProcedure = new System.Windows.Forms.GroupBox();
            this.codLeagueTXT = new System.Windows.Forms.TextBox();
            this.insertLeagueLBL = new System.Windows.Forms.Label();
            this.existLeagueLBL = new System.Windows.Forms.Label();
            this.insertTeamBTN = new System.Windows.Forms.Button();
            this.internationalCHK = new System.Windows.Forms.CheckBox();
            this.townTXT = new System.Windows.Forms.TextBox();
            this.townLBL = new System.Windows.Forms.Label();
            this.codLeagueLBL = new System.Windows.Forms.Label();
            this.nomTeamTXT = new System.Windows.Forms.TextBox();
            this.nameTeamLBL = new System.Windows.Forms.Label();
            this.thirtProcedure = new System.Windows.Forms.GroupBox();
            this.lowerPricesLBL = new System.Windows.Forms.Label();
            this.activeAgreementLBL = new System.Windows.Forms.Label();
            this.activePlayersBTN = new System.Windows.Forms.Button();
            this.priceTerminationTXT = new System.Windows.Forms.TextBox();
            this.priceTerminationLBL = new System.Windows.Forms.Label();
            this.priceYearTXT = new System.Windows.Forms.TextBox();
            this.priceYearLBL = new System.Windows.Forms.Label();
            this.codTeamTXT = new System.Windows.Forms.TextBox();
            this.codTeamLBL = new System.Windows.Forms.Label();
            this.fourthProcedure = new System.Windows.Forms.GroupBox();
            this.monthsPlayedLBL = new System.Windows.Forms.Label();
            this.showMonthsBTN = new System.Windows.Forms.Button();
            this.dniPlayerTXT = new System.Windows.Forms.TextBox();
            this.secondDniLBL = new System.Windows.Forms.Label();
            this.authorLBL = new System.Windows.Forms.Label();
            this.firstProcedure.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProcedure)).BeginInit();
            this.secondProcedure.SuspendLayout();
            this.thirtProcedure.SuspendLayout();
            this.fourthProcedure.SuspendLayout();
            this.SuspendLayout();
            // 
            // firstProcedure
            // 
            this.firstProcedure.Controls.Add(this.dataGridProcedure);
            this.firstProcedure.Controls.Add(this.leagueLBL);
            this.firstProcedure.Controls.Add(this.listAgreementBTN);
            this.firstProcedure.Controls.Add(this.dniAgreementTXT);
            this.firstProcedure.Controls.Add(this.firstDniLBL);
            this.firstProcedure.Font = new System.Drawing.Font("Assistant", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstProcedure.Location = new System.Drawing.Point(11, 24);
            this.firstProcedure.Name = "firstProcedure";
            this.firstProcedure.Size = new System.Drawing.Size(492, 480);
            this.firstProcedure.TabIndex = 0;
            this.firstProcedure.TabStop = false;
            this.firstProcedure.Text = "1ºProcedimiento: Listar contratos según DNI";
            // 
            // dataGridProcedure
            // 
            this.dataGridProcedure.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridProcedure.Location = new System.Drawing.Point(16, 89);
            this.dataGridProcedure.Name = "dataGridProcedure";
            this.dataGridProcedure.Size = new System.Drawing.Size(460, 378);
            this.dataGridProcedure.TabIndex = 43;
            // 
            // leagueLBL
            // 
            this.leagueLBL.AutoSize = true;
            this.leagueLBL.Font = new System.Drawing.Font("Assistant", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.leagueLBL.Location = new System.Drawing.Point(212, 69);
            this.leagueLBL.Name = "leagueLBL";
            this.leagueLBL.Size = new System.Drawing.Size(65, 17);
            this.leagueLBL.TabIndex = 42;
            this.leagueLBL.Text = "Contratos";
            this.leagueLBL.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // listAgreementBTN
            // 
            this.listAgreementBTN.Font = new System.Drawing.Font("Assistant", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listAgreementBTN.Location = new System.Drawing.Point(252, 27);
            this.listAgreementBTN.Name = "listAgreementBTN";
            this.listAgreementBTN.Size = new System.Drawing.Size(140, 30);
            this.listAgreementBTN.TabIndex = 41;
            this.listAgreementBTN.Text = "Listar contratos";
            this.listAgreementBTN.UseVisualStyleBackColor = true;
            this.listAgreementBTN.Click += new System.EventHandler(this.listAgreementBTN_Click);
            // 
            // dniAgreementTXT
            // 
            this.dniAgreementTXT.Font = new System.Drawing.Font("Assistant SemiBold", 8.249999F, System.Drawing.FontStyle.Bold);
            this.dniAgreementTXT.Location = new System.Drawing.Point(47, 31);
            this.dniAgreementTXT.Name = "dniAgreementTXT";
            this.dniAgreementTXT.Size = new System.Drawing.Size(184, 22);
            this.dniAgreementTXT.TabIndex = 40;
            // 
            // firstDniLBL
            // 
            this.firstDniLBL.AutoSize = true;
            this.firstDniLBL.Font = new System.Drawing.Font("Assistant", 9.75F);
            this.firstDniLBL.Location = new System.Drawing.Point(13, 34);
            this.firstDniLBL.Name = "firstDniLBL";
            this.firstDniLBL.Size = new System.Drawing.Size(30, 17);
            this.firstDniLBL.TabIndex = 39;
            this.firstDniLBL.Text = "DNI:";
            // 
            // secondProcedure
            // 
            this.secondProcedure.Controls.Add(this.codLeagueTXT);
            this.secondProcedure.Controls.Add(this.insertLeagueLBL);
            this.secondProcedure.Controls.Add(this.existLeagueLBL);
            this.secondProcedure.Controls.Add(this.insertTeamBTN);
            this.secondProcedure.Controls.Add(this.internationalCHK);
            this.secondProcedure.Controls.Add(this.townTXT);
            this.secondProcedure.Controls.Add(this.townLBL);
            this.secondProcedure.Controls.Add(this.codLeagueLBL);
            this.secondProcedure.Controls.Add(this.nomTeamTXT);
            this.secondProcedure.Controls.Add(this.nameTeamLBL);
            this.secondProcedure.Font = new System.Drawing.Font("Assistant", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.secondProcedure.Location = new System.Drawing.Point(521, 24);
            this.secondProcedure.Name = "secondProcedure";
            this.secondProcedure.Size = new System.Drawing.Size(454, 180);
            this.secondProcedure.TabIndex = 1;
            this.secondProcedure.TabStop = false;
            this.secondProcedure.Text = "2ºProcedimiento: Insertar Equipo";
            // 
            // codLeagueTXT
            // 
            this.codLeagueTXT.Font = new System.Drawing.Font("Assistant SemiBold", 8.249999F, System.Drawing.FontStyle.Bold);
            this.codLeagueTXT.Location = new System.Drawing.Point(110, 48);
            this.codLeagueTXT.Name = "codLeagueTXT";
            this.codLeagueTXT.Size = new System.Drawing.Size(123, 22);
            this.codLeagueTXT.TabIndex = 26;
            // 
            // insertLeagueLBL
            // 
            this.insertLeagueLBL.AutoSize = true;
            this.insertLeagueLBL.Font = new System.Drawing.Font("Assistant", 9.75F);
            this.insertLeagueLBL.Location = new System.Drawing.Point(303, 153);
            this.insertLeagueLBL.Name = "insertLeagueLBL";
            this.insertLeagueLBL.Size = new System.Drawing.Size(59, 17);
            this.insertLeagueLBL.TabIndex = 25;
            this.insertLeagueLBL.Text = "Inserción:";
            // 
            // existLeagueLBL
            // 
            this.existLeagueLBL.AutoSize = true;
            this.existLeagueLBL.Font = new System.Drawing.Font("Assistant", 9.75F);
            this.existLeagueLBL.Location = new System.Drawing.Point(303, 130);
            this.existLeagueLBL.Name = "existLeagueLBL";
            this.existLeagueLBL.Size = new System.Drawing.Size(68, 17);
            this.existLeagueLBL.TabIndex = 24;
            this.existLeagueLBL.Text = "Existe Liga:";
            // 
            // insertTeamBTN
            // 
            this.insertTeamBTN.Font = new System.Drawing.Font("Assistant", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.insertTeamBTN.Location = new System.Drawing.Point(16, 130);
            this.insertTeamBTN.Name = "insertTeamBTN";
            this.insertTeamBTN.Size = new System.Drawing.Size(281, 40);
            this.insertTeamBTN.TabIndex = 23;
            this.insertTeamBTN.Text = "Insertar equipo";
            this.insertTeamBTN.UseVisualStyleBackColor = true;
            this.insertTeamBTN.Click += new System.EventHandler(this.insertTeamBTN_Click);
            // 
            // internationalCHK
            // 
            this.internationalCHK.AutoSize = true;
            this.internationalCHK.Font = new System.Drawing.Font("Assistant", 9.75F);
            this.internationalCHK.Location = new System.Drawing.Point(16, 103);
            this.internationalCHK.Name = "internationalCHK";
            this.internationalCHK.Size = new System.Drawing.Size(98, 21);
            this.internationalCHK.TabIndex = 22;
            this.internationalCHK.Text = "Internacional";
            this.internationalCHK.UseVisualStyleBackColor = true;
            // 
            // townTXT
            // 
            this.townTXT.Font = new System.Drawing.Font("Assistant SemiBold", 8.249999F, System.Drawing.FontStyle.Bold);
            this.townTXT.Location = new System.Drawing.Point(83, 75);
            this.townTXT.Name = "townTXT";
            this.townTXT.Size = new System.Drawing.Size(177, 22);
            this.townTXT.TabIndex = 21;
            // 
            // townLBL
            // 
            this.townLBL.AutoSize = true;
            this.townLBL.Font = new System.Drawing.Font("Assistant", 9.75F);
            this.townLBL.Location = new System.Drawing.Point(13, 78);
            this.townLBL.Name = "townLBL";
            this.townLBL.Size = new System.Drawing.Size(64, 17);
            this.townLBL.TabIndex = 20;
            this.townLBL.Text = "Localidad:";
            // 
            // codLeagueLBL
            // 
            this.codLeagueLBL.AutoSize = true;
            this.codLeagueLBL.Font = new System.Drawing.Font("Assistant", 9.75F);
            this.codLeagueLBL.Location = new System.Drawing.Point(13, 49);
            this.codLeagueLBL.Name = "codLeagueLBL";
            this.codLeagueLBL.Size = new System.Drawing.Size(91, 17);
            this.codLeagueLBL.TabIndex = 18;
            this.codLeagueLBL.Text = "Código de Liga:";
            // 
            // nomTeamTXT
            // 
            this.nomTeamTXT.Font = new System.Drawing.Font("Assistant SemiBold", 8.249999F, System.Drawing.FontStyle.Bold);
            this.nomTeamTXT.Location = new System.Drawing.Point(113, 21);
            this.nomTeamTXT.Name = "nomTeamTXT";
            this.nomTeamTXT.Size = new System.Drawing.Size(184, 22);
            this.nomTeamTXT.TabIndex = 17;
            // 
            // nameTeamLBL
            // 
            this.nameTeamLBL.AutoSize = true;
            this.nameTeamLBL.Font = new System.Drawing.Font("Assistant", 9.75F);
            this.nameTeamLBL.Location = new System.Drawing.Point(13, 22);
            this.nameTeamLBL.Name = "nameTeamLBL";
            this.nameTeamLBL.Size = new System.Drawing.Size(94, 17);
            this.nameTeamLBL.TabIndex = 16;
            this.nameTeamLBL.Text = "Nombre equipo:";
            // 
            // thirtProcedure
            // 
            this.thirtProcedure.Controls.Add(this.lowerPricesLBL);
            this.thirtProcedure.Controls.Add(this.activeAgreementLBL);
            this.thirtProcedure.Controls.Add(this.activePlayersBTN);
            this.thirtProcedure.Controls.Add(this.priceTerminationTXT);
            this.thirtProcedure.Controls.Add(this.priceTerminationLBL);
            this.thirtProcedure.Controls.Add(this.priceYearTXT);
            this.thirtProcedure.Controls.Add(this.priceYearLBL);
            this.thirtProcedure.Controls.Add(this.codTeamTXT);
            this.thirtProcedure.Controls.Add(this.codTeamLBL);
            this.thirtProcedure.Font = new System.Drawing.Font("Assistant", 8.999999F, System.Drawing.FontStyle.Bold);
            this.thirtProcedure.Location = new System.Drawing.Point(521, 210);
            this.thirtProcedure.Name = "thirtProcedure";
            this.thirtProcedure.Size = new System.Drawing.Size(454, 171);
            this.thirtProcedure.TabIndex = 2;
            this.thirtProcedure.TabStop = false;
            this.thirtProcedure.Text = "3ºProcedimiento: Futbolistas activos en un equipo";
            // 
            // lowerPricesLBL
            // 
            this.lowerPricesLBL.AutoSize = true;
            this.lowerPricesLBL.Font = new System.Drawing.Font("Assistant", 9.75F);
            this.lowerPricesLBL.Location = new System.Drawing.Point(303, 144);
            this.lowerPricesLBL.Name = "lowerPricesLBL";
            this.lowerPricesLBL.Size = new System.Drawing.Size(98, 17);
            this.lowerPricesLBL.TabIndex = 33;
            this.lowerPricesLBL.Text = "Precios menores:";
            // 
            // activeAgreementLBL
            // 
            this.activeAgreementLBL.AutoSize = true;
            this.activeAgreementLBL.Font = new System.Drawing.Font("Assistant", 9.75F);
            this.activeAgreementLBL.Location = new System.Drawing.Point(303, 121);
            this.activeAgreementLBL.Name = "activeAgreementLBL";
            this.activeAgreementLBL.Size = new System.Drawing.Size(104, 17);
            this.activeAgreementLBL.TabIndex = 32;
            this.activeAgreementLBL.Text = "Contratos activos:";
            // 
            // activePlayersBTN
            // 
            this.activePlayersBTN.Font = new System.Drawing.Font("Assistant", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.activePlayersBTN.Location = new System.Drawing.Point(16, 121);
            this.activePlayersBTN.Name = "activePlayersBTN";
            this.activePlayersBTN.Size = new System.Drawing.Size(281, 40);
            this.activePlayersBTN.TabIndex = 31;
            this.activePlayersBTN.Text = "Futbolistas en activo";
            this.activePlayersBTN.UseVisualStyleBackColor = true;
            this.activePlayersBTN.Click += new System.EventHandler(this.activePlayersBTN_Click);
            // 
            // priceTerminationTXT
            // 
            this.priceTerminationTXT.Font = new System.Drawing.Font("Assistant SemiBold", 8.249999F, System.Drawing.FontStyle.Bold);
            this.priceTerminationTXT.Location = new System.Drawing.Point(112, 82);
            this.priceTerminationTXT.Name = "priceTerminationTXT";
            this.priceTerminationTXT.Size = new System.Drawing.Size(185, 22);
            this.priceTerminationTXT.TabIndex = 27;
            // 
            // priceTerminationLBL
            // 
            this.priceTerminationLBL.AutoSize = true;
            this.priceTerminationLBL.Font = new System.Drawing.Font("Assistant", 9.75F);
            this.priceTerminationLBL.Location = new System.Drawing.Point(13, 84);
            this.priceTerminationLBL.Name = "priceTerminationLBL";
            this.priceTerminationLBL.Size = new System.Drawing.Size(93, 17);
            this.priceTerminationLBL.TabIndex = 26;
            this.priceTerminationLBL.Text = "Precio rescisión:";
            // 
            // priceYearTXT
            // 
            this.priceYearTXT.Font = new System.Drawing.Font("Assistant SemiBold", 8.249999F, System.Drawing.FontStyle.Bold);
            this.priceYearTXT.Location = new System.Drawing.Point(97, 54);
            this.priceYearTXT.Name = "priceYearTXT";
            this.priceYearTXT.Size = new System.Drawing.Size(177, 22);
            this.priceYearTXT.TabIndex = 25;
            // 
            // priceYearLBL
            // 
            this.priceYearLBL.AutoSize = true;
            this.priceYearLBL.Font = new System.Drawing.Font("Assistant", 9.75F);
            this.priceYearLBL.Location = new System.Drawing.Point(13, 55);
            this.priceYearLBL.Name = "priceYearLBL";
            this.priceYearLBL.Size = new System.Drawing.Size(78, 17);
            this.priceYearLBL.TabIndex = 24;
            this.priceYearLBL.Text = "Precio anual:";
            // 
            // codTeamTXT
            // 
            this.codTeamTXT.Font = new System.Drawing.Font("Assistant SemiBold", 8.249999F, System.Drawing.FontStyle.Bold);
            this.codTeamTXT.Location = new System.Drawing.Point(124, 26);
            this.codTeamTXT.Name = "codTeamTXT";
            this.codTeamTXT.Size = new System.Drawing.Size(184, 22);
            this.codTeamTXT.TabIndex = 23;
            // 
            // codTeamLBL
            // 
            this.codTeamLBL.AutoSize = true;
            this.codTeamLBL.Font = new System.Drawing.Font("Assistant", 9.75F);
            this.codTeamLBL.Location = new System.Drawing.Point(13, 27);
            this.codTeamLBL.Name = "codTeamLBL";
            this.codTeamLBL.Size = new System.Drawing.Size(105, 17);
            this.codTeamLBL.TabIndex = 22;
            this.codTeamLBL.Text = "Código de equipo:";
            // 
            // fourthProcedure
            // 
            this.fourthProcedure.Controls.Add(this.monthsPlayedLBL);
            this.fourthProcedure.Controls.Add(this.showMonthsBTN);
            this.fourthProcedure.Controls.Add(this.dniPlayerTXT);
            this.fourthProcedure.Controls.Add(this.secondDniLBL);
            this.fourthProcedure.Font = new System.Drawing.Font("Assistant", 8.999999F, System.Drawing.FontStyle.Bold);
            this.fourthProcedure.Location = new System.Drawing.Point(521, 387);
            this.fourthProcedure.Name = "fourthProcedure";
            this.fourthProcedure.Size = new System.Drawing.Size(454, 117);
            this.fourthProcedure.TabIndex = 3;
            this.fourthProcedure.TabStop = false;
            this.fourthProcedure.Text = "4ºFunción: Cantidad de meses jugados por un jugador";
            // 
            // monthsPlayedLBL
            // 
            this.monthsPlayedLBL.AutoSize = true;
            this.monthsPlayedLBL.Font = new System.Drawing.Font("Assistant", 9.75F);
            this.monthsPlayedLBL.Location = new System.Drawing.Point(303, 76);
            this.monthsPlayedLBL.Name = "monthsPlayedLBL";
            this.monthsPlayedLBL.Size = new System.Drawing.Size(96, 17);
            this.monthsPlayedLBL.TabIndex = 34;
            this.monthsPlayedLBL.Text = "Mese(s) jugados:";
            // 
            // showMonthsBTN
            // 
            this.showMonthsBTN.Font = new System.Drawing.Font("Assistant", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showMonthsBTN.Location = new System.Drawing.Point(16, 64);
            this.showMonthsBTN.Name = "showMonthsBTN";
            this.showMonthsBTN.Size = new System.Drawing.Size(281, 40);
            this.showMonthsBTN.TabIndex = 32;
            this.showMonthsBTN.Text = "Mostrar meses";
            this.showMonthsBTN.UseVisualStyleBackColor = true;
            this.showMonthsBTN.Click += new System.EventHandler(this.showMonthsBTN_Click);
            // 
            // dniPlayerTXT
            // 
            this.dniPlayerTXT.Font = new System.Drawing.Font("Assistant SemiBold", 8.249999F, System.Drawing.FontStyle.Bold);
            this.dniPlayerTXT.Location = new System.Drawing.Point(49, 27);
            this.dniPlayerTXT.Name = "dniPlayerTXT";
            this.dniPlayerTXT.Size = new System.Drawing.Size(184, 22);
            this.dniPlayerTXT.TabIndex = 27;
            // 
            // secondDniLBL
            // 
            this.secondDniLBL.AutoSize = true;
            this.secondDniLBL.Font = new System.Drawing.Font("Assistant", 9.75F);
            this.secondDniLBL.Location = new System.Drawing.Point(13, 28);
            this.secondDniLBL.Name = "secondDniLBL";
            this.secondDniLBL.Size = new System.Drawing.Size(30, 17);
            this.secondDniLBL.TabIndex = 26;
            this.secondDniLBL.Text = "DNI:";
            // 
            // authorLBL
            // 
            this.authorLBL.AutoSize = true;
            this.authorLBL.Font = new System.Drawing.Font("Assistant", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.authorLBL.Location = new System.Drawing.Point(446, 518);
            this.authorLBL.Name = "authorLBL";
            this.authorLBL.Size = new System.Drawing.Size(136, 15);
            this.authorLBL.TabIndex = 10;
            this.authorLBL.Text = "Hecho por: Ayoze Amaro";
            this.authorLBL.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // Ejecutar_PyF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(987, 545);
            this.Controls.Add(this.authorLBL);
            this.Controls.Add(this.fourthProcedure);
            this.Controls.Add(this.thirtProcedure);
            this.Controls.Add(this.secondProcedure);
            this.Controls.Add(this.firstProcedure);
            this.Name = "Ejecutar_PyF";
            this.Text = "Ejecutar Procedimientos y Funciones";
            this.firstProcedure.ResumeLayout(false);
            this.firstProcedure.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProcedure)).EndInit();
            this.secondProcedure.ResumeLayout(false);
            this.secondProcedure.PerformLayout();
            this.thirtProcedure.ResumeLayout(false);
            this.thirtProcedure.PerformLayout();
            this.fourthProcedure.ResumeLayout(false);
            this.fourthProcedure.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox firstProcedure;
        private System.Windows.Forms.GroupBox secondProcedure;
        private System.Windows.Forms.GroupBox thirtProcedure;
        private System.Windows.Forms.GroupBox fourthProcedure;
        private System.Windows.Forms.Label authorLBL;
        private System.Windows.Forms.Button listAgreementBTN;
        private System.Windows.Forms.TextBox dniAgreementTXT;
        private System.Windows.Forms.Label firstDniLBL;
        private System.Windows.Forms.DataGridView dataGridProcedure;
        private System.Windows.Forms.Label leagueLBL;
        private System.Windows.Forms.Button insertTeamBTN;
        private System.Windows.Forms.CheckBox internationalCHK;
        private System.Windows.Forms.TextBox townTXT;
        private System.Windows.Forms.Label townLBL;
        private System.Windows.Forms.Label codLeagueLBL;
        private System.Windows.Forms.TextBox nomTeamTXT;
        private System.Windows.Forms.Label nameTeamLBL;
        private System.Windows.Forms.Label insertLeagueLBL;
        private System.Windows.Forms.Label existLeagueLBL;
        private System.Windows.Forms.TextBox priceYearTXT;
        private System.Windows.Forms.Label priceYearLBL;
        private System.Windows.Forms.TextBox codTeamTXT;
        private System.Windows.Forms.Label codTeamLBL;
        private System.Windows.Forms.Label lowerPricesLBL;
        private System.Windows.Forms.Label activeAgreementLBL;
        private System.Windows.Forms.Button activePlayersBTN;
        private System.Windows.Forms.TextBox priceTerminationTXT;
        private System.Windows.Forms.Label priceTerminationLBL;
        private System.Windows.Forms.Label monthsPlayedLBL;
        private System.Windows.Forms.Button showMonthsBTN;
        private System.Windows.Forms.TextBox dniPlayerTXT;
        private System.Windows.Forms.Label secondDniLBL;
        private System.Windows.Forms.TextBox codLeagueTXT;
    }
}