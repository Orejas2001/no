namespace Banco
{
    partial class Form8
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form8));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.administradorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.actualizarPasswordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.crearCDTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reporteGeneralDelBancoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.avanzar1MesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clienteBancoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zonaTransaccionalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.actualizarPasswordToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.reporteClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.administradorToolStripMenuItem,
            this.clienteBancoToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(759, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // administradorToolStripMenuItem
            // 
            this.administradorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrarClienteToolStripMenuItem,
            this.actualizarPasswordToolStripMenuItem,
            this.crearCDTToolStripMenuItem,
            this.reporteGeneralDelBancoToolStripMenuItem,
            this.eliminarClienteToolStripMenuItem,
            this.avanzar1MesToolStripMenuItem});
            this.administradorToolStripMenuItem.Enabled = false;
            this.administradorToolStripMenuItem.Name = "administradorToolStripMenuItem";
            this.administradorToolStripMenuItem.Size = new System.Drawing.Size(95, 20);
            this.administradorToolStripMenuItem.Text = "Administrador";
            // 
            // registrarClienteToolStripMenuItem
            // 
            this.registrarClienteToolStripMenuItem.Name = "registrarClienteToolStripMenuItem";
            this.registrarClienteToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.registrarClienteToolStripMenuItem.Text = "Registrar Cliente";
            this.registrarClienteToolStripMenuItem.Click += new System.EventHandler(this.registrarClienteToolStripMenuItem_Click);
            // 
            // actualizarPasswordToolStripMenuItem
            // 
            this.actualizarPasswordToolStripMenuItem.Name = "actualizarPasswordToolStripMenuItem";
            this.actualizarPasswordToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.actualizarPasswordToolStripMenuItem.Text = "Actualizar Password";
            this.actualizarPasswordToolStripMenuItem.Click += new System.EventHandler(this.actualizarPasswordToolStripMenuItem_Click);
            // 
            // crearCDTToolStripMenuItem
            // 
            this.crearCDTToolStripMenuItem.Name = "crearCDTToolStripMenuItem";
            this.crearCDTToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.crearCDTToolStripMenuItem.Text = "Crear CDT";
            this.crearCDTToolStripMenuItem.Click += new System.EventHandler(this.crearCDTToolStripMenuItem_Click);
            // 
            // reporteGeneralDelBancoToolStripMenuItem
            // 
            this.reporteGeneralDelBancoToolStripMenuItem.Name = "reporteGeneralDelBancoToolStripMenuItem";
            this.reporteGeneralDelBancoToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.reporteGeneralDelBancoToolStripMenuItem.Text = "Reporte General del Banco";
            this.reporteGeneralDelBancoToolStripMenuItem.Click += new System.EventHandler(this.reporteGeneralDelBancoToolStripMenuItem_Click);
            // 
            // eliminarClienteToolStripMenuItem
            // 
            this.eliminarClienteToolStripMenuItem.Name = "eliminarClienteToolStripMenuItem";
            this.eliminarClienteToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.eliminarClienteToolStripMenuItem.Text = "Eliminar Cliente";
            this.eliminarClienteToolStripMenuItem.Click += new System.EventHandler(this.eliminarClienteToolStripMenuItem_Click);
            // 
            // avanzar1MesToolStripMenuItem
            // 
            this.avanzar1MesToolStripMenuItem.Name = "avanzar1MesToolStripMenuItem";
            this.avanzar1MesToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.avanzar1MesToolStripMenuItem.Text = "Avanzar 1 Mes";
            this.avanzar1MesToolStripMenuItem.Click += new System.EventHandler(this.avanzar1MesToolStripMenuItem_Click);
            // 
            // clienteBancoToolStripMenuItem
            // 
            this.clienteBancoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.zonaTransaccionalToolStripMenuItem,
            this.actualizarPasswordToolStripMenuItem1,
            this.reporteClienteToolStripMenuItem});
            this.clienteBancoToolStripMenuItem.Enabled = false;
            this.clienteBancoToolStripMenuItem.Name = "clienteBancoToolStripMenuItem";
            this.clienteBancoToolStripMenuItem.Size = new System.Drawing.Size(92, 20);
            this.clienteBancoToolStripMenuItem.Text = "Cliente Banco";
            // 
            // zonaTransaccionalToolStripMenuItem
            // 
            this.zonaTransaccionalToolStripMenuItem.Name = "zonaTransaccionalToolStripMenuItem";
            this.zonaTransaccionalToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.zonaTransaccionalToolStripMenuItem.Text = "Zona Transaccional";
            this.zonaTransaccionalToolStripMenuItem.Click += new System.EventHandler(this.zonaTransaccionalToolStripMenuItem_Click);
            // 
            // actualizarPasswordToolStripMenuItem1
            // 
            this.actualizarPasswordToolStripMenuItem1.Name = "actualizarPasswordToolStripMenuItem1";
            this.actualizarPasswordToolStripMenuItem1.Size = new System.Drawing.Size(179, 22);
            this.actualizarPasswordToolStripMenuItem1.Text = "Actualizar Password";
            this.actualizarPasswordToolStripMenuItem1.Click += new System.EventHandler(this.actualizarPasswordToolStripMenuItem1_Click);
            // 
            // reporteClienteToolStripMenuItem
            // 
            this.reporteClienteToolStripMenuItem.Name = "reporteClienteToolStripMenuItem";
            this.reporteClienteToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.reporteClienteToolStripMenuItem.Text = "Reporte Cliente";
            this.reporteClienteToolStripMenuItem.Click += new System.EventHandler(this.reporteClienteToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(88, 20);
            this.salirToolStripMenuItem.Text = "Cerrar Sesión";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Gill Sans MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 181);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(265, 69);
            this.label1.TabIndex = 1;
            this.label1.Text = "DIGITE LA IDENTIFICACIÓN \r\nDEL CLIENTE QUE DESEA ELIMINAR\r\n\r\n";
            this.label1.Visible = false;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Gill Sans MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(325, 204);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(217, 26);
            this.textBox1.TabIndex = 2;
            this.textBox1.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(462, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(175, 24);
            this.label2.TabIndex = 13;
            this.label2.Text = "MES SIMULACIÓN:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // textBox2
            // 
            this.textBox2.Enabled = false;
            this.textBox2.Font = new System.Drawing.Font("Magneto", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.ForeColor = System.Drawing.Color.Black;
            this.textBox2.Location = new System.Drawing.Point(656, 62);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(68, 31);
            this.textBox2.TabIndex = 14;
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(98, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "label3";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Crimson;
            this.button1.Location = new System.Drawing.Point(625, 215);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(60, 30);
            this.button1.TabIndex = 16;
            this.button1.Text = "Eliminar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Form8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(759, 400);
            this.ControlBox = false;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form8";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Form8_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem administradorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrarClienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem actualizarPasswordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem crearCDTToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reporteGeneralDelBancoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clienteBancoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zonaTransaccionalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem actualizarPasswordToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem reporteClienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarClienteToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ToolStripMenuItem avanzar1MesToolStripMenuItem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
    }
}