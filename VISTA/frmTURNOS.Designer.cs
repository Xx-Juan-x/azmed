
namespace VISTA
{
    partial class frmTURNOS
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
            this.gbDATOS_TURNOS = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbPACIENTE = new System.Windows.Forms.ComboBox();
            this.btnCERRAR = new System.Windows.Forms.Button();
            this.btnGUARDAR = new System.Windows.Forms.Button();
            this.lblTIPO_TURNO = new System.Windows.Forms.Label();
            this.lblPROFESIONAL = new System.Windows.Forms.Label();
            this.cmbPROFESIONAL = new System.Windows.Forms.ComboBox();
            this.rbESTUDIO = new System.Windows.Forms.RadioButton();
            this.rbCONSULTA = new System.Windows.Forms.RadioButton();
            this.lblHORAS = new System.Windows.Forms.Label();
            this.cmbHORAS = new System.Windows.Forms.ComboBox();
            this.cmbDIA = new System.Windows.Forms.ComboBox();
            this.cmbESPECIALIDAD = new System.Windows.Forms.ComboBox();
            this.lblESPECIALIDAD = new System.Windows.Forms.Label();
            this.lblDIA = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.gbDATOS_TURNOS.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbDATOS_TURNOS
            // 
            this.gbDATOS_TURNOS.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbDATOS_TURNOS.Controls.Add(this.label1);
            this.gbDATOS_TURNOS.Controls.Add(this.cmbPACIENTE);
            this.gbDATOS_TURNOS.Controls.Add(this.btnCERRAR);
            this.gbDATOS_TURNOS.Controls.Add(this.btnGUARDAR);
            this.gbDATOS_TURNOS.Controls.Add(this.lblTIPO_TURNO);
            this.gbDATOS_TURNOS.Controls.Add(this.lblPROFESIONAL);
            this.gbDATOS_TURNOS.Controls.Add(this.cmbPROFESIONAL);
            this.gbDATOS_TURNOS.Controls.Add(this.rbESTUDIO);
            this.gbDATOS_TURNOS.Controls.Add(this.rbCONSULTA);
            this.gbDATOS_TURNOS.Controls.Add(this.lblHORAS);
            this.gbDATOS_TURNOS.Controls.Add(this.cmbHORAS);
            this.gbDATOS_TURNOS.Controls.Add(this.cmbDIA);
            this.gbDATOS_TURNOS.Controls.Add(this.cmbESPECIALIDAD);
            this.gbDATOS_TURNOS.Controls.Add(this.lblESPECIALIDAD);
            this.gbDATOS_TURNOS.Controls.Add(this.lblDIA);
            this.gbDATOS_TURNOS.ForeColor = System.Drawing.Color.White;
            this.gbDATOS_TURNOS.Location = new System.Drawing.Point(12, 58);
            this.gbDATOS_TURNOS.Name = "gbDATOS_TURNOS";
            this.gbDATOS_TURNOS.Size = new System.Drawing.Size(406, 384);
            this.gbDATOS_TURNOS.TabIndex = 8;
            this.gbDATOS_TURNOS.TabStop = false;
            this.gbDATOS_TURNOS.Text = "DATOS DEL TURNO";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 190);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 95;
            this.label1.Text = "PACIENTE:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // cmbPACIENTE
            // 
            this.cmbPACIENTE.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPACIENTE.FormattingEnabled = true;
            this.cmbPACIENTE.Location = new System.Drawing.Point(170, 182);
            this.cmbPACIENTE.Name = "cmbPACIENTE";
            this.cmbPACIENTE.Size = new System.Drawing.Size(224, 21);
            this.cmbPACIENTE.TabIndex = 94;
            this.cmbPACIENTE.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // btnCERRAR
            // 
            this.btnCERRAR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.btnCERRAR.FlatAppearance.BorderSize = 0;
            this.btnCERRAR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCERRAR.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCERRAR.ForeColor = System.Drawing.Color.White;
            this.btnCERRAR.Location = new System.Drawing.Point(275, 329);
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
            this.btnGUARDAR.Location = new System.Drawing.Point(6, 329);
            this.btnGUARDAR.Name = "btnGUARDAR";
            this.btnGUARDAR.Size = new System.Drawing.Size(119, 36);
            this.btnGUARDAR.TabIndex = 86;
            this.btnGUARDAR.Text = "Guardar";
            this.btnGUARDAR.UseVisualStyleBackColor = false;
            this.btnGUARDAR.Click += new System.EventHandler(this.btnGUARDAR_Click);
            // 
            // lblTIPO_TURNO
            // 
            this.lblTIPO_TURNO.AutoSize = true;
            this.lblTIPO_TURNO.Location = new System.Drawing.Point(13, 232);
            this.lblTIPO_TURNO.Name = "lblTIPO_TURNO";
            this.lblTIPO_TURNO.Size = new System.Drawing.Size(95, 13);
            this.lblTIPO_TURNO.TabIndex = 89;
            this.lblTIPO_TURNO.Text = "TIPO DE TURNO:";
            // 
            // lblPROFESIONAL
            // 
            this.lblPROFESIONAL.AutoSize = true;
            this.lblPROFESIONAL.Location = new System.Drawing.Point(13, 147);
            this.lblPROFESIONAL.Name = "lblPROFESIONAL";
            this.lblPROFESIONAL.Size = new System.Drawing.Size(85, 13);
            this.lblPROFESIONAL.TabIndex = 88;
            this.lblPROFESIONAL.Text = "PROFESIONAL:";
            // 
            // cmbPROFESIONAL
            // 
            this.cmbPROFESIONAL.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPROFESIONAL.FormattingEnabled = true;
            this.cmbPROFESIONAL.Location = new System.Drawing.Point(170, 139);
            this.cmbPROFESIONAL.Name = "cmbPROFESIONAL";
            this.cmbPROFESIONAL.Size = new System.Drawing.Size(224, 21);
            this.cmbPROFESIONAL.TabIndex = 87;
            // 
            // rbESTUDIO
            // 
            this.rbESTUDIO.AutoSize = true;
            this.rbESTUDIO.Location = new System.Drawing.Point(321, 230);
            this.rbESTUDIO.Name = "rbESTUDIO";
            this.rbESTUDIO.Size = new System.Drawing.Size(73, 17);
            this.rbESTUDIO.TabIndex = 86;
            this.rbESTUDIO.Text = "ESTUDIO";
            this.rbESTUDIO.UseVisualStyleBackColor = true;
            this.rbESTUDIO.CheckedChanged += new System.EventHandler(this.rbESTUDIO_CheckedChanged);
            // 
            // rbCONSULTA
            // 
            this.rbCONSULTA.AutoSize = true;
            this.rbCONSULTA.Checked = true;
            this.rbCONSULTA.Location = new System.Drawing.Point(170, 230);
            this.rbCONSULTA.Name = "rbCONSULTA";
            this.rbCONSULTA.Size = new System.Drawing.Size(83, 17);
            this.rbCONSULTA.TabIndex = 85;
            this.rbCONSULTA.TabStop = true;
            this.rbCONSULTA.Text = "CONSULTA";
            this.rbCONSULTA.UseVisualStyleBackColor = true;
            this.rbCONSULTA.CheckedChanged += new System.EventHandler(this.rbCONSULTA_CheckedChanged);
            // 
            // lblHORAS
            // 
            this.lblHORAS.AutoSize = true;
            this.lblHORAS.Location = new System.Drawing.Point(13, 107);
            this.lblHORAS.Name = "lblHORAS";
            this.lblHORAS.Size = new System.Drawing.Size(48, 13);
            this.lblHORAS.TabIndex = 84;
            this.lblHORAS.Text = "HORAS:";
            // 
            // cmbHORAS
            // 
            this.cmbHORAS.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbHORAS.FormattingEnabled = true;
            this.cmbHORAS.Location = new System.Drawing.Point(170, 99);
            this.cmbHORAS.Name = "cmbHORAS";
            this.cmbHORAS.Size = new System.Drawing.Size(224, 21);
            this.cmbHORAS.TabIndex = 83;
            this.cmbHORAS.SelectedIndexChanged += new System.EventHandler(this.cmbHORAS_SelectedIndexChanged);
            // 
            // cmbDIA
            // 
            this.cmbDIA.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDIA.FormattingEnabled = true;
            this.cmbDIA.Location = new System.Drawing.Point(170, 58);
            this.cmbDIA.Name = "cmbDIA";
            this.cmbDIA.Size = new System.Drawing.Size(224, 21);
            this.cmbDIA.TabIndex = 82;
            this.cmbDIA.SelectedIndexChanged += new System.EventHandler(this.cmbDIA_SelectedIndexChanged_1);
            // 
            // cmbESPECIALIDAD
            // 
            this.cmbESPECIALIDAD.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbESPECIALIDAD.FormattingEnabled = true;
            this.cmbESPECIALIDAD.Location = new System.Drawing.Point(170, 19);
            this.cmbESPECIALIDAD.Name = "cmbESPECIALIDAD";
            this.cmbESPECIALIDAD.Size = new System.Drawing.Size(224, 21);
            this.cmbESPECIALIDAD.TabIndex = 81;
            this.cmbESPECIALIDAD.SelectedIndexChanged += new System.EventHandler(this.cmbESPECIALIDAD_SelectedIndexChanged);
            // 
            // lblESPECIALIDAD
            // 
            this.lblESPECIALIDAD.AutoSize = true;
            this.lblESPECIALIDAD.Location = new System.Drawing.Point(13, 22);
            this.lblESPECIALIDAD.Name = "lblESPECIALIDAD";
            this.lblESPECIALIDAD.Size = new System.Drawing.Size(87, 13);
            this.lblESPECIALIDAD.TabIndex = 79;
            this.lblESPECIALIDAD.Text = "ESPECIALIDAD:";
            // 
            // lblDIA
            // 
            this.lblDIA.AutoSize = true;
            this.lblDIA.Location = new System.Drawing.Point(13, 66);
            this.lblDIA.Name = "lblDIA";
            this.lblDIA.Size = new System.Drawing.Size(28, 13);
            this.lblDIA.TabIndex = 80;
            this.lblDIA.Text = "DIA:";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(430, 55);
            this.label3.TabIndex = 929;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(103, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(217, 31);
            this.label4.TabIndex = 930;
            this.label4.Text = "Solicita un Turno";
            // 
            // frmTURNOS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(430, 454);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.gbDATOS_TURNOS);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmTURNOS";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "REALIZAR UNA CONSULTA";
            this.gbDATOS_TURNOS.ResumeLayout(false);
            this.gbDATOS_TURNOS.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbDATOS_TURNOS;
        private System.Windows.Forms.Button btnCERRAR;
        private System.Windows.Forms.Button btnGUARDAR;
        private System.Windows.Forms.Label lblTIPO_TURNO;
        private System.Windows.Forms.Label lblPROFESIONAL;
        private System.Windows.Forms.ComboBox cmbPROFESIONAL;
        private System.Windows.Forms.RadioButton rbESTUDIO;
        private System.Windows.Forms.RadioButton rbCONSULTA;
        private System.Windows.Forms.Label lblHORAS;
        private System.Windows.Forms.ComboBox cmbHORAS;
        private System.Windows.Forms.ComboBox cmbDIA;
        private System.Windows.Forms.ComboBox cmbESPECIALIDAD;
        private System.Windows.Forms.Label lblESPECIALIDAD;
        private System.Windows.Forms.Label lblDIA;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbPACIENTE;
    }
}