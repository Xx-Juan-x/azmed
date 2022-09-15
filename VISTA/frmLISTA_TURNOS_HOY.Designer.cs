
namespace VISTA
{
    partial class frmLISTA_TURNOS_HOY
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gbLISTA_TURNOS_HOY = new System.Windows.Forms.GroupBox();
            this.btnCANCELAR = new System.Windows.Forms.Button();
            this.btnTOMAR = new System.Windows.Forms.Button();
            this.btnCERRAR = new System.Windows.Forms.Button();
            this.dgvLISTA_TURNOS_HOY = new System.Windows.Forms.DataGridView();
            this.gbLISTA_TURNOS_HOY.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLISTA_TURNOS_HOY)).BeginInit();
            this.SuspendLayout();
            // 
            // gbLISTA_TURNOS_HOY
            // 
            this.gbLISTA_TURNOS_HOY.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbLISTA_TURNOS_HOY.Controls.Add(this.btnCANCELAR);
            this.gbLISTA_TURNOS_HOY.Controls.Add(this.btnTOMAR);
            this.gbLISTA_TURNOS_HOY.Controls.Add(this.btnCERRAR);
            this.gbLISTA_TURNOS_HOY.Controls.Add(this.dgvLISTA_TURNOS_HOY);
            this.gbLISTA_TURNOS_HOY.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbLISTA_TURNOS_HOY.ForeColor = System.Drawing.Color.White;
            this.gbLISTA_TURNOS_HOY.Location = new System.Drawing.Point(12, 12);
            this.gbLISTA_TURNOS_HOY.Name = "gbLISTA_TURNOS_HOY";
            this.gbLISTA_TURNOS_HOY.Size = new System.Drawing.Size(633, 325);
            this.gbLISTA_TURNOS_HOY.TabIndex = 7;
            this.gbLISTA_TURNOS_HOY.TabStop = false;
            this.gbLISTA_TURNOS_HOY.Text = "LISTA DE TURNOS DE HOY DEL PROFESIONAL";
            // 
            // btnCANCELAR
            // 
            this.btnCANCELAR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCANCELAR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.btnCANCELAR.FlatAppearance.BorderSize = 0;
            this.btnCANCELAR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCANCELAR.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCANCELAR.ForeColor = System.Drawing.Color.White;
            this.btnCANCELAR.Location = new System.Drawing.Point(95, 289);
            this.btnCANCELAR.Name = "btnCANCELAR";
            this.btnCANCELAR.Size = new System.Drawing.Size(83, 30);
            this.btnCANCELAR.TabIndex = 21;
            this.btnCANCELAR.Text = "Cancelar";
            this.btnCANCELAR.UseVisualStyleBackColor = false;
            this.btnCANCELAR.Click += new System.EventHandler(this.btnCANCELAR_Click);
            // 
            // btnTOMAR
            // 
            this.btnTOMAR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnTOMAR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.btnTOMAR.FlatAppearance.BorderSize = 0;
            this.btnTOMAR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTOMAR.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTOMAR.ForeColor = System.Drawing.Color.White;
            this.btnTOMAR.Location = new System.Drawing.Point(6, 289);
            this.btnTOMAR.Name = "btnTOMAR";
            this.btnTOMAR.Size = new System.Drawing.Size(83, 30);
            this.btnTOMAR.TabIndex = 20;
            this.btnTOMAR.Text = "Tomar";
            this.btnTOMAR.UseVisualStyleBackColor = false;
            this.btnTOMAR.Click += new System.EventHandler(this.btnTOMAR_Click);
            // 
            // btnCERRAR
            // 
            this.btnCERRAR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCERRAR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.btnCERRAR.FlatAppearance.BorderSize = 0;
            this.btnCERRAR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCERRAR.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCERRAR.ForeColor = System.Drawing.Color.White;
            this.btnCERRAR.Location = new System.Drawing.Point(544, 289);
            this.btnCERRAR.Name = "btnCERRAR";
            this.btnCERRAR.Size = new System.Drawing.Size(83, 30);
            this.btnCERRAR.TabIndex = 16;
            this.btnCERRAR.Text = "Cerrar";
            this.btnCERRAR.UseVisualStyleBackColor = false;
            this.btnCERRAR.Click += new System.EventHandler(this.btnCERRAR_Click);
            // 
            // dgvLISTA_TURNOS_HOY
            // 
            this.dgvLISTA_TURNOS_HOY.AllowUserToAddRows = false;
            this.dgvLISTA_TURNOS_HOY.AllowUserToDeleteRows = false;
            this.dgvLISTA_TURNOS_HOY.AllowUserToResizeColumns = false;
            this.dgvLISTA_TURNOS_HOY.AllowUserToResizeRows = false;
            this.dgvLISTA_TURNOS_HOY.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvLISTA_TURNOS_HOY.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLISTA_TURNOS_HOY.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.dgvLISTA_TURNOS_HOY.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvLISTA_TURNOS_HOY.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvLISTA_TURNOS_HOY.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLISTA_TURNOS_HOY.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvLISTA_TURNOS_HOY.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvLISTA_TURNOS_HOY.EnableHeadersVisualStyles = false;
            this.dgvLISTA_TURNOS_HOY.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.dgvLISTA_TURNOS_HOY.Location = new System.Drawing.Point(6, 19);
            this.dgvLISTA_TURNOS_HOY.Name = "dgvLISTA_TURNOS_HOY";
            this.dgvLISTA_TURNOS_HOY.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLISTA_TURNOS_HOY.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvLISTA_TURNOS_HOY.RowHeadersVisible = false;
            this.dgvLISTA_TURNOS_HOY.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            this.dgvLISTA_TURNOS_HOY.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvLISTA_TURNOS_HOY.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLISTA_TURNOS_HOY.Size = new System.Drawing.Size(621, 264);
            this.dgvLISTA_TURNOS_HOY.TabIndex = 0;
            // 
            // frmLISTA_TURNOS_HOY
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(657, 349);
            this.Controls.Add(this.gbLISTA_TURNOS_HOY);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "frmLISTA_TURNOS_HOY";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TURNOS DEL DÍA";
            this.gbLISTA_TURNOS_HOY.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLISTA_TURNOS_HOY)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbLISTA_TURNOS_HOY;
        private System.Windows.Forms.Button btnCERRAR;
        private System.Windows.Forms.DataGridView dgvLISTA_TURNOS_HOY;
        private System.Windows.Forms.Button btnCANCELAR;
        private System.Windows.Forms.Button btnTOMAR;
    }
}