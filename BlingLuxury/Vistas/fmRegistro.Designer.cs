using System;
using System.Drawing;

namespace BlingLuxury
{
    partial class fmRegistro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fmRegistro));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbxNivel = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtIdCliente = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbxEntidadFederativa = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbxMunicipio = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbxLocalidad = new System.Windows.Forms.ComboBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnLocalidad = new System.Windows.Forms.Button();
            this.btnEstado = new System.Windows.Forms.Button();
            this.btnMunicipio = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnUsuario = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnClose = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.rbnAdmin = new System.Windows.Forms.RadioButton();
            this.rbnClientes = new System.Windows.Forms.RadioButton();
            this.btnRestaurar = new System.Windows.Forms.Button();
            this.btnMin = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl.ForeColor = System.Drawing.Color.White;
            this.lbl.Location = new System.Drawing.Point(357, 9);
            this.lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(112, 29);
            this.lbl.TabIndex = 0;
            this.lbl.Text = "Registro";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(24)))), ((int)(((byte)(131)))));
            this.label1.Location = new System.Drawing.Point(27, 53);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre:";
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(171)))));
            this.txtNombre.Location = new System.Drawing.Point(108, 51);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtNombre.MaxLength = 50;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(371, 23);
            this.txtNombre.TabIndex = 2;
            this.txtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombre_KeyPress);
            // 
            // txtDireccion
            // 
            this.txtDireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDireccion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(171)))));
            this.txtDireccion.Location = new System.Drawing.Point(120, 29);
            this.txtDireccion.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtDireccion.MaxLength = 50;
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(446, 23);
            this.txtDireccion.TabIndex = 3;
            this.txtDireccion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDireccion_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(24)))), ((int)(((byte)(131)))));
            this.label3.Location = new System.Drawing.Point(27, 30);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "Dirección:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(24)))), ((int)(((byte)(131)))));
            this.label2.Location = new System.Drawing.Point(27, 23);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nivel:";
            // 
            // cbxNivel
            // 
            this.cbxNivel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cbxNivel.DisplayMember = "Seleccionar";
            this.cbxNivel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxNivel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cbxNivel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxNivel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(171)))));
            this.cbxNivel.FormattingEnabled = true;
            this.cbxNivel.Location = new System.Drawing.Point(108, 22);
            this.cbxNivel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cbxNivel.Name = "cbxNivel";
            this.cbxNivel.Size = new System.Drawing.Size(157, 24);
            this.cbxNivel.TabIndex = 1;
            this.cbxNivel.ValueMember = "Seleccionar";
            this.cbxNivel.SelectedIndexChanged += new System.EventHandler(this.cbxNivel_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Window;
            this.groupBox1.Controls.Add(this.txtIdCliente);
            this.groupBox1.Controls.Add(this.txtId);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cbxNivel);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtNombre);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Location = new System.Drawing.Point(20, 9);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(20, 9, 4, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Size = new System.Drawing.Size(608, 91);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            // 
            // txtIdCliente
            // 
            this.txtIdCliente.Location = new System.Drawing.Point(542, 50);
            this.txtIdCliente.Name = "txtIdCliente";
            this.txtIdCliente.ReadOnly = true;
            this.txtIdCliente.Size = new System.Drawing.Size(31, 21);
            this.txtIdCliente.TabIndex = 4;
            this.txtIdCliente.Visible = false;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(542, 23);
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(31, 21);
            this.txtId.TabIndex = 3;
            this.txtId.Visible = false;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefono.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(171)))));
            this.txtTelefono.Location = new System.Drawing.Point(120, 62);
            this.txtTelefono.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtTelefono.MaxLength = 10;
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(157, 22);
            this.txtTelefono.TabIndex = 4;
            this.txtTelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTelefono_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(24)))), ((int)(((byte)(131)))));
            this.label7.Location = new System.Drawing.Point(27, 63);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 18);
            this.label7.TabIndex = 13;
            this.label7.Text = "Teléfono:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(24)))), ((int)(((byte)(131)))));
            this.label6.Location = new System.Drawing.Point(320, 63);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 18);
            this.label6.TabIndex = 11;
            this.label6.Text = "Estado:";
            // 
            // cbxEntidadFederativa
            // 
            this.cbxEntidadFederativa.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cbxEntidadFederativa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxEntidadFederativa.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cbxEntidadFederativa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxEntidadFederativa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(171)))));
            this.cbxEntidadFederativa.FormattingEnabled = true;
            this.cbxEntidadFederativa.Location = new System.Drawing.Point(409, 61);
            this.cbxEntidadFederativa.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cbxEntidadFederativa.Name = "cbxEntidadFederativa";
            this.cbxEntidadFederativa.Size = new System.Drawing.Size(157, 24);
            this.cbxEntidadFederativa.TabIndex = 5;
            this.cbxEntidadFederativa.SelectedIndexChanged += new System.EventHandler(this.cbxEntidadFederativa_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(24)))), ((int)(((byte)(131)))));
            this.label5.Location = new System.Drawing.Point(27, 91);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 18);
            this.label5.TabIndex = 9;
            this.label5.Text = "Municipio:";
            // 
            // cbxMunicipio
            // 
            this.cbxMunicipio.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cbxMunicipio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxMunicipio.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cbxMunicipio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxMunicipio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(171)))));
            this.cbxMunicipio.FormattingEnabled = true;
            this.cbxMunicipio.Location = new System.Drawing.Point(120, 88);
            this.cbxMunicipio.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cbxMunicipio.Name = "cbxMunicipio";
            this.cbxMunicipio.Size = new System.Drawing.Size(157, 24);
            this.cbxMunicipio.TabIndex = 6;
            this.cbxMunicipio.SelectedIndexChanged += new System.EventHandler(this.cbxMunicipio_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(24)))), ((int)(((byte)(131)))));
            this.label4.Location = new System.Drawing.Point(320, 91);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 18);
            this.label4.TabIndex = 7;
            this.label4.Text = "Localidad:";
            // 
            // cbxLocalidad
            // 
            this.cbxLocalidad.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cbxLocalidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxLocalidad.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cbxLocalidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxLocalidad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(171)))));
            this.cbxLocalidad.FormattingEnabled = true;
            this.cbxLocalidad.Location = new System.Drawing.Point(409, 89);
            this.cbxLocalidad.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cbxLocalidad.Name = "cbxLocalidad";
            this.cbxLocalidad.Size = new System.Drawing.Size(157, 24);
            this.cbxLocalidad.TabIndex = 7;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.flowLayoutPanel1.Controls.Add(this.groupBox1);
            this.flowLayoutPanel1.Controls.Add(this.groupBox2);
            this.flowLayoutPanel1.Controls.Add(this.groupBox3);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(149, 53);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(643, 332);
            this.flowLayoutPanel1.TabIndex = 8;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnLocalidad);
            this.groupBox2.Controls.Add(this.btnEstado);
            this.groupBox2.Controls.Add(this.btnMunicipio);
            this.groupBox2.Controls.Add(this.txtTelefono);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txtDireccion);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.cbxLocalidad);
            this.groupBox2.Controls.Add(this.cbxEntidadFederativa);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.cbxMunicipio);
            this.groupBox2.Location = new System.Drawing.Point(20, 106);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(20, 3, 4, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox2.Size = new System.Drawing.Size(608, 127);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // btnLocalidad
            // 
            this.btnLocalidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnLocalidad.Location = new System.Drawing.Point(571, 89);
            this.btnLocalidad.Name = "btnLocalidad";
            this.btnLocalidad.Size = new System.Drawing.Size(25, 25);
            this.btnLocalidad.TabIndex = 18;
            this.btnLocalidad.Text = "+";
            this.btnLocalidad.UseVisualStyleBackColor = true;
            this.btnLocalidad.Click += new System.EventHandler(this.btnLocalidad_Click);
            // 
            // btnEstado
            // 
            this.btnEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnEstado.Location = new System.Drawing.Point(571, 60);
            this.btnEstado.Name = "btnEstado";
            this.btnEstado.Size = new System.Drawing.Size(25, 25);
            this.btnEstado.TabIndex = 17;
            this.btnEstado.Text = "+";
            this.btnEstado.UseVisualStyleBackColor = true;
            this.btnEstado.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnMunicipio
            // 
            this.btnMunicipio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnMunicipio.Location = new System.Drawing.Point(284, 88);
            this.btnMunicipio.Name = "btnMunicipio";
            this.btnMunicipio.Size = new System.Drawing.Size(25, 25);
            this.btnMunicipio.TabIndex = 16;
            this.btnMunicipio.Text = "+";
            this.btnMunicipio.UseVisualStyleBackColor = true;
            this.btnMunicipio.Click += new System.EventHandler(this.btnMunicipio_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnUsuario);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.txtPass);
            this.groupBox3.Controls.Add(this.txtUsuario);
            this.groupBox3.Location = new System.Drawing.Point(20, 239);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(20, 3, 4, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox3.Size = new System.Drawing.Size(608, 92);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            // 
            // btnUsuario
            // 
            this.btnUsuario.BackColor = System.Drawing.Color.LightGray;
            this.btnUsuario.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(171)))));
            this.btnUsuario.FlatAppearance.BorderSize = 3;
            this.btnUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(24)))), ((int)(((byte)(131)))));
            this.btnUsuario.Location = new System.Drawing.Point(25, 15);
            this.btnUsuario.Name = "btnUsuario";
            this.btnUsuario.Size = new System.Drawing.Size(142, 23);
            this.btnUsuario.TabIndex = 10;
            this.btnUsuario.Text = "Generar Usuario";
            this.btnUsuario.UseVisualStyleBackColor = false;
            this.btnUsuario.Click += new System.EventHandler(this.btnUsuario_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(24)))), ((int)(((byte)(131)))));
            this.label9.Location = new System.Drawing.Point(27, 46);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(100, 18);
            this.label9.TabIndex = 7;
            this.label9.Text = "Contraseña:";
            // 
            // txtPass
            // 
            this.txtPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(171)))));
            this.txtPass.Location = new System.Drawing.Point(135, 44);
            this.txtPass.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtPass.MaxLength = 15;
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(278, 23);
            this.txtPass.TabIndex = 9;
            // 
            // txtUsuario
            // 
            this.txtUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(171)))));
            this.txtUsuario.Location = new System.Drawing.Point(174, 15);
            this.txtUsuario.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtUsuario.MaxLength = 20;
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(239, 23);
            this.txtUsuario.TabIndex = 8;
            this.txtUsuario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUsuario_KeyPress);
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
            this.btnModificar.Location = new System.Drawing.Point(0, 51);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(0, 6, 0, 6);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Padding = new System.Windows.Forms.Padding(0, 6, 0, 0);
            this.btnModificar.Size = new System.Drawing.Size(114, 33);
            this.btnModificar.TabIndex = 12;
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
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
            this.btnAgregar.Location = new System.Drawing.Point(0, 6);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(0, 6, 0, 6);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Padding = new System.Windows.Forms.Padding(0, 6, 0, 0);
            this.btnAgregar.Size = new System.Drawing.Size(114, 33);
            this.btnAgregar.TabIndex = 11;
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
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
            this.btnLimpiar.Location = new System.Drawing.Point(0, 96);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(0, 6, 0, 6);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Padding = new System.Windows.Forms.Padding(0, 6, 0, 0);
            this.btnLimpiar.Size = new System.Drawing.Size(114, 33);
            this.btnLimpiar.TabIndex = 13;
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
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
            this.btnSalir.TabIndex = 14;
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.btnAgregar);
            this.flowLayoutPanel2.Controls.Add(this.btnModificar);
            this.flowLayoutPanel2.Controls.Add(this.btnLimpiar);
            this.flowLayoutPanel2.Controls.Add(this.btnSalir);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(21, 62);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(121, 183);
            this.flowLayoutPanel2.TabIndex = 13;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnClose.BackgroundImage")));
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.ForeColor = System.Drawing.Color.Transparent;
            this.btnClose.Location = new System.Drawing.Point(756, 9);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(36, 29);
            this.btnClose.TabIndex = 15;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Vivaldi", 8.25F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Location = new System.Drawing.Point(149, 426);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(643, 225);
            this.dataGridView1.TabIndex = 14;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // txtBuscar
            // 
            this.txtBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(171)))));
            this.txtBuscar.Location = new System.Drawing.Point(213, 398);
            this.txtBuscar.MaxLength = 50;
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(164, 22);
            this.txtBuscar.TabIndex = 16;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            this.txtBuscar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBuscar_KeyPress);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label10.Location = new System.Drawing.Point(145, 398);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(70, 20);
            this.label10.TabIndex = 17;
            this.label10.Text = "Buscar:";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AllowUserToResizeColumns = false;
            this.dataGridView2.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridView2.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView2.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Vivaldi", 8.25F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView2.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView2.Location = new System.Drawing.Point(149, 426);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridView2.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridView2.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(643, 225);
            this.dataGridView2.TabIndex = 20;
            this.dataGridView2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellClick_1);
            // 
            // rbnAdmin
            // 
            this.rbnAdmin.AutoSize = true;
            this.rbnAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbnAdmin.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rbnAdmin.Location = new System.Drawing.Point(500, 399);
            this.rbnAdmin.Name = "rbnAdmin";
            this.rbnAdmin.Size = new System.Drawing.Size(139, 20);
            this.rbnAdmin.TabIndex = 19;
            this.rbnAdmin.TabStop = true;
            this.rbnAdmin.Text = "Administradores";
            this.rbnAdmin.UseVisualStyleBackColor = true;
            this.rbnAdmin.CheckedChanged += new System.EventHandler(this.rbnAdmin_CheckedChanged);
            // 
            // rbnClientes
            // 
            this.rbnClientes.AutoSize = true;
            this.rbnClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbnClientes.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rbnClientes.Location = new System.Drawing.Point(396, 399);
            this.rbnClientes.Name = "rbnClientes";
            this.rbnClientes.Size = new System.Drawing.Size(82, 20);
            this.rbnClientes.TabIndex = 18;
            this.rbnClientes.TabStop = true;
            this.rbnClientes.Text = "Clientes";
            this.rbnClientes.UseVisualStyleBackColor = true;
            this.rbnClientes.CheckedChanged += new System.EventHandler(this.rbnClientes_CheckedChanged);
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
            this.btnRestaurar.Location = new System.Drawing.Point(718, 9);
            this.btnRestaurar.Name = "btnRestaurar";
            this.btnRestaurar.Size = new System.Drawing.Size(36, 29);
            this.btnRestaurar.TabIndex = 25;
            this.btnRestaurar.UseVisualStyleBackColor = false;
            this.btnRestaurar.Click += new System.EventHandler(this.btnRestaurar_Click);
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
            this.btnMin.Location = new System.Drawing.Point(682, 9);
            this.btnMin.Name = "btnMin";
            this.btnMin.Size = new System.Drawing.Size(36, 29);
            this.btnMin.TabIndex = 24;
            this.btnMin.UseVisualStyleBackColor = false;
            this.btnMin.Click += new System.EventHandler(this.btnMin_Click);
            // 
            // fmRegistro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(24)))), ((int)(((byte)(131)))));
            this.ClientSize = new System.Drawing.Size(793, 656);
            this.Controls.Add(this.btnRestaurar);
            this.Controls.Add(this.btnMin);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.rbnAdmin);
            this.Controls.Add(this.rbnClientes);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.lbl);
            this.Font = new System.Drawing.Font("Vivaldi", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "fmRegistro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fmRegistro";
            this.Load += new System.EventHandler(this.fmRegistro_Load);
            this.Shown += new System.EventHandler(this.fmRegistro_Shown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {
            
        }

        #endregion

        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbxNivel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbxEntidadFederativa;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbxMunicipio;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbxLocalidad;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnUsuario;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.RadioButton rbnAdmin;
        private System.Windows.Forms.RadioButton rbnClientes;
        private System.Windows.Forms.TextBox txtIdCliente;
        private System.Windows.Forms.Button btnRestaurar;
        private System.Windows.Forms.Button btnMin;
        private System.Windows.Forms.Button btnMunicipio;
        private System.Windows.Forms.Button btnLocalidad;
        private System.Windows.Forms.Button btnEstado;
    }
}