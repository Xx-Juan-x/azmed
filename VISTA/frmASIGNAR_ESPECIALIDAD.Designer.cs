
namespace VISTA
{
    partial class frmASIGNAR_ESPECIALIDAD
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
            this.dgvLISTA_PROFESIONALES = new System.Windows.Forms.DataGridView();
            this.cmbESPECIALIDADES = new System.Windows.Forms.ComboBox();
            this.gbESPECIALIDADES = new System.Windows.Forms.GroupBox();
            this.btnCANCELAR = new System.Windows.Forms.Button();
            this.btnGUARDAR = new System.Windows.Forms.Button();
            this.gbLISTA_PROFESIONALES = new System.Windows.Forms.GroupBox();
            this.btnCERRAR = new System.Windows.Forms.Button();
            this.btnASIGNAR = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLISTA_PROFESIONALES)).BeginInit();
            this.gbESPECIALIDADES.SuspendLayout();
            this.gbLISTA_PROFESIONALES.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvLISTA_PROFESIONALES
            // 
            this.dgvLISTA_PROFESIONALES.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLISTA_PROFESIONALES.Location = new System.Drawing.Point(6, 19);
            this.dgvLISTA_PROFESIONALES.Name = "dgvLISTA_PROFESIONALES";
            this.dgvLISTA_PROFESIONALES.Size = new System.Drawing.Size(637, 310);
            this.dgvLISTA_PROFESIONALES.TabIndex = 0;
            // 
            // cmbESPECIALIDADES
            // 
            this.cmbESPECIALIDADES.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbESPECIALIDADES.FormattingEnabled = true;
            this.cmbESPECIALIDADES.Location = new System.Drawing.Point(6, 34);
            this.cmbESPECIALIDADES.Name = "cmbESPECIALIDADES";
            this.cmbESPECIALIDADES.Size = new System.Drawing.Size(215, 21);
            this.cmbESPECIALIDADES.TabIndex = 1;
            // 
            // gbESPECIALIDADES
            // 
            this.gbESPECIALIDADES.Controls.Add(this.btnCANCELAR);
            this.gbESPECIALIDADES.Controls.Add(this.btnGUARDAR);
            this.gbESPECIALIDADES.Controls.Add(this.cmbESPECIALIDADES);
            this.gbESPECIALIDADES.Location = new System.Drawing.Point(667, 12);
            this.gbESPECIALIDADES.Name = "gbESPECIALIDADES";
            this.gbESPECIALIDADES.Size = new System.Drawing.Size(227, 108);
            this.gbESPECIALIDADES.TabIndex = 3;
            this.gbESPECIALIDADES.TabStop = false;
            this.gbESPECIALIDADES.Text = "ESPECIALIDADES";
            // 
            // btnCANCELAR
            // 
            this.btnCANCELAR.BackColor = System.Drawing.Color.Red;
            this.btnCANCELAR.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCANCELAR.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCANCELAR.ForeColor = System.Drawing.Color.White;
            this.btnCANCELAR.Location = new System.Drawing.Point(133, 76);
            this.btnCANCELAR.Name = "btnCANCELAR";
            this.btnCANCELAR.Size = new System.Drawing.Size(88, 23);
            this.btnCANCELAR.TabIndex = 60;
            this.btnCANCELAR.Text = "Cancelar";
            this.btnCANCELAR.UseVisualStyleBackColor = false;
            this.btnCANCELAR.Click += new System.EventHandler(this.btnCANCELAR_Click);
            // 
            // btnGUARDAR
            // 
            this.btnGUARDAR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnGUARDAR.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGUARDAR.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGUARDAR.ForeColor = System.Drawing.Color.White;
            this.btnGUARDAR.Location = new System.Drawing.Point(6, 76);
            this.btnGUARDAR.Name = "btnGUARDAR";
            this.btnGUARDAR.Size = new System.Drawing.Size(88, 23);
            this.btnGUARDAR.TabIndex = 49;
            this.btnGUARDAR.Text = "Guardar";
            this.btnGUARDAR.UseVisualStyleBackColor = false;
            this.btnGUARDAR.Click += new System.EventHandler(this.btnGUARDAR_Click_1);
            // 
            // gbLISTA_PROFESIONALES
            // 
            this.gbLISTA_PROFESIONALES.Controls.Add(this.btnCERRAR);
            this.gbLISTA_PROFESIONALES.Controls.Add(this.btnASIGNAR);
            this.gbLISTA_PROFESIONALES.Controls.Add(this.dgvLISTA_PROFESIONALES);
            this.gbLISTA_PROFESIONALES.Location = new System.Drawing.Point(12, 3);
            this.gbLISTA_PROFESIONALES.Name = "gbLISTA_PROFESIONALES";
            this.gbLISTA_PROFESIONALES.Size = new System.Drawing.Size(649, 362);
            this.gbLISTA_PROFESIONALES.TabIndex = 4;
            this.gbLISTA_PROFESIONALES.TabStop = false;
            this.gbLISTA_PROFESIONALES.Text = "LISTA DE PROFESIONALES";
            // 
            // btnCERRAR
            // 
            this.btnCERRAR.BackColor = System.Drawing.Color.Red;
            this.btnCERRAR.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCERRAR.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCERRAR.ForeColor = System.Drawing.Color.White;
            this.btnCERRAR.Location = new System.Drawing.Point(555, 333);
            this.btnCERRAR.Name = "btnCERRAR";
            this.btnCERRAR.Size = new System.Drawing.Size(88, 23);
            this.btnCERRAR.TabIndex = 53;
            this.btnCERRAR.Text = "Cerrar";
            this.btnCERRAR.UseVisualStyleBackColor = false;
            this.btnCERRAR.Click += new System.EventHandler(this.btnCERRAR_Click_1);
            // 
            // btnASIGNAR
            // 
            this.btnASIGNAR.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnASIGNAR.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnASIGNAR.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnASIGNAR.ForeColor = System.Drawing.Color.White;
            this.btnASIGNAR.Location = new System.Drawing.Point(6, 333);
            this.btnASIGNAR.Name = "btnASIGNAR";
            this.btnASIGNAR.Size = new System.Drawing.Size(88, 23);
            this.btnASIGNAR.TabIndex = 51;
            this.btnASIGNAR.Text = "Asignar";
            this.btnASIGNAR.UseVisualStyleBackColor = false;
            this.btnASIGNAR.Click += new System.EventHandler(this.btnASIGNAR_Click_1);
            // 
            // frmASIGNAR_ESPECIALIDAD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(901, 366);
            this.Controls.Add(this.gbLISTA_PROFESIONALES);
            this.Controls.Add(this.gbESPECIALIDADES);
            this.Name = "frmASIGNAR_ESPECIALIDAD";
            this.Text = "ASIGNAR ESPECIALIDADES A PROFESIONALES";
            ((System.ComponentModel.ISupportInitialize)(this.dgvLISTA_PROFESIONALES)).EndInit();
            this.gbESPECIALIDADES.ResumeLayout(false);
            this.gbLISTA_PROFESIONALES.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvLISTA_PROFESIONALES;
        private System.Windows.Forms.ComboBox cmbESPECIALIDADES;
        private System.Windows.Forms.GroupBox gbESPECIALIDADES;
        private System.Windows.Forms.GroupBox gbLISTA_PROFESIONALES;
        private System.Windows.Forms.Button btnGUARDAR;
        private System.Windows.Forms.Button btnCANCELAR;
        private System.Windows.Forms.Button btnASIGNAR;
        private System.Windows.Forms.Button btnCERRAR;
    }
}