
namespace Biblioteca
{
    partial class frm_Usuario
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
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.txt_apaterno = new System.Windows.Forms.TextBox();
            this.txt_amaterno = new System.Windows.Forms.TextBox();
            this.txt_correo = new System.Windows.Forms.TextBox();
            this.txt_tfijo = new System.Windows.Forms.TextBox();
            this.txt_tcelular = new System.Windows.Forms.TextBox();
            this.P_Usuarios = new System.Windows.Forms.Panel();
            this.btn_ActualizarUsuario = new System.Windows.Forms.Button();
            this.txt_filtrar = new System.Windows.Forms.TextBox();
            this.cb_filtrar = new System.Windows.Forms.ComboBox();
            this.btn_AgregarUsuario = new System.Windows.Forms.Button();
            this.lbl_TCelular = new System.Windows.Forms.Label();
            this.lbl_TFijo = new System.Windows.Forms.Label();
            this.lbl_correo = new System.Windows.Forms.Label();
            this.lbl_AMaterno = new System.Windows.Forms.Label();
            this.lbl_APaterno = new System.Windows.Forms.Label();
            this.lbl_nombre = new System.Windows.Forms.Label();
            this.btn_EliminarUsuario = new System.Windows.Forms.Button();
            this.dg_usuarios = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre_Completo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellidoPaternoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellidoMaternoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.celularDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.correoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.spListarUsuarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bibliotecaDataSet = new Biblioteca.BibliotecaDataSet();
            this.sp_ListarUsuarioTableAdapter = new Biblioteca.BibliotecaDataSetTableAdapters.sp_ListarUsuarioTableAdapter();
            this.btn_Filtrar = new System.Windows.Forms.Button();
            this.btn_Eliminar = new System.Windows.Forms.Button();
            this.btn_Actualizar = new System.Windows.Forms.Button();
            this.btn_Agregar = new System.Windows.Forms.Button();
            this.P_Fondo = new System.Windows.Forms.PictureBox();
            this.P_Usuarios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_usuarios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spListarUsuarioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bibliotecaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.P_Fondo)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_nombre
            // 
            this.txt_nombre.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_nombre.Location = new System.Drawing.Point(71, 15);
            this.txt_nombre.Margin = new System.Windows.Forms.Padding(2);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_nombre.Size = new System.Drawing.Size(174, 20);
            this.txt_nombre.TabIndex = 5;
            // 
            // txt_apaterno
            // 
            this.txt_apaterno.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_apaterno.Location = new System.Drawing.Point(324, 15);
            this.txt_apaterno.Margin = new System.Windows.Forms.Padding(2);
            this.txt_apaterno.Name = "txt_apaterno";
            this.txt_apaterno.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_apaterno.Size = new System.Drawing.Size(174, 20);
            this.txt_apaterno.TabIndex = 6;
            // 
            // txt_amaterno
            // 
            this.txt_amaterno.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_amaterno.Location = new System.Drawing.Point(596, 17);
            this.txt_amaterno.Margin = new System.Windows.Forms.Padding(2);
            this.txt_amaterno.Name = "txt_amaterno";
            this.txt_amaterno.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_amaterno.Size = new System.Drawing.Size(174, 20);
            this.txt_amaterno.TabIndex = 7;
            // 
            // txt_correo
            // 
            this.txt_correo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_correo.Location = new System.Drawing.Point(71, 83);
            this.txt_correo.Margin = new System.Windows.Forms.Padding(2);
            this.txt_correo.Name = "txt_correo";
            this.txt_correo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_correo.Size = new System.Drawing.Size(174, 20);
            this.txt_correo.TabIndex = 8;
            // 
            // txt_tfijo
            // 
            this.txt_tfijo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_tfijo.Location = new System.Drawing.Point(324, 83);
            this.txt_tfijo.Margin = new System.Windows.Forms.Padding(2);
            this.txt_tfijo.Name = "txt_tfijo";
            this.txt_tfijo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_tfijo.Size = new System.Drawing.Size(174, 20);
            this.txt_tfijo.TabIndex = 9;
            // 
            // txt_tcelular
            // 
            this.txt_tcelular.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_tcelular.Location = new System.Drawing.Point(596, 83);
            this.txt_tcelular.Margin = new System.Windows.Forms.Padding(2);
            this.txt_tcelular.Name = "txt_tcelular";
            this.txt_tcelular.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_tcelular.Size = new System.Drawing.Size(174, 20);
            this.txt_tcelular.TabIndex = 10;
            // 
            // P_Usuarios
            // 
            this.P_Usuarios.Controls.Add(this.btn_ActualizarUsuario);
            this.P_Usuarios.Controls.Add(this.txt_filtrar);
            this.P_Usuarios.Controls.Add(this.cb_filtrar);
            this.P_Usuarios.Controls.Add(this.btn_AgregarUsuario);
            this.P_Usuarios.Controls.Add(this.lbl_TCelular);
            this.P_Usuarios.Controls.Add(this.lbl_TFijo);
            this.P_Usuarios.Controls.Add(this.lbl_correo);
            this.P_Usuarios.Controls.Add(this.lbl_AMaterno);
            this.P_Usuarios.Controls.Add(this.lbl_APaterno);
            this.P_Usuarios.Controls.Add(this.lbl_nombre);
            this.P_Usuarios.Controls.Add(this.txt_nombre);
            this.P_Usuarios.Controls.Add(this.txt_tcelular);
            this.P_Usuarios.Controls.Add(this.txt_apaterno);
            this.P_Usuarios.Controls.Add(this.txt_tfijo);
            this.P_Usuarios.Controls.Add(this.txt_amaterno);
            this.P_Usuarios.Controls.Add(this.txt_correo);
            this.P_Usuarios.Controls.Add(this.btn_EliminarUsuario);
            this.P_Usuarios.Location = new System.Drawing.Point(-2, 104);
            this.P_Usuarios.Margin = new System.Windows.Forms.Padding(2);
            this.P_Usuarios.Name = "P_Usuarios";
            this.P_Usuarios.Size = new System.Drawing.Size(827, 188);
            this.P_Usuarios.TabIndex = 11;
            // 
            // btn_ActualizarUsuario
            // 
            this.btn_ActualizarUsuario.BackgroundImage = global::Biblioteca.Properties.Resources.pngwing_com__2_;
            this.btn_ActualizarUsuario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_ActualizarUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ActualizarUsuario.Location = new System.Drawing.Point(596, 117);
            this.btn_ActualizarUsuario.Margin = new System.Windows.Forms.Padding(2);
            this.btn_ActualizarUsuario.Name = "btn_ActualizarUsuario";
            this.btn_ActualizarUsuario.Size = new System.Drawing.Size(70, 63);
            this.btn_ActualizarUsuario.TabIndex = 20;
            this.btn_ActualizarUsuario.UseVisualStyleBackColor = false;
            this.btn_ActualizarUsuario.Visible = false;
            this.btn_ActualizarUsuario.Click += new System.EventHandler(this.btn_ActualizarUsuario_Click);
            // 
            // txt_filtrar
            // 
            this.txt_filtrar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_filtrar.Location = new System.Drawing.Point(148, 141);
            this.txt_filtrar.Margin = new System.Windows.Forms.Padding(2);
            this.txt_filtrar.Name = "txt_filtrar";
            this.txt_filtrar.Size = new System.Drawing.Size(620, 20);
            this.txt_filtrar.TabIndex = 19;
            this.txt_filtrar.Visible = false;
            this.txt_filtrar.TextChanged += new System.EventHandler(this.txt_filtrar_TextChanged);
            // 
            // cb_filtrar
            // 
            this.cb_filtrar.FormattingEnabled = true;
            this.cb_filtrar.Items.AddRange(new object[] {
            "Nombre Completo",
            "Teléfono",
            "Celular",
            "Correo"});
            this.cb_filtrar.Location = new System.Drawing.Point(20, 140);
            this.cb_filtrar.Margin = new System.Windows.Forms.Padding(2);
            this.cb_filtrar.Name = "cb_filtrar";
            this.cb_filtrar.Size = new System.Drawing.Size(108, 21);
            this.cb_filtrar.TabIndex = 18;
            this.cb_filtrar.Text = "Seleccione...";
            this.cb_filtrar.Visible = false;
            // 
            // btn_AgregarUsuario
            // 
            this.btn_AgregarUsuario.BackgroundImage = global::Biblioteca.Properties.Resources.pngwing_com__5_;
            this.btn_AgregarUsuario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_AgregarUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_AgregarUsuario.Location = new System.Drawing.Point(355, 117);
            this.btn_AgregarUsuario.Margin = new System.Windows.Forms.Padding(2);
            this.btn_AgregarUsuario.Name = "btn_AgregarUsuario";
            this.btn_AgregarUsuario.Size = new System.Drawing.Size(70, 63);
            this.btn_AgregarUsuario.TabIndex = 17;
            this.btn_AgregarUsuario.UseVisualStyleBackColor = true;
            this.btn_AgregarUsuario.Click += new System.EventHandler(this.btn_AgregarUsuario_Click);
            // 
            // lbl_TCelular
            // 
            this.lbl_TCelular.AutoSize = true;
            this.lbl_TCelular.Location = new System.Drawing.Point(518, 87);
            this.lbl_TCelular.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_TCelular.Name = "lbl_TCelular";
            this.lbl_TCelular.Size = new System.Drawing.Size(58, 13);
            this.lbl_TCelular.TabIndex = 16;
            this.lbl_TCelular.Text = "T. Celular :";
            // 
            // lbl_TFijo
            // 
            this.lbl_TFijo.AutoSize = true;
            this.lbl_TFijo.Location = new System.Drawing.Point(257, 87);
            this.lbl_TFijo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_TFijo.Name = "lbl_TFijo";
            this.lbl_TFijo.Size = new System.Drawing.Size(42, 13);
            this.lbl_TFijo.TabIndex = 15;
            this.lbl_TFijo.Text = "T. Fijo :";
            // 
            // lbl_correo
            // 
            this.lbl_correo.AutoSize = true;
            this.lbl_correo.Location = new System.Drawing.Point(17, 85);
            this.lbl_correo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_correo.Name = "lbl_correo";
            this.lbl_correo.Size = new System.Drawing.Size(44, 13);
            this.lbl_correo.TabIndex = 14;
            this.lbl_correo.Text = "Correo :";
            // 
            // lbl_AMaterno
            // 
            this.lbl_AMaterno.AutoSize = true;
            this.lbl_AMaterno.Location = new System.Drawing.Point(518, 19);
            this.lbl_AMaterno.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_AMaterno.Name = "lbl_AMaterno";
            this.lbl_AMaterno.Size = new System.Drawing.Size(65, 13);
            this.lbl_AMaterno.TabIndex = 13;
            this.lbl_AMaterno.Text = "A. Materno :";
            // 
            // lbl_APaterno
            // 
            this.lbl_APaterno.AutoSize = true;
            this.lbl_APaterno.Location = new System.Drawing.Point(257, 19);
            this.lbl_APaterno.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_APaterno.Name = "lbl_APaterno";
            this.lbl_APaterno.Size = new System.Drawing.Size(63, 13);
            this.lbl_APaterno.TabIndex = 12;
            this.lbl_APaterno.Text = "A. Paterno :";
            // 
            // lbl_nombre
            // 
            this.lbl_nombre.AutoSize = true;
            this.lbl_nombre.Location = new System.Drawing.Point(17, 17);
            this.lbl_nombre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_nombre.Name = "lbl_nombre";
            this.lbl_nombre.Size = new System.Drawing.Size(50, 13);
            this.lbl_nombre.TabIndex = 11;
            this.lbl_nombre.Text = "Nombre :";
            // 
            // btn_EliminarUsuario
            // 
            this.btn_EliminarUsuario.BackgroundImage = global::Biblioteca.Properties.Resources.pngwing_com__6_;
            this.btn_EliminarUsuario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_EliminarUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_EliminarUsuario.Location = new System.Drawing.Point(355, 117);
            this.btn_EliminarUsuario.Margin = new System.Windows.Forms.Padding(2);
            this.btn_EliminarUsuario.Name = "btn_EliminarUsuario";
            this.btn_EliminarUsuario.Size = new System.Drawing.Size(70, 63);
            this.btn_EliminarUsuario.TabIndex = 21;
            this.btn_EliminarUsuario.UseVisualStyleBackColor = false;
            this.btn_EliminarUsuario.Visible = false;
            this.btn_EliminarUsuario.Click += new System.EventHandler(this.btn_EliminarUsuario_Click);
            // 
            // dg_usuarios
            // 
            this.dg_usuarios.AllowUserToAddRows = false;
            this.dg_usuarios.AllowUserToDeleteRows = false;
            this.dg_usuarios.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dg_usuarios.AutoGenerateColumns = false;
            this.dg_usuarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dg_usuarios.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dg_usuarios.BackgroundColor = System.Drawing.Color.White;
            this.dg_usuarios.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dg_usuarios.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dg_usuarios.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dg_usuarios.ColumnHeadersHeight = 29;
            this.dg_usuarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.Nombre_Completo,
            this.nombreDataGridViewTextBoxColumn,
            this.apellidoPaternoDataGridViewTextBoxColumn,
            this.apellidoMaternoDataGridViewTextBoxColumn,
            this.telefonoDataGridViewTextBoxColumn,
            this.celularDataGridViewTextBoxColumn,
            this.correoDataGridViewTextBoxColumn});
            this.dg_usuarios.DataSource = this.spListarUsuarioBindingSource;
            this.dg_usuarios.Location = new System.Drawing.Point(-2, 289);
            this.dg_usuarios.Margin = new System.Windows.Forms.Padding(2);
            this.dg_usuarios.Name = "dg_usuarios";
            this.dg_usuarios.ReadOnly = true;
            this.dg_usuarios.RowHeadersWidth = 51;
            this.dg_usuarios.RowTemplate.Height = 24;
            this.dg_usuarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dg_usuarios.Size = new System.Drawing.Size(827, 344);
            this.dg_usuarios.TabIndex = 12;
            this.dg_usuarios.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_usuarios_CellContentDoubleClick);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.idDataGridViewTextBoxColumn.Visible = false;
            // 
            // Nombre_Completo
            // 
            this.Nombre_Completo.DataPropertyName = "Nombre Completo";
            this.Nombre_Completo.HeaderText = "Nombre Completo";
            this.Nombre_Completo.MinimumWidth = 6;
            this.Nombre_Completo.Name = "Nombre_Completo";
            this.Nombre_Completo.ReadOnly = true;
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nombreDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            this.nombreDataGridViewTextBoxColumn.ReadOnly = true;
            this.nombreDataGridViewTextBoxColumn.Visible = false;
            // 
            // apellidoPaternoDataGridViewTextBoxColumn
            // 
            this.apellidoPaternoDataGridViewTextBoxColumn.DataPropertyName = "Apellido Paterno";
            this.apellidoPaternoDataGridViewTextBoxColumn.HeaderText = "Apellido Paterno";
            this.apellidoPaternoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.apellidoPaternoDataGridViewTextBoxColumn.Name = "apellidoPaternoDataGridViewTextBoxColumn";
            this.apellidoPaternoDataGridViewTextBoxColumn.ReadOnly = true;
            this.apellidoPaternoDataGridViewTextBoxColumn.Visible = false;
            // 
            // apellidoMaternoDataGridViewTextBoxColumn
            // 
            this.apellidoMaternoDataGridViewTextBoxColumn.DataPropertyName = "Apellido Materno";
            this.apellidoMaternoDataGridViewTextBoxColumn.HeaderText = "Apellido Materno";
            this.apellidoMaternoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.apellidoMaternoDataGridViewTextBoxColumn.Name = "apellidoMaternoDataGridViewTextBoxColumn";
            this.apellidoMaternoDataGridViewTextBoxColumn.ReadOnly = true;
            this.apellidoMaternoDataGridViewTextBoxColumn.Visible = false;
            // 
            // telefonoDataGridViewTextBoxColumn
            // 
            this.telefonoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.telefonoDataGridViewTextBoxColumn.DataPropertyName = "Telefono";
            this.telefonoDataGridViewTextBoxColumn.HeaderText = "Telefono";
            this.telefonoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.telefonoDataGridViewTextBoxColumn.Name = "telefonoDataGridViewTextBoxColumn";
            this.telefonoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // celularDataGridViewTextBoxColumn
            // 
            this.celularDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.celularDataGridViewTextBoxColumn.DataPropertyName = "Celular";
            this.celularDataGridViewTextBoxColumn.HeaderText = "Celular";
            this.celularDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.celularDataGridViewTextBoxColumn.Name = "celularDataGridViewTextBoxColumn";
            this.celularDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // correoDataGridViewTextBoxColumn
            // 
            this.correoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.correoDataGridViewTextBoxColumn.DataPropertyName = "Correo";
            this.correoDataGridViewTextBoxColumn.HeaderText = "Correo";
            this.correoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.correoDataGridViewTextBoxColumn.Name = "correoDataGridViewTextBoxColumn";
            this.correoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // spListarUsuarioBindingSource
            // 
            this.spListarUsuarioBindingSource.DataMember = "sp_ListarUsuario";
            this.spListarUsuarioBindingSource.DataSource = this.bibliotecaDataSet;
            // 
            // bibliotecaDataSet
            // 
            this.bibliotecaDataSet.DataSetName = "BibliotecaDataSet";
            this.bibliotecaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sp_ListarUsuarioTableAdapter
            // 
            this.sp_ListarUsuarioTableAdapter.ClearBeforeFill = true;
            // 
            // btn_Filtrar
            // 
            this.btn_Filtrar.BackgroundImage = global::Biblioteca.Properties.Resources.pngwing_com__4_;
            this.btn_Filtrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Filtrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Filtrar.Location = new System.Drawing.Point(377, 10);
            this.btn_Filtrar.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Filtrar.Name = "btn_Filtrar";
            this.btn_Filtrar.Size = new System.Drawing.Size(104, 81);
            this.btn_Filtrar.TabIndex = 4;
            this.btn_Filtrar.UseVisualStyleBackColor = true;
            this.btn_Filtrar.Click += new System.EventHandler(this.btn_Filtrar_Click);
            // 
            // btn_Eliminar
            // 
            this.btn_Eliminar.BackgroundImage = global::Biblioteca.Properties.Resources.pngwing_com__3_;
            this.btn_Eliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Eliminar.Location = new System.Drawing.Point(257, 10);
            this.btn_Eliminar.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Eliminar.Name = "btn_Eliminar";
            this.btn_Eliminar.Size = new System.Drawing.Size(104, 81);
            this.btn_Eliminar.TabIndex = 3;
            this.btn_Eliminar.UseVisualStyleBackColor = true;
            this.btn_Eliminar.Click += new System.EventHandler(this.btn_Eliminar_Click);
            // 
            // btn_Actualizar
            // 
            this.btn_Actualizar.BackgroundImage = global::Biblioteca.Properties.Resources.pngwing_com__2_;
            this.btn_Actualizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Actualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Actualizar.Location = new System.Drawing.Point(132, 10);
            this.btn_Actualizar.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Actualizar.Name = "btn_Actualizar";
            this.btn_Actualizar.Size = new System.Drawing.Size(104, 81);
            this.btn_Actualizar.TabIndex = 2;
            this.btn_Actualizar.UseVisualStyleBackColor = true;
            this.btn_Actualizar.Click += new System.EventHandler(this.btn_Actualizar_Click);
            // 
            // btn_Agregar
            // 
            this.btn_Agregar.BackgroundImage = global::Biblioteca.Properties.Resources.pngwing_com__1_;
            this.btn_Agregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Agregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Agregar.Location = new System.Drawing.Point(9, 10);
            this.btn_Agregar.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Agregar.Name = "btn_Agregar";
            this.btn_Agregar.Size = new System.Drawing.Size(104, 81);
            this.btn_Agregar.TabIndex = 1;
            this.btn_Agregar.UseVisualStyleBackColor = true;
            this.btn_Agregar.Click += new System.EventHandler(this.btn_Agregar_Click);
            // 
            // P_Fondo
            // 
            this.P_Fondo.Image = global::Biblioteca.Properties.Resources.biblioteca;
            this.P_Fondo.Location = new System.Drawing.Point(-2, 104);
            this.P_Fondo.Margin = new System.Windows.Forms.Padding(2);
            this.P_Fondo.Name = "P_Fondo";
            this.P_Fondo.Size = new System.Drawing.Size(830, 521);
            this.P_Fondo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.P_Fondo.TabIndex = 14;
            this.P_Fondo.TabStop = false;
            this.P_Fondo.Visible = false;
            // 
            // frm_Usuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(826, 627);
            this.Controls.Add(this.dg_usuarios);
            this.Controls.Add(this.P_Usuarios);
            this.Controls.Add(this.btn_Filtrar);
            this.Controls.Add(this.btn_Eliminar);
            this.Controls.Add(this.btn_Actualizar);
            this.Controls.Add(this.btn_Agregar);
            this.Controls.Add(this.P_Fondo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "frm_Usuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Usuarios";
            this.Load += new System.EventHandler(this.frm_Usuario_Load);
            this.P_Usuarios.ResumeLayout(false);
            this.P_Usuarios.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_usuarios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spListarUsuarioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bibliotecaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.P_Fondo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Agregar;
        private System.Windows.Forms.Button btn_Actualizar;
        private System.Windows.Forms.Button btn_Eliminar;
        private System.Windows.Forms.Button btn_Filtrar;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.TextBox txt_apaterno;
        private System.Windows.Forms.TextBox txt_amaterno;
        private System.Windows.Forms.TextBox txt_correo;
        private System.Windows.Forms.TextBox txt_tfijo;
        private System.Windows.Forms.TextBox txt_tcelular;
        private System.Windows.Forms.Panel P_Usuarios;
        private System.Windows.Forms.Label lbl_AMaterno;
        private System.Windows.Forms.Label lbl_APaterno;
        private System.Windows.Forms.Label lbl_nombre;
        private System.Windows.Forms.Button btn_AgregarUsuario;
        private System.Windows.Forms.Label lbl_TCelular;
        private System.Windows.Forms.Label lbl_TFijo;
        private System.Windows.Forms.Label lbl_correo;
        private System.Windows.Forms.DataGridView dg_usuarios;
        private System.Windows.Forms.TextBox txt_filtrar;
        private System.Windows.Forms.ComboBox cb_filtrar;
        private System.Windows.Forms.PictureBox P_Fondo;
        private System.Windows.Forms.Button btn_ActualizarUsuario;
        private System.Windows.Forms.Button btn_EliminarUsuario;
        private BibliotecaDataSet bibliotecaDataSet;
        private System.Windows.Forms.BindingSource spListarUsuarioBindingSource;
        private BibliotecaDataSetTableAdapters.sp_ListarUsuarioTableAdapter sp_ListarUsuarioTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreCompletoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre_Completo;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellidoPaternoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellidoMaternoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn celularDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn correoDataGridViewTextBoxColumn;
    }
}