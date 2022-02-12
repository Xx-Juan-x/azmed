
namespace VISTA
{
    partial class frmLOGIN
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
            this.label4 = new System.Windows.Forms.Label();
            this.btnINGRESAR = new System.Windows.Forms.Button();
            this.btnSALIR = new System.Windows.Forms.Button();
            this.txtCLAVE = new System.Windows.Forms.TextBox();
            this.txtUSUARIO = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.linklblREGISTRARSE = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(51, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(148, 31);
            this.label4.TabIndex = 927;
            this.label4.Text = "Bienvenido";
            // 
            // btnINGRESAR
            // 
            this.btnINGRESAR.BackColor = System.Drawing.Color.CadetBlue;
            this.btnINGRESAR.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnINGRESAR.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnINGRESAR.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnINGRESAR.ForeColor = System.Drawing.Color.White;
            this.btnINGRESAR.Location = new System.Drawing.Point(12, 230);
            this.btnINGRESAR.Name = "btnINGRESAR";
            this.btnINGRESAR.Size = new System.Drawing.Size(221, 32);
            this.btnINGRESAR.TabIndex = 924;
            this.btnINGRESAR.Text = "Ingresar";
            this.btnINGRESAR.UseVisualStyleBackColor = false;
            // 
            // btnSALIR
            // 
            this.btnSALIR.BackColor = System.Drawing.Color.IndianRed;
            this.btnSALIR.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSALIR.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSALIR.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSALIR.ForeColor = System.Drawing.Color.White;
            this.btnSALIR.Location = new System.Drawing.Point(12, 268);
            this.btnSALIR.Name = "btnSALIR";
            this.btnSALIR.Size = new System.Drawing.Size(221, 32);
            this.btnSALIR.TabIndex = 925;
            this.btnSALIR.Text = "Salir";
            this.btnSALIR.UseVisualStyleBackColor = false;
            this.btnSALIR.Click += new System.EventHandler(this.btnSALIR_Click);
            // 
            // txtCLAVE
            // 
            this.txtCLAVE.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCLAVE.Location = new System.Drawing.Point(12, 164);
            this.txtCLAVE.Name = "txtCLAVE";
            this.txtCLAVE.PasswordChar = '*';
            this.txtCLAVE.Size = new System.Drawing.Size(221, 26);
            this.txtCLAVE.TabIndex = 923;
            this.txtCLAVE.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtUSUARIO
            // 
            this.txtUSUARIO.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUSUARIO.Location = new System.Drawing.Point(12, 104);
            this.txtUSUARIO.Name = "txtUSUARIO";
            this.txtUSUARIO.Size = new System.Drawing.Size(221, 26);
            this.txtUSUARIO.TabIndex = 920;
            this.txtUSUARIO.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(248, 73);
            this.label3.TabIndex = 926;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(83, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 20);
            this.label2.TabIndex = 921;
            this.label2.Text = "Contraseña";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(97, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 20);
            this.label1.TabIndex = 922;
            this.label1.Text = "Email";
            // 
            // linklblREGISTRARSE
            // 
            this.linklblREGISTRARSE.AutoSize = true;
            this.linklblREGISTRARSE.Location = new System.Drawing.Point(79, 205);
            this.linklblREGISTRARSE.Name = "linklblREGISTRARSE";
            this.linklblREGISTRARSE.Size = new System.Drawing.Size(96, 13);
            this.linklblREGISTRARSE.TabIndex = 928;
            this.linklblREGISTRARSE.TabStop = true;
            this.linklblREGISTRARSE.Text = "¿REGISTRARSE?";
            this.linklblREGISTRARSE.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linklblREGISTRARSE_LinkClicked);
            // 
            // frmLOGIN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(248, 309);
            this.Controls.Add(this.linklblREGISTRARSE);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnINGRESAR);
            this.Controls.Add(this.btnSALIR);
            this.Controls.Add(this.txtCLAVE);
            this.Controls.Add(this.txtUSUARIO);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmLOGIN";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LOGIN";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnINGRESAR;
        private System.Windows.Forms.Button btnSALIR;
        private System.Windows.Forms.TextBox txtCLAVE;
        private System.Windows.Forms.TextBox txtUSUARIO;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel linklblREGISTRARSE;
    }
}