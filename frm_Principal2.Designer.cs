
namespace Biblioteca
{
    partial class frm_Principal2
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
            FontAwesome.Sharp.IconButton btn_Salir;
            FontAwesome.Sharp.IconButton btn_Minimzar;
            FontAwesome.Sharp.IconButton btn_Maximizar;
            this.lblHora = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel_Menu = new System.Windows.Forms.Panel();
            this.iconButton5 = new FontAwesome.Sharp.IconButton();
            this.iconButton4 = new FontAwesome.Sharp.IconButton();
            this.btn_Libros = new FontAwesome.Sharp.IconButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Roles = new FontAwesome.Sharp.IconButton();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.btn_Usuario = new FontAwesome.Sharp.IconButton();
            this.panel_Logo = new System.Windows.Forms.Panel();
            this.btn_Home = new System.Windows.Forms.PictureBox();
            this.btn_AgregarUsuario = new System.Windows.Forms.Panel();
            this.lblTitleChildForm = new System.Windows.Forms.Label();
            this.iconCurrentChildForm = new FontAwesome.Sharp.IconPictureBox();
            this.panelDesktop = new System.Windows.Forms.Panel();
            btn_Salir = new FontAwesome.Sharp.IconButton();
            btn_Minimzar = new FontAwesome.Sharp.IconButton();
            btn_Maximizar = new FontAwesome.Sharp.IconButton();
            this.panel_Menu.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel_Logo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Home)).BeginInit();
            this.btn_AgregarUsuario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildForm)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Salir
            // 
            btn_Salir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            btn_Salir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            btn_Salir.FlatAppearance.BorderSize = 0;
            btn_Salir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btn_Salir.IconChar = FontAwesome.Sharp.IconChar.Times;
            btn_Salir.IconColor = System.Drawing.Color.Black;
            btn_Salir.IconFont = FontAwesome.Sharp.IconFont.Solid;
            btn_Salir.IconSize = 15;
            btn_Salir.Location = new System.Drawing.Point(1112, 0);
            btn_Salir.Name = "btn_Salir";
            btn_Salir.Size = new System.Drawing.Size(25, 20);
            btn_Salir.TabIndex = 2;
            btn_Salir.UseVisualStyleBackColor = true;
            btn_Salir.Click += new System.EventHandler(this.btn_Salir_Click);
            // 
            // btn_Minimzar
            // 
            btn_Minimzar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            btn_Minimzar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            btn_Minimzar.FlatAppearance.BorderSize = 0;
            btn_Minimzar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btn_Minimzar.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            btn_Minimzar.IconColor = System.Drawing.Color.Black;
            btn_Minimzar.IconFont = FontAwesome.Sharp.IconFont.Solid;
            btn_Minimzar.IconSize = 15;
            btn_Minimzar.Location = new System.Drawing.Point(1050, 0);
            btn_Minimzar.Name = "btn_Minimzar";
            btn_Minimzar.Size = new System.Drawing.Size(25, 20);
            btn_Minimzar.TabIndex = 3;
            btn_Minimzar.UseVisualStyleBackColor = true;
            btn_Minimzar.Click += new System.EventHandler(this.btn_Minimzar_Click);
            // 
            // btn_Maximizar
            // 
            btn_Maximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            btn_Maximizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            btn_Maximizar.FlatAppearance.BorderSize = 0;
            btn_Maximizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btn_Maximizar.IconChar = FontAwesome.Sharp.IconChar.WindowMaximize;
            btn_Maximizar.IconColor = System.Drawing.Color.Black;
            btn_Maximizar.IconFont = FontAwesome.Sharp.IconFont.Solid;
            btn_Maximizar.IconSize = 15;
            btn_Maximizar.Location = new System.Drawing.Point(1081, 0);
            btn_Maximizar.Name = "btn_Maximizar";
            btn_Maximizar.Size = new System.Drawing.Size(25, 20);
            btn_Maximizar.TabIndex = 4;
            btn_Maximizar.UseVisualStyleBackColor = true;
            btn_Maximizar.Click += new System.EventHandler(this.btn_Maximizar_Click);
            // 
            // lblHora
            // 
            this.lblHora.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblHora.AutoSize = true;
            this.lblHora.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHora.ForeColor = System.Drawing.Color.White;
            this.lblHora.Location = new System.Drawing.Point(24, 761);
            this.lblHora.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(93, 32);
            this.lblHora.TabIndex = 0;
            this.lblHora.Text = "label1";
            // 
            // lblFecha
            // 
            this.lblFecha.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblFecha.AutoSize = true;
            this.lblFecha.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.ForeColor = System.Drawing.Color.White;
            this.lblFecha.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.lblFecha.Location = new System.Drawing.Point(2, 817);
            this.lblFecha.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(46, 18);
            this.lblFecha.TabIndex = 1;
            this.lblFecha.Text = "label1";
            this.lblFecha.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel_Menu
            // 
            this.panel_Menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(209)))), ((int)(((byte)(206)))));
            this.panel_Menu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_Menu.Controls.Add(this.iconButton5);
            this.panel_Menu.Controls.Add(this.iconButton4);
            this.panel_Menu.Controls.Add(this.btn_Libros);
            this.panel_Menu.Controls.Add(this.panel1);
            this.panel_Menu.Controls.Add(this.lblFecha);
            this.panel_Menu.Controls.Add(this.lblHora);
            this.panel_Menu.Controls.Add(this.btn_Usuario);
            this.panel_Menu.Controls.Add(this.panel_Logo);
            this.panel_Menu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_Menu.Location = new System.Drawing.Point(0, 0);
            this.panel_Menu.Margin = new System.Windows.Forms.Padding(2);
            this.panel_Menu.Name = "panel_Menu";
            this.panel_Menu.Size = new System.Drawing.Size(213, 850);
            this.panel_Menu.TabIndex = 5;
            // 
            // iconButton5
            // 
            this.iconButton5.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButton5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton5.IconChar = FontAwesome.Sharp.IconChar.UserTie;
            this.iconButton5.IconColor = System.Drawing.Color.Black;
            this.iconButton5.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton5.Location = new System.Drawing.Point(0, 373);
            this.iconButton5.Margin = new System.Windows.Forms.Padding(2);
            this.iconButton5.Name = "iconButton5";
            this.iconButton5.Padding = new System.Windows.Forms.Padding(8, 0, 15, 0);
            this.iconButton5.Size = new System.Drawing.Size(211, 49);
            this.iconButton5.TabIndex = 8;
            this.iconButton5.Text = "iconButton5";
            this.iconButton5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton5.UseVisualStyleBackColor = true;
            this.iconButton5.Visible = false;
            // 
            // iconButton4
            // 
            this.iconButton4.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButton4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton4.IconChar = FontAwesome.Sharp.IconChar.UserTie;
            this.iconButton4.IconColor = System.Drawing.Color.Black;
            this.iconButton4.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton4.Location = new System.Drawing.Point(0, 324);
            this.iconButton4.Margin = new System.Windows.Forms.Padding(2);
            this.iconButton4.Name = "iconButton4";
            this.iconButton4.Padding = new System.Windows.Forms.Padding(8, 0, 15, 0);
            this.iconButton4.Size = new System.Drawing.Size(211, 49);
            this.iconButton4.TabIndex = 7;
            this.iconButton4.Text = "iconButton4";
            this.iconButton4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton4.UseVisualStyleBackColor = true;
            this.iconButton4.Visible = false;
            // 
            // btn_Libros
            // 
            this.btn_Libros.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Libros.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Libros.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Libros.IconChar = FontAwesome.Sharp.IconChar.Book;
            this.btn_Libros.IconColor = System.Drawing.Color.Black;
            this.btn_Libros.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_Libros.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Libros.Location = new System.Drawing.Point(0, 275);
            this.btn_Libros.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Libros.Name = "btn_Libros";
            this.btn_Libros.Padding = new System.Windows.Forms.Padding(8, 0, 15, 0);
            this.btn_Libros.Size = new System.Drawing.Size(211, 49);
            this.btn_Libros.TabIndex = 6;
            this.btn_Libros.Text = "iconButton3";
            this.btn_Libros.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Libros.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Libros.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_Roles);
            this.panel1.Controls.Add(this.iconButton1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 175);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(211, 100);
            this.panel1.TabIndex = 3;
            // 
            // btn_Roles
            // 
            this.btn_Roles.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Roles.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Roles.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Roles.IconChar = FontAwesome.Sharp.IconChar.Users;
            this.btn_Roles.IconColor = System.Drawing.Color.Black;
            this.btn_Roles.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_Roles.Location = new System.Drawing.Point(0, 49);
            this.btn_Roles.Name = "btn_Roles";
            this.btn_Roles.Size = new System.Drawing.Size(211, 49);
            this.btn_Roles.TabIndex = 1;
            this.btn_Roles.Text = "Rol";
            this.btn_Roles.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Roles.UseVisualStyleBackColor = true;
            // 
            // iconButton1
            // 
            this.iconButton1.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.UserEdit;
            this.iconButton1.IconColor = System.Drawing.Color.Black;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.Location = new System.Drawing.Point(0, 0);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(211, 49);
            this.iconButton1.TabIndex = 0;
            this.iconButton1.Text = "Usuario";
            this.iconButton1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconButton1.UseVisualStyleBackColor = true;
            // 
            // btn_Usuario
            // 
            this.btn_Usuario.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Usuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Usuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Usuario.IconChar = FontAwesome.Sharp.IconChar.UserTie;
            this.btn_Usuario.IconColor = System.Drawing.Color.Black;
            this.btn_Usuario.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_Usuario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Usuario.Location = new System.Drawing.Point(0, 126);
            this.btn_Usuario.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Usuario.Name = "btn_Usuario";
            this.btn_Usuario.Padding = new System.Windows.Forms.Padding(8, 0, 15, 0);
            this.btn_Usuario.Size = new System.Drawing.Size(211, 49);
            this.btn_Usuario.TabIndex = 2;
            this.btn_Usuario.Text = "Módulo Usuario";
            this.btn_Usuario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Usuario.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Usuario.UseVisualStyleBackColor = false;
            this.btn_Usuario.Click += new System.EventHandler(this.btn_Usuario_Click_1);
            // 
            // panel_Logo
            // 
            this.panel_Logo.Controls.Add(this.btn_Home);
            this.panel_Logo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_Logo.Location = new System.Drawing.Point(0, 0);
            this.panel_Logo.Margin = new System.Windows.Forms.Padding(2);
            this.panel_Logo.Name = "panel_Logo";
            this.panel_Logo.Size = new System.Drawing.Size(211, 126);
            this.panel_Logo.TabIndex = 0;
            // 
            // btn_Home
            // 
            this.btn_Home.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_Home.Image = global::Biblioteca.Properties.Resources.biblioteca;
            this.btn_Home.Location = new System.Drawing.Point(0, 0);
            this.btn_Home.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Home.Name = "btn_Home";
            this.btn_Home.Size = new System.Drawing.Size(211, 126);
            this.btn_Home.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_Home.TabIndex = 2;
            this.btn_Home.TabStop = false;
            this.btn_Home.Click += new System.EventHandler(this.btn_Home_Click);
            // 
            // btn_AgregarUsuario
            // 
            this.btn_AgregarUsuario.AutoSize = true;
            this.btn_AgregarUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(209)))), ((int)(((byte)(206)))));
            this.btn_AgregarUsuario.Controls.Add(btn_Maximizar);
            this.btn_AgregarUsuario.Controls.Add(btn_Minimzar);
            this.btn_AgregarUsuario.Controls.Add(btn_Salir);
            this.btn_AgregarUsuario.Controls.Add(this.lblTitleChildForm);
            this.btn_AgregarUsuario.Controls.Add(this.iconCurrentChildForm);
            this.btn_AgregarUsuario.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_AgregarUsuario.Location = new System.Drawing.Point(213, 0);
            this.btn_AgregarUsuario.Margin = new System.Windows.Forms.Padding(2);
            this.btn_AgregarUsuario.Name = "btn_AgregarUsuario";
            this.btn_AgregarUsuario.Size = new System.Drawing.Size(1137, 48);
            this.btn_AgregarUsuario.TabIndex = 3;
            this.btn_AgregarUsuario.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.panelTitleBar_MouseDoubleClick);
            this.btn_AgregarUsuario.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitleBar_MouseDown);
            // 
            // lblTitleChildForm
            // 
            this.lblTitleChildForm.AutoSize = true;
            this.lblTitleChildForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleChildForm.Location = new System.Drawing.Point(53, 18);
            this.lblTitleChildForm.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitleChildForm.Name = "lblTitleChildForm";
            this.lblTitleChildForm.Size = new System.Drawing.Size(54, 20);
            this.lblTitleChildForm.TabIndex = 1;
            this.lblTitleChildForm.Text = "Home";
            // 
            // iconCurrentChildForm
            // 
            this.iconCurrentChildForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(209)))), ((int)(((byte)(206)))));
            this.iconCurrentChildForm.ForeColor = System.Drawing.Color.Azure;
            this.iconCurrentChildForm.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.iconCurrentChildForm.IconColor = System.Drawing.Color.Azure;
            this.iconCurrentChildForm.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconCurrentChildForm.Location = new System.Drawing.Point(14, 11);
            this.iconCurrentChildForm.Margin = new System.Windows.Forms.Padding(2);
            this.iconCurrentChildForm.Name = "iconCurrentChildForm";
            this.iconCurrentChildForm.Size = new System.Drawing.Size(32, 35);
            this.iconCurrentChildForm.TabIndex = 0;
            this.iconCurrentChildForm.TabStop = false;
            // 
            // panelDesktop
            // 
            this.panelDesktop.AutoSize = true;
            this.panelDesktop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Location = new System.Drawing.Point(213, 48);
            this.panelDesktop.Margin = new System.Windows.Forms.Padding(2);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(1137, 802);
            this.panelDesktop.TabIndex = 4;
            // 
            // frm_Principal2
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1350, 850);
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.btn_AgregarUsuario);
            this.Controls.Add(this.panel_Menu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frm_Principal2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_Principal2";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frm_Principal2_Load);
            this.panel_Menu.ResumeLayout(false);
            this.panel_Menu.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel_Logo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btn_Home)).EndInit();
            this.btn_AgregarUsuario.ResumeLayout(false);
            this.btn_AgregarUsuario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildForm)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel_Menu;
        private System.Windows.Forms.Panel btn_AgregarUsuario;
        private System.Windows.Forms.Panel panel_Logo;
        private FontAwesome.Sharp.IconButton btn_Usuario;
        private FontAwesome.Sharp.IconPictureBox iconCurrentChildForm;
        private System.Windows.Forms.PictureBox btn_Home;
        private System.Windows.Forms.Label lblTitleChildForm;
        private FontAwesome.Sharp.IconButton iconButton5;
        private FontAwesome.Sharp.IconButton iconButton4;
        private FontAwesome.Sharp.IconButton btn_Libros;
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton btn_Roles;
        private FontAwesome.Sharp.IconButton iconButton1;
        public System.Windows.Forms.Panel panelDesktop;
    }
}