//using System;

//namespace BlingLuxury
//{
//    partial class FrmProducto
//    {
//        /// <summary>
//        /// Required designer variable.
//        /// </summary>
//        private System.ComponentModel.IContainer components = null;

//        /// <summary>
//        /// Clean up any resources being used.
//        /// </summary>
//        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
//        protected override void Dispose(bool disposing)
//        {
//            if (disposing && (components != null))
//            {
//                components.Dispose();
//            }
//            base.Dispose(disposing);
//        }

//        #region Windows Form Designer generated code

//        /// <summary>
//        /// Required method for Designer support - do not modify
//        /// the contents of this method with the code editor.
//        /// </summary>
//        private void InitializeComponent()
//        {
//            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmProducto));
//            this.lblProducto = new System.Windows.Forms.Label();
//            this.flpProducto = new System.Windows.Forms.FlowLayoutPanel();
//            this.gbxProducto = new System.Windows.Forms.GroupBox();
//            this.btnPrecios = new System.Windows.Forms.Button();
//            this.cbxPrecios = new System.Windows.Forms.ComboBox();
//            this.pbxImagen = new System.Windows.Forms.PictureBox();
//            this.txtPeso = new System.Windows.Forms.TextBox();
//            this.lblPeso = new System.Windows.Forms.Label();
//            this.lblPrecio = new System.Windows.Forms.Label();
//            this.lblCodigoBarras = new System.Windows.Forms.Label();
//            this.txtCodigoBarras = new System.Windows.Forms.TextBox();
//            this.txtId = new System.Windows.Forms.TextBox();
//            this.lblId = new System.Windows.Forms.Label();
//            this.gbxProducto1 = new System.Windows.Forms.GroupBox();
//            this.btnMarca = new System.Windows.Forms.Button();
//            this.btnColor = new System.Windows.Forms.Button();
//            this.btnModelo = new System.Windows.Forms.Button();
//            this.btnCategoria = new System.Windows.Forms.Button();
//            this.lblMarca = new System.Windows.Forms.Label();
//            this.cbxColor = new System.Windows.Forms.ComboBox();
//            this.cbxMarca = new System.Windows.Forms.ComboBox();
//            this.lblColor = new System.Windows.Forms.Label();
//            this.lblCategoria = new System.Windows.Forms.Label();
//            this.lblModelo = new System.Windows.Forms.Label();
//            this.cbxCategoria = new System.Windows.Forms.ComboBox();
//            this.cbxModelo = new System.Windows.Forms.ComboBox();
//            this.dgvProducto = new System.Windows.Forms.DataGridView();
//            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
//            this.btnLimpiar = new System.Windows.Forms.Button();
//            this.btnAgregar = new System.Windows.Forms.Button();
//            this.btnModificar = new System.Windows.Forms.Button();
//            this.btnSalir = new System.Windows.Forms.Button();
//            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
//            this.groupBox1 = new System.Windows.Forms.GroupBox();
//            this.txtBuscar = new System.Windows.Forms.TextBox();
//            this.lblBuscar = new System.Windows.Forms.Label();
//            this.btnClose = new System.Windows.Forms.Button();
//            this.btnMin = new System.Windows.Forms.Button();
//            this.btnRestaurar = new System.Windows.Forms.Button();
//            this.flpProducto.SuspendLayout();
//            this.gbxProducto.SuspendLayout();
//            ((System.ComponentModel.ISupportInitialize)(this.pbxImagen)).BeginInit();
//            this.gbxProducto1.SuspendLayout();
//            ((System.ComponentModel.ISupportInitialize)(this.dgvProducto)).BeginInit();
//            this.flowLayoutPanel2.SuspendLayout();
//            this.flowLayoutPanel1.SuspendLayout();
//            this.groupBox1.SuspendLayout();
//            this.SuspendLayout();
//            // 
//            // lblProducto
//            // 
//            this.lblProducto.Anchor = System.Windows.Forms.AnchorStyles.Top;
//            this.lblProducto.AutoSize = true;
//            this.lblProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
//            this.lblProducto.ForeColor = System.Drawing.Color.White;
//            this.lblProducto.Location = new System.Drawing.Point(488, 13);
//            this.lblProducto.Name = "lblProducto";
//            this.lblProducto.Size = new System.Drawing.Size(118, 29);
//            this.lblProducto.TabIndex = 1;
//            this.lblProducto.Text = "Producto";
//            // 
//            // flpProducto
//            // 
//            this.flpProducto.BackColor = System.Drawing.Color.White;
//            this.flpProducto.Controls.Add(this.gbxProducto);
//            this.flpProducto.Controls.Add(this.gbxProducto1);
//            this.flpProducto.Location = new System.Drawing.Point(162, 45);
//            this.flpProducto.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
//            this.flpProducto.Name = "flpProducto";
//            this.flpProducto.Size = new System.Drawing.Size(886, 346);
//            this.flpProducto.TabIndex = 11;
//            // 
//            // gbxProducto
//            // 
//            this.gbxProducto.BackColor = System.Drawing.SystemColors.Window;
//            this.gbxProducto.Controls.Add(this.btnPrecios);
//            this.gbxProducto.Controls.Add(this.cbxPrecios);
//            this.gbxProducto.Controls.Add(this.pbxImagen);
//            this.gbxProducto.Controls.Add(this.txtPeso);
//            this.gbxProducto.Controls.Add(this.lblPeso);
//            this.gbxProducto.Controls.Add(this.lblPrecio);
//            this.gbxProducto.Controls.Add(this.lblCodigoBarras);
//            this.gbxProducto.Controls.Add(this.txtCodigoBarras);
//            this.gbxProducto.Controls.Add(this.txtId);
//            this.gbxProducto.Controls.Add(this.lblId);
//            this.gbxProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
//            this.gbxProducto.Location = new System.Drawing.Point(20, 9);
//            this.gbxProducto.Margin = new System.Windows.Forms.Padding(20, 9, 4, 3);
//            this.gbxProducto.Name = "gbxProducto";
//            this.gbxProducto.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
//            this.gbxProducto.Size = new System.Drawing.Size(644, 172);
//            this.gbxProducto.TabIndex = 7;
//            this.gbxProducto.TabStop = false;
//            // 
//            // btnPrecios
//            // 
//            this.btnPrecios.Location = new System.Drawing.Point(322, 124);
//            this.btnPrecios.Name = "btnPrecios";
//            this.btnPrecios.Size = new System.Drawing.Size(25, 25);
//            this.btnPrecios.TabIndex = 16;
//            this.btnPrecios.Text = "+";
//            this.btnPrecios.UseVisualStyleBackColor = true;
//            // 
//            // cbxPrecios
//            // 
//            this.cbxPrecios.BackColor = System.Drawing.SystemColors.ButtonHighlight;
//            this.cbxPrecios.FlatStyle = System.Windows.Forms.FlatStyle.System;
//            this.cbxPrecios.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
//            this.cbxPrecios.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(171)))));
//            this.cbxPrecios.FormattingEnabled = true;
//            this.cbxPrecios.Location = new System.Drawing.Point(155, 124);
//            this.cbxPrecios.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
//            this.cbxPrecios.Name = "cbxPrecios";
//            this.cbxPrecios.Size = new System.Drawing.Size(164, 24);
//            this.cbxPrecios.TabIndex = 17;
//            // 
//            // pbxImagen
//            // 
//            this.pbxImagen.Image = ((System.Drawing.Image)(resources.GetObject("pbxImagen.Image")));
//            this.pbxImagen.Location = new System.Drawing.Point(383, 16);
//            this.pbxImagen.Name = "pbxImagen";
//            this.pbxImagen.Size = new System.Drawing.Size(254, 145);
//            this.pbxImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
//            this.pbxImagen.TabIndex = 15;
//            this.pbxImagen.TabStop = false;
//            // 
//            // txtPeso
//            // 
//            this.txtPeso.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
//            this.txtPeso.Location = new System.Drawing.Point(154, 93);
//            this.txtPeso.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
//            this.txtPeso.Name = "txtPeso";
//            this.txtPeso.Size = new System.Drawing.Size(165, 22);
//            this.txtPeso.TabIndex = 3;
//            this.txtPeso.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPeso_KeyPress);
//            // 
//            // lblPeso
//            // 
//            this.lblPeso.AutoSize = true;
//            this.lblPeso.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
//            this.lblPeso.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(24)))), ((int)(((byte)(131)))));
//            this.lblPeso.Location = new System.Drawing.Point(54, 95);
//            this.lblPeso.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
//            this.lblPeso.Name = "lblPeso";
//            this.lblPeso.Size = new System.Drawing.Size(93, 18);
//            this.lblPeso.TabIndex = 7;
//            this.lblPeso.Text = "Peso (KG):";
//            // 
//            // lblPrecio
//            // 
//            this.lblPrecio.AutoSize = true;
//            this.lblPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
//            this.lblPrecio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(24)))), ((int)(((byte)(131)))));
//            this.lblPrecio.Location = new System.Drawing.Point(59, 127);
//            this.lblPrecio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
//            this.lblPrecio.Name = "lblPrecio";
//            this.lblPrecio.Size = new System.Drawing.Size(88, 18);
//            this.lblPrecio.TabIndex = 5;
//            this.lblPrecio.Text = "Precio ($):";
//            // 
//            // lblCodigoBarras
//            // 
//            this.lblCodigoBarras.AutoSize = true;
//            this.lblCodigoBarras.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
//            this.lblCodigoBarras.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(24)))), ((int)(((byte)(131)))));
//            this.lblCodigoBarras.Location = new System.Drawing.Point(2, 58);
//            this.lblCodigoBarras.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
//            this.lblCodigoBarras.Name = "lblCodigoBarras";
//            this.lblCodigoBarras.Size = new System.Drawing.Size(145, 18);
//            this.lblCodigoBarras.TabIndex = 5;
//            this.lblCodigoBarras.Text = "Código de Barras:";
//            // 
//            // txtCodigoBarras
//            // 
//            this.txtCodigoBarras.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
//            this.txtCodigoBarras.Location = new System.Drawing.Point(154, 57);
//            this.txtCodigoBarras.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
//            this.txtCodigoBarras.MaxLength = 13;
//            this.txtCodigoBarras.Name = "txtCodigoBarras";
//            this.txtCodigoBarras.Size = new System.Drawing.Size(165, 22);
//            this.txtCodigoBarras.TabIndex = 2;
//            this.txtCodigoBarras.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodigoBarras_KeyPress_1);
//            // 
//            // txtId
//            // 
//            this.txtId.Location = new System.Drawing.Point(154, 23);
//            this.txtId.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
//            this.txtId.Name = "txtId";
//            this.txtId.Size = new System.Drawing.Size(165, 20);
//            this.txtId.TabIndex = 1;
//            this.txtId.Visible = false;
//            // 
//            // lblId
//            // 
//            this.lblId.AutoSize = true;
//            this.lblId.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
//            this.lblId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(24)))), ((int)(((byte)(131)))));
//            this.lblId.Location = new System.Drawing.Point(121, 24);
//            this.lblId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
//            this.lblId.Name = "lblId";
//            this.lblId.Size = new System.Drawing.Size(26, 18);
//            this.lblId.TabIndex = 13;
//            this.lblId.Text = "Id:";
//            this.lblId.Visible = false;
//            // 
//            // gbxProducto1
//            // 
//            this.gbxProducto1.Controls.Add(this.btnMarca);
//            this.gbxProducto1.Controls.Add(this.btnColor);
//            this.gbxProducto1.Controls.Add(this.btnModelo);
//            this.gbxProducto1.Controls.Add(this.btnCategoria);
//            this.gbxProducto1.Controls.Add(this.lblMarca);
//            this.gbxProducto1.Controls.Add(this.cbxColor);
//            this.gbxProducto1.Controls.Add(this.cbxMarca);
//            this.gbxProducto1.Controls.Add(this.lblColor);
//            this.gbxProducto1.Controls.Add(this.lblCategoria);
//            this.gbxProducto1.Controls.Add(this.lblModelo);
//            this.gbxProducto1.Controls.Add(this.cbxCategoria);
//            this.gbxProducto1.Controls.Add(this.cbxModelo);
//            this.gbxProducto1.Location = new System.Drawing.Point(20, 187);
//            this.gbxProducto1.Margin = new System.Windows.Forms.Padding(20, 3, 4, 3);
//            this.gbxProducto1.Name = "gbxProducto1";
//            this.gbxProducto1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
//            this.gbxProducto1.Size = new System.Drawing.Size(644, 132);
//            this.gbxProducto1.TabIndex = 8;
//            this.gbxProducto1.TabStop = false;
//            // 
//            // btnMarca
//            // 
//            this.btnMarca.Location = new System.Drawing.Point(583, 31);
//            this.btnMarca.Name = "btnMarca";
//            this.btnMarca.Size = new System.Drawing.Size(25, 25);
//            this.btnMarca.TabIndex = 15;
//            this.btnMarca.Text = "+";
//            this.btnMarca.UseVisualStyleBackColor = true;
//            this.btnMarca.Click += new System.EventHandler(this.btnMarca_Click);
//            // 
//            // btnColor
//            // 
//            this.btnColor.Location = new System.Drawing.Point(584, 73);
//            this.btnColor.Name = "btnColor";
//            this.btnColor.Size = new System.Drawing.Size(25, 25);
//            this.btnColor.TabIndex = 14;
//            this.btnColor.Text = "+";
//            this.btnColor.UseVisualStyleBackColor = true;
//            this.btnColor.Click += new System.EventHandler(this.btnColor_Click);
//            // 
//            // btnModelo
//            // 
//            this.btnModelo.Location = new System.Drawing.Point(295, 74);
//            this.btnModelo.Name = "btnModelo";
//            this.btnModelo.Size = new System.Drawing.Size(25, 25);
//            this.btnModelo.TabIndex = 13;
//            this.btnModelo.Text = "+";
//            this.btnModelo.UseVisualStyleBackColor = true;
//            this.btnModelo.Click += new System.EventHandler(this.btnModelo_Click);
//            // 
//            // btnCategoria
//            // 
//            this.btnCategoria.Location = new System.Drawing.Point(295, 32);
//            this.btnCategoria.Name = "btnCategoria";
//            this.btnCategoria.Size = new System.Drawing.Size(25, 25);
//            this.btnCategoria.TabIndex = 12;
//            this.btnCategoria.Text = "+";
//            this.btnCategoria.UseVisualStyleBackColor = true;
//            this.btnCategoria.Click += new System.EventHandler(this.btnCategoria_Click);
//            // 
//            // lblMarca
//            // 
//            this.lblMarca.AutoSize = true;
//            this.lblMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
//            this.lblMarca.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(24)))), ((int)(((byte)(131)))));
//            this.lblMarca.Location = new System.Drawing.Point(360, 35);
//            this.lblMarca.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
//            this.lblMarca.Name = "lblMarca";
//            this.lblMarca.Size = new System.Drawing.Size(60, 18);
//            this.lblMarca.TabIndex = 11;
//            this.lblMarca.Text = "Marca:";
//            // 
//            // cbxColor
//            // 
//            this.cbxColor.BackColor = System.Drawing.SystemColors.ButtonHighlight;
//            this.cbxColor.FlatStyle = System.Windows.Forms.FlatStyle.System;
//            this.cbxColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
//            this.cbxColor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(171)))));
//            this.cbxColor.FormattingEnabled = true;
//            this.cbxColor.Location = new System.Drawing.Point(423, 74);
//            this.cbxColor.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
//            this.cbxColor.Name = "cbxColor";
//            this.cbxColor.Size = new System.Drawing.Size(157, 24);
//            this.cbxColor.TabIndex = 8;
//            // 
//            // cbxMarca
//            // 
//            this.cbxMarca.BackColor = System.Drawing.SystemColors.ButtonHighlight;
//            this.cbxMarca.FlatStyle = System.Windows.Forms.FlatStyle.System;
//            this.cbxMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
//            this.cbxMarca.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(171)))));
//            this.cbxMarca.FormattingEnabled = true;
//            this.cbxMarca.Location = new System.Drawing.Point(423, 32);
//            this.cbxMarca.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
//            this.cbxMarca.Name = "cbxMarca";
//            this.cbxMarca.Size = new System.Drawing.Size(157, 24);
//            this.cbxMarca.TabIndex = 7;
//            // 
//            // lblColor
//            // 
//            this.lblColor.AutoSize = true;
//            this.lblColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
//            this.lblColor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(24)))), ((int)(((byte)(131)))));
//            this.lblColor.Location = new System.Drawing.Point(365, 77);
//            this.lblColor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
//            this.lblColor.Name = "lblColor";
//            this.lblColor.Size = new System.Drawing.Size(55, 18);
//            this.lblColor.TabIndex = 7;
//            this.lblColor.Text = "Color:";
//            // 
//            // lblCategoria
//            // 
//            this.lblCategoria.AutoSize = true;
//            this.lblCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
//            this.lblCategoria.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(24)))), ((int)(((byte)(131)))));
//            this.lblCategoria.Location = new System.Drawing.Point(9, 35);
//            this.lblCategoria.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
//            this.lblCategoria.Name = "lblCategoria";
//            this.lblCategoria.Size = new System.Drawing.Size(86, 18);
//            this.lblCategoria.TabIndex = 2;
//            this.lblCategoria.Text = "Categoria:";
//            // 
//            // lblModelo
//            // 
//            this.lblModelo.AutoSize = true;
//            this.lblModelo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
//            this.lblModelo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(24)))), ((int)(((byte)(131)))));
//            this.lblModelo.Location = new System.Drawing.Point(26, 77);
//            this.lblModelo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
//            this.lblModelo.Name = "lblModelo";
//            this.lblModelo.Size = new System.Drawing.Size(69, 18);
//            this.lblModelo.TabIndex = 9;
//            this.lblModelo.Text = "Modelo:";
//            // 
//            // cbxCategoria
//            // 
//            this.cbxCategoria.BackColor = System.Drawing.SystemColors.ButtonHighlight;
//            this.cbxCategoria.FlatStyle = System.Windows.Forms.FlatStyle.System;
//            this.cbxCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
//            this.cbxCategoria.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(171)))));
//            this.cbxCategoria.FormattingEnabled = true;
//            this.cbxCategoria.Location = new System.Drawing.Point(100, 32);
//            this.cbxCategoria.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
//            this.cbxCategoria.Name = "cbxCategoria";
//            this.cbxCategoria.Size = new System.Drawing.Size(192, 24);
//            this.cbxCategoria.TabIndex = 5;
//            this.cbxCategoria.SelectedIndexChanged += new System.EventHandler(this.cbxCategoria_SelectedIndexChanged);
//            // 
//            // cbxModelo
//            // 
//            this.cbxModelo.BackColor = System.Drawing.SystemColors.ButtonHighlight;
//            this.cbxModelo.FlatStyle = System.Windows.Forms.FlatStyle.System;
//            this.cbxModelo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
//            this.cbxModelo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(171)))));
//            this.cbxModelo.FormattingEnabled = true;
//            this.cbxModelo.Location = new System.Drawing.Point(100, 74);
//            this.cbxModelo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
//            this.cbxModelo.Name = "cbxModelo";
//            this.cbxModelo.Size = new System.Drawing.Size(192, 24);
//            this.cbxModelo.TabIndex = 6;
//            // 
//            // dgvProducto
//            // 
//            this.dgvProducto.AllowUserToAddRows = false;
//            this.dgvProducto.AllowUserToDeleteRows = false;
//            this.dgvProducto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
//            this.dgvProducto.Dock = System.Windows.Forms.DockStyle.Fill;
//            this.dgvProducto.Location = new System.Drawing.Point(3, 16);
//            this.dgvProducto.Name = "dgvProducto";
//            this.dgvProducto.ReadOnly = true;
//            this.dgvProducto.Size = new System.Drawing.Size(877, 211);
//            this.dgvProducto.StandardTab = true;
//            this.dgvProducto.TabIndex = 9;
//            this.dgvProducto.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProducto_CellContentClick);
//            // 
//            // flowLayoutPanel2
//            // 
//            this.flowLayoutPanel2.Controls.Add(this.btnLimpiar);
//            this.flowLayoutPanel2.Controls.Add(this.btnAgregar);
//            this.flowLayoutPanel2.Controls.Add(this.btnModificar);
//            this.flowLayoutPanel2.Controls.Add(this.btnSalir);
//            this.flowLayoutPanel2.Location = new System.Drawing.Point(22, 181);
//            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
//            this.flowLayoutPanel2.Size = new System.Drawing.Size(121, 183);
//            this.flowLayoutPanel2.TabIndex = 16;
//            // 
//            // btnLimpiar
//            // 
//            this.btnLimpiar.BackColor = System.Drawing.Color.Transparent;
//            this.btnLimpiar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLimpiar.BackgroundImage")));
//            this.btnLimpiar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
//            this.btnLimpiar.Cursor = System.Windows.Forms.Cursors.Hand;
//            this.btnLimpiar.FlatAppearance.BorderColor = System.Drawing.Color.Cyan;
//            this.btnLimpiar.FlatAppearance.BorderSize = 0;
//            this.btnLimpiar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
//            this.btnLimpiar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
//            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
//            this.btnLimpiar.Location = new System.Drawing.Point(0, 6);
//            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(0, 6, 0, 6);
//            this.btnLimpiar.Name = "btnLimpiar";
//            this.btnLimpiar.Padding = new System.Windows.Forms.Padding(0, 6, 0, 0);
//            this.btnLimpiar.Size = new System.Drawing.Size(114, 33);
//            this.btnLimpiar.TabIndex = 10;
//            this.btnLimpiar.UseVisualStyleBackColor = false;
//            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click_1);
//            // 
//            // btnAgregar
//            // 
//            this.btnAgregar.BackColor = System.Drawing.Color.Transparent;
//            this.btnAgregar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAgregar.BackgroundImage")));
//            this.btnAgregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
//            this.btnAgregar.Cursor = System.Windows.Forms.Cursors.Hand;
//            this.btnAgregar.FlatAppearance.BorderColor = System.Drawing.Color.Cyan;
//            this.btnAgregar.FlatAppearance.BorderSize = 0;
//            this.btnAgregar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
//            this.btnAgregar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
//            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
//            this.btnAgregar.Location = new System.Drawing.Point(0, 51);
//            this.btnAgregar.Margin = new System.Windows.Forms.Padding(0, 6, 0, 6);
//            this.btnAgregar.Name = "btnAgregar";
//            this.btnAgregar.Padding = new System.Windows.Forms.Padding(0, 6, 0, 0);
//            this.btnAgregar.Size = new System.Drawing.Size(114, 33);
//            this.btnAgregar.TabIndex = 11;
//            this.btnAgregar.UseVisualStyleBackColor = false;
//            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click_1);
//            // 
//            // btnModificar
//            // 
//            this.btnModificar.BackColor = System.Drawing.Color.Transparent;
//            this.btnModificar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnModificar.BackgroundImage")));
//            this.btnModificar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
//            this.btnModificar.Cursor = System.Windows.Forms.Cursors.Hand;
//            this.btnModificar.FlatAppearance.BorderColor = System.Drawing.Color.Cyan;
//            this.btnModificar.FlatAppearance.BorderSize = 0;
//            this.btnModificar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
//            this.btnModificar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
//            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
//            this.btnModificar.Location = new System.Drawing.Point(0, 96);
//            this.btnModificar.Margin = new System.Windows.Forms.Padding(0, 6, 0, 6);
//            this.btnModificar.Name = "btnModificar";
//            this.btnModificar.Padding = new System.Windows.Forms.Padding(0, 6, 0, 0);
//            this.btnModificar.Size = new System.Drawing.Size(114, 33);
//            this.btnModificar.TabIndex = 12;
//            this.btnModificar.UseVisualStyleBackColor = false;
//            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
//            // 
//            // btnSalir
//            // 
//            this.btnSalir.BackColor = System.Drawing.Color.Transparent;
//            this.btnSalir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSalir.BackgroundImage")));
//            this.btnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
//            this.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand;
//            this.btnSalir.FlatAppearance.BorderColor = System.Drawing.Color.Cyan;
//            this.btnSalir.FlatAppearance.BorderSize = 0;
//            this.btnSalir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
//            this.btnSalir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
//            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
//            this.btnSalir.Location = new System.Drawing.Point(0, 141);
//            this.btnSalir.Margin = new System.Windows.Forms.Padding(0, 6, 0, 6);
//            this.btnSalir.Name = "btnSalir";
//            this.btnSalir.Padding = new System.Windows.Forms.Padding(0, 6, 0, 0);
//            this.btnSalir.Size = new System.Drawing.Size(114, 33);
//            this.btnSalir.TabIndex = 13;
//            this.btnSalir.UseVisualStyleBackColor = false;
//            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click_1);
//            // 
//            // flowLayoutPanel1
//            // 
//            this.flowLayoutPanel1.BackColor = System.Drawing.Color.White;
//            this.flowLayoutPanel1.Controls.Add(this.groupBox1);
//            this.flowLayoutPanel1.Location = new System.Drawing.Point(162, 425);
//            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
//            this.flowLayoutPanel1.Size = new System.Drawing.Size(886, 233);
//            this.flowLayoutPanel1.TabIndex = 17;
//            // 
//            // groupBox1
//            // 
//            this.groupBox1.Controls.Add(this.dgvProducto);
//            this.groupBox1.Location = new System.Drawing.Point(3, 3);
//            this.groupBox1.Name = "groupBox1";
//            this.groupBox1.Size = new System.Drawing.Size(883, 230);
//            this.groupBox1.TabIndex = 0;
//            this.groupBox1.TabStop = false;
//            // 
//            // txtBuscar
//            // 
//            this.txtBuscar.Location = new System.Drawing.Point(229, 397);
//            this.txtBuscar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
//            this.txtBuscar.Name = "txtBuscar";
//            this.txtBuscar.Size = new System.Drawing.Size(165, 20);
//            this.txtBuscar.TabIndex = 18;
//            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
//            this.txtBuscar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBuscar_KeyPress);
//            // 
//            // lblBuscar
//            // 
//            this.lblBuscar.AutoSize = true;
//            this.lblBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
//            this.lblBuscar.ForeColor = System.Drawing.Color.White;
//            this.lblBuscar.Location = new System.Drawing.Point(162, 398);
//            this.lblBuscar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
//            this.lblBuscar.Name = "lblBuscar";
//            this.lblBuscar.Size = new System.Drawing.Size(66, 18);
//            this.lblBuscar.TabIndex = 19;
//            this.lblBuscar.Text = "Buscar:";
//            // 
//            // btnClose
//            // 
//            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
//            this.btnClose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnClose.BackgroundImage")));
//            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
//            this.btnClose.FlatAppearance.BorderSize = 0;
//            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
//            this.btnClose.ForeColor = System.Drawing.Color.Transparent;
//            this.btnClose.Location = new System.Drawing.Point(1033, 4);
//            this.btnClose.Name = "btnClose";
//            this.btnClose.Size = new System.Drawing.Size(36, 29);
//            this.btnClose.TabIndex = 20;
//            this.btnClose.UseVisualStyleBackColor = true;
//            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
//            // 
//            // btnMin
//            // 
//            this.btnMin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
//            this.btnMin.BackColor = System.Drawing.Color.Yellow;
//            this.btnMin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMin.BackgroundImage")));
//            this.btnMin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
//            this.btnMin.FlatAppearance.BorderSize = 0;
//            this.btnMin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
//            this.btnMin.ForeColor = System.Drawing.Color.Transparent;
//            this.btnMin.Location = new System.Drawing.Point(958, 4);
//            this.btnMin.Name = "btnMin";
//            this.btnMin.Size = new System.Drawing.Size(36, 29);
//            this.btnMin.TabIndex = 22;
//            this.btnMin.UseVisualStyleBackColor = false;
//            this.btnMin.Click += new System.EventHandler(this.btnMin_Click);
//            // 
//            // btnRestaurar
//            // 
//            this.btnRestaurar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
//            this.btnRestaurar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
//            this.btnRestaurar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRestaurar.BackgroundImage")));
//            this.btnRestaurar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
//            this.btnRestaurar.FlatAppearance.BorderSize = 0;
//            this.btnRestaurar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
//            this.btnRestaurar.ForeColor = System.Drawing.Color.Transparent;
//            this.btnRestaurar.Location = new System.Drawing.Point(994, 4);
//            this.btnRestaurar.Name = "btnRestaurar";
//            this.btnRestaurar.Size = new System.Drawing.Size(36, 29);
//            this.btnRestaurar.TabIndex = 23;
//            this.btnRestaurar.UseVisualStyleBackColor = false;
//            this.btnRestaurar.Click += new System.EventHandler(this.btnRestaurar_Click);
//            // 
//            // FrmProducto
//            // 
//            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
//            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
//            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(24)))), ((int)(((byte)(131)))));
//            this.ClientSize = new System.Drawing.Size(1074, 670);
//            this.Controls.Add(this.btnRestaurar);
//            this.Controls.Add(this.btnMin);
//            this.Controls.Add(this.btnClose);
//            this.Controls.Add(this.txtBuscar);
//            this.Controls.Add(this.lblBuscar);
//            this.Controls.Add(this.flowLayoutPanel1);
//            this.Controls.Add(this.flowLayoutPanel2);
//            this.Controls.Add(this.flpProducto);
//            this.Controls.Add(this.lblProducto);
//            this.ForeColor = System.Drawing.SystemColors.ControlText;
//            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
//            this.Name = "FrmProducto";
//            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
//            this.Text = "FrmProducto";           
//            this.flpProducto.ResumeLayout(false);
//            this.gbxProducto.ResumeLayout(false);
//            this.gbxProducto.PerformLayout();
//            ((System.ComponentModel.ISupportInitialize)(this.pbxImagen)).EndInit();
//            this.gbxProducto1.ResumeLayout(false);
//            this.gbxProducto1.PerformLayout();
//            ((System.ComponentModel.ISupportInitialize)(this.dgvProducto)).EndInit();
//            this.flowLayoutPanel2.ResumeLayout(false);
//            this.flowLayoutPanel1.ResumeLayout(false);
//            this.groupBox1.ResumeLayout(false);
//            this.ResumeLayout(false);
//            this.PerformLayout();

//        }

//        #endregion
//        private System.Windows.Forms.Label lblProducto;
//        private System.Windows.Forms.FlowLayoutPanel flpProducto;
//        private System.Windows.Forms.GroupBox gbxProducto;
//        private System.Windows.Forms.TextBox txtPeso;
//        private System.Windows.Forms.Label lblPeso;
//        private System.Windows.Forms.PictureBox pbxImagen;
//        private System.Windows.Forms.Label lblCodigoBarras;
//        private System.Windows.Forms.TextBox txtCodigoBarras;
//        private System.Windows.Forms.Label lblCategoria;
//        private System.Windows.Forms.ComboBox cbxCategoria;
//        private System.Windows.Forms.GroupBox gbxProducto1;
//        private System.Windows.Forms.ComboBox cbxColor;
//        private System.Windows.Forms.Label lblPrecio;
//        private System.Windows.Forms.Label lblColor;
//        private System.Windows.Forms.Label lblModelo;
//        private System.Windows.Forms.ComboBox cbxModelo;
//        private System.Windows.Forms.DataGridView dgvProducto;
//        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
//        private System.Windows.Forms.Button btnLimpiar;
//        private System.Windows.Forms.Button btnAgregar;
//        private System.Windows.Forms.Button btnModificar;
//        private System.Windows.Forms.Button btnSalir;
//        private System.Windows.Forms.TextBox txtId;
//        private System.Windows.Forms.Label lblId;
//        private System.Windows.Forms.Label lblMarca;
//        private System.Windows.Forms.ComboBox cbxMarca;
//        private System.Windows.Forms.ComboBox cbxPrecios;
//        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
//        private System.Windows.Forms.GroupBox groupBox1;
//        private System.Windows.Forms.TextBox txtBuscar;
//        private System.Windows.Forms.Label lblBuscar;
//        private System.Windows.Forms.Button btnClose;        
//        private System.Windows.Forms.Button btnMin;
//        private System.Windows.Forms.Button btnRestaurar;
//        private System.Windows.Forms.Button btnMarca;
//        private System.Windows.Forms.Button btnColor;
//        private System.Windows.Forms.Button btnModelo;
//        private System.Windows.Forms.Button btnCategoria;
//        private System.Windows.Forms.Button btnPrecios;
//    }
//}
using System;

namespace BlingLuxury
{
    partial class FrmProducto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmProducto));
            this.lblProducto = new System.Windows.Forms.Label();
            this.flpProducto = new System.Windows.Forms.FlowLayoutPanel();
            this.gbxProducto = new System.Windows.Forms.GroupBox();
            this.btnPrecios = new System.Windows.Forms.Button();
            this.cbxPrecios = new System.Windows.Forms.ComboBox();
            this.txtPeso = new System.Windows.Forms.TextBox();
            this.lblPeso = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.pbxImagen = new System.Windows.Forms.PictureBox();
            this.lblCodigoBarras = new System.Windows.Forms.Label();
            this.txtCodigoBarras = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.lblId = new System.Windows.Forms.Label();
            this.gbxProducto1 = new System.Windows.Forms.GroupBox();
            this.btnMarca = new System.Windows.Forms.Button();
            this.btnColor = new System.Windows.Forms.Button();
            this.btnModelo = new System.Windows.Forms.Button();
            this.btnCategoria = new System.Windows.Forms.Button();
            this.lblMarca = new System.Windows.Forms.Label();
            this.cbxColor = new System.Windows.Forms.ComboBox();
            this.cbxMarca = new System.Windows.Forms.ComboBox();
            this.lblColor = new System.Windows.Forms.Label();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.lblModelo = new System.Windows.Forms.Label();
            this.cbxCategoria = new System.Windows.Forms.ComboBox();
            this.cbxModelo = new System.Windows.Forms.ComboBox();
            this.dgvProducto = new System.Windows.Forms.DataGridView();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.lblBuscar = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnMin = new System.Windows.Forms.Button();
            this.btnRestaurar = new System.Windows.Forms.Button();
            this.flpProducto.SuspendLayout();
            this.gbxProducto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxImagen)).BeginInit();
            this.gbxProducto1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducto)).BeginInit();
            this.flowLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblProducto
            // 
            this.lblProducto.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblProducto.AutoSize = true;
            this.lblProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProducto.ForeColor = System.Drawing.Color.White;
            this.lblProducto.Location = new System.Drawing.Point(488, 13);
            this.lblProducto.Name = "lblProducto";
            this.lblProducto.Size = new System.Drawing.Size(118, 29);
            this.lblProducto.TabIndex = 1;
            this.lblProducto.Text = "Producto";
            // 
            // flpProducto
            // 
            this.flpProducto.BackColor = System.Drawing.Color.White;
            this.flpProducto.Controls.Add(this.gbxProducto);
            this.flpProducto.Controls.Add(this.gbxProducto1);
            this.flpProducto.Location = new System.Drawing.Point(162, 45);
            this.flpProducto.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.flpProducto.Name = "flpProducto";
            this.flpProducto.Size = new System.Drawing.Size(886, 346);
            this.flpProducto.TabIndex = 11;
            // 
            // gbxProducto
            // 
            this.gbxProducto.BackColor = System.Drawing.SystemColors.Window;
            this.gbxProducto.Controls.Add(this.btnPrecios);
            this.gbxProducto.Controls.Add(this.cbxPrecios);
            this.gbxProducto.Controls.Add(this.pbxImagen);
            this.gbxProducto.Controls.Add(this.txtPeso);
            this.gbxProducto.Controls.Add(this.lblPeso);
            this.gbxProducto.Controls.Add(this.lblPrecio);
            this.gbxProducto.Controls.Add(this.lblCodigoBarras);
            this.gbxProducto.Controls.Add(this.txtCodigoBarras);
            this.gbxProducto.Controls.Add(this.txtId);
            this.gbxProducto.Controls.Add(this.lblId);
            this.gbxProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbxProducto.Location = new System.Drawing.Point(20, 9);
            this.gbxProducto.Margin = new System.Windows.Forms.Padding(20, 9, 4, 3);
            this.gbxProducto.Name = "gbxProducto";
            this.gbxProducto.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gbxProducto.Size = new System.Drawing.Size(644, 172);
            this.gbxProducto.TabIndex = 7;
            this.gbxProducto.TabStop = false;
            // 
            // btnPrecios
            // 
            this.btnPrecios.Location = new System.Drawing.Point(322, 124);
            this.btnPrecios.Name = "btnPrecios";
            this.btnPrecios.Size = new System.Drawing.Size(25, 25);
            this.btnPrecios.TabIndex = 16;
            this.btnPrecios.Text = "+";
            this.btnPrecios.UseVisualStyleBackColor = true;
            // 
            // cbxPrecios
            // 
            this.cbxPrecios.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cbxPrecios.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cbxPrecios.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxPrecios.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(171)))));
            this.cbxPrecios.FormattingEnabled = true;
            this.cbxPrecios.Location = new System.Drawing.Point(155, 124);
            this.cbxPrecios.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cbxPrecios.Name = "cbxPrecios";
            this.cbxPrecios.Size = new System.Drawing.Size(164, 24);
            this.cbxPrecios.TabIndex = 17;
            // 
            // txtPeso
            // 
            this.txtPeso.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPeso.Location = new System.Drawing.Point(154, 93);
            this.txtPeso.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtPeso.Name = "txtPeso";
            this.txtPeso.Size = new System.Drawing.Size(165, 22);
            this.txtPeso.TabIndex = 3;
            this.txtPeso.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPeso_KeyPress);
            // 
            // lblPeso
            // 
            this.lblPeso.AutoSize = true;
            this.lblPeso.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPeso.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(24)))), ((int)(((byte)(131)))));
            this.lblPeso.Location = new System.Drawing.Point(54, 95);
            this.lblPeso.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPeso.Name = "lblPeso";
            this.lblPeso.Size = new System.Drawing.Size(93, 18);
            this.lblPeso.TabIndex = 7;
            this.lblPeso.Text = "Peso (KG):";
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(24)))), ((int)(((byte)(131)))));
            this.lblPrecio.Location = new System.Drawing.Point(59, 127);
            this.lblPrecio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(88, 18);
            this.lblPrecio.TabIndex = 5;
            this.lblPrecio.Text = "Precio ($):";
            // 
            // pbxImagen
            // 
            this.pbxImagen.Image = ((System.Drawing.Image)(resources.GetObject("pbxImagen.Image")));
            this.pbxImagen.Location = new System.Drawing.Point(383, 16);
            this.pbxImagen.Name = "pbxImagen";
            this.pbxImagen.Size = new System.Drawing.Size(254, 145);
            this.pbxImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxImagen.TabIndex = 15;
            this.pbxImagen.TabStop = false;
            // 
            // lblCodigoBarras
            // 
            this.lblCodigoBarras.AutoSize = true;
            this.lblCodigoBarras.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigoBarras.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(24)))), ((int)(((byte)(131)))));
            this.lblCodigoBarras.Location = new System.Drawing.Point(2, 58);
            this.lblCodigoBarras.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCodigoBarras.Name = "lblCodigoBarras";
            this.lblCodigoBarras.Size = new System.Drawing.Size(145, 18);
            this.lblCodigoBarras.TabIndex = 5;
            this.lblCodigoBarras.Text = "Código de Barras:";
            // 
            // txtCodigoBarras
            // 
            this.txtCodigoBarras.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigoBarras.Location = new System.Drawing.Point(154, 57);
            this.txtCodigoBarras.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtCodigoBarras.MaxLength = 13;
            this.txtCodigoBarras.Name = "txtCodigoBarras";
            this.txtCodigoBarras.Size = new System.Drawing.Size(165, 22);
            this.txtCodigoBarras.TabIndex = 2;
            this.txtCodigoBarras.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodigoBarras_KeyPress_1);
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(154, 23);
            this.txtId.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(165, 20);
            this.txtId.TabIndex = 1;
            this.txtId.Visible = false;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(24)))), ((int)(((byte)(131)))));
            this.lblId.Location = new System.Drawing.Point(121, 24);
            this.lblId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(26, 18);
            this.lblId.TabIndex = 13;
            this.lblId.Text = "Id:";
            this.lblId.Visible = false;
            // 
            // gbxProducto1
            // 
            this.gbxProducto1.Controls.Add(this.btnMarca);
            this.gbxProducto1.Controls.Add(this.btnColor);
            this.gbxProducto1.Controls.Add(this.btnModelo);
            this.gbxProducto1.Controls.Add(this.btnCategoria);
            this.gbxProducto1.Controls.Add(this.lblMarca);
            this.gbxProducto1.Controls.Add(this.cbxColor);
            this.gbxProducto1.Controls.Add(this.cbxMarca);
            this.gbxProducto1.Controls.Add(this.lblColor);
            this.gbxProducto1.Controls.Add(this.lblCategoria);
            this.gbxProducto1.Controls.Add(this.lblModelo);
            this.gbxProducto1.Controls.Add(this.cbxCategoria);
            this.gbxProducto1.Controls.Add(this.cbxModelo);
            this.gbxProducto1.Location = new System.Drawing.Point(20, 187);
            this.gbxProducto1.Margin = new System.Windows.Forms.Padding(20, 3, 4, 3);
            this.gbxProducto1.Name = "gbxProducto1";
            this.gbxProducto1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gbxProducto1.Size = new System.Drawing.Size(644, 132);
            this.gbxProducto1.TabIndex = 8;
            this.gbxProducto1.TabStop = false;
            // 
            // btnMarca
            // 
            this.btnMarca.Location = new System.Drawing.Point(583, 31);
            this.btnMarca.Name = "btnMarca";
            this.btnMarca.Size = new System.Drawing.Size(25, 25);
            this.btnMarca.TabIndex = 15;
            this.btnMarca.Text = "+";
            this.btnMarca.UseVisualStyleBackColor = true;
            this.btnMarca.Click += new System.EventHandler(this.btnMarca_Click);
            // 
            // btnColor
            // 
            this.btnColor.Location = new System.Drawing.Point(584, 73);
            this.btnColor.Name = "btnColor";
            this.btnColor.Size = new System.Drawing.Size(25, 25);
            this.btnColor.TabIndex = 14;
            this.btnColor.Text = "+";
            this.btnColor.UseVisualStyleBackColor = true;
            this.btnColor.Click += new System.EventHandler(this.btnColor_Click);
            // 
            // btnModelo
            // 
            this.btnModelo.Location = new System.Drawing.Point(295, 74);
            this.btnModelo.Name = "btnModelo";
            this.btnModelo.Size = new System.Drawing.Size(25, 25);
            this.btnModelo.TabIndex = 13;
            this.btnModelo.Text = "+";
            this.btnModelo.UseVisualStyleBackColor = true;
            this.btnModelo.Click += new System.EventHandler(this.btnModelo_Click);
            // 
            // btnCategoria
            // 
            this.btnCategoria.Location = new System.Drawing.Point(295, 32);
            this.btnCategoria.Name = "btnCategoria";
            this.btnCategoria.Size = new System.Drawing.Size(25, 25);
            this.btnCategoria.TabIndex = 12;
            this.btnCategoria.Text = "+";
            this.btnCategoria.UseVisualStyleBackColor = true;
            this.btnCategoria.Click += new System.EventHandler(this.btnCategoria_Click);
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMarca.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(24)))), ((int)(((byte)(131)))));
            this.lblMarca.Location = new System.Drawing.Point(360, 35);
            this.lblMarca.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(60, 18);
            this.lblMarca.TabIndex = 11;
            this.lblMarca.Text = "Marca:";
            // 
            // cbxColor
            // 
            this.cbxColor.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cbxColor.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cbxColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxColor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(171)))));
            this.cbxColor.FormattingEnabled = true;
            this.cbxColor.Location = new System.Drawing.Point(423, 74);
            this.cbxColor.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cbxColor.Name = "cbxColor";
            this.cbxColor.Size = new System.Drawing.Size(157, 24);
            this.cbxColor.TabIndex = 8;
            // 
            // cbxMarca
            // 
            this.cbxMarca.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cbxMarca.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cbxMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxMarca.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(171)))));
            this.cbxMarca.FormattingEnabled = true;
            this.cbxMarca.Location = new System.Drawing.Point(423, 32);
            this.cbxMarca.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cbxMarca.Name = "cbxMarca";
            this.cbxMarca.Size = new System.Drawing.Size(157, 24);
            this.cbxMarca.TabIndex = 7;
            // 
            // lblColor
            // 
            this.lblColor.AutoSize = true;
            this.lblColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblColor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(24)))), ((int)(((byte)(131)))));
            this.lblColor.Location = new System.Drawing.Point(365, 77);
            this.lblColor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(55, 18);
            this.lblColor.TabIndex = 7;
            this.lblColor.Text = "Color:";
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoria.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(24)))), ((int)(((byte)(131)))));
            this.lblCategoria.Location = new System.Drawing.Point(9, 35);
            this.lblCategoria.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(86, 18);
            this.lblCategoria.TabIndex = 2;
            this.lblCategoria.Text = "Categoria:";
            // 
            // lblModelo
            // 
            this.lblModelo.AutoSize = true;
            this.lblModelo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModelo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(24)))), ((int)(((byte)(131)))));
            this.lblModelo.Location = new System.Drawing.Point(26, 77);
            this.lblModelo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblModelo.Name = "lblModelo";
            this.lblModelo.Size = new System.Drawing.Size(69, 18);
            this.lblModelo.TabIndex = 9;
            this.lblModelo.Text = "Modelo:";
            // 
            // cbxCategoria
            // 
            this.cbxCategoria.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cbxCategoria.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cbxCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxCategoria.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(171)))));
            this.cbxCategoria.FormattingEnabled = true;
            this.cbxCategoria.Location = new System.Drawing.Point(100, 32);
            this.cbxCategoria.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cbxCategoria.Name = "cbxCategoria";
            this.cbxCategoria.Size = new System.Drawing.Size(192, 24);
            this.cbxCategoria.TabIndex = 5;
            this.cbxCategoria.SelectedIndexChanged += new System.EventHandler(this.cbxCategoria_SelectedIndexChanged);
            // 
            // cbxModelo
            // 
            this.cbxModelo.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cbxModelo.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cbxModelo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxModelo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(171)))));
            this.cbxModelo.FormattingEnabled = true;
            this.cbxModelo.Location = new System.Drawing.Point(100, 74);
            this.cbxModelo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cbxModelo.Name = "cbxModelo";
            this.cbxModelo.Size = new System.Drawing.Size(192, 24);
            this.cbxModelo.TabIndex = 6;
            // 
            // dgvProducto
            // 
            this.dgvProducto.AllowUserToAddRows = false;
            this.dgvProducto.AllowUserToDeleteRows = false;
            this.dgvProducto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProducto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvProducto.Location = new System.Drawing.Point(3, 16);
            this.dgvProducto.Name = "dgvProducto";
            this.dgvProducto.ReadOnly = true;
            this.dgvProducto.Size = new System.Drawing.Size(877, 211);
            this.dgvProducto.StandardTab = true;
            this.dgvProducto.TabIndex = 9;
            this.dgvProducto.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProducto_CellContentClick);
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.btnLimpiar);
            this.flowLayoutPanel2.Controls.Add(this.btnAgregar);
            this.flowLayoutPanel2.Controls.Add(this.btnModificar);
            this.flowLayoutPanel2.Controls.Add(this.btnSalir);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(22, 181);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(121, 183);
            this.flowLayoutPanel2.TabIndex = 16;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.Transparent;
            this.btnLimpiar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLimpiar.BackgroundImage")));
            this.btnLimpiar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnLimpiar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpiar.FlatAppearance.BorderColor = System.Drawing.Color.Cyan;
            this.btnLimpiar.FlatAppearance.BorderSize = 0;
            this.btnLimpiar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnLimpiar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiar.Location = new System.Drawing.Point(0, 6);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(0, 6, 0, 6);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Padding = new System.Windows.Forms.Padding(0, 6, 0, 0);
            this.btnLimpiar.Size = new System.Drawing.Size(114, 33);
            this.btnLimpiar.TabIndex = 10;
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click_1);
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.Transparent;
            this.btnAgregar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAgregar.BackgroundImage")));
            this.btnAgregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAgregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregar.FlatAppearance.BorderColor = System.Drawing.Color.Cyan;
            this.btnAgregar.FlatAppearance.BorderSize = 0;
            this.btnAgregar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnAgregar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Location = new System.Drawing.Point(0, 51);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(0, 6, 0, 6);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Padding = new System.Windows.Forms.Padding(0, 6, 0, 0);
            this.btnAgregar.Size = new System.Drawing.Size(114, 33);
            this.btnAgregar.TabIndex = 11;
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click_1);
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.Transparent;
            this.btnModificar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnModificar.BackgroundImage")));
            this.btnModificar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnModificar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnModificar.FlatAppearance.BorderColor = System.Drawing.Color.Cyan;
            this.btnModificar.FlatAppearance.BorderSize = 0;
            this.btnModificar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnModificar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificar.Location = new System.Drawing.Point(0, 96);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(0, 6, 0, 6);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Padding = new System.Windows.Forms.Padding(0, 6, 0, 0);
            this.btnModificar.Size = new System.Drawing.Size(114, 33);
            this.btnModificar.TabIndex = 12;
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.Transparent;
            this.btnSalir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSalir.BackgroundImage")));
            this.btnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalir.FlatAppearance.BorderColor = System.Drawing.Color.Cyan;
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnSalir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Location = new System.Drawing.Point(0, 141);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(0, 6, 0, 6);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Padding = new System.Windows.Forms.Padding(0, 6, 0, 0);
            this.btnSalir.Size = new System.Drawing.Size(114, 33);
            this.btnSalir.TabIndex = 13;
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click_1);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.flowLayoutPanel1.Controls.Add(this.groupBox1);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(162, 425);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(886, 233);
            this.flowLayoutPanel1.TabIndex = 17;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvProducto);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(883, 230);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(229, 397);
            this.txtBuscar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(165, 20);
            this.txtBuscar.TabIndex = 18;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            this.txtBuscar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBuscar_KeyPress);
            // 
            // lblBuscar
            // 
            this.lblBuscar.AutoSize = true;
            this.lblBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscar.ForeColor = System.Drawing.Color.White;
            this.lblBuscar.Location = new System.Drawing.Point(162, 398);
            this.lblBuscar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBuscar.Name = "lblBuscar";
            this.lblBuscar.Size = new System.Drawing.Size(66, 18);
            this.lblBuscar.TabIndex = 19;
            this.lblBuscar.Text = "Buscar:";
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnClose.BackgroundImage")));
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.ForeColor = System.Drawing.Color.Transparent;
            this.btnClose.Location = new System.Drawing.Point(1033, 4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(36, 29);
            this.btnClose.TabIndex = 20;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnMin
            // 
            this.btnMin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMin.BackColor = System.Drawing.Color.Yellow;
            this.btnMin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMin.BackgroundImage")));
            this.btnMin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnMin.FlatAppearance.BorderSize = 0;
            this.btnMin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMin.ForeColor = System.Drawing.Color.Transparent;
            this.btnMin.Location = new System.Drawing.Point(958, 4);
            this.btnMin.Name = "btnMin";
            this.btnMin.Size = new System.Drawing.Size(36, 29);
            this.btnMin.TabIndex = 22;
            this.btnMin.UseVisualStyleBackColor = false;
            this.btnMin.Click += new System.EventHandler(this.btnMin_Click);
            // 
            // btnRestaurar
            // 
            this.btnRestaurar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRestaurar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnRestaurar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRestaurar.BackgroundImage")));
            this.btnRestaurar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnRestaurar.FlatAppearance.BorderSize = 0;
            this.btnRestaurar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRestaurar.ForeColor = System.Drawing.Color.Transparent;
            this.btnRestaurar.Location = new System.Drawing.Point(994, 4);
            this.btnRestaurar.Name = "btnRestaurar";
            this.btnRestaurar.Size = new System.Drawing.Size(36, 29);
            this.btnRestaurar.TabIndex = 23;
            this.btnRestaurar.UseVisualStyleBackColor = false;
            this.btnRestaurar.Click += new System.EventHandler(this.btnRestaurar_Click);
            // 
            // FrmProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(24)))), ((int)(((byte)(131)))));
            this.ClientSize = new System.Drawing.Size(1074, 670);
            this.Controls.Add(this.btnRestaurar);
            this.Controls.Add(this.btnMin);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.lblBuscar);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.flpProducto);
            this.Controls.Add(this.lblProducto);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmProducto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FrmProducto";
            this.Load += new System.EventHandler(this.FrmProducto_Load);
            this.flpProducto.ResumeLayout(false);
            this.gbxProducto.ResumeLayout(false);
            this.gbxProducto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxImagen)).EndInit();
            this.gbxProducto1.ResumeLayout(false);
            this.gbxProducto1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducto)).EndInit();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblProducto;
        private System.Windows.Forms.FlowLayoutPanel flpProducto;
        private System.Windows.Forms.GroupBox gbxProducto;
        private System.Windows.Forms.TextBox txtPeso;
        private System.Windows.Forms.Label lblPeso;
        private System.Windows.Forms.PictureBox pbxImagen;
        private System.Windows.Forms.Label lblCodigoBarras;
        private System.Windows.Forms.TextBox txtCodigoBarras;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.ComboBox cbxCategoria;
        private System.Windows.Forms.GroupBox gbxProducto1;
        private System.Windows.Forms.ComboBox cbxColor;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Label lblColor;
        private System.Windows.Forms.Label lblModelo;
        private System.Windows.Forms.ComboBox cbxModelo;
        private System.Windows.Forms.DataGridView dgvProducto;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.ComboBox cbxMarca;
        private System.Windows.Forms.ComboBox cbxPrecios;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Label lblBuscar;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnMin;
        private System.Windows.Forms.Button btnRestaurar;
        private System.Windows.Forms.Button btnMarca;
        private System.Windows.Forms.Button btnColor;
        private System.Windows.Forms.Button btnModelo;
        private System.Windows.Forms.Button btnCategoria;
        private System.Windows.Forms.Button btnPrecios;
    }
}