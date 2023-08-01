
namespace VISTA
{
    partial class frmLISTA_ORDEN_COMPRA
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
            this.gbLISTA_ORDEN_COMPRA = new System.Windows.Forms.GroupBox();
            this.btnCERRAR = new System.Windows.Forms.Button();
            this.dgvLISTA_ORDENES_COMPRA = new System.Windows.Forms.DataGridView();
            this.cmbOrden = new System.Windows.Forms.ComboBox();
            this.gbLISTA_ORDEN_COMPRA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLISTA_ORDENES_COMPRA)).BeginInit();
            this.SuspendLayout();
            // 
            // gbLISTA_ORDEN_COMPRA
            // 
            this.gbLISTA_ORDEN_COMPRA.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbLISTA_ORDEN_COMPRA.Controls.Add(this.cmbOrden);
            this.gbLISTA_ORDEN_COMPRA.Controls.Add(this.btnCERRAR);
            this.gbLISTA_ORDEN_COMPRA.Controls.Add(this.dgvLISTA_ORDENES_COMPRA);
            this.gbLISTA_ORDEN_COMPRA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbLISTA_ORDEN_COMPRA.ForeColor = System.Drawing.Color.White;
            this.gbLISTA_ORDEN_COMPRA.Location = new System.Drawing.Point(12, 12);
            this.gbLISTA_ORDEN_COMPRA.Name = "gbLISTA_ORDEN_COMPRA";
            this.gbLISTA_ORDEN_COMPRA.Size = new System.Drawing.Size(953, 321);
            this.gbLISTA_ORDEN_COMPRA.TabIndex = 6;
            this.gbLISTA_ORDEN_COMPRA.TabStop = false;
            this.gbLISTA_ORDEN_COMPRA.Text = "LISTA DE ORDENES DE COMPRAS";
            // 
            // btnCERRAR
            // 
            this.btnCERRAR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCERRAR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.btnCERRAR.FlatAppearance.BorderSize = 0;
            this.btnCERRAR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCERRAR.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCERRAR.ForeColor = System.Drawing.Color.White;
            this.btnCERRAR.Location = new System.Drawing.Point(863, 285);
            this.btnCERRAR.Name = "btnCERRAR";
            this.btnCERRAR.Size = new System.Drawing.Size(83, 30);
            this.btnCERRAR.TabIndex = 16;
            this.btnCERRAR.Text = "Cerrar";
            this.btnCERRAR.UseVisualStyleBackColor = false;
            this.btnCERRAR.Click += new System.EventHandler(this.btnCERRAR_Click);
            // 
            // dgvLISTA_ORDENES_COMPRA
            // 
            this.dgvLISTA_ORDENES_COMPRA.AllowUserToAddRows = false;
            this.dgvLISTA_ORDENES_COMPRA.AllowUserToDeleteRows = false;
            this.dgvLISTA_ORDENES_COMPRA.AllowUserToResizeColumns = false;
            this.dgvLISTA_ORDENES_COMPRA.AllowUserToResizeRows = false;
            this.dgvLISTA_ORDENES_COMPRA.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvLISTA_ORDENES_COMPRA.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLISTA_ORDENES_COMPRA.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.dgvLISTA_ORDENES_COMPRA.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvLISTA_ORDENES_COMPRA.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvLISTA_ORDENES_COMPRA.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLISTA_ORDENES_COMPRA.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvLISTA_ORDENES_COMPRA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvLISTA_ORDENES_COMPRA.EnableHeadersVisualStyles = false;
            this.dgvLISTA_ORDENES_COMPRA.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.dgvLISTA_ORDENES_COMPRA.Location = new System.Drawing.Point(5, 54);
            this.dgvLISTA_ORDENES_COMPRA.Name = "dgvLISTA_ORDENES_COMPRA";
            this.dgvLISTA_ORDENES_COMPRA.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLISTA_ORDENES_COMPRA.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvLISTA_ORDENES_COMPRA.RowHeadersVisible = false;
            this.dgvLISTA_ORDENES_COMPRA.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            this.dgvLISTA_ORDENES_COMPRA.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvLISTA_ORDENES_COMPRA.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLISTA_ORDENES_COMPRA.Size = new System.Drawing.Size(941, 225);
            this.dgvLISTA_ORDENES_COMPRA.TabIndex = 0;
            // 
            // cmbOrden
            // 
            this.cmbOrden.FormattingEnabled = true;
            this.cmbOrden.Location = new System.Drawing.Point(655, 19);
            this.cmbOrden.Name = "cmbOrden";
            this.cmbOrden.Size = new System.Drawing.Size(279, 21);
            this.cmbOrden.TabIndex = 17;
            this.cmbOrden.SelectedIndexChanged += new System.EventHandler(this.cmbOrden_SelectedIndexChanged);
            // 
            // frmLISTA_ORDEN_COMPRA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(977, 345);
            this.Controls.Add(this.gbLISTA_ORDEN_COMPRA);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "frmLISTA_ORDEN_COMPRA";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ORDENES DE COMPRAS";
            this.gbLISTA_ORDEN_COMPRA.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLISTA_ORDENES_COMPRA)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbLISTA_ORDEN_COMPRA;
        private System.Windows.Forms.Button btnCERRAR;
        private System.Windows.Forms.DataGridView dgvLISTA_ORDENES_COMPRA;
        private System.Windows.Forms.ComboBox cmbOrden;
    }
}