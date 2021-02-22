
namespace Proyecto_ADO.NET
{
    partial class Main_Menu
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.handleRecordBTN = new System.Windows.Forms.Button();
            this.readRecordBTN = new System.Windows.Forms.Button();
            this.comboDatagridBTN = new System.Windows.Forms.Button();
            this.comboSelectBTN = new System.Windows.Forms.Button();
            this.insertRecordBTN = new System.Windows.Forms.Button();
            this.deleteRecordBTN = new System.Windows.Forms.Button();
            this.updateRecordBTN = new System.Windows.Forms.Button();
            this.twoDatagridBTN = new System.Windows.Forms.Button();
            this.proceduresFunctionsBTN = new System.Windows.Forms.Button();
            this.authorLBL = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // handleRecordBTN
            // 
            this.handleRecordBTN.Font = new System.Drawing.Font("Assistant", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.handleRecordBTN.Location = new System.Drawing.Point(12, 13);
            this.handleRecordBTN.Name = "handleRecordBTN";
            this.handleRecordBTN.Size = new System.Drawing.Size(285, 48);
            this.handleRecordBTN.TabIndex = 0;
            this.handleRecordBTN.Text = "Manipular registros de diferentes tablas";
            this.handleRecordBTN.UseVisualStyleBackColor = true;
            this.handleRecordBTN.Click += new System.EventHandler(this.handleRecordBTN_Click);
            // 
            // readRecordBTN
            // 
            this.readRecordBTN.Font = new System.Drawing.Font("Assistant", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.readRecordBTN.Location = new System.Drawing.Point(12, 68);
            this.readRecordBTN.Name = "readRecordBTN";
            this.readRecordBTN.Size = new System.Drawing.Size(285, 48);
            this.readRecordBTN.TabIndex = 1;
            this.readRecordBTN.Text = "Leer registros de diferentes tablas";
            this.readRecordBTN.UseVisualStyleBackColor = true;
            this.readRecordBTN.Click += new System.EventHandler(this.readRecordBTN_Click);
            // 
            // comboDatagridBTN
            // 
            this.comboDatagridBTN.Font = new System.Drawing.Font("Assistant", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboDatagridBTN.Location = new System.Drawing.Point(12, 123);
            this.comboDatagridBTN.Name = "comboDatagridBTN";
            this.comboDatagridBTN.Size = new System.Drawing.Size(285, 48);
            this.comboDatagridBTN.TabIndex = 2;
            this.comboDatagridBTN.Text = "Combo dentro de un DataGrid";
            this.comboDatagridBTN.UseVisualStyleBackColor = true;
            this.comboDatagridBTN.Click += new System.EventHandler(this.comboDatagridBTN_Click);
            // 
            // comboSelectBTN
            // 
            this.comboSelectBTN.Font = new System.Drawing.Font("Assistant", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboSelectBTN.Location = new System.Drawing.Point(12, 178);
            this.comboSelectBTN.Name = "comboSelectBTN";
            this.comboSelectBTN.Size = new System.Drawing.Size(285, 48);
            this.comboSelectBTN.TabIndex = 3;
            this.comboSelectBTN.Text = "Combo para seleccionar un DataGrid";
            this.comboSelectBTN.UseVisualStyleBackColor = true;
            this.comboSelectBTN.Click += new System.EventHandler(this.comboSelectBTN_Click);
            // 
            // insertRecordBTN
            // 
            this.insertRecordBTN.Font = new System.Drawing.Font("Assistant", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.insertRecordBTN.Location = new System.Drawing.Point(305, 13);
            this.insertRecordBTN.Name = "insertRecordBTN";
            this.insertRecordBTN.Size = new System.Drawing.Size(285, 48);
            this.insertRecordBTN.TabIndex = 4;
            this.insertRecordBTN.Text = "Inserción de un registro";
            this.insertRecordBTN.UseVisualStyleBackColor = true;
            this.insertRecordBTN.Click += new System.EventHandler(this.insertRecordBTN_Click);
            // 
            // deleteRecordBTN
            // 
            this.deleteRecordBTN.Font = new System.Drawing.Font("Assistant", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteRecordBTN.Location = new System.Drawing.Point(305, 68);
            this.deleteRecordBTN.Name = "deleteRecordBTN";
            this.deleteRecordBTN.Size = new System.Drawing.Size(285, 48);
            this.deleteRecordBTN.TabIndex = 5;
            this.deleteRecordBTN.Text = "Borrado de un registro";
            this.deleteRecordBTN.UseVisualStyleBackColor = true;
            this.deleteRecordBTN.Click += new System.EventHandler(this.deleteRecordBTN_Click);
            // 
            // updateRecordBTN
            // 
            this.updateRecordBTN.Font = new System.Drawing.Font("Assistant", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateRecordBTN.Location = new System.Drawing.Point(305, 124);
            this.updateRecordBTN.Name = "updateRecordBTN";
            this.updateRecordBTN.Size = new System.Drawing.Size(285, 48);
            this.updateRecordBTN.TabIndex = 6;
            this.updateRecordBTN.Text = "Edición de registro";
            this.updateRecordBTN.UseVisualStyleBackColor = true;
            this.updateRecordBTN.Click += new System.EventHandler(this.updateRecordBTN_Click);
            // 
            // twoDatagridBTN
            // 
            this.twoDatagridBTN.Font = new System.Drawing.Font("Assistant", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.twoDatagridBTN.Location = new System.Drawing.Point(305, 178);
            this.twoDatagridBTN.Name = "twoDatagridBTN";
            this.twoDatagridBTN.Size = new System.Drawing.Size(285, 48);
            this.twoDatagridBTN.TabIndex = 7;
            this.twoDatagridBTN.Text = "Dos DataGrid relacionados";
            this.twoDatagridBTN.UseVisualStyleBackColor = true;
            this.twoDatagridBTN.Click += new System.EventHandler(this.twoDatagridBTN_Click);
            // 
            // proceduresFunctionsBTN
            // 
            this.proceduresFunctionsBTN.Font = new System.Drawing.Font("Assistant", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.proceduresFunctionsBTN.Location = new System.Drawing.Point(305, 234);
            this.proceduresFunctionsBTN.Name = "proceduresFunctionsBTN";
            this.proceduresFunctionsBTN.Size = new System.Drawing.Size(285, 48);
            this.proceduresFunctionsBTN.TabIndex = 8;
            this.proceduresFunctionsBTN.Text = "Ejecutar Procedimientos y Funciones";
            this.proceduresFunctionsBTN.UseVisualStyleBackColor = true;
            this.proceduresFunctionsBTN.Click += new System.EventHandler(this.proceduresFunctionsBTN_Click);
            // 
            // authorLBL
            // 
            this.authorLBL.AutoSize = true;
            this.authorLBL.Font = new System.Drawing.Font("Assistant", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.authorLBL.Location = new System.Drawing.Point(90, 251);
            this.authorLBL.Name = "authorLBL";
            this.authorLBL.Size = new System.Drawing.Size(136, 15);
            this.authorLBL.TabIndex = 9;
            this.authorLBL.Text = "Hecho por: Ayoze Amaro";
            this.authorLBL.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // Menu_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 300);
            this.Controls.Add(this.authorLBL);
            this.Controls.Add(this.proceduresFunctionsBTN);
            this.Controls.Add(this.twoDatagridBTN);
            this.Controls.Add(this.updateRecordBTN);
            this.Controls.Add(this.deleteRecordBTN);
            this.Controls.Add(this.insertRecordBTN);
            this.Controls.Add(this.comboSelectBTN);
            this.Controls.Add(this.comboDatagridBTN);
            this.Controls.Add(this.readRecordBTN);
            this.Controls.Add(this.handleRecordBTN);
            this.Font = new System.Drawing.Font("Assistant", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Menu_Principal";
            this.Text = "Proyecto de Equipos de Fútbol";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button handleRecordBTN;
        private System.Windows.Forms.Button readRecordBTN;
        private System.Windows.Forms.Button comboDatagridBTN;
        private System.Windows.Forms.Button comboSelectBTN;
        private System.Windows.Forms.Button insertRecordBTN;
        private System.Windows.Forms.Button deleteRecordBTN;
        private System.Windows.Forms.Button updateRecordBTN;
        private System.Windows.Forms.Button twoDatagridBTN;
        private System.Windows.Forms.Button proceduresFunctionsBTN;
        private System.Windows.Forms.Label authorLBL;
    }
}

