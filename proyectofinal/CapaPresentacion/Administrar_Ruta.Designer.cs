﻿
namespace CapaPresentacion
{
    partial class Administrar_Ruta
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Administrar_Ruta));
            this.TopFormulario = new System.Windows.Forms.Panel();
            this.btn_Cerrar = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Formulario = new System.Windows.Forms.Panel();
            this.btnGuardar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_Reset = new Bunifu.Framework.UI.BunifuFlatButton();
            this.txt_ID = new System.Windows.Forms.TextBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_Eliminar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_Editar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.txtDistancia = new System.Windows.Forms.TextBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.txtParadas = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.MoverFormulario = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.TopFormulario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Cerrar)).BeginInit();
            this.Formulario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            this.TopFormulario.Size = new System.Drawing.Size(689, 59);
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
            this.btn_Cerrar.Location = new System.Drawing.Point(637, 9);
            this.btn_Cerrar.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btn_Cerrar.Name = "btn_Cerrar";
            this.btn_Cerrar.Size = new System.Drawing.Size(41, 32);
            this.btn_Cerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_Cerrar.TabIndex = 2;
            this.btn_Cerrar.TabStop = false;
            this.btn_Cerrar.Click += new System.EventHandler(this.btn_Cerrar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 15F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(245, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "ADMINISTRAR RUTAS";
            // 
            // Formulario
            // 
            this.Formulario.Controls.Add(this.btnGuardar);
            this.Formulario.Controls.Add(this.btn_Reset);
            this.Formulario.Controls.Add(this.txt_ID);
            this.Formulario.Controls.Add(this.pictureBox8);
            this.Formulario.Controls.Add(this.label7);
            this.Formulario.Controls.Add(this.btn_Eliminar);
            this.Formulario.Controls.Add(this.btn_Editar);
            this.Formulario.Controls.Add(this.txtDistancia);
            this.Formulario.Controls.Add(this.pictureBox4);
            this.Formulario.Controls.Add(this.txtParadas);
            this.Formulario.Controls.Add(this.txtNombre);
            this.Formulario.Controls.Add(this.pictureBox5);
            this.Formulario.Controls.Add(this.pictureBox3);
            this.Formulario.Controls.Add(this.label4);
            this.Formulario.Controls.Add(this.label3);
            this.Formulario.Controls.Add(this.label2);
            this.Formulario.Controls.Add(this.dataGridView1);
            this.Formulario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Formulario.Location = new System.Drawing.Point(0, 59);
            this.Formulario.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.Formulario.Name = "Formulario";
            this.Formulario.Size = new System.Drawing.Size(689, 376);
            this.Formulario.TabIndex = 1;
            this.Formulario.Paint += new System.Windows.Forms.PaintEventHandler(this.Formulario_Paint);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Activecolor = System.Drawing.Color.Purple;
            this.btnGuardar.BackColor = System.Drawing.Color.Purple;
            this.btnGuardar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnGuardar.BackgroundImage")));
            this.btnGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnGuardar.BorderRadius = 0;
            this.btnGuardar.ButtonText = "GUARDAR";
            this.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardar.DisabledColor = System.Drawing.Color.Gray;
            this.btnGuardar.Font = new System.Drawing.Font("Showcard Gothic", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.Color.Black;
            this.btnGuardar.Iconcolor = System.Drawing.Color.Transparent;
            this.btnGuardar.Iconimage = null;
            this.btnGuardar.Iconimage_right = null;
            this.btnGuardar.Iconimage_right_Selected = null;
            this.btnGuardar.Iconimage_Selected = null;
            this.btnGuardar.IconMarginLeft = 0;
            this.btnGuardar.IconMarginRight = 0;
            this.btnGuardar.IconRightVisible = true;
            this.btnGuardar.IconRightZoom = 0D;
            this.btnGuardar.IconVisible = true;
            this.btnGuardar.IconZoom = 60D;
            this.btnGuardar.IsTab = false;
            this.btnGuardar.Location = new System.Drawing.Point(134, 247);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Normalcolor = System.Drawing.Color.Purple;
            this.btnGuardar.OnHovercolor = System.Drawing.Color.Gray;
            this.btnGuardar.OnHoverTextColor = System.Drawing.Color.Purple;
            this.btnGuardar.selected = false;
            this.btnGuardar.Size = new System.Drawing.Size(161, 54);
            this.btnGuardar.TabIndex = 58;
            this.btnGuardar.Text = "GUARDAR";
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardar.Textcolor = System.Drawing.Color.Black;
            this.btnGuardar.TextFont = new System.Drawing.Font("Showcard Gothic", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btn_Reset
            // 
            this.btn_Reset.Activecolor = System.Drawing.Color.Purple;
            this.btn_Reset.BackColor = System.Drawing.Color.Purple;
            this.btn_Reset.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Reset.BackgroundImage")));
            this.btn_Reset.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_Reset.BorderRadius = 0;
            this.btn_Reset.ButtonText = "RESET";
            this.btn_Reset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Reset.DisabledColor = System.Drawing.Color.Gray;
            this.btn_Reset.Font = new System.Drawing.Font("Showcard Gothic", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Reset.ForeColor = System.Drawing.Color.Black;
            this.btn_Reset.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_Reset.Iconimage = null;
            this.btn_Reset.Iconimage_right = null;
            this.btn_Reset.Iconimage_right_Selected = null;
            this.btn_Reset.Iconimage_Selected = null;
            this.btn_Reset.IconMarginLeft = 0;
            this.btn_Reset.IconMarginRight = 0;
            this.btn_Reset.IconRightVisible = false;
            this.btn_Reset.IconRightZoom = 0D;
            this.btn_Reset.IconVisible = true;
            this.btn_Reset.IconZoom = 60D;
            this.btn_Reset.IsTab = false;
            this.btn_Reset.Location = new System.Drawing.Point(383, 247);
            this.btn_Reset.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.btn_Reset.Name = "btn_Reset";
            this.btn_Reset.Normalcolor = System.Drawing.Color.Purple;
            this.btn_Reset.OnHovercolor = System.Drawing.Color.Gray;
            this.btn_Reset.OnHoverTextColor = System.Drawing.Color.Purple;
            this.btn_Reset.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_Reset.selected = false;
            this.btn_Reset.Size = new System.Drawing.Size(161, 54);
            this.btn_Reset.TabIndex = 51;
            this.btn_Reset.Text = "RESET";
            this.btn_Reset.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Reset.Textcolor = System.Drawing.Color.Black;
            this.btn_Reset.TextFont = new System.Drawing.Font("Showcard Gothic", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Reset.Click += new System.EventHandler(this.btn_Reset_Click);
            // 
            // txt_ID
            // 
            this.txt_ID.BackColor = System.Drawing.SystemColors.Window;
            this.txt_ID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_ID.Location = new System.Drawing.Point(127, 29);
            this.txt_ID.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.txt_ID.Name = "txt_ID";
            this.txt_ID.ReadOnly = true;
            this.txt_ID.Size = new System.Drawing.Size(157, 13);
            this.txt_ID.TabIndex = 57;
            this.txt_ID.Text = "0";
            // 
            // pictureBox8
            // 
            this.pictureBox8.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox8.BackgroundImage")));
            this.pictureBox8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox8.ErrorImage = null;
            this.pictureBox8.InitialImage = null;
            this.pictureBox8.Location = new System.Drawing.Point(115, 20);
            this.pictureBox8.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(180, 31);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox8.TabIndex = 56;
            this.pictureBox8.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Showcard Gothic", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(113, 2);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(23, 17);
            this.label7.TabIndex = 55;
            this.label7.Text = "ID";
            // 
            // btn_Eliminar
            // 
            this.btn_Eliminar.Activecolor = System.Drawing.Color.Purple;
            this.btn_Eliminar.BackColor = System.Drawing.Color.Purple;
            this.btn_Eliminar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Eliminar.BackgroundImage")));
            this.btn_Eliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_Eliminar.BorderRadius = 0;
            this.btn_Eliminar.ButtonText = "ELIMINAR";
            this.btn_Eliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Eliminar.DisabledColor = System.Drawing.Color.Gray;
            this.btn_Eliminar.Font = new System.Drawing.Font("Showcard Gothic", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Eliminar.ForeColor = System.Drawing.Color.Black;
            this.btn_Eliminar.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_Eliminar.Iconimage = null;
            this.btn_Eliminar.Iconimage_right = null;
            this.btn_Eliminar.Iconimage_right_Selected = null;
            this.btn_Eliminar.Iconimage_Selected = null;
            this.btn_Eliminar.IconMarginLeft = 0;
            this.btn_Eliminar.IconMarginRight = 0;
            this.btn_Eliminar.IconRightVisible = true;
            this.btn_Eliminar.IconRightZoom = 0D;
            this.btn_Eliminar.IconVisible = true;
            this.btn_Eliminar.IconZoom = 60D;
            this.btn_Eliminar.IsTab = false;
            this.btn_Eliminar.Location = new System.Drawing.Point(134, 319);
            this.btn_Eliminar.Name = "btn_Eliminar";
            this.btn_Eliminar.Normalcolor = System.Drawing.Color.Purple;
            this.btn_Eliminar.OnHovercolor = System.Drawing.Color.Gray;
            this.btn_Eliminar.OnHoverTextColor = System.Drawing.Color.Purple;
            this.btn_Eliminar.selected = false;
            this.btn_Eliminar.Size = new System.Drawing.Size(161, 54);
            this.btn_Eliminar.TabIndex = 53;
            this.btn_Eliminar.Text = "ELIMINAR";
            this.btn_Eliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Eliminar.Textcolor = System.Drawing.Color.Black;
            this.btn_Eliminar.TextFont = new System.Drawing.Font("Showcard Gothic", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Eliminar.Click += new System.EventHandler(this.btn_Eliminar_Click);
            // 
            // btn_Editar
            // 
            this.btn_Editar.Activecolor = System.Drawing.Color.Purple;
            this.btn_Editar.BackColor = System.Drawing.Color.Purple;
            this.btn_Editar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Editar.BackgroundImage")));
            this.btn_Editar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_Editar.BorderRadius = 0;
            this.btn_Editar.ButtonText = "EDITAR";
            this.btn_Editar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Editar.DisabledColor = System.Drawing.Color.Gray;
            this.btn_Editar.Font = new System.Drawing.Font("Showcard Gothic", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Editar.ForeColor = System.Drawing.Color.Black;
            this.btn_Editar.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_Editar.Iconimage = null;
            this.btn_Editar.Iconimage_right = null;
            this.btn_Editar.Iconimage_right_Selected = null;
            this.btn_Editar.Iconimage_Selected = null;
            this.btn_Editar.IconMarginLeft = 0;
            this.btn_Editar.IconMarginRight = 0;
            this.btn_Editar.IconRightVisible = true;
            this.btn_Editar.IconRightZoom = 0D;
            this.btn_Editar.IconVisible = true;
            this.btn_Editar.IconZoom = 60D;
            this.btn_Editar.IsTab = false;
            this.btn_Editar.Location = new System.Drawing.Point(383, 319);
            this.btn_Editar.Name = "btn_Editar";
            this.btn_Editar.Normalcolor = System.Drawing.Color.Purple;
            this.btn_Editar.OnHovercolor = System.Drawing.Color.Gray;
            this.btn_Editar.OnHoverTextColor = System.Drawing.Color.Purple;
            this.btn_Editar.selected = false;
            this.btn_Editar.Size = new System.Drawing.Size(161, 54);
            this.btn_Editar.TabIndex = 52;
            this.btn_Editar.Text = "EDITAR";
            this.btn_Editar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Editar.Textcolor = System.Drawing.Color.Black;
            this.btn_Editar.TextFont = new System.Drawing.Font("Showcard Gothic", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Editar.Click += new System.EventHandler(this.btn_Editar_Click);
            // 
            // txtDistancia
            // 
            this.txtDistancia.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDistancia.Location = new System.Drawing.Point(395, 82);
            this.txtDistancia.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.txtDistancia.Name = "txtDistancia";
            this.txtDistancia.Size = new System.Drawing.Size(157, 13);
            this.txtDistancia.TabIndex = 50;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox4.BackgroundImage")));
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox4.ErrorImage = null;
            this.pictureBox4.InitialImage = null;
            this.pictureBox4.Location = new System.Drawing.Point(383, 75);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(180, 31);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 49;
            this.pictureBox4.TabStop = false;
            // 
            // txtParadas
            // 
            this.txtParadas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtParadas.Location = new System.Drawing.Point(127, 82);
            this.txtParadas.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.txtParadas.Name = "txtParadas";
            this.txtParadas.Size = new System.Drawing.Size(157, 13);
            this.txtParadas.TabIndex = 47;
            // 
            // txtNombre
            // 
            this.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNombre.Location = new System.Drawing.Point(395, 29);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(157, 13);
            this.txtNombre.TabIndex = 46;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox5.BackgroundImage")));
            this.pictureBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox5.ErrorImage = null;
            this.pictureBox5.InitialImage = null;
            this.pictureBox5.Location = new System.Drawing.Point(115, 76);
            this.pictureBox5.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(180, 31);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 44;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.BackgroundImage")));
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.ErrorImage = null;
            this.pictureBox3.InitialImage = null;
            this.pictureBox3.Location = new System.Drawing.Point(383, 19);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(180, 31);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 43;
            this.pictureBox3.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Showcard Gothic", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(113, 58);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 17);
            this.label4.TabIndex = 41;
            this.label4.Text = "PARADAS";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Showcard Gothic", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(381, 56);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 17);
            this.label3.TabIndex = 40;
            this.label3.Text = "DISTANCIA";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Showcard Gothic", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(381, 1);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 17);
            this.label2.TabIndex = 39;
            this.label2.Text = "NOMBRE";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.Color.Gainsboro;
            this.dataGridView1.Location = new System.Drawing.Point(105, 117);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(468, 126);
            this.dataGridView1.TabIndex = 22;
            // 
            // MoverFormulario
            // 
            this.MoverFormulario.Fixed = true;
            this.MoverFormulario.Horizontal = true;
            this.MoverFormulario.TargetControl = this.TopFormulario;
            this.MoverFormulario.Vertical = true;
            // 
            // Administrar_Ruta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(689, 435);
            this.Controls.Add(this.Formulario);
            this.Controls.Add(this.TopFormulario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.Name = "Administrar_Ruta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Administrar_Ruta";
            this.Load += new System.EventHandler(this.Administrar_Ruta_Load);
            this.TopFormulario.ResumeLayout(false);
            this.TopFormulario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Cerrar)).EndInit();
            this.Formulario.ResumeLayout(false);
            this.Formulario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel TopFormulario;
        private System.Windows.Forms.Panel Formulario;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtDistancia;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.TextBox txtParadas;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox btn_Cerrar;
        private Bunifu.Framework.UI.BunifuFlatButton btn_Reset;
        private System.Windows.Forms.TextBox txt_ID;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.Label label7;
        private Bunifu.Framework.UI.BunifuFlatButton btn_Eliminar;
        private Bunifu.Framework.UI.BunifuFlatButton btn_Editar;
        private Bunifu.Framework.UI.BunifuDragControl MoverFormulario;
        private Bunifu.Framework.UI.BunifuFlatButton btnGuardar;
    }
}