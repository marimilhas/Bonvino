namespace CapaPresentacion
{
    partial class Inicio
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
            this.menu = new System.Windows.Forms.MenuStrip();
            this.menubodega = new FontAwesome.Sharp.IconMenuItem();
            this.menuvarietal = new FontAwesome.Sharp.IconMenuItem();
            this.menuactualizacion = new FontAwesome.Sharp.IconMenuItem();
            this.menuTitulo = new System.Windows.Forms.MenuStrip();
            this.label1 = new System.Windows.Forms.Label();
            this.contenedor = new System.Windows.Forms.Panel();
            this.menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // menu
            // 
            this.menu.BackColor = System.Drawing.Color.WhiteSmoke;
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menubodega,
            this.menuvarietal,
            this.menuactualizacion});
            this.menu.Location = new System.Drawing.Point(0, 67);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(855, 73);
            this.menu.TabIndex = 0;
            this.menu.Text = "menuStrip1";
            this.menu.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // menubodega
            // 
            this.menubodega.AutoSize = false;
            this.menubodega.IconChar = FontAwesome.Sharp.IconChar.Store;
            this.menubodega.IconColor = System.Drawing.Color.Black;
            this.menubodega.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menubodega.IconSize = 50;
            this.menubodega.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menubodega.Name = "menubodega";
            this.menubodega.Size = new System.Drawing.Size(119, 69);
            this.menubodega.Text = "Registrar Bodega";
            this.menubodega.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.menubodega.Click += new System.EventHandler(this.iconMenuItem1_Click);
            // 
            // menuvarietal
            // 
            this.menuvarietal.AutoSize = false;
            this.menuvarietal.IconChar = FontAwesome.Sharp.IconChar.WineGlass;
            this.menuvarietal.IconColor = System.Drawing.Color.Black;
            this.menuvarietal.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menuvarietal.IconSize = 50;
            this.menuvarietal.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuvarietal.Name = "menuvarietal";
            this.menuvarietal.Size = new System.Drawing.Size(122, 69);
            this.menuvarietal.Text = "Registrar Varietal";
            this.menuvarietal.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.menuvarietal.Click += new System.EventHandler(this.iconMenuItem2_Click);
            // 
            // menuactualizacion
            // 
            this.menuactualizacion.AutoSize = false;
            this.menuactualizacion.IconChar = FontAwesome.Sharp.IconChar.Download;
            this.menuactualizacion.IconColor = System.Drawing.Color.Black;
            this.menuactualizacion.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menuactualizacion.IconSize = 50;
            this.menuactualizacion.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuactualizacion.Name = "menuactualizacion";
            this.menuactualizacion.Size = new System.Drawing.Size(119, 69);
            this.menuactualizacion.Text = "Actualizar Bodegas";
            this.menuactualizacion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // menuTitulo
            // 
            this.menuTitulo.AutoSize = false;
            this.menuTitulo.BackColor = System.Drawing.Color.Brown;
            this.menuTitulo.Location = new System.Drawing.Point(0, 0);
            this.menuTitulo.Name = "menuTitulo";
            this.menuTitulo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.menuTitulo.Size = new System.Drawing.Size(855, 67);
            this.menuTitulo.TabIndex = 1;
            this.menuTitulo.Text = "menuStrip2";
            this.menuTitulo.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip2_ItemClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Brown;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 31);
            this.label1.TabIndex = 2;
            this.label1.Text = "BONVINO";
            // 
            // contenedor
            // 
            this.contenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contenedor.Location = new System.Drawing.Point(0, 140);
            this.contenedor.Name = "contenedor";
            this.contenedor.Size = new System.Drawing.Size(855, 310);
            this.contenedor.TabIndex = 3;
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(855, 450);
            this.Controls.Add(this.contenedor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menu);
            this.Controls.Add(this.menuTitulo);
            this.MainMenuStrip = this.menu;
            this.Name = "Inicio";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Inicio_Load);
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.MenuStrip menuTitulo;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconMenuItem menubodega;
        private FontAwesome.Sharp.IconMenuItem menuvarietal;
        private FontAwesome.Sharp.IconMenuItem menuactualizacion;
        private System.Windows.Forms.Panel contenedor;
    }
}

