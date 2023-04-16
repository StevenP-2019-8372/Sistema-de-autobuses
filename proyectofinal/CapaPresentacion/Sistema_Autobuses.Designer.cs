
namespace CapaPresentacion
{
    partial class Sistema_Autobuses
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sistema_Autobuses));
            this.TopFormulario = new System.Windows.Forms.Panel();
            this.btn_Cerrar = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Formulario = new System.Windows.Forms.Panel();
            this.btnAdministrarRutas = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnAdministrarViajes = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnAdministrarAutobuses = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnAdministrarChoferes = new Bunifu.Framework.UI.BunifuFlatButton();
            this.MoverFormulario = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.TopFormulario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Cerrar)).BeginInit();
            this.Formulario.SuspendLayout();
            this.SuspendLayout();
            // 
            // TopFormulario
            // 
            this.TopFormulario.BackColor = System.Drawing.Color.Purple;
            this.TopFormulario.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("TopFormulario.BackgroundImage")));
            this.TopFormulario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.TopFormulario.Controls.Add(this.btn_Cerrar);
            this.TopFormulario.Controls.Add(this.label1);
            this.TopFormulario.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopFormulario.Location = new System.Drawing.Point(0, 0);
            this.TopFormulario.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.TopFormulario.Name = "TopFormulario";
            this.TopFormulario.Size = new System.Drawing.Size(593, 62);
            this.TopFormulario.TabIndex = 0;
            // 
            // btn_Cerrar
            // 
            this.btn_Cerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Cerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Cerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Cerrar.ErrorImage = null;
            this.btn_Cerrar.Image = ((System.Drawing.Image)(resources.GetObject("btn_Cerrar.Image")));
            this.btn_Cerrar.InitialImage = null;
            this.btn_Cerrar.Location = new System.Drawing.Point(534, 12);
            this.btn_Cerrar.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btn_Cerrar.Name = "btn_Cerrar";
            this.btn_Cerrar.Size = new System.Drawing.Size(48, 38);
            this.btn_Cerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_Cerrar.TabIndex = 3;
            this.btn_Cerrar.TabStop = false;
            this.btn_Cerrar.Tag = "";
            this.btn_Cerrar.Click += new System.EventHandler(this.btn_Cerrar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(116, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(380, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sistema de Control de Autobuses";
            // 
            // Formulario
            // 
            this.Formulario.Controls.Add(this.btnAdministrarRutas);
            this.Formulario.Controls.Add(this.btnAdministrarViajes);
            this.Formulario.Controls.Add(this.btnAdministrarAutobuses);
            this.Formulario.Controls.Add(this.btnAdministrarChoferes);
            this.Formulario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Formulario.Location = new System.Drawing.Point(0, 62);
            this.Formulario.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.Formulario.Name = "Formulario";
            this.Formulario.Size = new System.Drawing.Size(593, 343);
            this.Formulario.TabIndex = 1;
            this.Formulario.Paint += new System.Windows.Forms.PaintEventHandler(this.Formulario_Paint);
            // 
            // btnAdministrarRutas
            // 
            this.btnAdministrarRutas.Activecolor = System.Drawing.Color.Purple;
            this.btnAdministrarRutas.BackColor = System.Drawing.Color.Purple;
            this.btnAdministrarRutas.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAdministrarRutas.BackgroundImage")));
            this.btnAdministrarRutas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnAdministrarRutas.BorderRadius = 0;
            this.btnAdministrarRutas.ButtonText = "Administrar Rutas";
            this.btnAdministrarRutas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdministrarRutas.DisabledColor = System.Drawing.Color.Gray;
            this.btnAdministrarRutas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdministrarRutas.ForeColor = System.Drawing.Color.Black;
            this.btnAdministrarRutas.Iconcolor = System.Drawing.Color.Transparent;
            this.btnAdministrarRutas.Iconimage = null;
            this.btnAdministrarRutas.Iconimage_right = null;
            this.btnAdministrarRutas.Iconimage_right_Selected = null;
            this.btnAdministrarRutas.Iconimage_Selected = null;
            this.btnAdministrarRutas.IconMarginLeft = 0;
            this.btnAdministrarRutas.IconMarginRight = 0;
            this.btnAdministrarRutas.IconRightVisible = true;
            this.btnAdministrarRutas.IconRightZoom = 0D;
            this.btnAdministrarRutas.IconVisible = true;
            this.btnAdministrarRutas.IconZoom = 90D;
            this.btnAdministrarRutas.IsTab = false;
            this.btnAdministrarRutas.Location = new System.Drawing.Point(188, 185);
            this.btnAdministrarRutas.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnAdministrarRutas.Name = "btnAdministrarRutas";
            this.btnAdministrarRutas.Normalcolor = System.Drawing.Color.Purple;
            this.btnAdministrarRutas.OnHovercolor = System.Drawing.Color.Gray;
            this.btnAdministrarRutas.OnHoverTextColor = System.Drawing.Color.Purple;
            this.btnAdministrarRutas.selected = false;
            this.btnAdministrarRutas.Size = new System.Drawing.Size(227, 53);
            this.btnAdministrarRutas.TabIndex = 4;
            this.btnAdministrarRutas.Text = "Administrar Rutas";
            this.btnAdministrarRutas.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAdministrarRutas.Textcolor = System.Drawing.Color.Black;
            this.btnAdministrarRutas.TextFont = new System.Drawing.Font("Showcard Gothic", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdministrarRutas.Click += new System.EventHandler(this.btnAdministrarRutas_Click);
            // 
            // btnAdministrarViajes
            // 
            this.btnAdministrarViajes.Activecolor = System.Drawing.Color.Purple;
            this.btnAdministrarViajes.BackColor = System.Drawing.Color.Purple;
            this.btnAdministrarViajes.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAdministrarViajes.BackgroundImage")));
            this.btnAdministrarViajes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnAdministrarViajes.BorderRadius = 0;
            this.btnAdministrarViajes.ButtonText = "Administrar Viajes";
            this.btnAdministrarViajes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdministrarViajes.DisabledColor = System.Drawing.Color.Gray;
            this.btnAdministrarViajes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdministrarViajes.ForeColor = System.Drawing.Color.Black;
            this.btnAdministrarViajes.Iconcolor = System.Drawing.Color.Transparent;
            this.btnAdministrarViajes.Iconimage = null;
            this.btnAdministrarViajes.Iconimage_right = null;
            this.btnAdministrarViajes.Iconimage_right_Selected = null;
            this.btnAdministrarViajes.Iconimage_Selected = null;
            this.btnAdministrarViajes.IconMarginLeft = 0;
            this.btnAdministrarViajes.IconMarginRight = 0;
            this.btnAdministrarViajes.IconRightVisible = true;
            this.btnAdministrarViajes.IconRightZoom = 0D;
            this.btnAdministrarViajes.IconVisible = true;
            this.btnAdministrarViajes.IconZoom = 90D;
            this.btnAdministrarViajes.IsTab = false;
            this.btnAdministrarViajes.Location = new System.Drawing.Point(188, 268);
            this.btnAdministrarViajes.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnAdministrarViajes.Name = "btnAdministrarViajes";
            this.btnAdministrarViajes.Normalcolor = System.Drawing.Color.Purple;
            this.btnAdministrarViajes.OnHovercolor = System.Drawing.Color.Gray;
            this.btnAdministrarViajes.OnHoverTextColor = System.Drawing.Color.Purple;
            this.btnAdministrarViajes.selected = false;
            this.btnAdministrarViajes.Size = new System.Drawing.Size(227, 53);
            this.btnAdministrarViajes.TabIndex = 3;
            this.btnAdministrarViajes.Text = "Administrar Viajes";
            this.btnAdministrarViajes.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAdministrarViajes.Textcolor = System.Drawing.Color.Black;
            this.btnAdministrarViajes.TextFont = new System.Drawing.Font("Showcard Gothic", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdministrarViajes.Click += new System.EventHandler(this.btnAdministrarViajes_Click);
            // 
            // btnAdministrarAutobuses
            // 
            this.btnAdministrarAutobuses.Activecolor = System.Drawing.Color.Purple;
            this.btnAdministrarAutobuses.BackColor = System.Drawing.Color.Purple;
            this.btnAdministrarAutobuses.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAdministrarAutobuses.BackgroundImage")));
            this.btnAdministrarAutobuses.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnAdministrarAutobuses.BorderRadius = 0;
            this.btnAdministrarAutobuses.ButtonText = "Administrar Autobuses";
            this.btnAdministrarAutobuses.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdministrarAutobuses.DisabledColor = System.Drawing.Color.Gray;
            this.btnAdministrarAutobuses.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdministrarAutobuses.ForeColor = System.Drawing.Color.Black;
            this.btnAdministrarAutobuses.Iconcolor = System.Drawing.Color.Transparent;
            this.btnAdministrarAutobuses.Iconimage = null;
            this.btnAdministrarAutobuses.Iconimage_right = null;
            this.btnAdministrarAutobuses.Iconimage_right_Selected = null;
            this.btnAdministrarAutobuses.Iconimage_Selected = null;
            this.btnAdministrarAutobuses.IconMarginLeft = 0;
            this.btnAdministrarAutobuses.IconMarginRight = 0;
            this.btnAdministrarAutobuses.IconRightVisible = true;
            this.btnAdministrarAutobuses.IconRightZoom = 0D;
            this.btnAdministrarAutobuses.IconVisible = true;
            this.btnAdministrarAutobuses.IconZoom = 90D;
            this.btnAdministrarAutobuses.IsTab = false;
            this.btnAdministrarAutobuses.Location = new System.Drawing.Point(188, 102);
            this.btnAdministrarAutobuses.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnAdministrarAutobuses.Name = "btnAdministrarAutobuses";
            this.btnAdministrarAutobuses.Normalcolor = System.Drawing.Color.Purple;
            this.btnAdministrarAutobuses.OnHovercolor = System.Drawing.Color.Gray;
            this.btnAdministrarAutobuses.OnHoverTextColor = System.Drawing.Color.Purple;
            this.btnAdministrarAutobuses.selected = false;
            this.btnAdministrarAutobuses.Size = new System.Drawing.Size(227, 53);
            this.btnAdministrarAutobuses.TabIndex = 2;
            this.btnAdministrarAutobuses.Text = "Administrar Autobuses";
            this.btnAdministrarAutobuses.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAdministrarAutobuses.Textcolor = System.Drawing.Color.Black;
            this.btnAdministrarAutobuses.TextFont = new System.Drawing.Font("Showcard Gothic", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdministrarAutobuses.Click += new System.EventHandler(this.btnAdministrarAutobuses_Click);
            // 
            // btnAdministrarChoferes
            // 
            this.btnAdministrarChoferes.Activecolor = System.Drawing.Color.Purple;
            this.btnAdministrarChoferes.BackColor = System.Drawing.Color.Purple;
            this.btnAdministrarChoferes.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAdministrarChoferes.BackgroundImage")));
            this.btnAdministrarChoferes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnAdministrarChoferes.BorderRadius = 0;
            this.btnAdministrarChoferes.ButtonText = "Administrar Choferes";
            this.btnAdministrarChoferes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdministrarChoferes.DisabledColor = System.Drawing.Color.Gray;
            this.btnAdministrarChoferes.Font = new System.Drawing.Font("Showcard Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdministrarChoferes.ForeColor = System.Drawing.Color.Black;
            this.btnAdministrarChoferes.Iconcolor = System.Drawing.Color.Transparent;
            this.btnAdministrarChoferes.Iconimage = null;
            this.btnAdministrarChoferes.Iconimage_right = null;
            this.btnAdministrarChoferes.Iconimage_right_Selected = null;
            this.btnAdministrarChoferes.Iconimage_Selected = null;
            this.btnAdministrarChoferes.IconMarginLeft = 0;
            this.btnAdministrarChoferes.IconMarginRight = 0;
            this.btnAdministrarChoferes.IconRightVisible = true;
            this.btnAdministrarChoferes.IconRightZoom = 0D;
            this.btnAdministrarChoferes.IconVisible = true;
            this.btnAdministrarChoferes.IconZoom = 90D;
            this.btnAdministrarChoferes.IsTab = false;
            this.btnAdministrarChoferes.Location = new System.Drawing.Point(188, 22);
            this.btnAdministrarChoferes.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnAdministrarChoferes.Name = "btnAdministrarChoferes";
            this.btnAdministrarChoferes.Normalcolor = System.Drawing.Color.Purple;
            this.btnAdministrarChoferes.OnHovercolor = System.Drawing.Color.Gray;
            this.btnAdministrarChoferes.OnHoverTextColor = System.Drawing.Color.Purple;
            this.btnAdministrarChoferes.selected = false;
            this.btnAdministrarChoferes.Size = new System.Drawing.Size(227, 53);
            this.btnAdministrarChoferes.TabIndex = 1;
            this.btnAdministrarChoferes.Text = "Administrar Choferes";
            this.btnAdministrarChoferes.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAdministrarChoferes.Textcolor = System.Drawing.Color.Black;
            this.btnAdministrarChoferes.TextFont = new System.Drawing.Font("Showcard Gothic", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdministrarChoferes.Click += new System.EventHandler(this.btnAdministrarChoferes_Click);
            // 
            // MoverFormulario
            // 
            this.MoverFormulario.Fixed = true;
            this.MoverFormulario.Horizontal = true;
            this.MoverFormulario.TargetControl = this.TopFormulario;
            this.MoverFormulario.Vertical = true;
            // 
            // Sistema_Autobuses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(593, 405);
            this.Controls.Add(this.Formulario);
            this.Controls.Add(this.TopFormulario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.Name = "Sistema_Autobuses";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema de Control de Autobuses";
            this.Load += new System.EventHandler(this.Sistema_Autobuses_Load);
            this.TopFormulario.ResumeLayout(false);
            this.TopFormulario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Cerrar)).EndInit();
            this.Formulario.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel TopFormulario;
        private System.Windows.Forms.Panel Formulario;
        private Bunifu.Framework.UI.BunifuFlatButton btnAdministrarRutas;
        private Bunifu.Framework.UI.BunifuFlatButton btnAdministrarViajes;
        private Bunifu.Framework.UI.BunifuFlatButton btnAdministrarAutobuses;
        private Bunifu.Framework.UI.BunifuFlatButton btnAdministrarChoferes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox btn_Cerrar;
        private Bunifu.Framework.UI.BunifuDragControl MoverFormulario;
    }
}

