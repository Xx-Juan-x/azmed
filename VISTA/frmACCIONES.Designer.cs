namespace VISTA
{
    partial class frmACCIONES
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
            this.treeViewGrupo = new System.Windows.Forms.TreeView();
            this.lblGRUPOS = new System.Windows.Forms.Label();
            this.lblACCIONES = new System.Windows.Forms.Label();
            this.btnCERRAR = new System.Windows.Forms.Button();
            this.cmbGRUPOS = new System.Windows.Forms.ComboBox();
            this.cmb_ACCIONES = new System.Windows.Forms.ComboBox();
            this.btnASIGNAR_ACCION = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_ACCION = new System.Windows.Forms.TextBox();
            this.btn_DESASIGNAR = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // treeViewGrupo
            // 
            this.treeViewGrupo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.treeViewGrupo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.treeViewGrupo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.treeViewGrupo.ForeColor = System.Drawing.Color.White;
            this.treeViewGrupo.Location = new System.Drawing.Point(3, 76);
            this.treeViewGrupo.Name = "treeViewGrupo";
            this.treeViewGrupo.Size = new System.Drawing.Size(933, 354);
            this.treeViewGrupo.TabIndex = 0;
            this.treeViewGrupo.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeViewGrupo_NodeMouseClick);
            // 
            // lblGRUPOS
            // 
            this.lblGRUPOS.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lblGRUPOS.AutoSize = true;
            this.lblGRUPOS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.lblGRUPOS.ForeColor = System.Drawing.Color.White;
            this.lblGRUPOS.Location = new System.Drawing.Point(7, 9);
            this.lblGRUPOS.Name = "lblGRUPOS";
            this.lblGRUPOS.Size = new System.Drawing.Size(53, 13);
            this.lblGRUPOS.TabIndex = 2;
            this.lblGRUPOS.Text = "GRUPOS";
            // 
            // lblACCIONES
            // 
            this.lblACCIONES.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lblACCIONES.AutoSize = true;
            this.lblACCIONES.ForeColor = System.Drawing.Color.White;
            this.lblACCIONES.Location = new System.Drawing.Point(178, 9);
            this.lblACCIONES.Name = "lblACCIONES";
            this.lblACCIONES.Size = new System.Drawing.Size(61, 13);
            this.lblACCIONES.TabIndex = 5;
            this.lblACCIONES.Text = "ACCIONES";
            // 
            // btnCERRAR
            // 
            this.btnCERRAR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCERRAR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.btnCERRAR.FlatAppearance.BorderSize = 0;
            this.btnCERRAR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCERRAR.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCERRAR.ForeColor = System.Drawing.Color.White;
            this.btnCERRAR.Location = new System.Drawing.Point(799, 21);
            this.btnCERRAR.Name = "btnCERRAR";
            this.btnCERRAR.Size = new System.Drawing.Size(129, 40);
            this.btnCERRAR.TabIndex = 17;
            this.btnCERRAR.Text = "Cerrar";
            this.btnCERRAR.UseVisualStyleBackColor = false;
            this.btnCERRAR.Click += new System.EventHandler(this.btnCERRAR_Click);
            // 
            // cmbGRUPOS
            // 
            this.cmbGRUPOS.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGRUPOS.FormattingEnabled = true;
            this.cmbGRUPOS.Location = new System.Drawing.Point(10, 32);
            this.cmbGRUPOS.Name = "cmbGRUPOS";
            this.cmbGRUPOS.Size = new System.Drawing.Size(148, 21);
            this.cmbGRUPOS.TabIndex = 82;
            // 
            // cmb_ACCIONES
            // 
            this.cmb_ACCIONES.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_ACCIONES.FormattingEnabled = true;
            this.cmb_ACCIONES.Location = new System.Drawing.Point(181, 32);
            this.cmb_ACCIONES.Name = "cmb_ACCIONES";
            this.cmb_ACCIONES.Size = new System.Drawing.Size(163, 21);
            this.cmb_ACCIONES.TabIndex = 83;
            // 
            // btnASIGNAR_ACCION
            // 
            this.btnASIGNAR_ACCION.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.btnASIGNAR_ACCION.FlatAppearance.BorderSize = 0;
            this.btnASIGNAR_ACCION.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnASIGNAR_ACCION.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnASIGNAR_ACCION.ForeColor = System.Drawing.Color.White;
            this.btnASIGNAR_ACCION.Location = new System.Drawing.Point(350, 21);
            this.btnASIGNAR_ACCION.Name = "btnASIGNAR_ACCION";
            this.btnASIGNAR_ACCION.Size = new System.Drawing.Size(129, 40);
            this.btnASIGNAR_ACCION.TabIndex = 84;
            this.btnASIGNAR_ACCION.Text = "Asignar";
            this.btnASIGNAR_ACCION.UseVisualStyleBackColor = false;
            this.btnASIGNAR_ACCION.Click += new System.EventHandler(this.btnASIGNAR_ACCION_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(491, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 85;
            this.label1.Text = "ACCION";
            // 
            // txt_ACCION
            // 
            this.txt_ACCION.Enabled = false;
            this.txt_ACCION.Location = new System.Drawing.Point(494, 32);
            this.txt_ACCION.Name = "txt_ACCION";
            this.txt_ACCION.Size = new System.Drawing.Size(127, 20);
            this.txt_ACCION.TabIndex = 86;
            // 
            // btn_DESASIGNAR
            // 
            this.btn_DESASIGNAR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.btn_DESASIGNAR.Enabled = false;
            this.btn_DESASIGNAR.FlatAppearance.BorderSize = 0;
            this.btn_DESASIGNAR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_DESASIGNAR.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_DESASIGNAR.ForeColor = System.Drawing.Color.White;
            this.btn_DESASIGNAR.Location = new System.Drawing.Point(627, 21);
            this.btn_DESASIGNAR.Name = "btn_DESASIGNAR";
            this.btn_DESASIGNAR.Size = new System.Drawing.Size(129, 40);
            this.btn_DESASIGNAR.TabIndex = 87;
            this.btn_DESASIGNAR.Text = "Desasignar";
            this.btn_DESASIGNAR.UseVisualStyleBackColor = false;
            this.btn_DESASIGNAR.Click += new System.EventHandler(this.btn_DESASIGNAR_Click);
            // 
            // frmACCIONES
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(940, 432);
            this.Controls.Add(this.btn_DESASIGNAR);
            this.Controls.Add(this.txt_ACCION);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnASIGNAR_ACCION);
            this.Controls.Add(this.cmb_ACCIONES);
            this.Controls.Add(this.cmbGRUPOS);
            this.Controls.Add(this.btnCERRAR);
            this.Controls.Add(this.lblACCIONES);
            this.Controls.Add(this.lblGRUPOS);
            this.Controls.Add(this.treeViewGrupo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "frmACCIONES";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GESTIONAR ACCIONES";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView treeViewGrupo;
        private System.Windows.Forms.Label lblGRUPOS;
        private System.Windows.Forms.Label lblACCIONES;
        private System.Windows.Forms.Button btnCERRAR;
        private System.Windows.Forms.ComboBox cmbGRUPOS;
        private System.Windows.Forms.ComboBox cmb_ACCIONES;
        private System.Windows.Forms.Button btnASIGNAR_ACCION;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_ACCION;
        private System.Windows.Forms.Button btn_DESASIGNAR;
    }
}