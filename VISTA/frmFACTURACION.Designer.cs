
namespace VISTA
{
    partial class frmFACTURACION_TURNOS
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gbLISTA_TURNOS_HOY_FACTURAR = new System.Windows.Forms.GroupBox();
            this.btnEXPORTAR_PDF = new System.Windows.Forms.Button();
            this.btnCERRAR = new System.Windows.Forms.Button();
            this.dgvLISTA_TURNOS_HOY_FACTURAR = new System.Windows.Forms.DataGridView();
            this.gbLISTA_TURNOS_HOY_FACTURAR.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLISTA_TURNOS_HOY_FACTURAR)).BeginInit();
            this.SuspendLayout();
            // 
            // gbLISTA_TURNOS_HOY_FACTURAR
            // 
            this.gbLISTA_TURNOS_HOY_FACTURAR.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbLISTA_TURNOS_HOY_FACTURAR.Controls.Add(this.btnEXPORTAR_PDF);
            this.gbLISTA_TURNOS_HOY_FACTURAR.Controls.Add(this.btnCERRAR);
            this.gbLISTA_TURNOS_HOY_FACTURAR.Controls.Add(this.dgvLISTA_TURNOS_HOY_FACTURAR);
            this.gbLISTA_TURNOS_HOY_FACTURAR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbLISTA_TURNOS_HOY_FACTURAR.ForeColor = System.Drawing.Color.White;
            this.gbLISTA_TURNOS_HOY_FACTURAR.Location = new System.Drawing.Point(12, 12);
            this.gbLISTA_TURNOS_HOY_FACTURAR.Name = "gbLISTA_TURNOS_HOY_FACTURAR";
            this.gbLISTA_TURNOS_HOY_FACTURAR.Size = new System.Drawing.Size(631, 367);
            this.gbLISTA_TURNOS_HOY_FACTURAR.TabIndex = 8;
            this.gbLISTA_TURNOS_HOY_FACTURAR.TabStop = false;
            this.gbLISTA_TURNOS_HOY_FACTURAR.Text = "LISTA DE TURNOS DE HOY A FACTURAR";
            // 
            // btnEXPORTAR_PDF
            // 
            this.btnEXPORTAR_PDF.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.btnEXPORTAR_PDF.FlatAppearance.BorderSize = 0;
            this.btnEXPORTAR_PDF.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEXPORTAR_PDF.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEXPORTAR_PDF.ForeColor = System.Drawing.Color.White;
            this.btnEXPORTAR_PDF.Location = new System.Drawing.Point(6, 331);
            this.btnEXPORTAR_PDF.Name = "btnEXPORTAR_PDF";
            this.btnEXPORTAR_PDF.Size = new System.Drawing.Size(111, 30);
            this.btnEXPORTAR_PDF.TabIndex = 17;
            this.btnEXPORTAR_PDF.Text = "Exportar en PDF";
            this.btnEXPORTAR_PDF.UseVisualStyleBackColor = false;
            this.btnEXPORTAR_PDF.Click += new System.EventHandler(this.btnEXPORTAR_PDF_Click);
            // 
            // btnCERRAR
            // 
            this.btnCERRAR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCERRAR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.btnCERRAR.FlatAppearance.BorderSize = 0;
            this.btnCERRAR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCERRAR.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCERRAR.ForeColor = System.Drawing.Color.White;
            this.btnCERRAR.Location = new System.Drawing.Point(542, 331);
            this.btnCERRAR.Name = "btnCERRAR";
            this.btnCERRAR.Size = new System.Drawing.Size(83, 30);
            this.btnCERRAR.TabIndex = 16;
            this.btnCERRAR.Text = "Cerrar";
            this.btnCERRAR.UseVisualStyleBackColor = false;
            this.btnCERRAR.Click += new System.EventHandler(this.btnCERRAR_Click);
            // 
            // dgvLISTA_TURNOS_HOY_FACTURAR
            // 
            this.dgvLISTA_TURNOS_HOY_FACTURAR.AllowUserToAddRows = false;
            this.dgvLISTA_TURNOS_HOY_FACTURAR.AllowUserToDeleteRows = false;
            this.dgvLISTA_TURNOS_HOY_FACTURAR.AllowUserToResizeColumns = false;
            this.dgvLISTA_TURNOS_HOY_FACTURAR.AllowUserToResizeRows = false;
            this.dgvLISTA_TURNOS_HOY_FACTURAR.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvLISTA_TURNOS_HOY_FACTURAR.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLISTA_TURNOS_HOY_FACTURAR.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.dgvLISTA_TURNOS_HOY_FACTURAR.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvLISTA_TURNOS_HOY_FACTURAR.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvLISTA_TURNOS_HOY_FACTURAR.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLISTA_TURNOS_HOY_FACTURAR.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvLISTA_TURNOS_HOY_FACTURAR.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvLISTA_TURNOS_HOY_FACTURAR.EnableHeadersVisualStyles = false;
            this.dgvLISTA_TURNOS_HOY_FACTURAR.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.dgvLISTA_TURNOS_HOY_FACTURAR.Location = new System.Drawing.Point(6, 19);
            this.dgvLISTA_TURNOS_HOY_FACTURAR.Name = "dgvLISTA_TURNOS_HOY_FACTURAR";
            this.dgvLISTA_TURNOS_HOY_FACTURAR.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLISTA_TURNOS_HOY_FACTURAR.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvLISTA_TURNOS_HOY_FACTURAR.RowHeadersVisible = false;
            this.dgvLISTA_TURNOS_HOY_FACTURAR.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            this.dgvLISTA_TURNOS_HOY_FACTURAR.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvLISTA_TURNOS_HOY_FACTURAR.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLISTA_TURNOS_HOY_FACTURAR.Size = new System.Drawing.Size(619, 306);
            this.dgvLISTA_TURNOS_HOY_FACTURAR.TabIndex = 0;
            // 
            // frmFACTURACION_TURNOS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(655, 391);
            this.Controls.Add(this.gbLISTA_TURNOS_HOY_FACTURAR);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "frmFACTURACION_TURNOS";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FACTURACIÓN";
            this.gbLISTA_TURNOS_HOY_FACTURAR.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLISTA_TURNOS_HOY_FACTURAR)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbLISTA_TURNOS_HOY_FACTURAR;
        private System.Windows.Forms.Button btnCERRAR;
        private System.Windows.Forms.DataGridView dgvLISTA_TURNOS_HOY_FACTURAR;
        private System.Windows.Forms.Button btnEXPORTAR_PDF;
    }
}