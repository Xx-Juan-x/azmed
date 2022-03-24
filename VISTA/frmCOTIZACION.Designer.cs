
namespace VISTA
{
    partial class frmCOTIZACION
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
            this.gbDATOS_COTIZACION = new System.Windows.Forms.GroupBox();
            this.btnCERRAR = new System.Windows.Forms.Button();
            this.btnGUARDAR = new System.Windows.Forms.Button();
            this.lblMOTIVO = new System.Windows.Forms.Label();
            this.lblSOLICITUD_PEDIDO = new System.Windows.Forms.Label();
            this.cmbSOLICITUD_PEDIDO = new System.Windows.Forms.ComboBox();
            this.lblNOMBRE_COTIZACION = new System.Windows.Forms.Label();
            this.lblPROVEEDOR = new System.Windows.Forms.Label();
            this.txtNOMBRE = new System.Windows.Forms.TextBox();
            this.cmbPROVEEDOR = new System.Windows.Forms.ComboBox();
            this.txtMOTIVO = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblPRECIO = new System.Windows.Forms.Label();
            this.txtPRECIO = new System.Windows.Forms.TextBox();
            this.gbDATOS_COTIZACION.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbDATOS_COTIZACION
            // 
            this.gbDATOS_COTIZACION.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbDATOS_COTIZACION.Controls.Add(this.txtPRECIO);
            this.gbDATOS_COTIZACION.Controls.Add(this.lblPRECIO);
            this.gbDATOS_COTIZACION.Controls.Add(this.txtMOTIVO);
            this.gbDATOS_COTIZACION.Controls.Add(this.cmbPROVEEDOR);
            this.gbDATOS_COTIZACION.Controls.Add(this.txtNOMBRE);
            this.gbDATOS_COTIZACION.Controls.Add(this.btnCERRAR);
            this.gbDATOS_COTIZACION.Controls.Add(this.btnGUARDAR);
            this.gbDATOS_COTIZACION.Controls.Add(this.lblMOTIVO);
            this.gbDATOS_COTIZACION.Controls.Add(this.lblSOLICITUD_PEDIDO);
            this.gbDATOS_COTIZACION.Controls.Add(this.cmbSOLICITUD_PEDIDO);
            this.gbDATOS_COTIZACION.Controls.Add(this.lblNOMBRE_COTIZACION);
            this.gbDATOS_COTIZACION.Controls.Add(this.lblPROVEEDOR);
            this.gbDATOS_COTIZACION.ForeColor = System.Drawing.Color.White;
            this.gbDATOS_COTIZACION.Location = new System.Drawing.Point(12, 58);
            this.gbDATOS_COTIZACION.Name = "gbDATOS_COTIZACION";
            this.gbDATOS_COTIZACION.Size = new System.Drawing.Size(404, 345);
            this.gbDATOS_COTIZACION.TabIndex = 10;
            this.gbDATOS_COTIZACION.TabStop = false;
            this.gbDATOS_COTIZACION.Text = "DATOS DE LA COTIZACION";
            // 
            // btnCERRAR
            // 
            this.btnCERRAR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.btnCERRAR.FlatAppearance.BorderSize = 0;
            this.btnCERRAR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCERRAR.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCERRAR.ForeColor = System.Drawing.Color.White;
            this.btnCERRAR.Location = new System.Drawing.Point(279, 303);
            this.btnCERRAR.Name = "btnCERRAR";
            this.btnCERRAR.Size = new System.Drawing.Size(119, 36);
            this.btnCERRAR.TabIndex = 90;
            this.btnCERRAR.Text = "Cerrar";
            this.btnCERRAR.UseVisualStyleBackColor = false;
            this.btnCERRAR.Click += new System.EventHandler(this.btnCERRAR_Click);
            // 
            // btnGUARDAR
            // 
            this.btnGUARDAR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.btnGUARDAR.FlatAppearance.BorderSize = 0;
            this.btnGUARDAR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGUARDAR.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGUARDAR.ForeColor = System.Drawing.Color.White;
            this.btnGUARDAR.Location = new System.Drawing.Point(6, 303);
            this.btnGUARDAR.Name = "btnGUARDAR";
            this.btnGUARDAR.Size = new System.Drawing.Size(119, 36);
            this.btnGUARDAR.TabIndex = 86;
            this.btnGUARDAR.Text = "Cotizar";
            this.btnGUARDAR.UseVisualStyleBackColor = false;
            this.btnGUARDAR.Click += new System.EventHandler(this.btnGUARDAR_Click);
            // 
            // lblMOTIVO
            // 
            this.lblMOTIVO.AutoSize = true;
            this.lblMOTIVO.Location = new System.Drawing.Point(13, 193);
            this.lblMOTIVO.Name = "lblMOTIVO";
            this.lblMOTIVO.Size = new System.Drawing.Size(52, 13);
            this.lblMOTIVO.TabIndex = 88;
            this.lblMOTIVO.Text = "MOTIVO:";
            // 
            // lblSOLICITUD_PEDIDO
            // 
            this.lblSOLICITUD_PEDIDO.AutoSize = true;
            this.lblSOLICITUD_PEDIDO.Location = new System.Drawing.Point(13, 116);
            this.lblSOLICITUD_PEDIDO.Name = "lblSOLICITUD_PEDIDO";
            this.lblSOLICITUD_PEDIDO.Size = new System.Drawing.Size(129, 13);
            this.lblSOLICITUD_PEDIDO.TabIndex = 84;
            this.lblSOLICITUD_PEDIDO.Text = "SOLICITUD DE PEDIDO:";
            // 
            // cmbSOLICITUD_PEDIDO
            // 
            this.cmbSOLICITUD_PEDIDO.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSOLICITUD_PEDIDO.FormattingEnabled = true;
            this.cmbSOLICITUD_PEDIDO.Location = new System.Drawing.Point(170, 108);
            this.cmbSOLICITUD_PEDIDO.Name = "cmbSOLICITUD_PEDIDO";
            this.cmbSOLICITUD_PEDIDO.Size = new System.Drawing.Size(224, 21);
            this.cmbSOLICITUD_PEDIDO.TabIndex = 83;
            // 
            // lblNOMBRE_COTIZACION
            // 
            this.lblNOMBRE_COTIZACION.AutoSize = true;
            this.lblNOMBRE_COTIZACION.Location = new System.Drawing.Point(13, 22);
            this.lblNOMBRE_COTIZACION.Name = "lblNOMBRE_COTIZACION";
            this.lblNOMBRE_COTIZACION.Size = new System.Drawing.Size(57, 13);
            this.lblNOMBRE_COTIZACION.TabIndex = 79;
            this.lblNOMBRE_COTIZACION.Text = "NOMBRE:";
            // 
            // lblPROVEEDOR
            // 
            this.lblPROVEEDOR.AutoSize = true;
            this.lblPROVEEDOR.Location = new System.Drawing.Point(13, 67);
            this.lblPROVEEDOR.Name = "lblPROVEEDOR";
            this.lblPROVEEDOR.Size = new System.Drawing.Size(78, 13);
            this.lblPROVEEDOR.TabIndex = 80;
            this.lblPROVEEDOR.Text = "PROVEEDOR:";
            // 
            // txtNOMBRE
            // 
            this.txtNOMBRE.Location = new System.Drawing.Point(170, 22);
            this.txtNOMBRE.Name = "txtNOMBRE";
            this.txtNOMBRE.Size = new System.Drawing.Size(224, 20);
            this.txtNOMBRE.TabIndex = 91;
            // 
            // cmbPROVEEDOR
            // 
            this.cmbPROVEEDOR.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPROVEEDOR.FormattingEnabled = true;
            this.cmbPROVEEDOR.Location = new System.Drawing.Point(170, 64);
            this.cmbPROVEEDOR.Name = "cmbPROVEEDOR";
            this.cmbPROVEEDOR.Size = new System.Drawing.Size(224, 21);
            this.cmbPROVEEDOR.TabIndex = 92;
            // 
            // txtMOTIVO
            // 
            this.txtMOTIVO.Location = new System.Drawing.Point(85, 190);
            this.txtMOTIVO.Multiline = true;
            this.txtMOTIVO.Name = "txtMOTIVO";
            this.txtMOTIVO.Size = new System.Drawing.Size(309, 98);
            this.txtMOTIVO.TabIndex = 93;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(428, 55);
            this.label3.TabIndex = 930;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(110, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(204, 31);
            this.label4.TabIndex = 931;
            this.label4.Text = "Cotizar Material";
            // 
            // lblPRECIO
            // 
            this.lblPRECIO.AutoSize = true;
            this.lblPRECIO.Location = new System.Drawing.Point(13, 155);
            this.lblPRECIO.Name = "lblPRECIO";
            this.lblPRECIO.Size = new System.Drawing.Size(50, 13);
            this.lblPRECIO.TabIndex = 94;
            this.lblPRECIO.Text = "PRECIO:";
            // 
            // txtPRECIO
            // 
            this.txtPRECIO.Location = new System.Drawing.Point(170, 152);
            this.txtPRECIO.Name = "txtPRECIO";
            this.txtPRECIO.Size = new System.Drawing.Size(224, 20);
            this.txtPRECIO.TabIndex = 95;
            // 
            // frmCOTIZACION
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(428, 415);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.gbDATOS_COTIZACION);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCOTIZACION";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "COTIZACIONES";
            this.gbDATOS_COTIZACION.ResumeLayout(false);
            this.gbDATOS_COTIZACION.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbDATOS_COTIZACION;
        private System.Windows.Forms.TextBox txtMOTIVO;
        private System.Windows.Forms.ComboBox cmbPROVEEDOR;
        private System.Windows.Forms.TextBox txtNOMBRE;
        private System.Windows.Forms.Button btnCERRAR;
        private System.Windows.Forms.Button btnGUARDAR;
        private System.Windows.Forms.Label lblMOTIVO;
        private System.Windows.Forms.Label lblSOLICITUD_PEDIDO;
        private System.Windows.Forms.ComboBox cmbSOLICITUD_PEDIDO;
        private System.Windows.Forms.Label lblNOMBRE_COTIZACION;
        private System.Windows.Forms.Label lblPROVEEDOR;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPRECIO;
        private System.Windows.Forms.Label lblPRECIO;
    }
}