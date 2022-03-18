
namespace VISTA
{
    partial class frmLISTA_TURNOS_PACIENTES
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gbLISTA_TURNOS = new System.Windows.Forms.GroupBox();
            this.gbTURNOS_BUSCADOR = new System.Windows.Forms.GroupBox();
            this.rbLISTA_TURNOS_PASADO = new System.Windows.Forms.RadioButton();
            this.rbLISTA_TURNOS_PROXIMOS = new System.Windows.Forms.RadioButton();
            this.btnEXPORTAR = new System.Windows.Forms.Button();
            this.btnCERRAR = new System.Windows.Forms.Button();
            this.dgvLISTA_TURNOS = new System.Windows.Forms.DataGridView();
            this.gbLISTA_TURNOS.SuspendLayout();
            this.gbTURNOS_BUSCADOR.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLISTA_TURNOS)).BeginInit();
            this.SuspendLayout();
            // 
            // gbLISTA_TURNOS
            // 
            this.gbLISTA_TURNOS.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbLISTA_TURNOS.Controls.Add(this.gbTURNOS_BUSCADOR);
            this.gbLISTA_TURNOS.Controls.Add(this.btnEXPORTAR);
            this.gbLISTA_TURNOS.Controls.Add(this.btnCERRAR);
            this.gbLISTA_TURNOS.Controls.Add(this.dgvLISTA_TURNOS);
            this.gbLISTA_TURNOS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbLISTA_TURNOS.ForeColor = System.Drawing.Color.White;
            this.gbLISTA_TURNOS.Location = new System.Drawing.Point(12, 12);
            this.gbLISTA_TURNOS.Name = "gbLISTA_TURNOS";
            this.gbLISTA_TURNOS.Size = new System.Drawing.Size(907, 426);
            this.gbLISTA_TURNOS.TabIndex = 7;
            this.gbLISTA_TURNOS.TabStop = false;
            this.gbLISTA_TURNOS.Text = "LISTA DE TURNOS DEL PACIENTE";
            // 
            // gbTURNOS_BUSCADOR
            // 
            this.gbTURNOS_BUSCADOR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gbTURNOS_BUSCADOR.Controls.Add(this.rbLISTA_TURNOS_PASADO);
            this.gbTURNOS_BUSCADOR.Controls.Add(this.rbLISTA_TURNOS_PROXIMOS);
            this.gbTURNOS_BUSCADOR.ForeColor = System.Drawing.Color.White;
            this.gbTURNOS_BUSCADOR.Location = new System.Drawing.Point(682, 12);
            this.gbTURNOS_BUSCADOR.Name = "gbTURNOS_BUSCADOR";
            this.gbTURNOS_BUSCADOR.Size = new System.Drawing.Size(218, 43);
            this.gbTURNOS_BUSCADOR.TabIndex = 92;
            this.gbTURNOS_BUSCADOR.TabStop = false;
            this.gbTURNOS_BUSCADOR.Text = "TURNOS";
            // 
            // rbLISTA_TURNOS_PASADO
            // 
            this.rbLISTA_TURNOS_PASADO.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rbLISTA_TURNOS_PASADO.AutoSize = true;
            this.rbLISTA_TURNOS_PASADO.Location = new System.Drawing.Point(6, 20);
            this.rbLISTA_TURNOS_PASADO.Name = "rbLISTA_TURNOS_PASADO";
            this.rbLISTA_TURNOS_PASADO.Size = new System.Drawing.Size(76, 17);
            this.rbLISTA_TURNOS_PASADO.TabIndex = 90;
            this.rbLISTA_TURNOS_PASADO.TabStop = true;
            this.rbLISTA_TURNOS_PASADO.Text = "PASADOS";
            this.rbLISTA_TURNOS_PASADO.UseVisualStyleBackColor = true;
            this.rbLISTA_TURNOS_PASADO.CheckedChanged += new System.EventHandler(this.rbLISTA_TURNOS_PASADO_CheckedChanged);
            // 
            // rbLISTA_TURNOS_PROXIMOS
            // 
            this.rbLISTA_TURNOS_PROXIMOS.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rbLISTA_TURNOS_PROXIMOS.AutoSize = true;
            this.rbLISTA_TURNOS_PROXIMOS.Location = new System.Drawing.Point(130, 19);
            this.rbLISTA_TURNOS_PROXIMOS.Name = "rbLISTA_TURNOS_PROXIMOS";
            this.rbLISTA_TURNOS_PROXIMOS.Size = new System.Drawing.Size(82, 17);
            this.rbLISTA_TURNOS_PROXIMOS.TabIndex = 91;
            this.rbLISTA_TURNOS_PROXIMOS.TabStop = true;
            this.rbLISTA_TURNOS_PROXIMOS.Text = "PROXIMOS";
            this.rbLISTA_TURNOS_PROXIMOS.UseVisualStyleBackColor = true;
            this.rbLISTA_TURNOS_PROXIMOS.CheckedChanged += new System.EventHandler(this.rbLISTA_TURNOS_PROXIMOS_CheckedChanged);
            // 
            // btnEXPORTAR
            // 
            this.btnEXPORTAR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnEXPORTAR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.btnEXPORTAR.FlatAppearance.BorderSize = 0;
            this.btnEXPORTAR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEXPORTAR.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEXPORTAR.ForeColor = System.Drawing.Color.White;
            this.btnEXPORTAR.Location = new System.Drawing.Point(6, 390);
            this.btnEXPORTAR.Name = "btnEXPORTAR";
            this.btnEXPORTAR.Size = new System.Drawing.Size(123, 30);
            this.btnEXPORTAR.TabIndex = 89;
            this.btnEXPORTAR.Text = "Exportar en PDF";
            this.btnEXPORTAR.UseVisualStyleBackColor = false;
            // 
            // btnCERRAR
            // 
            this.btnCERRAR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCERRAR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.btnCERRAR.FlatAppearance.BorderSize = 0;
            this.btnCERRAR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCERRAR.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCERRAR.ForeColor = System.Drawing.Color.White;
            this.btnCERRAR.Location = new System.Drawing.Point(817, 390);
            this.btnCERRAR.Name = "btnCERRAR";
            this.btnCERRAR.Size = new System.Drawing.Size(83, 30);
            this.btnCERRAR.TabIndex = 16;
            this.btnCERRAR.Text = "Cerrar";
            this.btnCERRAR.UseVisualStyleBackColor = false;
            this.btnCERRAR.Click += new System.EventHandler(this.btnCERRAR_Click);
            // 
            // dgvLISTA_TURNOS
            // 
            this.dgvLISTA_TURNOS.AllowUserToAddRows = false;
            this.dgvLISTA_TURNOS.AllowUserToDeleteRows = false;
            this.dgvLISTA_TURNOS.AllowUserToResizeColumns = false;
            this.dgvLISTA_TURNOS.AllowUserToResizeRows = false;
            this.dgvLISTA_TURNOS.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvLISTA_TURNOS.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLISTA_TURNOS.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.dgvLISTA_TURNOS.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvLISTA_TURNOS.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvLISTA_TURNOS.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLISTA_TURNOS.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
            this.dgvLISTA_TURNOS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvLISTA_TURNOS.EnableHeadersVisualStyles = false;
            this.dgvLISTA_TURNOS.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.dgvLISTA_TURNOS.Location = new System.Drawing.Point(5, 61);
            this.dgvLISTA_TURNOS.Name = "dgvLISTA_TURNOS";
            this.dgvLISTA_TURNOS.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLISTA_TURNOS.RowHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.dgvLISTA_TURNOS.RowHeadersVisible = false;
            this.dgvLISTA_TURNOS.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.White;
            this.dgvLISTA_TURNOS.RowsDefaultCellStyle = dataGridViewCellStyle15;
            this.dgvLISTA_TURNOS.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLISTA_TURNOS.Size = new System.Drawing.Size(895, 323);
            this.dgvLISTA_TURNOS.TabIndex = 0;
            // 
            // frmLISTA_TURNOS_PACIENTES
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(931, 450);
            this.Controls.Add(this.gbLISTA_TURNOS);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "frmLISTA_TURNOS_PACIENTES";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LISTA DE TURNOS";
            this.gbLISTA_TURNOS.ResumeLayout(false);
            this.gbTURNOS_BUSCADOR.ResumeLayout(false);
            this.gbTURNOS_BUSCADOR.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLISTA_TURNOS)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbLISTA_TURNOS;
        private System.Windows.Forms.Button btnEXPORTAR;
        private System.Windows.Forms.Button btnCERRAR;
        private System.Windows.Forms.DataGridView dgvLISTA_TURNOS;
        private System.Windows.Forms.GroupBox gbTURNOS_BUSCADOR;
        private System.Windows.Forms.RadioButton rbLISTA_TURNOS_PASADO;
        private System.Windows.Forms.RadioButton rbLISTA_TURNOS_PROXIMOS;
    }
}