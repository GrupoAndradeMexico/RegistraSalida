﻿namespace RegistraSalida
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmdRegistrar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTextoCodigoBarras = new System.Windows.Forms.TextBox();
            this.timerThread = new System.Windows.Forms.Timer(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.fsw = new System.IO.FileSystemWatcher();
            this.ntiBalloon = new System.Windows.Forms.NotifyIcon(this.components);
            this.timerReproceso = new System.Windows.Forms.Timer(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fsw)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cmdRegistrar);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtTextoCodigoBarras);
            this.panel1.Location = new System.Drawing.Point(110, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(611, 151);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // cmdRegistrar
            // 
            this.cmdRegistrar.Location = new System.Drawing.Point(154, 99);
            this.cmdRegistrar.Name = "cmdRegistrar";
            this.cmdRegistrar.Size = new System.Drawing.Size(210, 29);
            this.cmdRegistrar.TabIndex = 2;
            this.cmdRegistrar.Text = "REGISTRAR";
            this.cmdRegistrar.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(607, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Capture el No. de Serie de la unidad a registrar la salida";
            // 
            // txtTextoCodigoBarras
            // 
            this.txtTextoCodigoBarras.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTextoCodigoBarras.Location = new System.Drawing.Point(4, 54);
            this.txtTextoCodigoBarras.Name = "txtTextoCodigoBarras";
            this.txtTextoCodigoBarras.Size = new System.Drawing.Size(551, 31);
            this.txtTextoCodigoBarras.TabIndex = 0;
            // 
            // timerThread
            // 
            this.timerThread.Interval = 30000;
            this.timerThread.Tick += new System.EventHandler(this.timerThread_Tick);
            // 
            // panel2
            // 
            this.panel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel2.BackgroundImage = global::RegistraSalida.Properties.Resources.A_Logo;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Location = new System.Drawing.Point(0, 1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(107, 151);
            this.panel2.TabIndex = 1;
            // 
            // fsw
            // 
            this.fsw.EnableRaisingEvents = true;
            this.fsw.SynchronizingObject = this;
            this.fsw.Created += new System.IO.FileSystemEventHandler(this.fsw_Created);
            // 
            // ntiBalloon
            // 
            this.ntiBalloon.ContextMenuStrip = this.contextMenuStrip1;
            this.ntiBalloon.Text = "REGISTRO SALIDAS";
            this.ntiBalloon.Visible = true;
            // 
            // timerReproceso
            // 
            this.timerReproceso.Interval = 3600000;
            this.timerReproceso.Tick += new System.EventHandler(this.timerReproceso_Tick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(153, 48);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            this.contextMenuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.contextMenuStrip1_ItemClicked);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.toolStripMenuItem1.Text = "SALIR";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(721, 153);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registra Salida de Unidad.";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fsw)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtTextoCodigoBarras;
        private System.Windows.Forms.Button cmdRegistrar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Timer timerThread;
        private System.IO.FileSystemWatcher fsw;
        private System.Windows.Forms.NotifyIcon ntiBalloon;
        private System.Windows.Forms.Timer timerReproceso;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
    }
}

