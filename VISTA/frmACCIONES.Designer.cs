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
            this.label1 = new System.Windows.Forms.Label();
            this.cmb_GRUPOS = new System.Windows.Forms.ComboBox();
            this.cmb_ACCIONES = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_asignarAccion = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // treeViewGrupo
            // 
            this.treeViewGrupo.Location = new System.Drawing.Point(12, 76);
            this.treeViewGrupo.Name = "treeViewGrupo";
            this.treeViewGrupo.Size = new System.Drawing.Size(767, 362);
            this.treeViewGrupo.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "GRUPOS";
            // 
            // cmb_GRUPOS
            // 
            this.cmb_GRUPOS.FormattingEnabled = true;
            this.cmb_GRUPOS.Location = new System.Drawing.Point(25, 32);
            this.cmb_GRUPOS.Name = "cmb_GRUPOS";
            this.cmb_GRUPOS.Size = new System.Drawing.Size(121, 21);
            this.cmb_GRUPOS.TabIndex = 3;
            // 
            // cmb_ACCIONES
            // 
            this.cmb_ACCIONES.FormattingEnabled = true;
            this.cmb_ACCIONES.Location = new System.Drawing.Point(196, 32);
            this.cmb_ACCIONES.Name = "cmb_ACCIONES";
            this.cmb_ACCIONES.Size = new System.Drawing.Size(121, 21);
            this.cmb_ACCIONES.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(193, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "ACCIONES";
            // 
            // btn_asignarAccion
            // 
            this.btn_asignarAccion.Location = new System.Drawing.Point(358, 30);
            this.btn_asignarAccion.Name = "btn_asignarAccion";
            this.btn_asignarAccion.Size = new System.Drawing.Size(129, 23);
            this.btn_asignarAccion.TabIndex = 6;
            this.btn_asignarAccion.Text = "ASIGNAR ACCION";
            this.btn_asignarAccion.UseVisualStyleBackColor = true;
            this.btn_asignarAccion.Click += new System.EventHandler(this.btn_asignarAccion_Click);
            // 
            // frmACCIONES
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_asignarAccion);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmb_ACCIONES);
            this.Controls.Add(this.cmb_GRUPOS);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.treeViewGrupo);
            this.Name = "frmACCIONES";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView treeViewGrupo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmb_GRUPOS;
        private System.Windows.Forms.ComboBox cmb_ACCIONES;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_asignarAccion;
    }
}