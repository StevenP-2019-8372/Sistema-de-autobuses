﻿
namespace CapaPresentacion
{
    partial class Administrar_Choferes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Administrar_Choferes));
            this.TopFormulario = new System.Windows.Forms.Panel();
            this.btn_Cerrar = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dateFecha = new System.Windows.Forms.DateTimePicker();
            this.btn_Reset = new Bunifu.Framework.UI.BunifuFlatButton();
            this.txt_ID = new System.Windows.Forms.TextBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_Guardar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_Eliminar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_Editar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.txtCedula = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.MoverFormulario = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.TopFormulario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Cerrar)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
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
            this.btn_Cerrar.Location = new System.Drawing.Point(637, 11);
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
            this.label1.BackColor = System.Drawing.Color.Purple;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 15F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(224, 17);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(250, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "ADMINISTRAR CHOFERES";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.dateFecha);
            this.panel2.Controls.Add(this.btn_Reset);
            this.panel2.Controls.Add(this.txt_ID);
            this.panel2.Controls.Add(this.pictureBox8);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.btn_Guardar);
            this.panel2.Controls.Add(this.btn_Eliminar);
            this.panel2.Controls.Add(this.btn_Editar);
            this.panel2.Controls.Add(this.txtApellido);
            this.panel2.Controls.Add(this.pictureBox4);
            this.panel2.Controls.Add(this.txtCedula);
            this.panel2.Controls.Add(this.txtNombre);
            this.panel2.Controls.Add(this.pictureBox6);
            this.panel2.Controls.Add(this.pictureBox5);
            this.panel2.Controls.Add(this.pictureBox3);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 59);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(689, 418);
            this.panel2.TabIndex = 1;
            // 
            // dateFecha
            // 
            this.dateFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateFecha.Location = new System.Drawing.Point(489, 37);
            this.dateFecha.Margin = new System.Windows.Forms.Padding(2);
            this.dateFecha.Name = "dateFecha";
            this.dateFecha.Size = new System.Drawing.Size(158, 20);
            this.dateFecha.TabIndex = 49;
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
            this.btn_Reset.Location = new System.Drawing.Point(378, 274);
            this.btn_Reset.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.btn_Reset.Name = "btn_Reset";
            this.btn_Reset.Normalcolor = System.Drawing.Color.Purple;
            this.btn_Reset.OnHovercolor = System.Drawing.Color.Gray;
            this.btn_Reset.OnHoverTextColor = System.Drawing.Color.Purple;
            this.btn_Reset.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_Reset.selected = false;
            this.btn_Reset.Size = new System.Drawing.Size(161, 54);
            this.btn_Reset.TabIndex = 42;
            this.btn_Reset.Text = "RESET";
            this.btn_Reset.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Reset.Textcolor = System.Drawing.Color.Black;
            this.btn_Reset.TextFont = new System.Drawing.Font("Showcard Gothic", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Reset.Click += new System.EventHandler(this.btn_Reset_Click);
            // 
            // txt_ID
            // 
            this.txt_ID.BackColor = System.Drawing.SystemColors.Window;
            this.txt_ID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_ID.Location = new System.Drawing.Point(41, 38);
            this.txt_ID.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.txt_ID.Name = "txt_ID";
            this.txt_ID.ReadOnly = true;
            this.txt_ID.Size = new System.Drawing.Size(157, 13);
            this.txt_ID.TabIndex = 48;
            this.txt_ID.Text = "0";
            // 
            // pictureBox8
            // 
            this.pictureBox8.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox8.BackgroundImage")));
            this.pictureBox8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox8.ErrorImage = null;
            this.pictureBox8.InitialImage = null;
            this.pictureBox8.Location = new System.Drawing.Point(29, 29);
            this.pictureBox8.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(180, 31);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox8.TabIndex = 47;
            this.pictureBox8.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Showcard Gothic", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(26, 11);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(23, 17);
            this.label7.TabIndex = 46;
            this.label7.Text = "ID";
            // 
            // btn_Guardar
            // 
            this.btn_Guardar.Activecolor = System.Drawing.Color.Purple;
            this.btn_Guardar.BackColor = System.Drawing.Color.Purple;
            this.btn_Guardar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Guardar.BackgroundImage")));
            this.btn_Guardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_Guardar.BorderRadius = 0;
            this.btn_Guardar.ButtonText = "GUARDAR";
            this.btn_Guardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Guardar.DisabledColor = System.Drawing.Color.Gray;
            this.btn_Guardar.Font = new System.Drawing.Font("Showcard Gothic", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Guardar.ForeColor = System.Drawing.Color.Black;
            this.btn_Guardar.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_Guardar.Iconimage = null;
            this.btn_Guardar.Iconimage_right = null;
            this.btn_Guardar.Iconimage_right_Selected = null;
            this.btn_Guardar.Iconimage_Selected = null;
            this.btn_Guardar.IconMarginLeft = 0;
            this.btn_Guardar.IconMarginRight = 0;
            this.btn_Guardar.IconRightVisible = true;
            this.btn_Guardar.IconRightZoom = 0D;
            this.btn_Guardar.IconVisible = true;
            this.btn_Guardar.IconZoom = 60D;
            this.btn_Guardar.IsTab = false;
            this.btn_Guardar.Location = new System.Drawing.Point(117, 274);
            this.btn_Guardar.Name = "btn_Guardar";
            this.btn_Guardar.Normalcolor = System.Drawing.Color.Purple;
            this.btn_Guardar.OnHovercolor = System.Drawing.Color.Gray;
            this.btn_Guardar.OnHoverTextColor = System.Drawing.Color.Purple;
            this.btn_Guardar.selected = false;
            this.btn_Guardar.Size = new System.Drawing.Size(165, 54);
            this.btn_Guardar.TabIndex = 45;
            this.btn_Guardar.Text = "GUARDAR";
            this.btn_Guardar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Guardar.Textcolor = System.Drawing.Color.Black;
            this.btn_Guardar.TextFont = new System.Drawing.Font("Showcard Gothic", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Guardar.Click += new System.EventHandler(this.btn_Guardar_Click);
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
            this.btn_Eliminar.Location = new System.Drawing.Point(117, 356);
            this.btn_Eliminar.Name = "btn_Eliminar";
            this.btn_Eliminar.Normalcolor = System.Drawing.Color.Purple;
            this.btn_Eliminar.OnHovercolor = System.Drawing.Color.Gray;
            this.btn_Eliminar.OnHoverTextColor = System.Drawing.Color.Purple;
            this.btn_Eliminar.selected = false;
            this.btn_Eliminar.Size = new System.Drawing.Size(165, 54);
            this.btn_Eliminar.TabIndex = 44;
            this.btn_Eliminar.Text = "ELIMINAR";
            this.btn_Eliminar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.btn_Editar.Location = new System.Drawing.Point(378, 356);
            this.btn_Editar.Name = "btn_Editar";
            this.btn_Editar.Normalcolor = System.Drawing.Color.Purple;
            this.btn_Editar.OnHovercolor = System.Drawing.Color.Gray;
            this.btn_Editar.OnHoverTextColor = System.Drawing.Color.Purple;
            this.btn_Editar.selected = false;
            this.btn_Editar.Size = new System.Drawing.Size(161, 54);
            this.btn_Editar.TabIndex = 43;
            this.btn_Editar.Text = "EDITAR";
            this.btn_Editar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Editar.Textcolor = System.Drawing.Color.Black;
            this.btn_Editar.TextFont = new System.Drawing.Font("Showcard Gothic", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Editar.Click += new System.EventHandler(this.btn_Editar_Click);
            // 
            // txtApellido
            // 
            this.txtApellido.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtApellido.Location = new System.Drawing.Point(42, 93);
            this.txtApellido.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(157, 13);
            this.txtApellido.TabIndex = 21;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox4.BackgroundImage")));
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox4.ErrorImage = null;
            this.pictureBox4.InitialImage = null;
            this.pictureBox4.Location = new System.Drawing.Point(30, 86);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(180, 31);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 20;
            this.pictureBox4.TabStop = false;
            // 
            // txtCedula
            // 
            this.txtCedula.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCedula.Location = new System.Drawing.Point(269, 93);
            this.txtCedula.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.txtCedula.Name = "txtCedula";
            this.txtCedula.Size = new System.Drawing.Size(157, 13);
            this.txtCedula.TabIndex = 19;
            // 
            // txtNombre
            // 
            this.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNombre.Location = new System.Drawing.Point(269, 38);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(157, 13);
            this.txtNombre.TabIndex = 16;
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox6.BackgroundImage")));
            this.pictureBox6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox6.ErrorImage = null;
            this.pictureBox6.InitialImage = null;
            this.pictureBox6.Location = new System.Drawing.Point(257, 85);
            this.pictureBox6.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(180, 31);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 15;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox5.BackgroundImage")));
            this.pictureBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox5.ErrorImage = null;
            this.pictureBox5.InitialImage = null;
            this.pictureBox5.Location = new System.Drawing.Point(477, 29);
            this.pictureBox5.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(180, 31);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 14;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.BackgroundImage")));
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.ErrorImage = null;
            this.pictureBox3.InitialImage = null;
            this.pictureBox3.Location = new System.Drawing.Point(257, 28);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(180, 31);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 12;
            this.pictureBox3.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Showcard Gothic", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(253, 67);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "CEDULA";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Showcard Gothic", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(473, 11);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "FECHA_NACIMIENTO";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Showcard Gothic", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(26, 67);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "APELLIDO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Showcard Gothic", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(253, 11);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "NOMBRE";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.Color.Gainsboro;
            this.dataGridView1.Location = new System.Drawing.Point(53, 133);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(554, 132);
            this.dataGridView1.TabIndex = 0;
            // 
            // MoverFormulario
            // 
            this.MoverFormulario.Fixed = true;
            this.MoverFormulario.Horizontal = true;
            this.MoverFormulario.TargetControl = this.TopFormulario;
            this.MoverFormulario.Vertical = true;
            // 
            // Administrar_Choferes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(689, 477);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.TopFormulario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.Name = "Administrar_Choferes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Administrar_Choferes_Load);
            this.TopFormulario.ResumeLayout(false);
            this.TopFormulario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Cerrar)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel TopFormulario;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.TextBox txtCedula;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox btn_Cerrar;
        private Bunifu.Framework.UI.BunifuFlatButton btn_Reset;
        private System.Windows.Forms.TextBox txt_ID;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.Label label7;
        private Bunifu.Framework.UI.BunifuFlatButton btn_Guardar;
        private Bunifu.Framework.UI.BunifuFlatButton btn_Eliminar;
        private Bunifu.Framework.UI.BunifuFlatButton btn_Editar;
        private Bunifu.Framework.UI.BunifuDragControl MoverFormulario;
        private System.Windows.Forms.DateTimePicker dateFecha;
    }
}