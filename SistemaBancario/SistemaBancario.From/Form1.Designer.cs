﻿namespace SistemaBancario.From
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAbrir = new System.Windows.Forms.Button();
            this.txtMonto = new System.Windows.Forms.TextBox();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnRetiro = new System.Windows.Forms.Button();
            this.btnDeposito = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.txtSaldo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lstRetiros = new System.Windows.Forms.ListBox();
            this.lstDepositos = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAbrir);
            this.groupBox1.Controls.Add(this.txtMonto);
            this.groupBox1.Controls.Add(this.txtCliente);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(16, 16);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(637, 117);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ingrese los Datos";
            // 
            // btnAbrir
            // 
            this.btnAbrir.Location = new System.Drawing.Point(380, 39);
            this.btnAbrir.Name = "btnAbrir";
            this.btnAbrir.Size = new System.Drawing.Size(109, 28);
            this.btnAbrir.TabIndex = 4;
            this.btnAbrir.Text = "Abrir Cuenta";
            this.btnAbrir.UseVisualStyleBackColor = true;
            this.btnAbrir.Click += new System.EventHandler(this.btnAbrir_Click);
            // 
            // txtMonto
            // 
            this.txtMonto.Location = new System.Drawing.Point(90, 71);
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.Size = new System.Drawing.Size(159, 20);
            this.txtMonto.TabIndex = 3;
            // 
            // txtCliente
            // 
            this.txtCliente.Location = new System.Drawing.Point(90, 27);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(160, 20);
            this.txtCliente.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Monto:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cliente:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnRetiro);
            this.groupBox2.Controls.Add(this.btnDeposito);
            this.groupBox2.Location = new System.Drawing.Point(16, 151);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(637, 104);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Trasacciones";
            // 
            // btnRetiro
            // 
            this.btnRetiro.Location = new System.Drawing.Point(240, 48);
            this.btnRetiro.Name = "btnRetiro";
            this.btnRetiro.Size = new System.Drawing.Size(115, 32);
            this.btnRetiro.TabIndex = 1;
            this.btnRetiro.Text = "Retiro";
            this.btnRetiro.UseVisualStyleBackColor = true;
            this.btnRetiro.Click += new System.EventHandler(this.btnRetiro_Click);
            // 
            // btnDeposito
            // 
            this.btnDeposito.Location = new System.Drawing.Point(50, 48);
            this.btnDeposito.Name = "btnDeposito";
            this.btnDeposito.Size = new System.Drawing.Size(102, 32);
            this.btnDeposito.TabIndex = 0;
            this.btnDeposito.Text = "Deposito";
            this.btnDeposito.UseVisualStyleBackColor = true;
            this.btnDeposito.Click += new System.EventHandler(this.btnDeposito_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnNuevo);
            this.groupBox3.Controls.Add(this.txtSaldo);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.lstRetiros);
            this.groupBox3.Controls.Add(this.lstDepositos);
            this.groupBox3.Location = new System.Drawing.Point(22, 279);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(630, 159);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Historia";
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(437, 114);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(75, 23);
            this.btnNuevo.TabIndex = 6;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // txtSaldo
            // 
            this.txtSaldo.Location = new System.Drawing.Point(437, 88);
            this.txtSaldo.Name = "txtSaldo";
            this.txtSaldo.Size = new System.Drawing.Size(96, 20);
            this.txtSaldo.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(440, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Saldo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(240, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Retiros";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Depositos";
            // 
            // lstRetiros
            // 
            this.lstRetiros.FormattingEnabled = true;
            this.lstRetiros.Location = new System.Drawing.Point(234, 56);
            this.lstRetiros.Name = "lstRetiros";
            this.lstRetiros.Size = new System.Drawing.Size(138, 82);
            this.lstRetiros.TabIndex = 1;
            // 
            // lstDepositos
            // 
            this.lstDepositos.Location = new System.Drawing.Point(28, 56);
            this.lstDepositos.Name = "lstDepositos";
            this.lstDepositos.Size = new System.Drawing.Size(141, 82);
            this.lstDepositos.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(666, 450);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAbrir;
        private System.Windows.Forms.TextBox txtMonto;
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnRetiro;
        private System.Windows.Forms.Button btnDeposito;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.TextBox txtSaldo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox lstRetiros;
        private System.Windows.Forms.ListBox lstDepositos;
    }
}

