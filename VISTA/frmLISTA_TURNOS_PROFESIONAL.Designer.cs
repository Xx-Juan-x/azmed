﻿
namespace VISTA
{
    partial class frmLISTA_TURNOS_PROFESIONAL
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
            this.gbLISTA_TURNOS = new System.Windows.Forms.GroupBox();
            this.btnAGREGAR = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnMODIFICAR = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbFILTRO_PROFESIONAL = new System.Windows.Forms.ComboBox();
            this.btnBUSCAR = new System.Windows.Forms.Button();
            this.lblFILTRO_DIA_LABORAL = new System.Windows.Forms.Label();
            this.cmbFILTRO_DIA_LABORAL = new System.Windows.Forms.ComboBox();
            this.btnCERRAR = new System.Windows.Forms.Button();
            this.dgvLISTA_TURNOS = new System.Windows.Forms.DataGridView();
            this.gbLISTA_TURNOS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLISTA_TURNOS)).BeginInit();
            this.SuspendLayout();
            // 
            // gbLISTA_TURNOS
            // 
            this.gbLISTA_TURNOS.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbLISTA_TURNOS.Controls.Add(this.btnAGREGAR);
            this.gbLISTA_TURNOS.Controls.Add(this.btnEliminar);
            this.gbLISTA_TURNOS.Controls.Add(this.btnMODIFICAR);
            this.gbLISTA_TURNOS.Controls.Add(this.label1);
            this.gbLISTA_TURNOS.Controls.Add(this.cmbFILTRO_PROFESIONAL);
            this.gbLISTA_TURNOS.Controls.Add(this.btnBUSCAR);
            this.gbLISTA_TURNOS.Controls.Add(this.lblFILTRO_DIA_LABORAL);
            this.gbLISTA_TURNOS.Controls.Add(this.cmbFILTRO_DIA_LABORAL);
            this.gbLISTA_TURNOS.Controls.Add(this.btnCERRAR);
            this.gbLISTA_TURNOS.Controls.Add(this.dgvLISTA_TURNOS);
            this.gbLISTA_TURNOS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbLISTA_TURNOS.ForeColor = System.Drawing.Color.White;
            this.gbLISTA_TURNOS.Location = new System.Drawing.Point(12, 12);
            this.gbLISTA_TURNOS.Name = "gbLISTA_TURNOS";
            this.gbLISTA_TURNOS.Size = new System.Drawing.Size(820, 378);
            this.gbLISTA_TURNOS.TabIndex = 6;
            this.gbLISTA_TURNOS.TabStop = false;
            this.gbLISTA_TURNOS.Text = "LISTA DE TURNOS DEL PROFESIONAL";
            // 
            // btnAGREGAR
            // 
            this.btnAGREGAR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAGREGAR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.btnAGREGAR.FlatAppearance.BorderSize = 0;
            this.btnAGREGAR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAGREGAR.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAGREGAR.ForeColor = System.Drawing.Color.White;
            this.btnAGREGAR.Location = new System.Drawing.Point(6, 342);
            this.btnAGREGAR.Name = "btnAGREGAR";
            this.btnAGREGAR.Size = new System.Drawing.Size(83, 30);
            this.btnAGREGAR.TabIndex = 93;
            this.btnAGREGAR.Text = "Agregar";
            this.btnAGREGAR.UseVisualStyleBackColor = false;
            this.btnAGREGAR.Click += new System.EventHandler(this.btnAGREGAR_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.btnEliminar.FlatAppearance.BorderSize = 0;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.Color.White;
            this.btnEliminar.Location = new System.Drawing.Point(184, 342);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(83, 30);
            this.btnEliminar.TabIndex = 92;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnMODIFICAR
            // 
            this.btnMODIFICAR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnMODIFICAR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.btnMODIFICAR.FlatAppearance.BorderSize = 0;
            this.btnMODIFICAR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMODIFICAR.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMODIFICAR.ForeColor = System.Drawing.Color.White;
            this.btnMODIFICAR.Location = new System.Drawing.Point(95, 342);
            this.btnMODIFICAR.Name = "btnMODIFICAR";
            this.btnMODIFICAR.Size = new System.Drawing.Size(83, 30);
            this.btnMODIFICAR.TabIndex = 91;
            this.btnMODIFICAR.Text = "Modificar";
            this.btnMODIFICAR.UseVisualStyleBackColor = false;
            this.btnMODIFICAR.Click += new System.EventHandler(this.btnMODIFICAR_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 90;
            this.label1.Text = "PROFESIONAL";
            // 
            // cmbFILTRO_PROFESIONAL
            // 
            this.cmbFILTRO_PROFESIONAL.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbFILTRO_PROFESIONAL.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFILTRO_PROFESIONAL.FormattingEnabled = true;
            this.cmbFILTRO_PROFESIONAL.Location = new System.Drawing.Point(103, 28);
            this.cmbFILTRO_PROFESIONAL.Name = "cmbFILTRO_PROFESIONAL";
            this.cmbFILTRO_PROFESIONAL.Size = new System.Drawing.Size(159, 21);
            this.cmbFILTRO_PROFESIONAL.TabIndex = 89;
            // 
            // btnBUSCAR
            // 
            this.btnBUSCAR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBUSCAR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.btnBUSCAR.FlatAppearance.BorderSize = 0;
            this.btnBUSCAR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBUSCAR.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBUSCAR.ForeColor = System.Drawing.Color.White;
            this.btnBUSCAR.Location = new System.Drawing.Point(714, 19);
            this.btnBUSCAR.Name = "btnBUSCAR";
            this.btnBUSCAR.Size = new System.Drawing.Size(100, 36);
            this.btnBUSCAR.TabIndex = 86;
            this.btnBUSCAR.Text = "Buscar";
            this.btnBUSCAR.UseVisualStyleBackColor = false;
            this.btnBUSCAR.Click += new System.EventHandler(this.btnBUSCAR_Click);
            // 
            // lblFILTRO_DIA_LABORAL
            // 
            this.lblFILTRO_DIA_LABORAL.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFILTRO_DIA_LABORAL.AutoSize = true;
            this.lblFILTRO_DIA_LABORAL.Location = new System.Drawing.Point(463, 31);
            this.lblFILTRO_DIA_LABORAL.Name = "lblFILTRO_DIA_LABORAL";
            this.lblFILTRO_DIA_LABORAL.Size = new System.Drawing.Size(80, 13);
            this.lblFILTRO_DIA_LABORAL.TabIndex = 87;
            this.lblFILTRO_DIA_LABORAL.Text = "DIA LABORAL:";
            // 
            // cmbFILTRO_DIA_LABORAL
            // 
            this.cmbFILTRO_DIA_LABORAL.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbFILTRO_DIA_LABORAL.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFILTRO_DIA_LABORAL.FormattingEnabled = true;
            this.cmbFILTRO_DIA_LABORAL.Location = new System.Drawing.Point(549, 28);
            this.cmbFILTRO_DIA_LABORAL.Name = "cmbFILTRO_DIA_LABORAL";
            this.cmbFILTRO_DIA_LABORAL.Size = new System.Drawing.Size(159, 21);
            this.cmbFILTRO_DIA_LABORAL.TabIndex = 88;
            // 
            // btnCERRAR
            // 
            this.btnCERRAR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCERRAR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.btnCERRAR.FlatAppearance.BorderSize = 0;
            this.btnCERRAR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCERRAR.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCERRAR.ForeColor = System.Drawing.Color.White;
            this.btnCERRAR.Location = new System.Drawing.Point(730, 342);
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLISTA_TURNOS.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvLISTA_TURNOS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvLISTA_TURNOS.EnableHeadersVisualStyles = false;
            this.dgvLISTA_TURNOS.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.dgvLISTA_TURNOS.Location = new System.Drawing.Point(5, 61);
            this.dgvLISTA_TURNOS.Name = "dgvLISTA_TURNOS";
            this.dgvLISTA_TURNOS.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLISTA_TURNOS.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvLISTA_TURNOS.RowHeadersVisible = false;
            this.dgvLISTA_TURNOS.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            this.dgvLISTA_TURNOS.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvLISTA_TURNOS.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLISTA_TURNOS.Size = new System.Drawing.Size(808, 275);
            this.dgvLISTA_TURNOS.TabIndex = 0;
            // 
            // frmLISTA_TURNOS_PROFESIONAL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(844, 402);
            this.Controls.Add(this.gbLISTA_TURNOS);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "frmLISTA_TURNOS_PROFESIONAL";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LISTA DE TURNOS";
            this.gbLISTA_TURNOS.ResumeLayout(false);
            this.gbLISTA_TURNOS.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLISTA_TURNOS)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbLISTA_TURNOS;
        private System.Windows.Forms.Button btnCERRAR;
        private System.Windows.Forms.DataGridView dgvLISTA_TURNOS;
        private System.Windows.Forms.Button btnBUSCAR;
        private System.Windows.Forms.Label lblFILTRO_DIA_LABORAL;
        private System.Windows.Forms.ComboBox cmbFILTRO_DIA_LABORAL;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbFILTRO_PROFESIONAL;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnMODIFICAR;
        private System.Windows.Forms.Button btnAGREGAR;
    }
}