
namespace Biblioteca
{
    partial class frm_Principal
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
            this.btn_Usuario = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.lbl_NombreLogin = new System.Windows.Forms.ToolStripLabel();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Usuario
            // 
            this.btn_Usuario.BackgroundImage = global::Biblioteca.Properties.Resources.pngwing_com;
            this.btn_Usuario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Usuario.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_Usuario.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_Usuario.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_Usuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Usuario.Location = new System.Drawing.Point(107, 110);
            this.btn_Usuario.Name = "btn_Usuario";
            this.btn_Usuario.Size = new System.Drawing.Size(189, 177);
            this.btn_Usuario.TabIndex = 1;
            this.btn_Usuario.UseVisualStyleBackColor = false;
            this.btn_Usuario.Click += new System.EventHandler(this.btn_Usuario_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lbl_NombreLogin});
            this.toolStrip1.Location = new System.Drawing.Point(0, 697);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1100, 25);
            this.toolStrip1.TabIndex = 4;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // lbl_NombreLogin
            // 
            this.lbl_NombreLogin.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.lbl_NombreLogin.Name = "lbl_NombreLogin";
            this.lbl_NombreLogin.Size = new System.Drawing.Size(111, 22);
            this.lbl_NombreLogin.Text = "toolStripLabel1";
            // 
            // frm_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Biblioteca.Properties.Resources.biblioteca;
            this.ClientSize = new System.Drawing.Size(1100, 722);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.btn_Usuario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IsMdiContainer = true;
            this.Name = "frm_Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Principal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_Usuario;
        private System.Windows.Forms.ToolStrip toolStrip1;
        public System.Windows.Forms.ToolStripLabel lbl_NombreLogin;
    }
}