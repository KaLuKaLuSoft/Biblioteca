using System;
using System.Data;
using System.Windows.Forms;
using Capa_Logica;
using Capa_Negocio;

namespace Biblioteca
{
    public partial class frm_Login : Form
    {
        L_Login objl = new L_Login();
        N_Login objn = new N_Login();
        public frm_Login()
        {
            InitializeComponent();
        }

        private void btn_Cerrar_Click(object sender, EventArgs e)
        {
            Close();
        }
        int veces = 0;
        private void btn_Login_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            objl.logueo = txt_Usuario.Text;
            objl.contrasena = txt_Contrasena.Text;
            dt = objn.n_Login(objl);
            if (string.IsNullOrEmpty(txt_Usuario.Text) || string.IsNullOrEmpty(txt_Contrasena.Text))
            {
                MessageBox.Show("Debe Completar los campos necesarios");
            }
            else
            {
                string Rol = ((L_Login)cbo_Rol.SelectedItem).rol;
                if (dt.Rows.Count > 0)
                {
                    objl.logueo = dt.Rows[0][0].ToString();
                    objl.contrasena = dt.Rows[0][1].ToString();

                    if (Rol == dt.Rows[0][2].ToString())
                    {
                        this.Hide();
                        frm_Principal2 pri = new frm_Principal2();
                        pri.Show();
                        //pri.lbl_NombreLogin.Text = "Bienvenido " + objl.logueo + " / " + Rol;
                    }
                    else
                    {
                        MessageBox.Show("Elija su rol");
                        veces += 1;
                    }
                }
                else
                {
                    //al intenter incorrectamente va sumante la variables veces
                    MessageBox.Show("Usuario o Contraseña incorrecto");
                    veces += 1;
                }
                //si veces es igual a 3 bloqueo el boton de ingresar
                if (veces == 3)
                {
                    MessageBox.Show("Usuario Bloqueado / Vuelva a intentar en 10 segundos");
                    veces = 0;
                    btn_Login.Enabled = false; ;
                    timer_bloqueo.Start();
                    MessageBox.Show("Usuario o Contraseña incorrecto");
                }
            }
        }
        private void frm_Login_Load(object sender, EventArgs e)
        {
            cbo_Rol.DataSource = N_Login.ObtenerRoles();
            cbo_Rol.DisplayMember = "rol";
            cbo_Rol.ValueMember = "id";
            txt_Usuario.Select();
        }
        private void timer_bloqueo_Tick(object sender, EventArgs e)
        {
            btn_Login.Enabled = true;
            timer_bloqueo.Stop();
        }
    }
}
